﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace D16.VideoCommander
{
    internal partial class Main : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));

        private string vlcPath;

        private AddDialog addDialog;

        private Settings settingsDialog;

        private VlcCommander commander;

        private DisplaySetting display1;

        private DisplaySetting display2;

        private DisplaySettingSerializer settingSerializer;

        private PlaylistSerializer playlistSerializer;

        private System.Threading.Timer mouseTimer;

        private ListViewExtender playlistExtender;

        private DisplaySetting GetActiveDisplay()
        {
            if (rbnDisplay1.Checked)
                return display1;

            return display2;
        }

        public Main()
        {
            this.InitializeComponent();

            this.playlistExtender = new ListViewExtender(this.playlist);

            // extend 2nd column
            var buttonAction = new ListViewButtonColumn(this.playlist.Columns.Count - 1);
            buttonAction.Click += this.PlaySingleAction;
            buttonAction.FixedWidth = true;

            this.playlistExtender.AddColumn(buttonAction);
            this.DragEnter += MainDragEnter;
            this.DragDrop += MainDragDrop;

            this.addDialog = new AddDialog();
            this.settingsDialog = new Settings();

            this.lblVersion.Text = string.Format("Version {0} [peter@d16.de]", Application.ProductVersion);

            this.settingSerializer = new DisplaySettingSerializer();
            this.playlistSerializer = new PlaylistSerializer();

            this.mouseTimer = new System.Threading.Timer(DisplayMousePosition);

            this.Disposed += Main_Disposed;
        }

        private void PlaySingleAction(object sender, ListViewColumnMouseEventArgs e)
        {
            this.ExecutePlaylist(new[] { e.Item });
        }

        private void MainDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void MainDragDrop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (files == null)
                return;

            foreach (string file in files)
            {
                this.AddPlaylistItem(file);
            }
        }

        private void Main_Disposed(object sender, EventArgs e)
        {
            if (this.mouseTimer != null)
            {
                this.mouseTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                this.mouseTimer.Dispose();
            }
        }

        private bool TryGetVlcPath(out string path)
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"VideoLAN\VLC\vlc.exe");

            return File.Exists(path);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            this.AllowDrop = true;

            string storedPath = Properties.Settings.Default.VlcPath;

            if (string.IsNullOrEmpty(storedPath))
                storedPath = ConfigManager.GetValue("defaultVlcPath");

            if (!string.IsNullOrEmpty(storedPath) && File.Exists(storedPath))
            {
                this.vlcPath = storedPath;
            }
            else if (!TryGetVlcPath(out this.vlcPath))
            {
                using (var fileDialog = new OpenFileDialog())
                {
                    fileDialog.Filter = @"exe|*.exe";
                    fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                    fileDialog.CheckFileExists = true;
                    fileDialog.RestoreDirectory = true;

                    if (fileDialog.ShowDialog() != DialogResult.OK)
                    {
                        Close();
                    }
                    else
                    {
                        vlcPath = fileDialog.FileName;
                    }
                }
            }

            Properties.Settings.Default.VlcPath = vlcPath;
            Properties.Settings.Default.Save();

            commander = new VlcCommander(vlcPath);
        }

        private void SetDisplayBindings(DisplaySetting setting)
        {
            chkFullscreen.DataBindings.Clear();
            chkFullscreen.DataBindings.Add(new Binding("Checked", setting, "Fullscreen", false, DataSourceUpdateMode.OnPropertyChanged));

            chkEmbedded.DataBindings.Clear();
            chkEmbedded.DataBindings.Add(new Binding("Checked", setting, "Embedded", false, DataSourceUpdateMode.OnPropertyChanged));

            chkCloseAfterPlay.DataBindings.Clear();
            chkCloseAfterPlay.DataBindings.Add(new Binding("Checked", setting, "CloseAfterPlay", false, DataSourceUpdateMode.OnPropertyChanged));

            valXPos.DataBindings.Clear();
            valXPos.DataBindings.Add(new Binding("Value", setting, "XPos", false, DataSourceUpdateMode.OnPropertyChanged));

            valYPos.DataBindings.Clear();
            valYPos.DataBindings.Add(new Binding("Value", setting, "YPos", false, DataSourceUpdateMode.OnPropertyChanged));

            valWidth.DataBindings.Clear();
            valWidth.DataBindings.Add(new Binding("Value", setting, "Width", false, DataSourceUpdateMode.OnPropertyChanged));

            valHeight.DataBindings.Clear();
            valHeight.DataBindings.Add(new Binding("Value", setting, "Height", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private DisplaySetting GetSetting1()
        {
            string confValue = Properties.Settings.Default.Display1;

            try
            {
                DisplaySetting stored = settingSerializer.Deserialize(confValue);
                if (stored != null)
                    return stored;
            }
            catch { }

            return new DisplaySetting
            {
                Fullscreen = false,

                Embedded = true,
                CloseAfterPlay = false,

                XPos = 400,
                YPos = 200,

                Height = 300,
                Width = 400,
            };
        }

        private DisplaySetting GetSetting2()
        {
            string confValue = Properties.Settings.Default.Display2;

            try
            {
                DisplaySetting stored = settingSerializer.Deserialize(confValue);
                if (stored != null)
                    return stored;
            }
            catch { }

            return new DisplaySetting
            {
                Fullscreen = true,

                Embedded = false,
                CloseAfterPlay = true,

                XPos = 1300,
                YPos = 200,

                Height = -1,
                Width = -1,
            };
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitializeFormPosition();

            string language = Properties.Settings.Default.AudioLanguage;
            if (string.IsNullOrEmpty(language))
                language = "de";

            bool showTitle = Properties.Settings.Default.ShowVideoTitle;

            settingsDialog.ShowVideoTitle = showTitle;
            settingsDialog.Language = language;

            display1 = GetSetting1();
            display2 = GetSetting2();

            string activeDisplay = Properties.Settings.Default.CurrentDisplay;
            if (activeDisplay == "display2")
            {
                rbnDisplay2.Checked = true;
            }
            else
            {
                rbnDisplay1.Checked = true;
            }

            SetDisplayBindings(GetActiveDisplay());
        }

        private void InitializeFormPosition()
        {
            int temp;

            temp = Properties.Settings.Default.FormLeft;
            if (temp > 0)
            {
                this.Left = temp;
            }

            temp = Properties.Settings.Default.FormTop;
            if (temp > 0)
            {
                this.Top = temp;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.FormLeft = this.Left;
                Properties.Settings.Default.FormTop = this.Top;

                Properties.Settings.Default.VlcPath = this.vlcPath;

                Properties.Settings.Default.Display1 = settingSerializer.Serialize(display1);
                Properties.Settings.Default.Display2 = settingSerializer.Serialize(display2);

                Properties.Settings.Default.AudioLanguage = settingsDialog.Language;
                Properties.Settings.Default.ShowVideoTitle = settingsDialog.ShowVideoTitle;

                Properties.Settings.Default.CurrentDisplay = rbnDisplay2.Checked ? "display2" : "display1";

                Properties.Settings.Default.Save();
            }
            catch (Exception exception)
            {
                Trace.TraceError(exception.Message);
            }
        }

        private void rbnDisplay1_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayBindings(GetActiveDisplay());

            if (rbnDisplay2.Checked)
            {
                btnPlay.Image = Properties.Resources.live;
                btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
            else
            {
                btnPlay.Image = null;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.ExecutePlaylist(this.playlist.Items.OfType<ListViewItem>());
        }

        private void ExecutePlaylist(IEnumerable<ListViewItem> items)
        {
            DisplaySetting setting = GetActiveDisplay();

            var general = new VlcCommandBuilder()
                .SetLanguage(settingsDialog.Language)
                .SetVideoTitleShow(settingsDialog.ShowVideoTitle)
                .SetFullscreen(setting.Fullscreen)
                .SetEmbedded(setting.Embedded)
                .SetWidth(setting.Width)
                .SetHeight(setting.Height)
                .SetXPos(setting.XPos)
                .SetYPos(setting.YPos);

            var commands = new List<VlcArgumentBuilder>
            {
                general
            };

            foreach (ListViewItem item in items)
            {
                var file = new VlcFile(item.Text);

                if (item.SubItems.Count > 1 && !string.IsNullOrEmpty(item.SubItems[1].Text))
                {
                    file.SetStartTime((int)TimeHelpers.FromFormatedString(item.SubItems[1].Text).TotalSeconds);
                }
                if (item.SubItems.Count > 2 && !string.IsNullOrEmpty(item.SubItems[2].Text))
                {
                    file.SetEndTime((int)TimeHelpers.FromFormatedString(item.SubItems[2].Text).TotalSeconds);
                }
                if (item.SubItems.Count > 3 && !string.IsNullOrEmpty(item.SubItems[3].Text))
                {
                    file.SetDuration((int)TimeHelpers.FromFormatedString(item.SubItems[3].Text).TotalSeconds);
                }

                commands.Add(file);
            }

            commander.Start(commands.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddPlaylistItem();
        }

        public void AddPlaylistItem(string file, string startTime = "", string endTime = "", string duration = "")
        {
            var item = new ListViewItem
            {
                Text = file,
            };

            item.SubItems.AddRange(new[] { startTime, endTime, duration, "\u25B6" });

            this.playlist.Items.Add(item);
        }

        private void AddPlaylistItem()
        {
            addDialog.ResetTexts();

            if (addDialog.ShowDialog() == DialogResult.OK)
            {
                this.AddPlaylistItem(addDialog.Video, addDialog.StartTime, addDialog.EndTime, addDialog.Duration);
            }
        }

        private void EditPlaylistItem(ListViewItem item)
        {
            if (item == null)
                return;

            addDialog.Video = item.Text;
            addDialog.StartTime = item.SubItems[1].Text;
            addDialog.EndTime = item.SubItems[2].Text;
            addDialog.Duration = item.SubItems[3].Text;

            if (addDialog.ShowDialog() == DialogResult.OK)
            {
                item.Text = addDialog.Video;
                item.SubItems[1].Text = addDialog.StartTime;
                item.SubItems[2].Text = addDialog.EndTime;
                item.SubItems[3].Text = addDialog.Duration;
            }
        }

        private void playlist_KeyUp(object sender, KeyEventArgs e)
        {
            if (playlist.Items.Count == 0)
                return;

            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in playlist.SelectedItems)
                {
                    playlist.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                resources.GetString("Message.Clear"), 
                resources.GetString("Message.Clear.Title"), 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                playlist.Items.Clear();
            }
        }

        private void AddToJumplist(string fileName)
        {
            if (TaskbarManager.IsPlatformSupported)
            {
                JumpList.AddToRecent(fileName);

                if (this.Visible)
                {
                    var jumplist = JumpList.CreateJumpList();
                    jumplist.Refresh();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (playlistSaveDialog.ShowDialog() == DialogResult.OK)
            {
                var items = this.playlist.Items.Cast<ListViewItem>().ToList();

                XmlDocument doc = playlistSerializer.Serialize(items);
                doc.Save(playlistSaveDialog.FileName);

                this.AddToJumplist(playlistSaveDialog.FileName);
            }
        }

        public void LoadPlaylist(string filename)
        {
            var doc = new XmlDocument();

            try
            {
                doc.Load(filename);
                IEnumerable<ListViewItem> items = playlistSerializer.Deserialize(doc);

                if (items != null)
                {
                    playlist.Items.AddRange(items.ToArray());
                }

                this.AddToJumplist(filename);
            }
            catch (Exception exception)
            {
                Trace.TraceError(exception.ToString());

                MessageBox.Show(
                    string.Concat(
                        resources.GetString("Error.FileLoad"),
                        Environment.NewLine, 
                        Environment.NewLine,
                        exception.Message), 
                    resources.GetString("Error.FileLoad.Title"), 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (playlistOpenDialog.ShowDialog() == DialogResult.OK)
            {
                LoadPlaylist(playlistOpenDialog.FileName);
            }
        }

        private void playlist_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = playlist.SelectedItems;

            if (items == null || items.Count == 0)
            {
                this.AddPlaylistItem();
            }
            else
            {
                this.EditPlaylistItem(items[0]);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsDialog.ShowDialog();
        }

        private void DisplayMousePosition(object state)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lbMousePosition.Text = "X: " + Cursor.Position.X + " / Y: " + Cursor.Position.Y;
            });
        }

        private void cbMousePosition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMousePosition.Checked)
            {
                mouseTimer.Change(0, 500);
            }
            else
            {
                mouseTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                lbMousePosition.Text = string.Empty;
            }
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            this.AddPlaylistItem();
        }

        private void menuPlaylist_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection items = playlist.SelectedItems;

            bool enabled = items != null && items.Count == 1;

            tsmiEdit.Enabled = enabled;
            tsmiDelete.Enabled = enabled;
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection items = playlist.SelectedItems;

            if (items == null || items.Count == 0)
                return;

            this.EditPlaylistItem(items[0]);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection items = playlist.SelectedItems;

            if (items == null || items.Count == 0)
                return;

            playlist.Items.Remove(items[0]);
        }
    }
}

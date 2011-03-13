using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace D16.VideoCommander
{
    public partial class Main : Form
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

        private DisplaySetting GetActiveDisplay()
        {
            if (rbnDisplay1.Checked)
                return display1;

            return display2;
        }

        public Main()
        {
            InitializeComponent();

            addDialog = new AddDialog();
            settingsDialog = new Settings();

            lblVersion.Text = String.Format("Version {0} [peter@d16.de]", Application.ProductVersion);

            settingSerializer = new DisplaySettingSerializer();
            playlistSerializer = new PlaylistSerializer();
        }

        private bool TryGetVlcPath(out string path)
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"VideoLAN\VLC\vlc.exe");
            
            return File.Exists(path);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            string storedPath = ConfigManager.GetValue("vlcPath");
            
            if (!String.IsNullOrEmpty(storedPath) && File.Exists(storedPath))
            {
                this.vlcPath = storedPath;
            }
            else if (!TryGetVlcPath(out this.vlcPath))
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    fileDialog.Filter = "exe|*.exe";
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

            ConfigManager.SetValue("vlcPath", vlcPath);
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
            string confValue = ConfigManager.GetValue("display1");

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
            string confValue = ConfigManager.GetValue("display2");

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

            string language = ConfigManager.GetValue("audio-language");
            if (String.IsNullOrEmpty(language))
                language = "de";

            bool showTitle;
            if (!bool.TryParse(ConfigManager.GetValue("show-videotitle"), out showTitle))
            {
                showTitle = false;
            }

            settingsDialog.ShowVideoTitle = showTitle;
            settingsDialog.Language = language;

            display1 = GetSetting1();
            display2 = GetSetting2();

            string activeDisplay = ConfigManager.GetValue("current-display");
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

            if (int.TryParse(ConfigManager.GetValue("formPosLeft"), out temp))
            {
                this.Left = temp;
            }
            if (int.TryParse(ConfigManager.GetValue("formPosTop"), out temp))
            {
                this.Top = temp;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ConfigManager.SetValue("formPosLeft", this.Left);
                ConfigManager.SetValue("formPosTop", this.Top);

                ConfigManager.SetValue("vlcPath", this.vlcPath);

                ConfigManager.SetValue("display1", settingSerializer.Serialize(display1));
                ConfigManager.SetValue("display2", settingSerializer.Serialize(display2));

                ConfigManager.SetValue("audio-language", settingsDialog.Language);
                ConfigManager.SetValue("show-videotitle", settingsDialog.ShowVideoTitle);

                ConfigManager.SetValue("current-display", rbnDisplay2.Checked ? "display2" : "display1");
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

            List<VlcArgumentBuilder> commands = new List<VlcArgumentBuilder>();
            commands.Add(general);

            foreach (ListViewItem item in playlist.Items)
            {
                var file = new VlcFile(item.Text);

                if (item.SubItems.Count > 1 && !String.IsNullOrEmpty(item.SubItems[1].Text))
                {
                    file.SetStartTime((int)TimeHelpers.FromFormatedString(item.SubItems[1].Text).TotalSeconds);
                }
                if (item.SubItems.Count > 2 && !String.IsNullOrEmpty(item.SubItems[2].Text))
                {
                    file.SetEndTime((int)TimeHelpers.FromFormatedString(item.SubItems[2].Text).TotalSeconds);
                }
                if (item.SubItems.Count > 3 && !String.IsNullOrEmpty(item.SubItems[3].Text))
                {
                    file.SetDuration((int)TimeHelpers.FromFormatedString(item.SubItems[3].Text).TotalSeconds);
                }

                commands.Add(file);
            }

            commander.Start(commands.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addDialog.ResetTexts();

            if (addDialog.ShowDialog() == DialogResult.OK)
            {
                var item = new ListViewItem
                {
                    Text = addDialog.Video,
                };
                item.SubItems.AddRange(new [] { addDialog.StartTime, addDialog.EndTime, addDialog.Duration });

                playlist.Items.Add(item);
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
            if (MessageBox.Show(resources.GetString("Message.Clear"), resources.GetString("Message.Clear.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
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
            if (playlistSaveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<ListViewItem> items = new List<ListViewItem>();
                foreach (var item in playlist.Items) 
                {
                    items.Add((ListViewItem)item);
                }

                XmlDocument doc = playlistSerializer.Serialize(items);
                doc.Save(playlistSaveDialog.FileName);

                AddToJumplist(playlistSaveDialog.FileName);
            }
        }

        public void LoadPlaylist(string filename)
        {
            XmlDocument doc = new XmlDocument();
            try 
            {
                doc.Load(filename);
                IEnumerable<ListViewItem> items = playlistSerializer.Deserialize(doc);

                if (items != null)
                {
                    playlist.Items.AddRange(items.ToArray());
                }

                AddToJumplist(filename);
            }
            catch (Exception exception)
            {
                Trace.TraceError(exception.ToString());

                MessageBox.Show(String.Concat(resources.GetString("Error.FileLoad"),
                    Environment.NewLine, Environment.NewLine,
                    exception.Message), resources.GetString("Error.FileLoad.Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (playlistOpenDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadPlaylist(playlistOpenDialog.FileName);
            }
        }

        private void playlist_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection items = playlist.SelectedItems;

            if (items == null || items.Count == 0)
                return;

            ListViewItem item = items[0];

            addDialog.Video = item.Text;
            addDialog.StartTime = item.SubItems[1].Text;
            addDialog.EndTime = item.SubItems[2].Text;
            addDialog.Duration = item.SubItems[3].Text;

            if (addDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                item.Text = addDialog.Video;
                item.SubItems[1].Text = addDialog.StartTime;
                item.SubItems[2].Text = addDialog.EndTime;
                item.SubItems[3].Text = addDialog.Duration;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsDialog.ShowDialog();
        }
    }
}

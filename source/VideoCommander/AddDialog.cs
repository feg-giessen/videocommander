using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace D16.VideoCommander
{
    internal partial class AddDialog : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDialog));

        public AddDialog()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Path to the video file.
        /// </summary>
        public string Video
        {
            get { return this.txbPath.Text; }
            set { this.txbPath.Text = value; }
        }

        private string ConvertTimeString(string timeString)
        {
            string raw = timeString.Replace(":", string.Empty);

            if (raw.Trim().Length == 0 || Convert.ToInt32(raw) == 0)
                return string.Empty;

            return timeString.Replace(' ', '0');
        }

        public string StartTime
        {
            get { return this.ConvertTimeString(this.mtbStart.Text); }
            set { this.mtbStart.Text = value; }
        }

        public string EndTime
        {
            get { return this.ConvertTimeString(this.mtbEnd.Text); }
            set { this.mtbEnd.Text = value; }
        }

        public string Duration
        {
            get { return this.ConvertTimeString(this.mtbDuration.Text); }
            set { this.mtbDuration.Text = value; }
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (!this.Video.StartsWith("dvdsimple:") && !File.Exists(this.Video))
            {
                MessageBox.Show(
                    this.resources.GetString("Error.NoFile"), 
                    this.resources.GetString("Error.NoFile.Title"), 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            this.fileDialog.InitialDirectory = this.Video;

            if (this.fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Video = this.fileDialog.FileName;
            }
        }

        public void ResetTexts()
        {
            this.txbPath.ResetText();

            this.mtbStart.ResetText();
            this.mtbEnd.ResetText();
            this.mtbDuration.ResetText();        
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(this.folderBrowserDialog.SelectedPath))
                    return;

                string volume = this.folderBrowserDialog.SelectedPath.Split(Path.VolumeSeparatorChar).First();
                this.Video = "dvdsimple:///" + volume + ":";

                using (var dvdSettings = new DvdSetting(this.Video))
                {
                    dvdSettings.ShowDialog();

                    this.Video = dvdSettings.Path;
                }
            }
        }
    }
}

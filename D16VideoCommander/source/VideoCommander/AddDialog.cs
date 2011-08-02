using System.Windows.Forms;
using System.IO;
using System;

namespace D16.VideoCommander
{
    internal partial class AddDialog : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDialog));

        public AddDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Path to the video file.
        /// </summary>
        public string Video
        {
            get
            {
                return txbPath.Text;
            }
            set
            {
                txbPath.Text = value;
            }
        }

        private string ConvertTimeString(string timeString)
        {
            string raw = timeString.Replace(":", String.Empty);
            if (raw.Trim().Length == 0 || Convert.ToInt32(raw) == 0)
                return String.Empty;

            return timeString.Replace(' ', '0');
        }

        public string StartTime
        {
            get { return ConvertTimeString(mtbStart.Text); }
            set { mtbStart.Text = value; }
        }

        public string EndTime
        {
            get { return ConvertTimeString(mtbEnd.Text); }
            set { mtbEnd.Text = value; }
        }

        public string Duration
        {
            get { return ConvertTimeString(mtbDuration.Text); }
            set { mtbDuration.Text = value; }
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (!Video.StartsWith("dvdsimple:") && !File.Exists(Video))
            {
                MessageBox.Show(resources.GetString("Error.NoFile"), resources.GetString("Error.NoFile.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            fileDialog.InitialDirectory = Video;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Video = fileDialog.FileName;
            }
        }

        public void ResetTexts()
        {
            txbPath.ResetText();

            mtbStart.ResetText();
            mtbEnd.ResetText();
            mtbDuration.ResetText();        
        }
    }
}

using System;
using System.Windows.Forms;

namespace D16.VideoCommander
{
    public partial class DvdSetting : Form
    {
        private readonly string basePath;

        public DvdSetting(string basePath)
        {
            this.basePath = basePath;

            this.InitializeComponent();
        }

        public int Title
        {
            get { return (int)this.nudTitle.Value; }
            set { this.nudTitle.Value = value; }
        }

        public int Chapter
        {
            get { return (int)this.nudChapter.Value; }
            set { this.nudChapter.Value = value; }
        }

        public string Path
        {
            get 
            { 
                if (this.Title <= 0)
                    return this.basePath;

                if (this.Chapter <= 0)
                    return string.Format("{0}/#{1}", this.basePath, this.Title);

                return string.Format("{0}/#{1}:{2}", this.basePath, this.Title, this.Chapter);
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            this.txbPath.Text = this.Path;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.txbPath.Text = this.Path;
        }
    }
}

using System.Windows.Forms;

namespace D16.VideoCommander
{
    /// <summary>
    /// Formular for general vlc settings.
    /// </summary>
    internal partial class Settings : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the audio language.
        /// </summary>
        public string Language
        {
            get { return this.txbSprache.Text; }
            set { this.txbSprache.Text = value; }
        }

        /// <summary>
        /// Gets or sets whether the video title should be shown on play.
        /// </summary>
        public bool ShowVideoTitle
        {
            get { return this.chkVideoTitel.Checked; }
            set { this.chkVideoTitel.Checked = value; }
        }
    }
}
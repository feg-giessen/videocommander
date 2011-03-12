using System.Windows.Forms;

namespace D16.VideoCommander
{
    /// <summary>
    /// Formular for general vlc settings.
    /// </summary>
    public partial class Settings : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the audio language.
        /// </summary>
        public string Language
        {
            get { return txbSprache.Text; }
            set { txbSprache.Text = value; }
        }

        /// <summary>
        /// Gets or sets whether the video title should be shown on play.
        /// </summary>
        public bool ShowVideoTitle
        {
            get { return chkVideoTitel.Checked; }
            set { chkVideoTitel.Checked = value; }
        }
    }
}

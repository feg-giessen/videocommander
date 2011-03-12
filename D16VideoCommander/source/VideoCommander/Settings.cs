using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D16.VideoCommander
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public string Language
        {
            get { return txbSprache.Text; }
            set { txbSprache.Text = value; }
        }

        public bool ShowVideoTitle
        {
            get { return chkVideoTitel.Checked; }
            set { chkVideoTitel.Checked = value; }
        }
    }
}

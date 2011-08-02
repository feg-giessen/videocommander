namespace D16.VideoCommander
{
    internal partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.rbnDisplay1 = new System.Windows.Forms.RadioButton();
            this.rbnDisplay2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.valHeight = new System.Windows.Forms.NumericUpDown();
            this.valWidth = new System.Windows.Forms.NumericUpDown();
            this.valYPos = new System.Windows.Forms.NumericUpDown();
            this.valXPos = new System.Windows.Forms.NumericUpDown();
            this.chkCloseAfterPlay = new System.Windows.Forms.CheckBox();
            this.chkEmbedded = new System.Windows.Forms.CheckBox();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.playlistSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.playlistOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valXPos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbnDisplay1
            // 
            resources.ApplyResources(this.rbnDisplay1, "rbnDisplay1");
            this.rbnDisplay1.Checked = true;
            this.rbnDisplay1.Name = "rbnDisplay1";
            this.rbnDisplay1.TabStop = true;
            this.rbnDisplay1.UseVisualStyleBackColor = true;
            this.rbnDisplay1.CheckedChanged += new System.EventHandler(this.rbnDisplay1_CheckedChanged);
            // 
            // rbnDisplay2
            // 
            resources.ApplyResources(this.rbnDisplay2, "rbnDisplay2");
            this.rbnDisplay2.Name = "rbnDisplay2";
            this.rbnDisplay2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.lblYPos);
            this.panel1.Controls.Add(this.lblXPos);
            this.panel1.Controls.Add(this.valHeight);
            this.panel1.Controls.Add(this.valWidth);
            this.panel1.Controls.Add(this.valYPos);
            this.panel1.Controls.Add(this.valXPos);
            this.panel1.Controls.Add(this.chkCloseAfterPlay);
            this.panel1.Controls.Add(this.chkEmbedded);
            this.panel1.Controls.Add(this.chkFullscreen);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Name = "panel1";
            // 
            // lblHeight
            // 
            resources.ApplyResources(this.lblHeight, "lblHeight");
            this.lblHeight.Name = "lblHeight";
            // 
            // lblWidth
            // 
            resources.ApplyResources(this.lblWidth, "lblWidth");
            this.lblWidth.Name = "lblWidth";
            // 
            // lblYPos
            // 
            resources.ApplyResources(this.lblYPos, "lblYPos");
            this.lblYPos.Name = "lblYPos";
            // 
            // lblXPos
            // 
            resources.ApplyResources(this.lblXPos, "lblXPos");
            this.lblXPos.Name = "lblXPos";
            // 
            // valHeight
            // 
            resources.ApplyResources(this.valHeight, "valHeight");
            this.valHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.valHeight.Name = "valHeight";
            this.valHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // valWidth
            // 
            resources.ApplyResources(this.valWidth, "valWidth");
            this.valWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.valWidth.Name = "valWidth";
            this.valWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // valYPos
            // 
            resources.ApplyResources(this.valYPos, "valYPos");
            this.valYPos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valYPos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.valYPos.Name = "valYPos";
            this.valYPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // valXPos
            // 
            resources.ApplyResources(this.valXPos, "valXPos");
            this.valXPos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valXPos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.valXPos.Name = "valXPos";
            this.valXPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // chkCloseAfterPlay
            // 
            resources.ApplyResources(this.chkCloseAfterPlay, "chkCloseAfterPlay");
            this.chkCloseAfterPlay.Name = "chkCloseAfterPlay";
            this.chkCloseAfterPlay.UseVisualStyleBackColor = true;
            // 
            // chkEmbedded
            // 
            resources.ApplyResources(this.chkEmbedded, "chkEmbedded");
            this.chkEmbedded.Name = "chkEmbedded";
            this.chkEmbedded.UseVisualStyleBackColor = true;
            // 
            // chkFullscreen
            // 
            resources.ApplyResources(this.chkFullscreen, "chkFullscreen");
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.rbnDisplay1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.rbnDisplay2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // playlist
            // 
            this.playlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.playlist.FullRowSelect = true;
            this.playlist.GridLines = true;
            resources.ApplyResources(this.playlist, "playlist");
            this.playlist.MultiSelect = false;
            this.playlist.Name = "playlist";
            this.playlist.UseCompatibleStateImageBehavior = false;
            this.playlist.View = System.Windows.Forms.View.Details;
            this.playlist.DoubleClick += new System.EventHandler(this.playlist_DoubleClick);
            this.playlist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playlist_KeyUp);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // playlistSaveDialog
            // 
            this.playlistSaveDialog.DefaultExt = "vplx";
            resources.ApplyResources(this.playlistSaveDialog, "playlistSaveDialog");
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // playlistOpenDialog
            // 
            this.playlistOpenDialog.DefaultExt = "vplx";
            resources.ApplyResources(this.playlistOpenDialog, "playlistOpenDialog");
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::D16.VideoCommander.Properties.Resources.cog;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::D16.VideoCommander.Properties.Resources.video;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valXPos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnDisplay1;
        private System.Windows.Forms.RadioButton rbnDisplay2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkFullscreen;
        private System.Windows.Forms.NumericUpDown valXPos;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.NumericUpDown valYPos;
        private System.Windows.Forms.NumericUpDown valWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown valHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkEmbedded;
        private System.Windows.Forms.CheckBox chkCloseAfterPlay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView playlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog playlistSaveDialog;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog playlistOpenDialog;
        private System.Windows.Forms.Button btnSettings;
    }
}
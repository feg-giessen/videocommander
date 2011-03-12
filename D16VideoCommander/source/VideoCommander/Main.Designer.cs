namespace D16.VideoCommander
{
    partial class Main
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
            this.rbnDisplay1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnDisplay1.Checked = true;
            this.rbnDisplay1.Location = new System.Drawing.Point(3, 3);
            this.rbnDisplay1.Name = "rbnDisplay1";
            this.rbnDisplay1.Size = new System.Drawing.Size(90, 24);
            this.rbnDisplay1.TabIndex = 0;
            this.rbnDisplay1.TabStop = true;
            this.rbnDisplay1.Text = "Vorschau";
            this.rbnDisplay1.UseVisualStyleBackColor = true;
            this.rbnDisplay1.CheckedChanged += new System.EventHandler(this.rbnDisplay1_CheckedChanged);
            // 
            // rbnDisplay2
            // 
            this.rbnDisplay2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnDisplay2.Location = new System.Drawing.Point(100, 3);
            this.rbnDisplay2.Name = "rbnDisplay2";
            this.rbnDisplay2.Size = new System.Drawing.Size(90, 24);
            this.rbnDisplay2.TabIndex = 0;
            this.rbnDisplay2.Text = "Live";
            this.rbnDisplay2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblHeight);
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
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 205);
            this.panel1.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 102);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(42, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(11, 76);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(39, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Location = new System.Drawing.Point(11, 42);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(34, 13);
            this.lblYPos.TabIndex = 2;
            this.lblYPos.Text = "Y-Pos";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Location = new System.Drawing.Point(11, 16);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(35, 13);
            this.lblXPos.TabIndex = 2;
            this.lblXPos.Text = "X-Pos";
            // 
            // valHeight
            // 
            this.valHeight.Location = new System.Drawing.Point(52, 100);
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
            this.valHeight.Size = new System.Drawing.Size(86, 22);
            this.valHeight.TabIndex = 1;
            this.valHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // valWidth
            // 
            this.valWidth.Location = new System.Drawing.Point(52, 74);
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
            this.valWidth.Size = new System.Drawing.Size(86, 22);
            this.valWidth.TabIndex = 1;
            this.valWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // valYPos
            // 
            this.valYPos.Location = new System.Drawing.Point(52, 40);
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
            this.valYPos.Size = new System.Drawing.Size(86, 22);
            this.valYPos.TabIndex = 1;
            this.valYPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // valXPos
            // 
            this.valXPos.Location = new System.Drawing.Point(52, 14);
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
            this.valXPos.Size = new System.Drawing.Size(86, 22);
            this.valXPos.TabIndex = 1;
            this.valXPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // chkCloseAfterPlay
            // 
            this.chkCloseAfterPlay.AutoSize = true;
            this.chkCloseAfterPlay.Location = new System.Drawing.Point(14, 180);
            this.chkCloseAfterPlay.Name = "chkCloseAfterPlay";
            this.chkCloseAfterPlay.Size = new System.Drawing.Size(173, 17);
            this.chkCloseAfterPlay.TabIndex = 0;
            this.chkCloseAfterPlay.Text = "Nach Wiedergabe schliessen";
            this.chkCloseAfterPlay.UseVisualStyleBackColor = true;
            // 
            // chkEmbedded
            // 
            this.chkEmbedded.AutoSize = true;
            this.chkEmbedded.Location = new System.Drawing.Point(14, 157);
            this.chkEmbedded.Name = "chkEmbedded";
            this.chkEmbedded.Size = new System.Drawing.Size(153, 17);
            this.chkEmbedded.TabIndex = 0;
            this.chkEmbedded.Text = "Video in Control-Fenster";
            this.chkEmbedded.UseVisualStyleBackColor = true;
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.Location = new System.Drawing.Point(14, 134);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(66, 17);
            this.chkFullscreen.TabIndex = 0;
            this.chkFullscreen.Text = "Vollbild";
            this.chkFullscreen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.rbnDisplay1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.rbnDisplay2);
            this.panel2.Location = new System.Drawing.Point(574, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 242);
            this.panel2.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(574, 260);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(195, 48);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "P L A Y";
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
            this.playlist.Location = new System.Drawing.Point(12, 12);
            this.playlist.MultiSelect = false;
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(556, 242);
            this.playlist.TabIndex = 4;
            this.playlist.UseCompatibleStateImageBehavior = false;
            this.playlist.View = System.Windows.Forms.View.Details;
            this.playlist.DoubleClick += new System.EventHandler(this.playlist_DoubleClick);
            this.playlist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playlist_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datei";
            this.columnHeader1.Width = 344;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ende";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dauer";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(545, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 295);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(82, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version 1.0.0.0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Leeren";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // playlistSaveDialog
            // 
            this.playlistSaveDialog.DefaultExt = "vplx";
            this.playlistSaveDialog.Filter = "Video-Playlist|*.vplx|Alle Dateien|*.*";
            this.playlistSaveDialog.Title = "Video-Playlist speichern...";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(145, 260);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // playlistOpenDialog
            // 
            this.playlistOpenDialog.DefaultExt = "vplx";
            this.playlistOpenDialog.Filter = "Video-Playlist|*.vplx|Alle Dateien|*.*";
            this.playlistOpenDialog.Title = "Video-Playlist öffnen...";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::D16.VideoCommander.Properties.Resources.cog;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Location = new System.Drawing.Point(12, 260);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 318);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::D16.VideoCommander.Properties.Resources.video;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "D16 – VideoCommander";
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
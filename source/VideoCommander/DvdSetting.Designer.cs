namespace D16.VideoCommander
{
    partial class DvdSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DvdSetting));
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChapter = new System.Windows.Forms.Label();
            this.nudTitle = new System.Windows.Forms.NumericUpDown();
            this.nudChapter = new System.Windows.Forms.NumericUpDown();
            this.lblPath = new System.Windows.Forms.Label();
            this.txbPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChapter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblChapter
            // 
            resources.ApplyResources(this.lblChapter, "lblChapter");
            this.lblChapter.Name = "lblChapter";
            // 
            // nudTitle
            // 
            resources.ApplyResources(this.nudTitle, "nudTitle");
            this.nudTitle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTitle.Name = "nudTitle";
            this.nudTitle.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // nudChapter
            // 
            resources.ApplyResources(this.nudChapter, "nudChapter");
            this.nudChapter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudChapter.Name = "nudChapter";
            this.nudChapter.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblPath
            // 
            resources.ApplyResources(this.lblPath, "lblPath");
            this.lblPath.Name = "lblPath";
            // 
            // txbPath
            // 
            resources.ApplyResources(this.txbPath, "txbPath");
            this.txbPath.Name = "txbPath";
            this.txbPath.ReadOnly = true;
            // 
            // DvdSetting
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.nudChapter);
            this.Controls.Add(this.nudTitle);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblChapter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DvdSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nudTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChapter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.NumericUpDown nudTitle;
        private System.Windows.Forms.NumericUpDown nudChapter;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txbPath;
    }
}
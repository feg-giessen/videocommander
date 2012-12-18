namespace D16.VideoCommander
{
    internal partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblSprache = new System.Windows.Forms.Label();
            this.txbSprache = new System.Windows.Forms.TextBox();
            this.chkVideoTitel = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSprache
            // 
            resources.ApplyResources(this.lblSprache, "lblSprache");
            this.lblSprache.Name = "lblSprache";
            // 
            // txbSprache
            // 
            resources.ApplyResources(this.txbSprache, "txbSprache");
            this.txbSprache.Name = "txbSprache";
            // 
            // chkVideoTitel
            // 
            resources.ApplyResources(this.chkVideoTitel, "chkVideoTitel");
            this.chkVideoTitel.Name = "chkVideoTitel";
            this.chkVideoTitel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkVideoTitel);
            this.Controls.Add(this.txbSprache);
            this.Controls.Add(this.lblSprache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSprache;
        private System.Windows.Forms.TextBox txbSprache;
        private System.Windows.Forms.CheckBox chkVideoTitel;
        private System.Windows.Forms.Button btnOk;
    }
}
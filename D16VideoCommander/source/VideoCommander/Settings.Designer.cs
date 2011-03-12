namespace D16.VideoCommander
{
    partial class Settings
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
            this.lblSprache = new System.Windows.Forms.Label();
            this.txbSprache = new System.Windows.Forms.TextBox();
            this.chkVideoTitel = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSprache
            // 
            this.lblSprache.AutoSize = true;
            this.lblSprache.Location = new System.Drawing.Point(32, 36);
            this.lblSprache.Name = "lblSprache";
            this.lblSprache.Size = new System.Drawing.Size(51, 13);
            this.lblSprache.TabIndex = 0;
            this.lblSprache.Text = "Sprache:";
            // 
            // txbSprache
            // 
            this.txbSprache.Location = new System.Drawing.Point(89, 33);
            this.txbSprache.Name = "txbSprache";
            this.txbSprache.Size = new System.Drawing.Size(100, 22);
            this.txbSprache.TabIndex = 1;
            this.txbSprache.Text = "de";
            // 
            // chkVideoTitel
            // 
            this.chkVideoTitel.AutoSize = true;
            this.chkVideoTitel.Location = new System.Drawing.Point(35, 72);
            this.chkVideoTitel.Name = "chkVideoTitel";
            this.chkVideoTitel.Size = new System.Drawing.Size(126, 17);
            this.chkVideoTitel.TabIndex = 2;
            this.chkVideoTitel.Text = "Videotitel anzeigen";
            this.chkVideoTitel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(258, 105);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 140);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkVideoTitel);
            this.Controls.Add(this.txbSprache);
            this.Controls.Add(this.lblSprache);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
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
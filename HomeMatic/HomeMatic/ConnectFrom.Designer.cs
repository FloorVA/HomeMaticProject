namespace HomeMatic
{
    partial class ConnectFrom
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
            this.lbFoundDevices = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFoundDevices
            // 
            this.lbFoundDevices.FormattingEnabled = true;
            this.lbFoundDevices.ItemHeight = 20;
            this.lbFoundDevices.Location = new System.Drawing.Point(99, 80);
            this.lbFoundDevices.Name = "lbFoundDevices";
            this.lbFoundDevices.Size = new System.Drawing.Size(205, 264);
            this.lbFoundDevices.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(99, 350);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(205, 45);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "OK";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(25, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(323, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Select your device from the list and press OK";
            // 
            // ConnectFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 438);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbFoundDevices);
            this.Name = "ConnectFrom";
            this.Text = "ConnectFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFoundDevices;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblInfo;
    }
}
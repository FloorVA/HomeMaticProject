﻿namespace HomeMatic
{
    partial class ConnectForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
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
            this.lblInfo.Location = new System.Drawing.Point(86, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(228, 40);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Zoek uw apparaat en selecteer\r\nhet apparaatadres eronder";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(309, 357);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 31);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Terug";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 438);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbFoundDevices);
            this.Name = "ConnectForm";
            this.Text = "ConnectFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFoundDevices;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn_back;
    }
}
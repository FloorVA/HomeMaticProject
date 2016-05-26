namespace HomeMatic
{
    partial class TempForm
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
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnHigher = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtTempChange = new System.Windows.Forms.TextBox();
            this.getInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.AutoSize = true;
            this.lblCurrentTemp.Location = new System.Drawing.Point(148, 109);
            this.lblCurrentTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(28, 13);
            this.lblCurrentTemp.TabIndex = 0;
            this.lblCurrentTemp.Text = "21.0";
            this.lblCurrentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(197, 40);
            this.btnLower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(34, 34);
            this.btnLower.TabIndex = 1;
            this.btnLower.Text = "-";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnHigher
            // 
            this.btnHigher.Location = new System.Drawing.Point(139, 40);
            this.btnHigher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(34, 34);
            this.btnHigher.TabIndex = 2;
            this.btnHigher.Text = "+";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(129, 185);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(109, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Press enter to confirm";
            // 
            // txtTempChange
            // 
            this.txtTempChange.Location = new System.Drawing.Point(139, 159);
            this.txtTempChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTempChange.Name = "txtTempChange";
            this.txtTempChange.Size = new System.Drawing.Size(85, 20);
            this.txtTempChange.TabIndex = 4;
            this.txtTempChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTempChange_KeyDown);
            // 
            // getInfoBtn
            // 
            this.getInfoBtn.Location = new System.Drawing.Point(12, 12);
            this.getInfoBtn.Name = "getInfoBtn";
            this.getInfoBtn.Size = new System.Drawing.Size(96, 23);
            this.getInfoBtn.TabIndex = 5;
            this.getInfoBtn.Text = "Get Information";
            this.getInfoBtn.UseVisualStyleBackColor = true;
            this.getInfoBtn.Click += new System.EventHandler(this.getInfoBtn_Click);
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 222);
            this.Controls.Add(this.getInfoBtn);
            this.Controls.Add(this.lblCurrentTemp);
            this.Controls.Add(this.txtTempChange);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.btnLower);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TempForm";
            this.Text = "TempForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTemp;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtTempChange;
        private System.Windows.Forms.Button getInfoBtn;
    }
}
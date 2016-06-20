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
            this.components = new System.ComponentModel.Container();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnHigher = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtTempChange = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.AutoSize = true;
            this.lblCurrentTemp.Location = new System.Drawing.Point(222, 168);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(40, 20);
            this.lblCurrentTemp.TabIndex = 0;
            this.lblCurrentTemp.Text = "21.0";
            this.lblCurrentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(296, 62);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(51, 52);
            this.btnLower.TabIndex = 1;
            this.btnLower.Text = "-";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnHigher
            // 
            this.btnHigher.Location = new System.Drawing.Point(208, 62);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(51, 52);
            this.btnHigher.TabIndex = 2;
            this.btnHigher.Text = "+";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(194, 285);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(164, 20);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Press enter to confirm";
            // 
            // txtTempChange
            // 
            this.txtTempChange.Location = new System.Drawing.Point(208, 245);
            this.txtTempChange.Name = "txtTempChange";
            this.txtTempChange.Size = new System.Drawing.Size(126, 26);
            this.txtTempChange.TabIndex = 4;
            this.txtTempChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTempChange_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(29, 273);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 32);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Terug";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 342);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblCurrentTemp);
            this.Controls.Add(this.txtTempChange);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.btnLower);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_back;
    }
}
namespace projectHomeMatic
{
    partial class Form1
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
            this.setTempTxt = new System.Windows.Forms.TextBox();
            this.setTempBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tempToSetTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDataTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setTempTxt
            // 
            this.setTempTxt.Location = new System.Drawing.Point(13, 13);
            this.setTempTxt.Name = "setTempTxt";
            this.setTempTxt.Size = new System.Drawing.Size(100, 20);
            this.setTempTxt.TabIndex = 0;
            // 
            // setTempBtn
            // 
            this.setTempBtn.Location = new System.Drawing.Point(13, 40);
            this.setTempBtn.Name = "setTempBtn";
            this.setTempBtn.Size = new System.Drawing.Size(100, 23);
            this.setTempBtn.TabIndex = 1;
            this.setTempBtn.Text = "Set Temperature";
            this.setTempBtn.UseVisualStyleBackColor = true;
            this.setTempBtn.Click += new System.EventHandler(this.setTempBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature to set";
            // 
            // tempToSetTxt
            // 
            this.tempToSetTxt.Location = new System.Drawing.Point(13, 131);
            this.tempToSetTxt.Name = "tempToSetTxt";
            this.tempToSetTxt.Size = new System.Drawing.Size(100, 20);
            this.tempToSetTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command Data";
            // 
            // cmdDataTxt
            // 
            this.cmdDataTxt.Location = new System.Drawing.Point(13, 175);
            this.cmdDataTxt.Name = "cmdDataTxt";
            this.cmdDataTxt.Size = new System.Drawing.Size(100, 20);
            this.cmdDataTxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdDataTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempToSetTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setTempBtn);
            this.Controls.Add(this.setTempTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setTempTxt;
        private System.Windows.Forms.Button setTempBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempToSetTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmdDataTxt;
    }
}


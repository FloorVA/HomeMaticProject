namespace HomeMatic
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
            this.btn_connct = new System.Windows.Forms.Button();
            this.btn_tempSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connct
            // 
            this.btn_connct.Location = new System.Drawing.Point(316, 172);
            this.btn_connct.Name = "btn_connct";
            this.btn_connct.Size = new System.Drawing.Size(427, 97);
            this.btn_connct.TabIndex = 0;
            this.btn_connct.Text = "Verbinding maken";
            this.btn_connct.UseVisualStyleBackColor = true;
            this.btn_connct.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btn_tempSettings
            // 
            this.btn_tempSettings.Location = new System.Drawing.Point(316, 275);
            this.btn_tempSettings.Name = "btn_tempSettings";
            this.btn_tempSettings.Size = new System.Drawing.Size(427, 97);
            this.btn_tempSettings.TabIndex = 1;
            this.btn_tempSettings.Text = "Temperatuur instellen";
            this.btn_tempSettings.UseVisualStyleBackColor = true;
            this.btn_tempSettings.Click += new System.EventHandler(this.btnTempSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 548);
            this.Controls.Add(this.btn_tempSettings);
            this.Controls.Add(this.btn_connct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connct;
        private System.Windows.Forms.Button btn_tempSettings;
    }
}


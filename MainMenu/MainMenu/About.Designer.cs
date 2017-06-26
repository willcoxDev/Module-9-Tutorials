namespace MainMenu
{
    partial class frmAbout
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
            this.lblTheCakeCompany = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTheCakeCompany
            // 
            this.lblTheCakeCompany.AutoSize = true;
            this.lblTheCakeCompany.Location = new System.Drawing.Point(290, 277);
            this.lblTheCakeCompany.Name = "lblTheCakeCompany";
            this.lblTheCakeCompany.Size = new System.Drawing.Size(265, 32);
            this.lblTheCakeCompany.TabIndex = 0;
            this.lblTheCakeCompany.Text = "The Cake Company";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(350, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 79);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 877);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTheCakeCompany);
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheCakeCompany;
        private System.Windows.Forms.Button btnClose;
    }
}
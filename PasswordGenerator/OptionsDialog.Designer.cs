namespace PasswordGenerator
{
    partial class OptionsDialog
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
            this.createAc = new System.Windows.Forms.Button();
            this.decryptAc = new System.Windows.Forms.Button();
            this.encryptAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAc
            // 
            this.createAc.Location = new System.Drawing.Point(20, 20);
            this.createAc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAc.Name = "createAc";
            this.createAc.Size = new System.Drawing.Size(186, 122);
            this.createAc.TabIndex = 0;
            this.createAc.Text = "Create";
            this.createAc.UseVisualStyleBackColor = true;
            this.createAc.Click += new System.EventHandler(this.createAc_Click);
            // 
            // decryptAc
            // 
            this.decryptAc.Location = new System.Drawing.Point(408, 20);
            this.decryptAc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptAc.Name = "decryptAc";
            this.decryptAc.Size = new System.Drawing.Size(186, 122);
            this.decryptAc.TabIndex = 2;
            this.decryptAc.Text = "Decrypt";
            this.decryptAc.UseVisualStyleBackColor = true;
            this.decryptAc.Click += new System.EventHandler(this.decryptAc_Click);
            // 
            // encryptAc
            // 
            this.encryptAc.Location = new System.Drawing.Point(213, 20);
            this.encryptAc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encryptAc.Name = "encryptAc";
            this.encryptAc.Size = new System.Drawing.Size(186, 122);
            this.encryptAc.TabIndex = 1;
            this.encryptAc.Text = "Encrypt";
            this.encryptAc.UseVisualStyleBackColor = true;
            this.encryptAc.Click += new System.EventHandler(this.encryptAc_Click);
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 160);
            this.Controls.Add(this.encryptAc);
            this.Controls.Add(this.decryptAc);
            this.Controls.Add(this.createAc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAc;
        private System.Windows.Forms.Button decryptAc;
        private System.Windows.Forms.Button encryptAc;
    }
}
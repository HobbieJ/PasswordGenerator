namespace PasswordGenerator
{
    partial class PassGen
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
            this.finalPass = new System.Windows.Forms.TextBox();
            this.findPass = new System.Windows.Forms.Button();
            this.clipCopy = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finalPass
            // 
            this.finalPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.finalPass.Location = new System.Drawing.Point(12, 12);
            this.finalPass.MaxLength = 255;
            this.finalPass.Name = "finalPass";
            this.finalPass.ReadOnly = true;
            this.finalPass.Size = new System.Drawing.Size(384, 20);
            this.finalPass.TabIndex = 5;
            this.finalPass.TabStop = false;
            this.finalPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findPass
            // 
            this.findPass.Location = new System.Drawing.Point(12, 48);
            this.findPass.Name = "findPass";
            this.findPass.Size = new System.Drawing.Size(116, 44);
            this.findPass.TabIndex = 1;
            this.findPass.Text = "Generate";
            this.findPass.UseVisualStyleBackColor = true;
            this.findPass.Click += new System.EventHandler(this.findPass_Click);
            // 
            // clipCopy
            // 
            this.clipCopy.Location = new System.Drawing.Point(146, 48);
            this.clipCopy.Name = "clipCopy";
            this.clipCopy.Size = new System.Drawing.Size(116, 44);
            this.clipCopy.TabIndex = 3;
            this.clipCopy.Text = "Copy to Clipboard";
            this.clipCopy.UseVisualStyleBackColor = true;
            this.clipCopy.Click += new System.EventHandler(this.clipCopy_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(280, 48);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(116, 44);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // PassGen
            // 
            this.AcceptButton = this.findPass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 104);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.clipCopy);
            this.Controls.Add(this.findPass);
            this.Controls.Add(this.finalPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox finalPass;
        private System.Windows.Forms.Button findPass;
        private System.Windows.Forms.Button clipCopy;
        private System.Windows.Forms.Button btnAbout;
    }
}


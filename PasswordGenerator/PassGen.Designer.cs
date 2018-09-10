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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGen));
            this.finalPass = new System.Windows.Forms.TextBox();
            this.findPass = new System.Windows.Forms.Button();
            this.clipCopy = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finalPass
            // 
            this.finalPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.finalPass.Location = new System.Drawing.Point(16, 15);
            this.finalPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finalPass.MaxLength = 255;
            this.finalPass.Name = "finalPass";
            this.finalPass.ReadOnly = true;
            this.finalPass.Size = new System.Drawing.Size(511, 22);
            this.finalPass.TabIndex = 5;
            this.finalPass.TabStop = false;
            this.finalPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findPass
            // 
            this.findPass.Location = new System.Drawing.Point(16, 59);
            this.findPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findPass.Name = "findPass";
            this.findPass.Size = new System.Drawing.Size(155, 54);
            this.findPass.TabIndex = 1;
            this.findPass.Text = "Generate";
            this.findPass.UseVisualStyleBackColor = true;
            this.findPass.Click += new System.EventHandler(this.findPass_Click);
            // 
            // clipCopy
            // 
            this.clipCopy.Location = new System.Drawing.Point(195, 59);
            this.clipCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clipCopy.Name = "clipCopy";
            this.clipCopy.Size = new System.Drawing.Size(155, 54);
            this.clipCopy.TabIndex = 3;
            this.clipCopy.Text = "Copy to Clipboard";
            this.clipCopy.UseVisualStyleBackColor = true;
            this.clipCopy.Click += new System.EventHandler(this.clipCopy_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(373, 59);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(155, 54);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // PassGen
            // 
            this.AcceptButton = this.findPass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 128);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.clipCopy);
            this.Controls.Add(this.findPass);
            this.Controls.Add(this.finalPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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


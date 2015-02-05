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
            this.goToOptions = new System.Windows.Forms.Button();
            this.findText = new System.Windows.Forms.OpenFileDialog();
            this.saveText = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // finalPass
            // 
            this.finalPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.finalPass.Location = new System.Drawing.Point(18, 18);
            this.finalPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finalPass.MaxLength = 255;
            this.finalPass.Name = "finalPass";
            this.finalPass.ReadOnly = true;
            this.finalPass.Size = new System.Drawing.Size(574, 26);
            this.finalPass.TabIndex = 5;
            this.finalPass.TabStop = false;
            this.finalPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findPass
            // 
            this.findPass.Location = new System.Drawing.Point(18, 74);
            this.findPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findPass.Name = "findPass";
            this.findPass.Size = new System.Drawing.Size(174, 68);
            this.findPass.TabIndex = 1;
            this.findPass.Text = "Generate";
            this.findPass.UseVisualStyleBackColor = true;
            this.findPass.Click += new System.EventHandler(this.findPass_Click);
            // 
            // clipCopy
            // 
            this.clipCopy.Location = new System.Drawing.Point(420, 74);
            this.clipCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clipCopy.Name = "clipCopy";
            this.clipCopy.Size = new System.Drawing.Size(174, 68);
            this.clipCopy.TabIndex = 3;
            this.clipCopy.Text = "Copy to Clipboard";
            this.clipCopy.UseVisualStyleBackColor = true;
            this.clipCopy.Click += new System.EventHandler(this.clipCopy_Click);
            // 
            // goToOptions
            // 
            this.goToOptions.Location = new System.Drawing.Point(219, 74);
            this.goToOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goToOptions.Name = "goToOptions";
            this.goToOptions.Size = new System.Drawing.Size(174, 68);
            this.goToOptions.TabIndex = 2;
            this.goToOptions.Text = "Options";
            this.goToOptions.UseVisualStyleBackColor = true;
            this.goToOptions.Click += new System.EventHandler(this.goToOptions_Click);
            // 
            // findText
            // 
            this.findText.InitialDirectory = "C:\\Users\\Public\\Documents\\Saved Passwords";
            // 
            // saveText
            // 
            this.saveText.FileName = "Password.txt";
            this.saveText.InitialDirectory = "C:\\Users\\Public\\Documents\\Saved Passwords";
            // 
            // PassGen
            // 
            this.AcceptButton = this.findPass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 160);
            this.Controls.Add(this.goToOptions);
            this.Controls.Add(this.clipCopy);
            this.Controls.Add(this.findPass);
            this.Controls.Add(this.finalPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button goToOptions;
        private System.Windows.Forms.OpenFileDialog findText;
        private System.Windows.Forms.SaveFileDialog saveText;
    }
}


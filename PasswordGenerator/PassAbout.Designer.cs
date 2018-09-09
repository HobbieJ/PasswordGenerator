﻿namespace PasswordGenerator
{
    partial class PassAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassAbout));
            this.picAuthor = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lnkLblWebsite = new System.Windows.Forms.LinkLabel();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblProjectWebsite = new System.Windows.Forms.Label();
            this.lnkLblProjectWebsite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // picAuthor
            // 
            this.picAuthor.Image = ((System.Drawing.Image)(resources.GetObject("picAuthor.Image")));
            this.picAuthor.Location = new System.Drawing.Point(12, 12);
            this.picAuthor.Name = "picAuthor";
            this.picAuthor.Size = new System.Drawing.Size(80, 80);
            this.picAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAuthor.TabIndex = 0;
            this.picAuthor.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(98, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Simple Password Generator";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(98, 29);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(169, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "A C# Application by Jacob Hobbie";
            // 
            // lnkLblWebsite
            // 
            this.lnkLblWebsite.AutoSize = true;
            this.lnkLblWebsite.Location = new System.Drawing.Point(188, 79);
            this.lnkLblWebsite.Name = "lnkLblWebsite";
            this.lnkLblWebsite.Size = new System.Drawing.Size(124, 13);
            this.lnkLblWebsite.TabIndex = 3;
            this.lnkLblWebsite.TabStop = true;
            this.lnkLblWebsite.Text = "https://jacobhobbie.com";
            this.lnkLblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblWebsite_LinkClicked);
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(98, 79);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(93, 13);
            this.lblWebsite.TabIndex = 4;
            this.lblWebsite.Text = "Personal Website:";
            // 
            // lblProjectWebsite
            // 
            this.lblProjectWebsite.AutoSize = true;
            this.lblProjectWebsite.Location = new System.Drawing.Point(98, 62);
            this.lblProjectWebsite.Name = "lblProjectWebsite";
            this.lblProjectWebsite.Size = new System.Drawing.Size(43, 13);
            this.lblProjectWebsite.TabIndex = 5;
            this.lblProjectWebsite.Text = "Project:";
            // 
            // lnkLblProjectWebsite
            // 
            this.lnkLblProjectWebsite.AutoSize = true;
            this.lnkLblProjectWebsite.Location = new System.Drawing.Point(138, 62);
            this.lnkLblProjectWebsite.Name = "lnkLblProjectWebsite";
            this.lnkLblProjectWebsite.Size = new System.Drawing.Size(237, 13);
            this.lnkLblProjectWebsite.TabIndex = 6;
            this.lnkLblProjectWebsite.TabStop = true;
            this.lnkLblProjectWebsite.Text = "https://github.com/HobbieJ/PasswordGenerator";
            this.lnkLblProjectWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblProjectWebsite_LinkClicked);
            // 
            // PassAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 104);
            this.Controls.Add(this.lnkLblProjectWebsite);
            this.Controls.Add(this.lblProjectWebsite);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lnkLblWebsite);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.LinkLabel lnkLblWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblProjectWebsite;
        private System.Windows.Forms.LinkLabel lnkLblProjectWebsite;
    }
}
﻿namespace PasswordGenerator
{
    partial class PassAsk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassAsk));
            this.questLab = new System.Windows.Forms.Label();
            this.submitLength = new System.Windows.Forms.Button();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.radioGroup = new System.Windows.Forms.Panel();
            this.advancedRadio = new System.Windows.Forms.RadioButton();
            this.basicRadio = new System.Windows.Forms.RadioButton();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // questLab
            // 
            this.questLab.AutoSize = true;
            this.questLab.Location = new System.Drawing.Point(16, 11);
            this.questLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questLab.Name = "questLab";
            this.questLab.Size = new System.Drawing.Size(286, 17);
            this.questLab.TabIndex = 0;
            this.questLab.Text = "How long do you want your password to be?";
            // 
            // submitLength
            // 
            this.submitLength.Location = new System.Drawing.Point(220, 38);
            this.submitLength.Margin = new System.Windows.Forms.Padding(4);
            this.submitLength.Name = "submitLength";
            this.submitLength.Size = new System.Drawing.Size(128, 25);
            this.submitLength.TabIndex = 2;
            this.submitLength.Text = "Submit";
            this.submitLength.UseVisualStyleBackColor = true;
            this.submitLength.Click += new System.EventHandler(this.submitLength_Click);
            // 
            // lengthText
            // 
            this.lengthText.AllowDrop = true;
            this.lengthText.Location = new System.Drawing.Point(16, 39);
            this.lengthText.Margin = new System.Windows.Forms.Padding(4);
            this.lengthText.MaxLength = 3;
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(197, 22);
            this.lengthText.TabIndex = 1;
            this.lengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioGroup
            // 
            this.radioGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radioGroup.Controls.Add(this.advancedRadio);
            this.radioGroup.Controls.Add(this.basicRadio);
            this.radioGroup.Location = new System.Drawing.Point(16, 74);
            this.radioGroup.Margin = new System.Windows.Forms.Padding(4);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(331, 55);
            this.radioGroup.TabIndex = 3;
            // 
            // advancedRadio
            // 
            this.advancedRadio.AutoSize = true;
            this.advancedRadio.Location = new System.Drawing.Point(171, 16);
            this.advancedRadio.Margin = new System.Windows.Forms.Padding(4);
            this.advancedRadio.Name = "advancedRadio";
            this.advancedRadio.Size = new System.Drawing.Size(92, 21);
            this.advancedRadio.TabIndex = 4;
            this.advancedRadio.Text = "Advanced";
            this.advancedRadio.UseVisualStyleBackColor = true;
            this.advancedRadio.CheckedChanged += new System.EventHandler(this.RadioChecker);
            // 
            // basicRadio
            // 
            this.basicRadio.AutoSize = true;
            this.basicRadio.Checked = true;
            this.basicRadio.Location = new System.Drawing.Point(37, 16);
            this.basicRadio.Margin = new System.Windows.Forms.Padding(4);
            this.basicRadio.Name = "basicRadio";
            this.basicRadio.Size = new System.Drawing.Size(74, 21);
            this.basicRadio.TabIndex = 3;
            this.basicRadio.TabStop = true;
            this.basicRadio.Text = "Normal";
            this.basicRadio.UseVisualStyleBackColor = true;
            this.basicRadio.CheckedChanged += new System.EventHandler(this.RadioChecker);
            // 
            // PassAsk
            // 
            this.AcceptButton = this.submitLength;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 143);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.submitLength);
            this.Controls.Add(this.questLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PassAsk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Length";
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questLab;
        private System.Windows.Forms.Button submitLength;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.Panel radioGroup;
        public System.Windows.Forms.RadioButton advancedRadio;
        public System.Windows.Forms.RadioButton basicRadio;
    }
}
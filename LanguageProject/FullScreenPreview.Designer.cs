﻿namespace LanguageProject
{
    partial class FullScreenPreview
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
            this.fullscreen_txtbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fullscreen_txtbox
            // 
            this.fullscreen_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreen_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullscreen_txtbox.Location = new System.Drawing.Point(306, 32);
            this.fullscreen_txtbox.Name = "fullscreen_txtbox";
            this.fullscreen_txtbox.ReadOnly = true;
            this.fullscreen_txtbox.Size = new System.Drawing.Size(917, 760);
            this.fullscreen_txtbox.TabIndex = 0;
            this.fullscreen_txtbox.Text = "";
            // 
            // FullScreenPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 572);
            this.Controls.Add(this.fullscreen_txtbox);
            this.Name = "FullScreenPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullScreenPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox fullscreen_txtbox;
    }
}
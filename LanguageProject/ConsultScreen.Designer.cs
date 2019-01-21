﻿namespace LanguageProject
{
    partial class ConsultScreen
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
            this.confirm_search_result_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_new_summary_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.print_summary_btn = new System.Windows.Forms.Button();
            this.display_summary_fullscreen_btn = new System.Windows.Forms.Button();
            this.searchbox_consult_screen = new System.Windows.Forms.ComboBox();
            this.consult_search_btn = new System.Windows.Forms.Button();
            this.consult_screen_search_result_textbox = new System.Windows.Forms.RichTextBox();
            this.summary_preview_txtbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // confirm_search_result_btn
            // 
            this.confirm_search_result_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_search_result_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_search_result_btn.Location = new System.Drawing.Point(578, 398);
            this.confirm_search_result_btn.Name = "confirm_search_result_btn";
            this.confirm_search_result_btn.Size = new System.Drawing.Size(112, 67);
            this.confirm_search_result_btn.TabIndex = 1;
            this.confirm_search_result_btn.Text = "Confirm";
            this.confirm_search_result_btn.UseVisualStyleBackColor = true;
            this.confirm_search_result_btn.Click += new System.EventHandler(this.confirm_search_result_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Results:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Final Summary Preview";
            // 
            // add_new_summary_btn
            // 
            this.add_new_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_new_summary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_summary_btn.Location = new System.Drawing.Point(388, 50);
            this.add_new_summary_btn.Name = "add_new_summary_btn";
            this.add_new_summary_btn.Size = new System.Drawing.Size(112, 49);
            this.add_new_summary_btn.TabIndex = 6;
            this.add_new_summary_btn.Text = "Create New Summary";
            this.add_new_summary_btn.UseVisualStyleBackColor = true;
            this.add_new_summary_btn.Click += new System.EventHandler(this.add_new_summary_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Box:";
            // 
            // print_summary_btn
            // 
            this.print_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.print_summary_btn.Location = new System.Drawing.Point(1135, 307);
            this.print_summary_btn.Name = "print_summary_btn";
            this.print_summary_btn.Size = new System.Drawing.Size(75, 23);
            this.print_summary_btn.TabIndex = 8;
            this.print_summary_btn.Text = "Print";
            this.print_summary_btn.UseVisualStyleBackColor = true;
            // 
            // display_summary_fullscreen_btn
            // 
            this.display_summary_fullscreen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display_summary_fullscreen_btn.Location = new System.Drawing.Point(1135, 388);
            this.display_summary_fullscreen_btn.Name = "display_summary_fullscreen_btn";
            this.display_summary_fullscreen_btn.Size = new System.Drawing.Size(75, 37);
            this.display_summary_fullscreen_btn.TabIndex = 9;
            this.display_summary_fullscreen_btn.Text = "Full Screen Summary";
            this.display_summary_fullscreen_btn.UseVisualStyleBackColor = true;
            this.display_summary_fullscreen_btn.Click += new System.EventHandler(this.display_summary_fullscreen_btn_Click);
            // 
            // searchbox_consult_screen
            // 
            this.searchbox_consult_screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox_consult_screen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchbox_consult_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox_consult_screen.FormattingEnabled = true;
            this.searchbox_consult_screen.Location = new System.Drawing.Point(110, 178);
            this.searchbox_consult_screen.Name = "searchbox_consult_screen";
            this.searchbox_consult_screen.Size = new System.Drawing.Size(202, 32);
            this.searchbox_consult_screen.TabIndex = 10;
            // 
            // consult_search_btn
            // 
            this.consult_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consult_search_btn.AutoSize = true;
            this.consult_search_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consult_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_search_btn.Location = new System.Drawing.Point(377, 184);
            this.consult_search_btn.Name = "consult_search_btn";
            this.consult_search_btn.Size = new System.Drawing.Size(123, 26);
            this.consult_search_btn.TabIndex = 11;
            this.consult_search_btn.Text = "Confirm Search";
            this.consult_search_btn.UseVisualStyleBackColor = true;
            this.consult_search_btn.Click += new System.EventHandler(this.consult_search_btn_Click);
            // 
            // consult_screen_search_result_textbox
            // 
            this.consult_screen_search_result_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consult_screen_search_result_textbox.Location = new System.Drawing.Point(110, 329);
            this.consult_screen_search_result_textbox.Name = "consult_screen_search_result_textbox";
            this.consult_screen_search_result_textbox.Size = new System.Drawing.Size(420, 270);
            this.consult_screen_search_result_textbox.TabIndex = 12;
            this.consult_screen_search_result_textbox.Text = "";
            this.consult_screen_search_result_textbox.SizeChanged += new System.EventHandler(this.consult_screen_search_result_textbox_SizeChanged);
            // 
            // summary_preview_txtbox
            // 
            this.summary_preview_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.summary_preview_txtbox.Location = new System.Drawing.Point(752, 110);
            this.summary_preview_txtbox.Name = "summary_preview_txtbox";
            this.summary_preview_txtbox.Size = new System.Drawing.Size(320, 456);
            this.summary_preview_txtbox.TabIndex = 13;
            this.summary_preview_txtbox.Text = "";
            // 
            // ConsultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1261, 631);
            this.Controls.Add(this.summary_preview_txtbox);
            this.Controls.Add(this.consult_screen_search_result_textbox);
            this.Controls.Add(this.consult_search_btn);
            this.Controls.Add(this.searchbox_consult_screen);
            this.Controls.Add(this.display_summary_fullscreen_btn);
            this.Controls.Add(this.print_summary_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_new_summary_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_search_result_btn);
            this.Name = "ConsultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultScreen";
            this.ResizeBegin += new System.EventHandler(this.ConsultScreen_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.ConsultScreen_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirm_search_result_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_new_summary_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button print_summary_btn;
        private System.Windows.Forms.Button display_summary_fullscreen_btn;
        private System.Windows.Forms.ComboBox searchbox_consult_screen;
        private System.Windows.Forms.Button consult_search_btn;
        private System.Windows.Forms.RichTextBox consult_screen_search_result_textbox;
        private System.Windows.Forms.RichTextBox summary_preview_txtbox;
    }
}
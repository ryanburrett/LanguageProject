namespace LanguageProject
{
    partial class StartScreen
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
            this.start_screen_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start_screen_searchbox = new System.Windows.Forms.ComboBox();
            this.start_scrn_insert_image_btn = new System.Windows.Forms.Button();
            this.new_condition_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_screen_btn
            // 
            this.start_screen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.start_screen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_screen_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_screen_btn.Location = new System.Drawing.Point(401, 345);
            this.start_screen_btn.MaximumSize = new System.Drawing.Size(109, 41);
            this.start_screen_btn.Name = "start_screen_btn";
            this.start_screen_btn.Size = new System.Drawing.Size(109, 41);
            this.start_screen_btn.TabIndex = 0;
            this.start_screen_btn.Text = "Confirm";
            this.start_screen_btn.UseVisualStyleBackColor = true;
            this.start_screen_btn.Click += new System.EventHandler(this.start_screen_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language Simplification";
            // 
            // start_screen_searchbox
            // 
            this.start_screen_searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.start_screen_searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.start_screen_searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.start_screen_searchbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_screen_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_screen_searchbox.FormattingEnabled = true;
            this.start_screen_searchbox.Location = new System.Drawing.Point(315, 192);
            this.start_screen_searchbox.Name = "start_screen_searchbox";
            this.start_screen_searchbox.Size = new System.Drawing.Size(265, 37);
            this.start_screen_searchbox.TabIndex = 3;
            // 
            // start_scrn_insert_image_btn
            // 
            this.start_scrn_insert_image_btn.Location = new System.Drawing.Point(782, 390);
            this.start_scrn_insert_image_btn.Name = "start_scrn_insert_image_btn";
            this.start_scrn_insert_image_btn.Size = new System.Drawing.Size(75, 23);
            this.start_scrn_insert_image_btn.TabIndex = 4;
            this.start_scrn_insert_image_btn.Text = "Add Image";
            this.start_scrn_insert_image_btn.UseVisualStyleBackColor = true;
            this.start_scrn_insert_image_btn.Visible = false;
            this.start_scrn_insert_image_btn.Click += new System.EventHandler(this.start_scrn_insert_image_btn_Click);
            // 
            // new_condition_btn
            // 
            this.new_condition_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.new_condition_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_condition_btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_condition_btn.Location = new System.Drawing.Point(401, 402);
            this.new_condition_btn.MaximumSize = new System.Drawing.Size(109, 41);
            this.new_condition_btn.Name = "new_condition_btn";
            this.new_condition_btn.Size = new System.Drawing.Size(109, 41);
            this.new_condition_btn.TabIndex = 5;
            this.new_condition_btn.Text = "Create New";
            this.new_condition_btn.UseVisualStyleBackColor = true;
            this.new_condition_btn.Click += new System.EventHandler(this.new_condition_btn_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LanguageProject.Properties.Resources.abstract_art_business_249348;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.new_condition_btn);
            this.Controls.Add(this.start_scrn_insert_image_btn);
            this.Controls.Add(this.start_screen_searchbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_screen_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_screen_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox start_screen_searchbox;
        private System.Windows.Forms.Button start_scrn_insert_image_btn;
        private System.Windows.Forms.Button new_condition_btn;
    }
}
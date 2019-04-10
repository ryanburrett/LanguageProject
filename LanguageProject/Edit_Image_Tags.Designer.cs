namespace LanguageProject
{
    partial class Edit_Image_Tags
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
            this.tag_search_groupbox = new System.Windows.Forms.GroupBox();
            this.tag_returns_label = new System.Windows.Forms.Label();
            this.tag_search_autobox = new System.Windows.Forms.ComboBox();
            this.tag_search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.symbol_listview = new System.Windows.Forms.ListView();
            this.selected_image_picbox = new System.Windows.Forms.PictureBox();
            this.selected_image_groupbox = new System.Windows.Forms.GroupBox();
            this.list_of_tags_checked_listbox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.additional_tags_txtbox = new System.Windows.Forms.TextBox();
            this.delete_image_btn = new System.Windows.Forms.Button();
            this.tag_search_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selected_image_picbox)).BeginInit();
            this.selected_image_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tag_search_groupbox
            // 
            this.tag_search_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tag_search_groupbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tag_search_groupbox.Controls.Add(this.tag_returns_label);
            this.tag_search_groupbox.Controls.Add(this.tag_search_autobox);
            this.tag_search_groupbox.Controls.Add(this.tag_search_btn);
            this.tag_search_groupbox.Controls.Add(this.label5);
            this.tag_search_groupbox.Controls.Add(this.symbol_listview);
            this.tag_search_groupbox.Location = new System.Drawing.Point(27, 52);
            this.tag_search_groupbox.Name = "tag_search_groupbox";
            this.tag_search_groupbox.Size = new System.Drawing.Size(269, 452);
            this.tag_search_groupbox.TabIndex = 30;
            this.tag_search_groupbox.TabStop = false;
            // 
            // tag_returns_label
            // 
            this.tag_returns_label.AutoSize = true;
            this.tag_returns_label.Location = new System.Drawing.Point(6, 66);
            this.tag_returns_label.Name = "tag_returns_label";
            this.tag_returns_label.Size = new System.Drawing.Size(83, 13);
            this.tag_returns_label.TabIndex = 33;
            this.tag_returns_label.Text = "Images Fround: ";
            // 
            // tag_search_autobox
            // 
            this.tag_search_autobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tag_search_autobox.FormattingEnabled = true;
            this.tag_search_autobox.Location = new System.Drawing.Point(8, 35);
            this.tag_search_autobox.Name = "tag_search_autobox";
            this.tag_search_autobox.Size = new System.Drawing.Size(173, 21);
            this.tag_search_autobox.TabIndex = 32;
            // 
            // tag_search_btn
            // 
            this.tag_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_search_btn.Location = new System.Drawing.Point(201, 35);
            this.tag_search_btn.Name = "tag_search_btn";
            this.tag_search_btn.Size = new System.Drawing.Size(57, 22);
            this.tag_search_btn.TabIndex = 21;
            this.tag_search_btn.Text = "Search";
            this.tag_search_btn.UseVisualStyleBackColor = true;
            this.tag_search_btn.Click += new System.EventHandler(this.tag_search_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search Image To Edit By Keyword:";
            // 
            // symbol_listview
            // 
            this.symbol_listview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.symbol_listview.Location = new System.Drawing.Point(8, 82);
            this.symbol_listview.MultiSelect = false;
            this.symbol_listview.Name = "symbol_listview";
            this.symbol_listview.Size = new System.Drawing.Size(250, 364);
            this.symbol_listview.TabIndex = 19;
            this.symbol_listview.UseCompatibleStateImageBehavior = false;
            this.symbol_listview.SelectedIndexChanged += new System.EventHandler(this.symbol_listview_SelectedIndexChanged);
            // 
            // selected_image_picbox
            // 
            this.selected_image_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selected_image_picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selected_image_picbox.Location = new System.Drawing.Point(3, 16);
            this.selected_image_picbox.Name = "selected_image_picbox";
            this.selected_image_picbox.Size = new System.Drawing.Size(223, 186);
            this.selected_image_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selected_image_picbox.TabIndex = 31;
            this.selected_image_picbox.TabStop = false;
            // 
            // selected_image_groupbox
            // 
            this.selected_image_groupbox.Controls.Add(this.selected_image_picbox);
            this.selected_image_groupbox.Location = new System.Drawing.Point(360, 52);
            this.selected_image_groupbox.Name = "selected_image_groupbox";
            this.selected_image_groupbox.Size = new System.Drawing.Size(229, 205);
            this.selected_image_groupbox.TabIndex = 32;
            this.selected_image_groupbox.TabStop = false;
            this.selected_image_groupbox.Text = "Selected Image";
            // 
            // list_of_tags_checked_listbox
            // 
            this.list_of_tags_checked_listbox.FormattingEnabled = true;
            this.list_of_tags_checked_listbox.Location = new System.Drawing.Point(710, 52);
            this.list_of_tags_checked_listbox.Name = "list_of_tags_checked_listbox";
            this.list_of_tags_checked_listbox.Size = new System.Drawing.Size(171, 439);
            this.list_of_tags_checked_listbox.Sorted = true;
            this.list_of_tags_checked_listbox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Current Tags:";
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(435, 449);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(122, 55);
            this.update_btn.TabIndex = 35;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Enter Additional Tags: (seperate by comma )";
            // 
            // additional_tags_txtbox
            // 
            this.additional_tags_txtbox.Location = new System.Drawing.Point(897, 335);
            this.additional_tags_txtbox.Name = "additional_tags_txtbox";
            this.additional_tags_txtbox.Size = new System.Drawing.Size(283, 20);
            this.additional_tags_txtbox.TabIndex = 36;
            // 
            // delete_image_btn
            // 
            this.delete_image_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_image_btn.Location = new System.Drawing.Point(411, 263);
            this.delete_image_btn.Name = "delete_image_btn";
            this.delete_image_btn.Size = new System.Drawing.Size(125, 60);
            this.delete_image_btn.TabIndex = 38;
            this.delete_image_btn.Text = "Delete Image";
            this.delete_image_btn.UseVisualStyleBackColor = true;
            this.delete_image_btn.Click += new System.EventHandler(this.delete_image_btn_Click);
            // 
            // Edit_Image_Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1192, 584);
            this.Controls.Add(this.delete_image_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.additional_tags_txtbox);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_of_tags_checked_listbox);
            this.Controls.Add(this.selected_image_groupbox);
            this.Controls.Add(this.tag_search_groupbox);
            this.Name = "Edit_Image_Tags";
            this.Text = " ";
            this.tag_search_groupbox.ResumeLayout(false);
            this.tag_search_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selected_image_picbox)).EndInit();
            this.selected_image_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tag_search_groupbox;
        private System.Windows.Forms.Label tag_returns_label;
        private System.Windows.Forms.ComboBox tag_search_autobox;
        private System.Windows.Forms.Button tag_search_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView symbol_listview;
        private System.Windows.Forms.PictureBox selected_image_picbox;
        private System.Windows.Forms.GroupBox selected_image_groupbox;
        private System.Windows.Forms.CheckedListBox list_of_tags_checked_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox additional_tags_txtbox;
        private System.Windows.Forms.Button delete_image_btn;
    }
}
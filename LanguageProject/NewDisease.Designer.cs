namespace LanguageProject
{
    partial class NewDisease
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.condition_txtbox = new System.Windows.Forms.TextBox();
            this.summary_txtbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.symbol_listview = new System.Windows.Forms.ListView();
            this.tag_search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.exit_2_consult_screen_menu_item = new System.Windows.Forms.MenuItem();
            this.exit_program_fully_menu_item = new System.Windows.Forms.MenuItem();
            this.add_images_to_db_menu_item = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.about_menu_item = new System.Windows.Forms.MenuItem();
            this.tag_search_autobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploading_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.summary_word_count_lebel = new System.Windows.Forms.Label();
            this.hard_word_label = new System.Windows.Forms.Label();
            this.images_found_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.formatting_label = new System.Windows.Forms.Label();
            this.txt2speech_btn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2speech_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condition: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Summary: ";
            // 
            // condition_txtbox
            // 
            this.condition_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.condition_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition_txtbox.Location = new System.Drawing.Point(165, 22);
            this.condition_txtbox.Name = "condition_txtbox";
            this.condition_txtbox.Size = new System.Drawing.Size(331, 35);
            this.condition_txtbox.TabIndex = 3;
            this.condition_txtbox.MouseHover += new System.EventHandler(this.condition_txtbox_MouseHover);
            // 
            // summary_txtbox
            // 
            this.summary_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summary_txtbox.EnableAutoDragDrop = true;
            this.summary_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_txtbox.Location = new System.Drawing.Point(165, 87);
            this.summary_txtbox.Name = "summary_txtbox";
            this.summary_txtbox.Size = new System.Drawing.Size(659, 253);
            this.summary_txtbox.TabIndex = 4;
            this.summary_txtbox.Text = "";
            this.summary_txtbox.TextChanged += new System.EventHandler(this.summary_txtbox_TextChanged);
            this.summary_txtbox.MouseHover += new System.EventHandler(this.summary_txtbox_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add New Simplified Condition Summary";
            // 
            // submit_btn
            // 
            this.submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(3, 3);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(209, 31);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(218, 3);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(209, 31);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Maroon;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(165, 366);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(659, 10);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progress bar represents the amount of text deemed appropriate ";
            this.label4.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.submit_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancel_btn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(326, 455);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(430, 37);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // symbol_listview
            // 
            this.symbol_listview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbol_listview.Location = new System.Drawing.Point(20, 91);
            this.symbol_listview.Name = "symbol_listview";
            this.symbol_listview.Size = new System.Drawing.Size(250, 336);
            this.symbol_listview.TabIndex = 14;
            this.symbol_listview.UseCompatibleStateImageBehavior = false;
            this.symbol_listview.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.symbol_listview_ItemDrag);
            // 
            // tag_search_btn
            // 
            this.tag_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tag_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_search_btn.Location = new System.Drawing.Point(208, 40);
            this.tag_search_btn.Name = "tag_search_btn";
            this.tag_search_btn.Size = new System.Drawing.Size(62, 21);
            this.tag_search_btn.TabIndex = 16;
            this.tag_search_btn.Text = "Search";
            this.tag_search_btn.UseVisualStyleBackColor = true;
            this.tag_search_btn.Click += new System.EventHandler(this.tag_search_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search Images By Keyword:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem1});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.exit_2_consult_screen_menu_item,
            this.exit_program_fully_menu_item,
            this.add_images_to_db_menu_item});
            this.menuItem2.Text = "Options";
            // 
            // exit_2_consult_screen_menu_item
            // 
            this.exit_2_consult_screen_menu_item.Index = 0;
            this.exit_2_consult_screen_menu_item.Text = "Exit to Consoltation Screen";
            this.exit_2_consult_screen_menu_item.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // exit_program_fully_menu_item
            // 
            this.exit_program_fully_menu_item.Index = 1;
            this.exit_program_fully_menu_item.Text = "Exit Program";
            this.exit_program_fully_menu_item.Click += new System.EventHandler(this.exit_program_fully_menu_item_Click);
            // 
            // add_images_to_db_menu_item
            // 
            this.add_images_to_db_menu_item.Index = 2;
            this.add_images_to_db_menu_item.Text = "Add External Images(Admin)";
            this.add_images_to_db_menu_item.Click += new System.EventHandler(this.add_images_to_db_menu_item_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.about_menu_item});
            this.menuItem1.Text = "Help";
            // 
            // about_menu_item
            // 
            this.about_menu_item.Index = 0;
            this.about_menu_item.Text = "About";
            this.about_menu_item.Click += new System.EventHandler(this.about_menu_item_Click);
            // 
            // tag_search_autobox
            // 
            this.tag_search_autobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tag_search_autobox.FormattingEnabled = true;
            this.tag_search_autobox.Location = new System.Drawing.Point(20, 40);
            this.tag_search_autobox.Name = "tag_search_autobox";
            this.tag_search_autobox.Size = new System.Drawing.Size(173, 21);
            this.tag_search_autobox.TabIndex = 33;
            this.tag_search_autobox.SelectedIndexChanged += new System.EventHandler(this.tag_search_autobox_SelectedIndexChanged);
            this.tag_search_autobox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tag_search_autobox_KeyDown);
            this.tag_search_autobox.MouseHover += new System.EventHandler(this.tag_search_autobox_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.formatting_label);
            this.groupBox1.Controls.Add(this.uploading_label);
            this.groupBox1.Controls.Add(this.txt2speech_btn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.condition_txtbox);
            this.groupBox1.Controls.Add(this.summary_txtbox);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 367);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // uploading_label
            // 
            this.uploading_label.AutoSize = true;
            this.uploading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploading_label.Location = new System.Drawing.Point(551, 29);
            this.uploading_label.Name = "uploading_label";
            this.uploading_label.Size = new System.Drawing.Size(0, 33);
            this.uploading_label.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Controls.Add(this.summary_word_count_lebel);
            this.groupBox3.Controls.Add(this.hard_word_label);
            this.groupBox3.Location = new System.Drawing.Point(6, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 100);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary Info";
            // 
            // summary_word_count_lebel
            // 
            this.summary_word_count_lebel.AutoSize = true;
            this.summary_word_count_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_word_count_lebel.Location = new System.Drawing.Point(6, 31);
            this.summary_word_count_lebel.Name = "summary_word_count_lebel";
            this.summary_word_count_lebel.Size = new System.Drawing.Size(81, 16);
            this.summary_word_count_lebel.TabIndex = 9;
            this.summary_word_count_lebel.Text = "Word Count:";
            // 
            // hard_word_label
            // 
            this.hard_word_label.AutoSize = true;
            this.hard_word_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard_word_label.Location = new System.Drawing.Point(6, 56);
            this.hard_word_label.Name = "hard_word_label";
            this.hard_word_label.Size = new System.Drawing.Size(84, 16);
            this.hard_word_label.TabIndex = 10;
            this.hard_word_label.Text = "Hard Words:";
            // 
            // images_found_label
            // 
            this.images_found_label.AutoSize = true;
            this.images_found_label.Location = new System.Drawing.Point(17, 75);
            this.images_found_label.Name = "images_found_label";
            this.images_found_label.Size = new System.Drawing.Size(77, 13);
            this.images_found_label.TabIndex = 35;
            this.images_found_label.Text = "Images Found:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.images_found_label);
            this.groupBox2.Controls.Add(this.symbol_listview);
            this.groupBox2.Controls.Add(this.tag_search_autobox);
            this.groupBox2.Controls.Add(this.tag_search_btn);
            this.groupBox2.Location = new System.Drawing.Point(893, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 433);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // formatting_label
            // 
            this.formatting_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formatting_label.AutoSize = true;
            this.formatting_label.Cursor = System.Windows.Forms.Cursors.Help;
            this.formatting_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatting_label.Location = new System.Drawing.Point(728, 68);
            this.formatting_label.Name = "formatting_label";
            this.formatting_label.Size = new System.Drawing.Size(96, 16);
            this.formatting_label.TabIndex = 40;
            this.formatting_label.Text = "?Format Guide";
            this.formatting_label.Click += new System.EventHandler(this.formatting_label_Click_1);
            // 
            // txt2speech_btn
            // 
            this.txt2speech_btn.BackColor = System.Drawing.Color.Transparent;
            this.txt2speech_btn.BackgroundImage = global::LanguageProject.Properties.Resources.txt_speech;
            this.txt2speech_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txt2speech_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt2speech_btn.Location = new System.Drawing.Point(25, 289);
            this.txt2speech_btn.Name = "txt2speech_btn";
            this.txt2speech_btn.Size = new System.Drawing.Size(100, 50);
            this.txt2speech_btn.TabIndex = 38;
            this.txt2speech_btn.TabStop = false;
            this.txt2speech_btn.Click += new System.EventHandler(this.txt2speech_btn_Click);
            // 
            // NewDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1194, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Menu = this.mainMenu1;
            this.Name = "NewDisease";
            this.Text = "NewDisease";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDisease_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2speech_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox condition_txtbox;
        private System.Windows.Forms.RichTextBox summary_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView symbol_listview;
        private System.Windows.Forms.Button tag_search_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem exit_2_consult_screen_menu_item;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem about_menu_item;
        private System.Windows.Forms.MenuItem exit_program_fully_menu_item;
        private System.Windows.Forms.MenuItem add_images_to_db_menu_item;
        private System.Windows.Forms.ComboBox tag_search_autobox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label images_found_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label summary_word_count_lebel;
        private System.Windows.Forms.Label hard_word_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox txt2speech_btn;
        private System.Windows.Forms.Label uploading_label;
        private System.Windows.Forms.Label formatting_label;
    }
}
namespace LanguageProject
{
    partial class InsertNewImageDB
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
            this.insert_btn = new System.Windows.Forms.Button();
            this.get_image_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list_of_tags_checked_listbox = new System.Windows.Forms.CheckedListBox();
            this.additional_tags_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tag_search_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(425, 470);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(122, 55);
            this.insert_btn.TabIndex = 0;
            this.insert_btn.Text = "Insert ";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // get_image_btn
            // 
            this.get_image_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_image_btn.Location = new System.Drawing.Point(59, 116);
            this.get_image_btn.Name = "get_image_btn";
            this.get_image_btn.Size = new System.Drawing.Size(130, 73);
            this.get_image_btn.TabIndex = 1;
            this.get_image_btn.Text = "GET IMAGE";
            this.get_image_btn.UseVisualStyleBackColor = true;
            this.get_image_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(250, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // list_of_tags_checked_listbox
            // 
            this.list_of_tags_checked_listbox.FormattingEnabled = true;
            this.list_of_tags_checked_listbox.Location = new System.Drawing.Point(725, 36);
            this.list_of_tags_checked_listbox.Name = "list_of_tags_checked_listbox";
            this.list_of_tags_checked_listbox.Size = new System.Drawing.Size(171, 274);
            this.list_of_tags_checked_listbox.TabIndex = 4;
            // 
            // additional_tags_txtbox
            // 
            this.additional_tags_txtbox.Location = new System.Drawing.Point(725, 362);
            this.additional_tags_txtbox.Name = "additional_tags_txtbox";
            this.additional_tags_txtbox.Size = new System.Drawing.Size(283, 20);
            this.additional_tags_txtbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Additional Tags: (seperate by comma )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Availaible Tags:";
            // 
            // tag_search_txtbox
            // 
            this.tag_search_txtbox.Location = new System.Drawing.Point(22, 50);
            this.tag_search_txtbox.Name = "tag_search_txtbox";
            this.tag_search_txtbox.Size = new System.Drawing.Size(143, 20);
            this.tag_search_txtbox.TabIndex = 8;
            this.tag_search_txtbox.TextChanged += new System.EventHandler(this.tag_search_txtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Tags (case sensitive):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tag_search_txtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(917, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // InsertNewImageDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1129, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.additional_tags_txtbox);
            this.Controls.Add(this.list_of_tags_checked_listbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.get_image_btn);
            this.Controls.Add(this.insert_btn);
            this.Name = "InsertNewImageDB";
            this.Text = "InsertNewImageDB";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button get_image_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox list_of_tags_checked_listbox;
        private System.Windows.Forms.TextBox additional_tags_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tag_search_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
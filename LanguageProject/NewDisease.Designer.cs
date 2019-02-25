﻿namespace LanguageProject
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
            this.tag_search_txtbox = new System.Windows.Forms.TextBox();
            this.tag_search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.about_menu_item = new System.Windows.Forms.MenuItem();
            this.tutorial_menu_item = new System.Windows.Forms.MenuItem();
            this.exit_2_consult_screen_menu_item = new System.Windows.Forms.MenuItem();
            this.exit_program_fully_menu_item = new System.Windows.Forms.MenuItem();
            this.add_images_to_db_menu_item = new System.Windows.Forms.MenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condition: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Simple Summary: ";
            // 
            // condition_txtbox
            // 
            this.condition_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.condition_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition_txtbox.Location = new System.Drawing.Point(242, 89);
            this.condition_txtbox.Name = "condition_txtbox";
            this.condition_txtbox.Size = new System.Drawing.Size(382, 35);
            this.condition_txtbox.TabIndex = 3;
            this.condition_txtbox.MouseHover += new System.EventHandler(this.condition_txtbox_MouseHover);
            // 
            // summary_txtbox
            // 
            this.summary_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.summary_txtbox.EnableAutoDragDrop = true;
            this.summary_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_txtbox.Location = new System.Drawing.Point(242, 155);
            this.summary_txtbox.Name = "summary_txtbox";
            this.summary_txtbox.Size = new System.Drawing.Size(588, 256);
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
            this.label2.Location = new System.Drawing.Point(321, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add New Simplified Condition Summary";
            // 
            // submit_btn
            // 
            this.submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(3, 30);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(173, 39);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(182, 30);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(174, 39);
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
            this.progressBar1.Location = new System.Drawing.Point(242, 432);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(588, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progress bar represents the amount of text deemed appropriate ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancel_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.submit_btn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(409, 475);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 100);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // symbol_listview
            // 
            this.symbol_listview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbol_listview.Location = new System.Drawing.Point(848, 169);
            this.symbol_listview.Name = "symbol_listview";
            this.symbol_listview.Size = new System.Drawing.Size(250, 256);
            this.symbol_listview.TabIndex = 14;
            this.symbol_listview.UseCompatibleStateImageBehavior = false;
            this.symbol_listview.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.symbol_listview_ItemDrag);
            // 
            // tag_search_txtbox
            // 
            this.tag_search_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tag_search_txtbox.Location = new System.Drawing.Point(848, 144);
            this.tag_search_txtbox.Name = "tag_search_txtbox";
            this.tag_search_txtbox.Size = new System.Drawing.Size(181, 20);
            this.tag_search_txtbox.TabIndex = 15;
            this.tag_search_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tag_search_txtbox_KeyDown);
            this.tag_search_txtbox.MouseHover += new System.EventHandler(this.tag_search_txtbox_MouseHover);
            // 
            // tag_search_btn
            // 
            this.tag_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tag_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_search_btn.Location = new System.Drawing.Point(1036, 143);
            this.tag_search_btn.Name = "tag_search_btn";
            this.tag_search_btn.Size = new System.Drawing.Size(62, 20);
            this.tag_search_btn.TabIndex = 16;
            this.tag_search_btn.Text = "Search";
            this.tag_search_btn.UseVisualStyleBackColor = true;
            this.tag_search_btn.Click += new System.EventHandler(this.tag_search_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(845, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search Images By Keyword:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.about_menu_item,
            this.tutorial_menu_item});
            this.menuItem1.Text = "Help";
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
            // about_menu_item
            // 
            this.about_menu_item.Index = 0;
            this.about_menu_item.Text = "About";
            this.about_menu_item.Click += new System.EventHandler(this.about_menu_item_Click);
            // 
            // tutorial_menu_item
            // 
            this.tutorial_menu_item.Index = 1;
            this.tutorial_menu_item.Text = "Tutorial";
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
            // NewDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1123, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tag_search_btn);
            this.Controls.Add(this.tag_search_txtbox);
            this.Controls.Add(this.symbol_listview);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.summary_txtbox);
            this.Controls.Add(this.condition_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "NewDisease";
            this.Text = "NewDisease";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDisease_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tag_search_txtbox;
        private System.Windows.Forms.Button tag_search_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem exit_2_consult_screen_menu_item;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem about_menu_item;
        private System.Windows.Forms.MenuItem tutorial_menu_item;
        private System.Windows.Forms.MenuItem exit_program_fully_menu_item;
        private System.Windows.Forms.MenuItem add_images_to_db_menu_item;
    }
}
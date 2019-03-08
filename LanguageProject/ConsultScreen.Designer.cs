namespace LanguageProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultScreen));
            this.confirm_search_result_btn = new System.Windows.Forms.Button();
            this.print_summary_btn = new System.Windows.Forms.Button();
            this.display_summary_fullscreen_btn = new System.Windows.Forms.Button();
            this.add_new_summary_btn = new System.Windows.Forms.Button();
            this.consult_search_btn = new System.Windows.Forms.Button();
            this.searchbox_consult_screen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.symbol_listview = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.tag_search_btn = new System.Windows.Forms.Button();
            this.tag_search_txtbox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.new_summary_menu_item = new System.Windows.Forms.MenuItem();
            this.add_external_image_menu_item = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.about_menu_item = new System.Windows.Forms.MenuItem();
            this.Tutorial_menu_item = new System.Windows.Forms.MenuItem();
            this.consult_screen_search_result_textbox = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ready_4_print_listview = new System.Windows.Forms.ListView();
            this.condition_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.print_selected_btn = new System.Windows.Forms.Button();
            this.print_selected_document = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.print_waiting_zone_rtb = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.view_selected_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.tag_search_groupbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_btn_flash_timer = new System.Windows.Forms.Timer(this.components);
            this.tag_search_groupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirm_search_result_btn
            // 
            this.confirm_search_result_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirm_search_result_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.confirm_search_result_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm_search_result_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_search_result_btn.Location = new System.Drawing.Point(388, 101);
            this.confirm_search_result_btn.Name = "confirm_search_result_btn";
            this.confirm_search_result_btn.Size = new System.Drawing.Size(126, 40);
            this.confirm_search_result_btn.TabIndex = 1;
            this.confirm_search_result_btn.Text = "Summary Ready";
            this.confirm_search_result_btn.UseVisualStyleBackColor = false;
            this.confirm_search_result_btn.Click += new System.EventHandler(this.confirm_search_result_btn_Click);
            this.confirm_search_result_btn.MouseHover += new System.EventHandler(this.confirm_search_result_btn_MouseHover);
            // 
            // print_summary_btn
            // 
            this.print_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_summary_btn.BackColor = System.Drawing.SystemColors.Control;
            this.print_summary_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.print_summary_btn.FlatAppearance.BorderSize = 2;
            this.print_summary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.print_summary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.print_summary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_summary_btn.Location = new System.Drawing.Point(264, 8);
            this.print_summary_btn.Name = "print_summary_btn";
            this.print_summary_btn.Size = new System.Drawing.Size(112, 31);
            this.print_summary_btn.TabIndex = 8;
            this.print_summary_btn.Text = "Print";
            this.print_summary_btn.UseVisualStyleBackColor = false;
            this.print_summary_btn.Click += new System.EventHandler(this.print_summary_btn_Click);
            // 
            // display_summary_fullscreen_btn
            // 
            this.display_summary_fullscreen_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.display_summary_fullscreen_btn.BackColor = System.Drawing.SystemColors.Control;
            this.display_summary_fullscreen_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.display_summary_fullscreen_btn.FlatAppearance.BorderSize = 2;
            this.display_summary_fullscreen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.display_summary_fullscreen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.display_summary_fullscreen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_summary_fullscreen_btn.Location = new System.Drawing.Point(270, 118);
            this.display_summary_fullscreen_btn.Name = "display_summary_fullscreen_btn";
            this.display_summary_fullscreen_btn.Size = new System.Drawing.Size(112, 23);
            this.display_summary_fullscreen_btn.TabIndex = 9;
            this.display_summary_fullscreen_btn.Text = "View Fullscreen";
            this.display_summary_fullscreen_btn.UseVisualStyleBackColor = false;
            this.display_summary_fullscreen_btn.Click += new System.EventHandler(this.display_summary_fullscreen_btn_Click);
            // 
            // add_new_summary_btn
            // 
            this.add_new_summary_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_new_summary_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_new_summary_btn.FlatAppearance.BorderSize = 2;
            this.add_new_summary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_new_summary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.add_new_summary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_summary_btn.Location = new System.Drawing.Point(228, 12);
            this.add_new_summary_btn.Name = "add_new_summary_btn";
            this.add_new_summary_btn.Size = new System.Drawing.Size(94, 28);
            this.add_new_summary_btn.TabIndex = 6;
            this.add_new_summary_btn.Text = "Create New";
            this.add_new_summary_btn.UseVisualStyleBackColor = false;
            this.add_new_summary_btn.Click += new System.EventHandler(this.add_new_summary_btn_Click);
            // 
            // consult_search_btn
            // 
            this.consult_search_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consult_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_search_btn.Location = new System.Drawing.Point(228, 46);
            this.consult_search_btn.Name = "consult_search_btn";
            this.consult_search_btn.Size = new System.Drawing.Size(62, 28);
            this.consult_search_btn.TabIndex = 11;
            this.consult_search_btn.Text = "Search";
            this.consult_search_btn.UseVisualStyleBackColor = true;
            this.consult_search_btn.Click += new System.EventHandler(this.consult_search_btn_Click);
            // 
            // searchbox_consult_screen
            // 
            this.searchbox_consult_screen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchbox_consult_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox_consult_screen.FormattingEnabled = true;
            this.searchbox_consult_screen.Location = new System.Drawing.Point(20, 46);
            this.searchbox_consult_screen.Name = "searchbox_consult_screen";
            this.searchbox_consult_screen.Size = new System.Drawing.Size(202, 28);
            this.searchbox_consult_screen.TabIndex = 10;
            this.searchbox_consult_screen.MouseHover += new System.EventHandler(this.searchbox_consult_screen_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Condition Search:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(83, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 14;
            // 
            // symbol_listview
            // 
            this.symbol_listview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.symbol_listview.Location = new System.Drawing.Point(8, 60);
            this.symbol_listview.Name = "symbol_listview";
            this.symbol_listview.Size = new System.Drawing.Size(250, 426);
            this.symbol_listview.TabIndex = 19;
            this.symbol_listview.UseCompatibleStateImageBehavior = false;
            this.symbol_listview.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.symbol_listview_ItemDrag);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search Images By Keyword:";
            // 
            // tag_search_btn
            // 
            this.tag_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_search_btn.Location = new System.Drawing.Point(195, 32);
            this.tag_search_btn.Name = "tag_search_btn";
            this.tag_search_btn.Size = new System.Drawing.Size(57, 22);
            this.tag_search_btn.TabIndex = 21;
            this.tag_search_btn.Text = "Search";
            this.tag_search_btn.UseVisualStyleBackColor = true;
            this.tag_search_btn.Click += new System.EventHandler(this.tag_search_btn_Click);
            // 
            // tag_search_txtbox
            // 
            this.tag_search_txtbox.Location = new System.Drawing.Point(8, 34);
            this.tag_search_txtbox.Name = "tag_search_txtbox";
            this.tag_search_txtbox.Size = new System.Drawing.Size(181, 20);
            this.tag_search_txtbox.TabIndex = 20;
            this.tag_search_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tag_search_txtbox_KeyDown);
            this.tag_search_txtbox.MouseHover += new System.EventHandler(this.tag_search_txtbox_MouseHover);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.new_summary_menu_item,
            this.add_external_image_menu_item});
            this.menuItem1.Text = "Options";
            // 
            // new_summary_menu_item
            // 
            this.new_summary_menu_item.Index = 0;
            this.new_summary_menu_item.Text = "Create New Summary";
            this.new_summary_menu_item.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // add_external_image_menu_item
            // 
            this.add_external_image_menu_item.Index = 1;
            this.add_external_image_menu_item.Text = "Add External Images (Admin)";
            this.add_external_image_menu_item.Click += new System.EventHandler(this.add_external_image_menu_item_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.about_menu_item,
            this.Tutorial_menu_item});
            this.menuItem2.Text = "Help";
            // 
            // about_menu_item
            // 
            this.about_menu_item.Index = 0;
            this.about_menu_item.Text = "About";
            this.about_menu_item.Click += new System.EventHandler(this.about_menu_item_Click);
            // 
            // Tutorial_menu_item
            // 
            this.Tutorial_menu_item.Index = 1;
            this.Tutorial_menu_item.Text = "Tutorial";
            // 
            // consult_screen_search_result_textbox
            // 
            this.consult_screen_search_result_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consult_screen_search_result_textbox.EnableAutoDragDrop = true;
            this.consult_screen_search_result_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_screen_search_result_textbox.Location = new System.Drawing.Point(3, 16);
            this.consult_screen_search_result_textbox.Name = "consult_screen_search_result_textbox";
            this.consult_screen_search_result_textbox.ReadOnly = true;
            this.consult_screen_search_result_textbox.Size = new System.Drawing.Size(781, 539);
            this.consult_screen_search_result_textbox.TabIndex = 0;
            this.consult_screen_search_result_textbox.Text = "";
            this.consult_screen_search_result_textbox.TextChanged += new System.EventHandler(this.consult_screen_search_result_textbox_TextChanged);
            this.consult_screen_search_result_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consult_screen_search_result_textbox_KeyPress);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // ready_4_print_listview
            // 
            this.ready_4_print_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ready_4_print_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.condition_column,
            this.status_column});
            this.ready_4_print_listview.Location = new System.Drawing.Point(119, 13);
            this.ready_4_print_listview.MultiSelect = false;
            this.ready_4_print_listview.Name = "ready_4_print_listview";
            this.ready_4_print_listview.Size = new System.Drawing.Size(309, 104);
            this.ready_4_print_listview.TabIndex = 24;
            this.ready_4_print_listview.UseCompatibleStateImageBehavior = false;
            this.ready_4_print_listview.View = System.Windows.Forms.View.Details;
            // 
            // condition_column
            // 
            this.condition_column.Text = "Condition";
            this.condition_column.Width = 186;
            // 
            // status_column
            // 
            this.status_column.Text = "Status";
            this.status_column.Width = 98;
            // 
            // print_selected_btn
            // 
            this.print_selected_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_selected_btn.Location = new System.Drawing.Point(6, 31);
            this.print_selected_btn.Name = "print_selected_btn";
            this.print_selected_btn.Size = new System.Drawing.Size(85, 23);
            this.print_selected_btn.TabIndex = 25;
            this.print_selected_btn.Text = "Print Selected";
            this.print_selected_btn.UseVisualStyleBackColor = true;
            this.print_selected_btn.Click += new System.EventHandler(this.print_selected_btn_Click);
            // 
            // print_selected_document
            // 
            this.print_selected_document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_selected_document_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.print_selected_document;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // print_waiting_zone_rtb
            // 
            this.print_waiting_zone_rtb.Location = new System.Drawing.Point(404, -12);
            this.print_waiting_zone_rtb.Name = "print_waiting_zone_rtb";
            this.print_waiting_zone_rtb.Size = new System.Drawing.Size(100, 96);
            this.print_waiting_zone_rtb.TabIndex = 26;
            this.print_waiting_zone_rtb.Text = "";
            this.print_waiting_zone_rtb.Visible = false;
            // 
            // view_selected_btn
            // 
            this.view_selected_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_selected_btn.Location = new System.Drawing.Point(6, 60);
            this.view_selected_btn.Name = "view_selected_btn";
            this.view_selected_btn.Size = new System.Drawing.Size(85, 23);
            this.view_selected_btn.TabIndex = 27;
            this.view_selected_btn.Text = "View Selected";
            this.view_selected_btn.UseVisualStyleBackColor = true;
            this.view_selected_btn.Click += new System.EventHandler(this.view_selected_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.IndianRed;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(816, 170);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(111, 31);
            this.edit_btn.TabIndex = 28;
            this.edit_btn.Text = "Edit Inactive";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // tag_search_groupbox
            // 
            this.tag_search_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tag_search_groupbox.Controls.Add(this.print_summary_btn);
            this.tag_search_groupbox.Controls.Add(this.tag_search_btn);
            this.tag_search_groupbox.Controls.Add(this.tag_search_txtbox);
            this.tag_search_groupbox.Controls.Add(this.label5);
            this.tag_search_groupbox.Controls.Add(this.symbol_listview);
            this.tag_search_groupbox.Location = new System.Drawing.Point(816, 207);
            this.tag_search_groupbox.Name = "tag_search_groupbox";
            this.tag_search_groupbox.Size = new System.Drawing.Size(269, 492);
            this.tag_search_groupbox.TabIndex = 29;
            this.tag_search_groupbox.TabStop = false;
            this.tag_search_groupbox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.consult_screen_search_result_textbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 558);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.print_selected_btn);
            this.groupBox1.Controls.Add(this.view_selected_btn);
            this.groupBox1.Controls.Add(this.ready_4_print_listview);
            this.groupBox1.Location = new System.Drawing.Point(651, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 123);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finished Summaries";
            // 
            // edit_btn_flash_timer
            // 
            this.edit_btn_flash_timer.Enabled = true;
            this.edit_btn_flash_timer.Interval = 150;
            // 
            // ConsultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1114, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tag_search_groupbox);
            this.Controls.Add(this.display_summary_fullscreen_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.add_new_summary_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.print_waiting_zone_rtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consult_search_btn);
            this.Controls.Add(this.confirm_search_result_btn);
            this.Controls.Add(this.searchbox_consult_screen);
            this.MaximumSize = new System.Drawing.Size(1280, 1080);
            this.Menu = this.mainMenu1;
            this.Name = "ConsultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultScreen";
            this.Load += new System.EventHandler(this.ConsultScreen_Load);
            this.ResizeBegin += new System.EventHandler(this.ConsultScreen_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.ConsultScreen_ResizeEnd);
            this.tag_search_groupbox.ResumeLayout(false);
            this.tag_search_groupbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirm_search_result_btn;
        private System.Windows.Forms.Button print_summary_btn;
        private System.Windows.Forms.Button display_summary_fullscreen_btn;
        private System.Windows.Forms.Button add_new_summary_btn;
        private System.Windows.Forms.Button consult_search_btn;
        private System.Windows.Forms.ComboBox searchbox_consult_screen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView symbol_listview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tag_search_btn;
        private System.Windows.Forms.TextBox tag_search_txtbox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem new_summary_menu_item;
        private System.Windows.Forms.MenuItem add_external_image_menu_item;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem about_menu_item;
        private System.Windows.Forms.MenuItem Tutorial_menu_item;
        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl consult_screen_search_result_textbox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ListView ready_4_print_listview;
        private System.Windows.Forms.ColumnHeader condition_column;
        private System.Windows.Forms.ColumnHeader status_column;
        private System.Windows.Forms.Button print_selected_btn;
        private System.Drawing.Printing.PrintDocument print_selected_document;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl print_waiting_zone_rtb;
        private System.Windows.Forms.Button view_selected_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.GroupBox tag_search_groupbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer edit_btn_flash_timer;
    }
}
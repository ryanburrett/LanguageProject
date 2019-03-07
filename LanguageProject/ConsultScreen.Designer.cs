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
            this.summary_preview_txtbox = new System.Windows.Forms.RichTextBox();
            this.add_new_summary_btn = new System.Windows.Forms.Button();
            this.consult_search_btn = new System.Windows.Forms.Button();
            this.searchbox_consult_screen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirm_search_result_btn
            // 
            this.confirm_search_result_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirm_search_result_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.confirm_search_result_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm_search_result_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_search_result_btn.Location = new System.Drawing.Point(751, 61);
            this.confirm_search_result_btn.Name = "confirm_search_result_btn";
            this.confirm_search_result_btn.Size = new System.Drawing.Size(126, 40);
            this.confirm_search_result_btn.TabIndex = 1;
            this.confirm_search_result_btn.Text = "Confirm";
            this.confirm_search_result_btn.UseVisualStyleBackColor = false;
            this.confirm_search_result_btn.Click += new System.EventHandler(this.confirm_search_result_btn_Click);
            this.confirm_search_result_btn.MouseHover += new System.EventHandler(this.confirm_search_result_btn_MouseHover);
            // 
            // print_summary_btn
            // 
            this.print_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_summary_btn.BackColor = System.Drawing.Color.White;
            this.print_summary_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.print_summary_btn.FlatAppearance.BorderSize = 2;
            this.print_summary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.print_summary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.print_summary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_summary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_summary_btn.Location = new System.Drawing.Point(8, 74);
            this.print_summary_btn.Name = "print_summary_btn";
            this.print_summary_btn.Size = new System.Drawing.Size(112, 31);
            this.print_summary_btn.TabIndex = 8;
            this.print_summary_btn.Text = "Print";
            this.print_summary_btn.UseVisualStyleBackColor = false;
            this.print_summary_btn.Click += new System.EventHandler(this.print_summary_btn_Click);
            // 
            // display_summary_fullscreen_btn
            // 
            this.display_summary_fullscreen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.display_summary_fullscreen_btn.BackColor = System.Drawing.Color.White;
            this.display_summary_fullscreen_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.display_summary_fullscreen_btn.FlatAppearance.BorderSize = 2;
            this.display_summary_fullscreen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.display_summary_fullscreen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.display_summary_fullscreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_summary_fullscreen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_summary_fullscreen_btn.Location = new System.Drawing.Point(8, 111);
            this.display_summary_fullscreen_btn.Name = "display_summary_fullscreen_btn";
            this.display_summary_fullscreen_btn.Size = new System.Drawing.Size(112, 43);
            this.display_summary_fullscreen_btn.TabIndex = 9;
            this.display_summary_fullscreen_btn.Text = "Full Screen Summary";
            this.display_summary_fullscreen_btn.UseVisualStyleBackColor = false;
            this.display_summary_fullscreen_btn.Click += new System.EventHandler(this.display_summary_fullscreen_btn_Click);
            // 
            // summary_preview_txtbox
            // 
            this.summary_preview_txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summary_preview_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_preview_txtbox.Location = new System.Drawing.Point(3, 20);
            this.summary_preview_txtbox.Name = "summary_preview_txtbox";
            this.summary_preview_txtbox.ReadOnly = true;
            this.summary_preview_txtbox.Size = new System.Drawing.Size(173, 458);
            this.summary_preview_txtbox.TabIndex = 13;
            this.summary_preview_txtbox.Text = "";
            // 
            // add_new_summary_btn
            // 
            this.add_new_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_new_summary_btn.BackColor = System.Drawing.Color.White;
            this.add_new_summary_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_new_summary_btn.FlatAppearance.BorderSize = 2;
            this.add_new_summary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_new_summary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.add_new_summary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_summary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_summary_btn.Location = new System.Drawing.Point(8, 19);
            this.add_new_summary_btn.Name = "add_new_summary_btn";
            this.add_new_summary_btn.Size = new System.Drawing.Size(112, 49);
            this.add_new_summary_btn.TabIndex = 6;
            this.add_new_summary_btn.Text = "Create New Summary";
            this.add_new_summary_btn.UseVisualStyleBackColor = false;
            this.add_new_summary_btn.Click += new System.EventHandler(this.add_new_summary_btn_Click);
            // 
            // consult_search_btn
            // 
            this.consult_search_btn.AutoSize = true;
            this.consult_search_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consult_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_search_btn.Location = new System.Drawing.Point(511, 41);
            this.consult_search_btn.Name = "consult_search_btn";
            this.consult_search_btn.Size = new System.Drawing.Size(71, 28);
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
            this.searchbox_consult_screen.Location = new System.Drawing.Point(303, 42);
            this.searchbox_consult_screen.Name = "searchbox_consult_screen";
            this.searchbox_consult_screen.Size = new System.Drawing.Size(202, 28);
            this.searchbox_consult_screen.TabIndex = 10;
            this.searchbox_consult_screen.MouseHover += new System.EventHandler(this.searchbox_consult_screen_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Condition Search:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.consult_screen_search_result_textbox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 481);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.summary_preview_txtbox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 481);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary Preview";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(287, 107);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(998, 481);
            this.splitContainer1.SplitterDistance = 815;
            this.splitContainer1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(83, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 14;
            // 
            // symbol_listview
            // 
            this.symbol_listview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.symbol_listview.Location = new System.Drawing.Point(12, 242);
            this.symbol_listview.Name = "symbol_listview";
            this.symbol_listview.Size = new System.Drawing.Size(250, 346);
            this.symbol_listview.TabIndex = 19;
            this.symbol_listview.UseCompatibleStateImageBehavior = false;
            this.symbol_listview.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.symbol_listview_ItemDrag);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search Images By Keyword:";
            // 
            // tag_search_btn
            // 
            this.tag_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_search_btn.Location = new System.Drawing.Point(205, 204);
            this.tag_search_btn.Name = "tag_search_btn";
            this.tag_search_btn.Size = new System.Drawing.Size(57, 20);
            this.tag_search_btn.TabIndex = 21;
            this.tag_search_btn.Text = "Search";
            this.tag_search_btn.UseVisualStyleBackColor = true;
            this.tag_search_btn.Click += new System.EventHandler(this.tag_search_btn_Click);
            // 
            // tag_search_txtbox
            // 
            this.tag_search_txtbox.Location = new System.Drawing.Point(12, 204);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.display_summary_fullscreen_btn);
            this.groupBox1.Controls.Add(this.print_summary_btn);
            this.groupBox1.Controls.Add(this.add_new_summary_btn);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 166);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // consult_screen_search_result_textbox
            // 
            this.consult_screen_search_result_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consult_screen_search_result_textbox.EnableAutoDragDrop = true;
            this.consult_screen_search_result_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_screen_search_result_textbox.Location = new System.Drawing.Point(3, 20);
            this.consult_screen_search_result_textbox.Name = "consult_screen_search_result_textbox";
            this.consult_screen_search_result_textbox.Size = new System.Drawing.Size(809, 458);
            this.consult_screen_search_result_textbox.TabIndex = 0;
            this.consult_screen_search_result_textbox.Text = "";
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
            this.ready_4_print_listview.Location = new System.Drawing.Point(990, 4);
            this.ready_4_print_listview.MultiSelect = false;
            this.ready_4_print_listview.Name = "ready_4_print_listview";
            this.ready_4_print_listview.Size = new System.Drawing.Size(274, 97);
            this.ready_4_print_listview.TabIndex = 24;
            this.ready_4_print_listview.UseCompatibleStateImageBehavior = false;
            this.ready_4_print_listview.View = System.Windows.Forms.View.Details;
            // 
            // condition_column
            // 
            this.condition_column.Text = "Condition";
            this.condition_column.Width = 170;
            // 
            // status_column
            // 
            this.status_column.Text = "Status";
            this.status_column.Width = 98;
            // 
            // print_selected_btn
            // 
            this.print_selected_btn.Location = new System.Drawing.Point(899, 12);
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
            this.print_waiting_zone_rtb.Location = new System.Drawing.Point(611, 12);
            this.print_waiting_zone_rtb.Name = "print_waiting_zone_rtb";
            this.print_waiting_zone_rtb.Size = new System.Drawing.Size(100, 96);
            this.print_waiting_zone_rtb.TabIndex = 26;
            this.print_waiting_zone_rtb.Text = "";
            this.print_waiting_zone_rtb.Visible = false;
            // 
            // view_selected_btn
            // 
            this.view_selected_btn.Location = new System.Drawing.Point(899, 45);
            this.view_selected_btn.Name = "view_selected_btn";
            this.view_selected_btn.Size = new System.Drawing.Size(85, 23);
            this.view_selected_btn.TabIndex = 27;
            this.view_selected_btn.Text = "View Selected";
            this.view_selected_btn.UseVisualStyleBackColor = true;
            this.view_selected_btn.Click += new System.EventHandler(this.view_selected_btn_Click);
            // 
            // ConsultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1297, 628);
            this.Controls.Add(this.view_selected_btn);
            this.Controls.Add(this.print_waiting_zone_rtb);
            this.Controls.Add(this.print_selected_btn);
            this.Controls.Add(this.ready_4_print_listview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tag_search_txtbox);
            this.Controls.Add(this.tag_search_btn);
            this.Controls.Add(this.symbol_listview);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consult_search_btn);
            this.Controls.Add(this.confirm_search_result_btn);
            this.Controls.Add(this.searchbox_consult_screen);
            this.Menu = this.mainMenu1;
            this.Name = "ConsultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultScreen";
            this.ResizeBegin += new System.EventHandler(this.ConsultScreen_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.ConsultScreen_ResizeEnd);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirm_search_result_btn;
        private System.Windows.Forms.Button print_summary_btn;
        private System.Windows.Forms.Button display_summary_fullscreen_btn;
        private System.Windows.Forms.RichTextBox summary_preview_txtbox;
        private System.Windows.Forms.Button add_new_summary_btn;
        private System.Windows.Forms.Button consult_search_btn;
        private System.Windows.Forms.ComboBox searchbox_consult_screen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}
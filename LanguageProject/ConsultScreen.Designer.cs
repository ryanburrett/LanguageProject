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
            this.confirm_search_result_btn = new System.Windows.Forms.Button();
            this.print_summary_btn = new System.Windows.Forms.Button();
            this.display_summary_fullscreen_btn = new System.Windows.Forms.Button();
            this.summary_preview_txtbox = new System.Windows.Forms.RichTextBox();
            this.add_new_summary_btn = new System.Windows.Forms.Button();
            this.consult_screen_search_result_textbox = new System.Windows.Forms.RichTextBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirm_search_result_btn
            // 
            this.confirm_search_result_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirm_search_result_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.confirm_search_result_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm_search_result_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_search_result_btn.Location = new System.Drawing.Point(749, 115);
            this.confirm_search_result_btn.Name = "confirm_search_result_btn";
            this.confirm_search_result_btn.Size = new System.Drawing.Size(126, 40);
            this.confirm_search_result_btn.TabIndex = 1;
            this.confirm_search_result_btn.Text = "Confirm";
            this.confirm_search_result_btn.UseVisualStyleBackColor = false;
            this.confirm_search_result_btn.Click += new System.EventHandler(this.confirm_search_result_btn_Click);
            // 
            // print_summary_btn
            // 
            this.print_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_summary_btn.Location = new System.Drawing.Point(1131, 81);
            this.print_summary_btn.Name = "print_summary_btn";
            this.print_summary_btn.Size = new System.Drawing.Size(75, 23);
            this.print_summary_btn.TabIndex = 8;
            this.print_summary_btn.Text = "Print";
            this.print_summary_btn.UseVisualStyleBackColor = true;
            this.print_summary_btn.Click += new System.EventHandler(this.print_summary_btn_Click);
            // 
            // display_summary_fullscreen_btn
            // 
            this.display_summary_fullscreen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.display_summary_fullscreen_btn.Location = new System.Drawing.Point(1223, 65);
            this.display_summary_fullscreen_btn.Name = "display_summary_fullscreen_btn";
            this.display_summary_fullscreen_btn.Size = new System.Drawing.Size(75, 37);
            this.display_summary_fullscreen_btn.TabIndex = 9;
            this.display_summary_fullscreen_btn.Text = "Full Screen Summary";
            this.display_summary_fullscreen_btn.UseVisualStyleBackColor = true;
            this.display_summary_fullscreen_btn.Click += new System.EventHandler(this.display_summary_fullscreen_btn_Click);
            // 
            // summary_preview_txtbox
            // 
            this.summary_preview_txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summary_preview_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_preview_txtbox.Location = new System.Drawing.Point(3, 20);
            this.summary_preview_txtbox.Name = "summary_preview_txtbox";
            this.summary_preview_txtbox.ReadOnly = true;
            this.summary_preview_txtbox.Size = new System.Drawing.Size(462, 404);
            this.summary_preview_txtbox.TabIndex = 13;
            this.summary_preview_txtbox.Text = "";
            // 
            // add_new_summary_btn
            // 
            this.add_new_summary_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_new_summary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_summary_btn.Location = new System.Drawing.Point(1120, 12);
            this.add_new_summary_btn.Name = "add_new_summary_btn";
            this.add_new_summary_btn.Size = new System.Drawing.Size(112, 49);
            this.add_new_summary_btn.TabIndex = 6;
            this.add_new_summary_btn.Text = "Create New Summary";
            this.add_new_summary_btn.UseVisualStyleBackColor = true;
            this.add_new_summary_btn.Click += new System.EventHandler(this.add_new_summary_btn_Click);
            // 
            // consult_screen_search_result_textbox
            // 
            this.consult_screen_search_result_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consult_screen_search_result_textbox.EnableAutoDragDrop = true;
            this.consult_screen_search_result_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_screen_search_result_textbox.Location = new System.Drawing.Point(3, 20);
            this.consult_screen_search_result_textbox.Name = "consult_screen_search_result_textbox";
            this.consult_screen_search_result_textbox.Size = new System.Drawing.Size(520, 404);
            this.consult_screen_search_result_textbox.TabIndex = 12;
            this.consult_screen_search_result_textbox.Text = "";
            this.consult_screen_search_result_textbox.SizeChanged += new System.EventHandler(this.consult_screen_search_result_textbox_SizeChanged);
            // 
            // consult_search_btn
            // 
            this.consult_search_btn.AutoSize = true;
            this.consult_search_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consult_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_search_btn.Location = new System.Drawing.Point(384, 73);
            this.consult_search_btn.Name = "consult_search_btn";
            this.consult_search_btn.Size = new System.Drawing.Size(65, 28);
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
            this.searchbox_consult_screen.Location = new System.Drawing.Point(158, 73);
            this.searchbox_consult_screen.Name = "searchbox_consult_screen";
            this.searchbox_consult_screen.Size = new System.Drawing.Size(202, 28);
            this.searchbox_consult_screen.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.consult_screen_search_result_textbox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 427);
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
            this.groupBox3.Size = new System.Drawing.Size(468, 427);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary Preview";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(287, 161);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(998, 427);
            this.splitContainer1.SplitterDistance = 526;
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
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search Images By Tag:";
            // 
            // tag_search_btn
            // 
            this.tag_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_search_btn.Location = new System.Drawing.Point(188, 203);
            this.tag_search_btn.Name = "tag_search_btn";
            this.tag_search_btn.Size = new System.Drawing.Size(74, 20);
            this.tag_search_btn.TabIndex = 21;
            this.tag_search_btn.Text = "Search";
            this.tag_search_btn.UseVisualStyleBackColor = true;
            this.tag_search_btn.Click += new System.EventHandler(this.tag_search_btn_Click);
            // 
            // tag_search_txtbox
            // 
            this.tag_search_txtbox.Location = new System.Drawing.Point(12, 204);
            this.tag_search_txtbox.Name = "tag_search_txtbox";
            this.tag_search_txtbox.Size = new System.Drawing.Size(151, 20);
            this.tag_search_txtbox.TabIndex = 20;
            this.tag_search_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tag_search_txtbox_KeyDown);
            // 
            // ConsultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1297, 628);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tag_search_txtbox);
            this.Controls.Add(this.tag_search_btn);
            this.Controls.Add(this.symbol_listview);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_new_summary_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consult_search_btn);
            this.Controls.Add(this.display_summary_fullscreen_btn);
            this.Controls.Add(this.confirm_search_result_btn);
            this.Controls.Add(this.searchbox_consult_screen);
            this.Controls.Add(this.print_summary_btn);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirm_search_result_btn;
        private System.Windows.Forms.Button print_summary_btn;
        private System.Windows.Forms.Button display_summary_fullscreen_btn;
        private System.Windows.Forms.RichTextBox summary_preview_txtbox;
        private System.Windows.Forms.Button add_new_summary_btn;
        private System.Windows.Forms.RichTextBox consult_screen_search_result_textbox;
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
    }
}
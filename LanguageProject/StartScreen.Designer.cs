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
            this.start_screen_search_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start_screen_btn
            // 
            this.start_screen_btn.Location = new System.Drawing.Point(401, 345);
            this.start_screen_btn.Name = "start_screen_btn";
            this.start_screen_btn.Size = new System.Drawing.Size(109, 41);
            this.start_screen_btn.TabIndex = 0;
            this.start_screen_btn.Text = "Confirm";
            this.start_screen_btn.UseVisualStyleBackColor = true;
            this.start_screen_btn.Click += new System.EventHandler(this.start_screen_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language Simplification";
            // 
            // start_screen_search_box
            // 
            this.start_screen_search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_screen_search_box.Location = new System.Drawing.Point(315, 205);
            this.start_screen_search_box.Name = "start_screen_search_box";
            this.start_screen_search_box.Size = new System.Drawing.Size(288, 31);
            this.start_screen_search_box.TabIndex = 2;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 478);
            this.Controls.Add(this.start_screen_search_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_screen_btn);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_screen_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox start_screen_search_box;
    }
}
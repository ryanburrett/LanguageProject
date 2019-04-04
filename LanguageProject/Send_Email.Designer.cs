namespace LanguageProject
{
    partial class Send_Email
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
            this.user_input_email_txtbox = new System.Windows.Forms.TextBox();
            this.email_send_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.invalid_email_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_input_email_txtbox
            // 
            this.user_input_email_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_input_email_txtbox.Location = new System.Drawing.Point(104, 93);
            this.user_input_email_txtbox.Name = "user_input_email_txtbox";
            this.user_input_email_txtbox.Size = new System.Drawing.Size(241, 24);
            this.user_input_email_txtbox.TabIndex = 0;
            // 
            // email_send_button
            // 
            this.email_send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_send_button.Location = new System.Drawing.Point(179, 181);
            this.email_send_button.Name = "email_send_button";
            this.email_send_button.Size = new System.Drawing.Size(80, 33);
            this.email_send_button.TabIndex = 1;
            this.email_send_button.Text = "Send";
            this.email_send_button.UseVisualStyleBackColor = true;
            this.email_send_button.Click += new System.EventHandler(this.email_send_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Email to send to:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(308, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Include Text-2-Speech File";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // invalid_email_label
            // 
            this.invalid_email_label.AutoSize = true;
            this.invalid_email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid_email_label.ForeColor = System.Drawing.Color.Red;
            this.invalid_email_label.Location = new System.Drawing.Point(102, 131);
            this.invalid_email_label.Name = "invalid_email_label";
            this.invalid_email_label.Size = new System.Drawing.Size(157, 15);
            this.invalid_email_label.TabIndex = 4;
            this.invalid_email_label.Text = "Invalid Email, Try Again";
            this.invalid_email_label.Visible = false;
            // 
            // Send_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(473, 259);
            this.Controls.Add(this.invalid_email_label);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_send_button);
            this.Controls.Add(this.user_input_email_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Send_Email";
            this.Text = "Send_Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_input_email_txtbox;
        private System.Windows.Forms.Button email_send_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label invalid_email_label;
    }
}
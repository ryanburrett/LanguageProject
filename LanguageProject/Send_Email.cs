using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageProject
{
    public partial class Send_Email : Form
    {

        string email;
        

        public Send_Email()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.DialogResult = DialogResult.None;
            
            
        }

        private void email_send_button_Click(object sender, EventArgs e)
        {
            
            //check for valid stuff
            validate_email();
            
            
        }

        public void validate_email()
        {
            //setting false at start of method, assuming valid entry of email until otherwise detected 
            invalid_email_label.Visible = false;


            email = user_input_email_txtbox.Text;

            //check for valid email format
             if (email == "" || !email.Contains("@"))
              {
                  invalid_email_label.Visible = true;
               
            }
              else
              {
                if (email.Contains(".com") || email.Contains(".co.uk") || email.Contains(".ac.uk"))
                {
                    if (email.Length>7)
                    this.DialogResult = DialogResult.OK;
                    else
                    {
                        invalid_email_label.Visible = true;
                    }
                }
                else
                {
                    invalid_email_label.Visible = true;
                }
                
              }
           
             

        }

        public string get_email()
        {
            

          //  email_send_button.DialogResult = DialogResult.OK;
            return email;
        }

        
    }
}

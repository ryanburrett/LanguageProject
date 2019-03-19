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
            email_send_button.DialogResult = DialogResult.OK;
            
        }

        private void email_send_button_Click(object sender, EventArgs e)
        {
            
            
        }

        public string get_email()
        {
            
            //check for valid email in future
            if (email != "") //check for empty input
            {

                email = user_input_email_txtbox.Text;
            }
            return email;
        }

        
    }
}

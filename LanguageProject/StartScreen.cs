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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void start_screen_btn_Click(object sender, EventArgs e)
        {
            //need to pass diagnosis search into consultation constructor at some point

            ConsultScreen newCounsult = new ConsultScreen();
            newCounsult.Show();
            this.Hide();

        }
    }
}

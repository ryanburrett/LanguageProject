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
    public partial class FullScreenPreview : Form
    {
        public FullScreenPreview(string a)
        {
            InitializeComponent();
            this.CenterToScreen();


            fullscreen_txtbox.Text = a;
            string b = fullscreen_txtbox.Rtf;
            Console.WriteLine(b);
        }
    }
}

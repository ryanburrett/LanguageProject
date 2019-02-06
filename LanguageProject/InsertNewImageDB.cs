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
    public partial class InsertNewImageDB : Form
    {
        // element to pull all availible tags, ability to add new tags 
        // button to select image 
        // resize image in app if possible, non essential for first pass

        //insert button 

        public InsertNewImageDB()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //send to db 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open file browser

            //opening file browser 
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "All files |*.*";
            //change filter to images eventually 
            

            if (files.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = files.FileName;
                    Bitmap b = new Bitmap(filename);
                    pictureBox1.Image = b;
                    // look into making size uniform in app
                }
                catch (Exception f)
                {

                    
                    MessageBox.Show("Error Message: " + f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

            
        }
    }
}

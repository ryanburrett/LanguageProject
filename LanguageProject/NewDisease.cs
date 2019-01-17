using MySql.Data.MySqlClient;
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
    public partial class NewDisease : Form
    {
        public NewDisease()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //check for valid input in text boxes

            if (condition_txtbox.Text == "" || summary_txtbox.Text == "")
            {
                // invalid

                MessageBox.Show("Invalid Data, Please make sure you have data in each section.", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //execute commands
                write_to_db();
            }

        }

        private void write_to_db()
        {
            string condition = condition_txtbox.Text;
            string summary = summary_txtbox.Text;

            //INSERT INTO `language_simplification`.`diseases` (`Name`, `Simple_Summary`) VALUES ('dd', 'dd');

            string write_query = "INSERT INTO `diseases` (`Name`, `Simple_Summary`) VALUES ('"+ condition + "','"+ summary +"')";
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand(write_query, conn);

            conn.Open();
            command.ExecuteNonQuery();

            conn.Close();
            
            
        }

        private void summary_txtbox_TextChanged(object sender, EventArgs e)
        {
            //get text length
           int text_length = summary_txtbox.TextLength;
            //setting progress bar length propertional to text length
            if (text_length <= 100)
            {
                progressBar1.Value = text_length;
            }
            else
            {
                //indicate too much text but perhaps dont hard lock them from submit
                
            }

           
           


        }

        private void NewDisease_FormClosing(object sender, FormClosingEventArgs e)
        {
            clean_up();
        }

        private void clean_up()
        {
            //use startscreen function to get list of diseases. never showing form here
            StartScreen newStart = new StartScreen();
            List<string> list_of_diseases = new List<string>();

            list_of_diseases = newStart.return_List();

            newStart.Close();

            ConsultScreen consult = new ConsultScreen(list_of_diseases);
            consult.Show();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void open_file_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "All files |*.*";
            var originalData = Clipboard.GetDataObject();

            if (files.ShowDialog() == DialogResult.OK)
            {
                string filename = files.FileName;
                Bitmap b = new Bitmap(filename);
                Clipboard.SetDataObject(b);
                summary_txtbox.Paste();

            }

            Clipboard.SetDataObject(originalData);

            
        }
    }
}

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
using System.Windows;
using System.IO;

namespace LanguageProject
{
    public partial class ConsultScreen : Form
    {
        List<string> list_of_diseases = new List<string>();
        int current_form_height;
        int current_textbox_height;


        public ConsultScreen(string disease, List<string> diseases)
        {
            InitializeComponent();
            this.CenterToScreen();
            list_of_diseases = diseases;
            searchbox_consult_screen.Text = disease;
            assign_autocomplete();

            //pull summary data about disease
            get_disease_summary(disease);
        }

        public ConsultScreen(List<string> diseases)
        {
            InitializeComponent();
            this.CenterToScreen();
            list_of_diseases = diseases;
            assign_autocomplete();
        }

        public void get_disease_summary(string disease)
        {

            // select Simple_Summary from language_simplification.diseases where Name = "Diabetes";

            string get_disease_summary = "select * from diseases where Name = '" + disease + "';" ;
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand(get_disease_summary, conn);

            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list_of_diseases.Add(reader.GetString("Name"));
                //string result = reader.GetString("Simple_Summary");



                byte[] bytes = (byte[])reader["Simple_Summary"];

                Console.WriteLine("byte length ::   " + bytes.Length);

                MemoryStream ms = new MemoryStream(bytes);
                ms.Position = 0;
                Console.WriteLine("STReam memory ::::::  " + ms.Length);

                string content;
                using (StreamReader sr = new StreamReader(ms, Encoding.Default, false))
                {


                    content = sr.ReadToEnd();

                   
                }
                Console.WriteLine("Reading into content for selected condition");
                consult_screen_search_result_textbox.Rtf = content;
            }
        }

        void assign_autocomplete()
        {
            // setting up auto complete using combobox and list of diseases
            var autoObject = new AutoCompleteStringCollection();
            autoObject.AddRange(list_of_diseases.ToArray());
            searchbox_consult_screen.AutoCompleteSource = AutoCompleteSource.CustomSource;

            searchbox_consult_screen.AutoCompleteCustomSource = autoObject;
        }

        private void consult_search_btn_Click(object sender, EventArgs e)
        {
            string search = searchbox_consult_screen.Text;
            if (list_of_diseases.Contains(search))
            {
                get_disease_summary(search);
            }
            else
            {
                Console.WriteLine("invalid");
                MessageBox.Show("Not Valid Search, Please match search with an autocomplete suggestion.", "Not valid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void confirm_search_result_btn_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Confirm you would like to send this summary to patient summary?", "Confirm Simplified Summary", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                //look for existing text within the summary screen
                // if existing text is there then combine rtf files and format 
                // else just append text to rtb
                //
                // note that any reference to text is within rtb and includes images, otherwise this would be alot easier...


                if (string.IsNullOrWhiteSpace(summary_preview_txtbox.Text))
                {
                    // empty summary preview... add text.
                    string disease_text = consult_screen_search_result_textbox.Rtf;
                    summary_preview_txtbox.Rtf = disease_text;
                }
                else
                {
                    //combine rtf files, to allow multiple submissions to summary box
                    Console.WriteLine("running, combine rtf files...");
                    string current_summary_text = summary_preview_txtbox.Rtf;
                    string new_text = consult_screen_search_result_textbox.Rtf;

                    string combined_rtfs = combine_rtf(current_summary_text, new_text);
                    summary_preview_txtbox.Rtf = combined_rtfs;
                }
                
               

                

            }

            


        }

        private string combine_rtf(string current_summary_text, string new_text)
        {
            // combine rtf files 
            string summary_text = current_summary_text;
            string text_to_add = new_text;

            

            try
            {


                int firstPar = text_to_add.IndexOf(@"\par");
                int lastPar = text_to_add.LastIndexOf(@"\par") - 1;

                int end_of_summary = summary_text.LastIndexOf("}");

                string formatted_new_text = text_to_add.Substring(firstPar, lastPar - firstPar + 1);

                formatted_new_text = @"\par\par" + formatted_new_text;

                summary_text = summary_text.Insert(end_of_summary, formatted_new_text);

                return summary_text;





            }
            catch (Exception e)
            {
                throw e;
            }




            
        }

        private void add_new_summary_btn_Click(object sender, EventArgs e)
        {
            NewDisease newDisease = new NewDisease();
            newDisease.Show();
            this.Close();
        }

        private void display_summary_fullscreen_btn_Click(object sender, EventArgs e)
        {
            //launch new form with only patient summary data and display full screen
            string summary = summary_preview_txtbox.Rtf;
            FullScreenPreview full = new FullScreenPreview(summary);
            full.Show();
        }

        private void ConsultScreen_ResizeBegin(object sender, EventArgs e)
        {
            // current_form_height = this.Size.Height;
            // current_textbox_height = consult_screen_search_result_textbox.Height;

            
        }

        private void ConsultScreen_ResizeEnd(object sender, EventArgs e)
        {
           // int change = this.Size.Height - current_form_height;

           // consult_screen_search_result_textbox.Height += change;

          //  Console.WriteLine("form height change : " + change);
        }

        private void consult_screen_search_result_textbox_SizeChanged(object sender, EventArgs e)
        {
           // current_form_height = this.Size.Height;

            
        }

        private void print_summary_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

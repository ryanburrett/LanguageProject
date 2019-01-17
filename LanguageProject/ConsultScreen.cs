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
    public partial class ConsultScreen : Form
    {
        List<string> list_of_diseases = new List<string>();
        public ConsultScreen(string disease, List<string> diseases)
        {
            InitializeComponent();
            list_of_diseases = diseases;
            searchbox_consult_screen.Text = disease;
            assign_autocomplete();

            //pull summary data about disease
            get_disease_summary(disease);
        }

        public ConsultScreen(List<string> diseases)
        {
            InitializeComponent();
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
               // list_of_diseases.Add(reader.GetString("Name"));
                string result = reader.GetString("Simple_Summary");
                consult_screen_search_result_textbox.Text = result;
                

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
                string disease_text = consult_screen_search_result_textbox.Text;
               
                //eventually needs formatting
                summary_preview_txtbox.AppendText(disease_text + "\r\n\r\n");


            }

            


        }

        private void add_new_summary_btn_Click(object sender, EventArgs e)
        {
            NewDisease newDisease = new NewDisease();
            newDisease.Show();
            this.Close();
        }
    }
}

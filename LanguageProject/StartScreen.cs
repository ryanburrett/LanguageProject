using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LanguageProject
{
    public partial class StartScreen : Form
    {
        List<string> list_of_diseases = new List<string>();
        string[] aaab = new string[10];

        public StartScreen()
        {
            InitializeComponent();
            //connection to database and pull all disease titles and allow them to be easily searched with smart autofilling 
            get_list_of_diseases();

            assign_autocomplete();


        }

        private void get_list_of_diseases()
        {
            string get_diseases_query = "Select Name from diseases";
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand(get_diseases_query, conn);
  
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list_of_diseases.Add(reader.GetString("Name"));

               
                
            }
            //checking for valid input
            list_of_diseases.ForEach(Console.WriteLine);
            
        }

        void assign_autocomplete()
        {
            var autoObject = new AutoCompleteStringCollection();
            autoObject.AddRange(list_of_diseases.ToArray());
            start_screen_searchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            start_screen_searchbox.AutoCompleteCustomSource = autoObject;
            
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

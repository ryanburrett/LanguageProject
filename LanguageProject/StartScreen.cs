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
            this.CenterToScreen();
            //connection to database and pull all disease titles and allow them to be easily searched with smart autofilling 
            List_of_Diseases list = new List_of_Diseases();
            list_of_diseases = list.return_list();
            

            assign_autocomplete();


        }

       

       

        void assign_autocomplete()
        {
            // setting up auto complete using combobox and list of diseases
            AutoCompleteStringCollection autoComplete_Object = new AutoCompleteStringCollection();
            autoComplete_Object.AddRange(list_of_diseases.ToArray());        
            start_screen_searchbox.AutoCompleteCustomSource = autoComplete_Object;
            
        }
        private void start_screen_btn_Click(object sender, EventArgs e)
        {

            //TO-DO add validation on click that the text is valid disease
            //DONE

            //TO-DO add scrubing of whitespace... maybe 

            //get current text in search box
            string search = start_screen_searchbox.Text;
            bool found = false;
            foreach (string disease in list_of_diseases) {
                if
                ( string.Equals(search, disease, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
                

            }
            
            if (found == false)
            {
                
                
                 Console.WriteLine("invalid");
                 MessageBox.Show("Not Valid Search, Please match search with an autocomplete suggestion.", "Not valid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
 
            
                ConsultScreen newCounsult = new ConsultScreen(search, list_of_diseases);
                newCounsult.Show();
                this.Hide();
            
           
            

        }

        private void start_scrn_insert_image_btn_Click(object sender, EventArgs e)
        {
            InsertNewImageDB newImage = new InsertNewImageDB();
            newImage.Show();
        }

        private void new_condition_btn_Click(object sender, EventArgs e)
        {
            NewDisease d = new NewDisease();

            d.Show();
            this.Hide();
        }
    }
}

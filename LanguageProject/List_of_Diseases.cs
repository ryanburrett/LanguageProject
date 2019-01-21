using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class List_of_Diseases
    {
        List<string> list_of_diseases = new List<string>();

        public List_of_Diseases()
        {
            get_list_of_diseases();

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
            //removes any whitespace for empty index in db
            list_of_diseases = list_of_diseases.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            list_of_diseases.ForEach(Console.WriteLine);
            conn.Close();
        }

        public List<string> return_list()
        {
            return list_of_diseases;
        }
    }


}

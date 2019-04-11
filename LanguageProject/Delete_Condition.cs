using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class Delete_Condition
    {
        //will hold logic to delete a condition from database 

        public Delete_Condition(string condition_name)
        {
            int id_to_delete = get_condition_id(condition_name);
            delete_from_db(id_to_delete);
        }

        private int get_condition_id(string condition_name)
        {

            int id = -1;

            //SELECT id FROM language_simplification.diseases WHERE `Name` = 'Obesity';

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT id FROM diseases WHERE `Name` = @name;";
            command.Parameters.AddWithValue("name", condition_name);

            command.Connection = conn;

            conn.Open();



            command.Prepare();


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32("id");
                    Console.WriteLine("Returned ID: " +id+ " for condition "+condition_name);
                }

            }
            conn.Close();

                return id;
        }

        public void delete_from_db(int id)
        {
            //will hold database commands 

            //DELETE FROM `language_simplification`.`diseases` WHERE (`Name` = '123')


            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM diseases WHERE `id` = @id;";
            command.Parameters.AddWithValue("id", id);

            command.Connection = conn;

            conn.Open();
            command.Prepare();
            command.ExecuteNonQuery();
            Console.WriteLine("Deleted Condition");
            conn.Close();
        }
    }
}

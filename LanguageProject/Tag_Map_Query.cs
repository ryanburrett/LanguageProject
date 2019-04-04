using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class Tag_Map_Query
    {


        public List<int> get_all_tags_for_one_image(int image_id)
        {

            List<int> tag_id_list = new List<int>();

            ConnectDB db = new ConnectDB();
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();

            //SELECT * FROM language_simplification.image_tag_map WHERE image_id = '25'


            command.CommandText = "SELECT * FROM image_tag_map WHERE image_id = '"+ image_id + "';";
            command.Connection = conn;

            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int tag_id = reader.GetInt32("tag_id");
                    tag_id_list.Add(tag_id);
                    
                    Console.WriteLine("FOUND MATCHING TAG FOR IMAGE WITH ID: " + tag_id);
                }



            }

            conn.Close();
            return tag_id_list;
        }

    }
}

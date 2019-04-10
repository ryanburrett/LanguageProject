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

        public void delete_tag_mapping_for_image(int image_id, List<uint> tags)
        {
            //  ConnectDB newConn = new ConnectDB();
            //  MySqlConnection conn = newConn.connect_db();
            
            foreach (uint tag in tags)
            {
                //DELETE FROM `language_simplification`.`image_tag_map` WHERE (`image_id` = '65') and (`tag_id` = '88');
                ConnectDB newConn = new ConnectDB();
                MySqlConnection conn = newConn.connect_db();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "DELETE FROM image_tag_map WHERE `image_id`='"+ image_id + "' AND `tag_id`='"+tag+"';";

                // i could not get this to work with parameters. always returned 0 affected rows even though the parameter values where valid
                // should not matter as there is no user input here and no concern for sql injection 

              //  command.Parameters.AddWithValue("image", a);
             //   command.Parameters.AddWithValue("tag", tag);
                

                
                command.Connection = conn;
               
                conn.Open();
                command.Prepare();
                command.ExecuteNonQuery();
                Console.WriteLine("should have deleted id");
                conn.Close();

            }

           
        }

        public void add_tag_mapping_for_image(int image_id, List<uint> tags)
        {
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();

            foreach (uint tag in tags)
              {

                  
                  MySqlCommand command = new MySqlCommand();
                  command.CommandText = "INSERT INTO image_tag_map (image_id, tag_id) VALUES (@image, @tag)";
                  command.Parameters.AddWithValue("image", image_id);
                  command.Parameters.AddWithValue("tag", tag);

                  Console.WriteLine("tag id: " + tag);
                  command.Connection = conn;

                  conn.Open();
                command.Prepare();
                  command.ExecuteNonQuery();
                  
              }

            conn.Close();
        }

        public List<uint> add_new_tags_to_db(List<string> new_tags)
        {
            List<uint> tag_id_list = new List<uint>();

            foreach (string tag in new_tags)
            {

                ConnectDB newConn = new ConnectDB();
                MySqlConnection conn = newConn.connect_db();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO tags (tag_name) VALUES (@tag)";
                command.Parameters.AddWithValue("tag", tag);

                command.Connection = conn;

                conn.Open();
                command.ExecuteNonQuery();

                MySqlCommand getIdCommand = new MySqlCommand();
                getIdCommand.CommandText = "SELECT last_insert_id()";
                getIdCommand.Connection = conn;

                using (MySqlDataReader reader = getIdCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tag_id_list.Add(reader.GetUInt32("last_insert_id()"));
                    }
                }


                conn.Close();
               
            }

            return tag_id_list;
        }


    }
}

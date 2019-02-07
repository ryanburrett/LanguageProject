using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class Add_Image_To_DB
    {
        List<string> database_tag_list = new List<string>();
        List<uint> tag_id_list = new List<uint>();
        int image_id;

        public Add_Image_To_DB(Bitmap b, List<string> tag_list)
        {
            // get list of tags, compare tags with tag list. add any tags that dont match to db. get all tag ids for passed in tags
            //add image to db 
            //get image id 
            //set image_tag map for image id and tag ids
            Get_Current_Tags current_tags = new Get_Current_Tags();
            database_tag_list = current_tags.get_tags();
            Console.WriteLine("database tag list: ");
            database_tag_list.ForEach(Console.WriteLine);
            compare_tags(tag_list);
            add_image(b);
            update_image_tag_mapping();
            
            

        }

        private void update_image_tag_mapping()
        {

            foreach (uint tag in tag_id_list)
            {
                
                ConnectDB newConn = new ConnectDB();
                MySqlConnection conn = newConn.connect_db();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO image_tag_map (image_id, tag_id) VALUES (@image, @tag)";
                command.Parameters.AddWithValue("image", image_id);
                command.Parameters.AddWithValue("tag", tag);

                Console.WriteLine("tag id: "+ tag);
                command.Connection = conn;

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void add_image(Bitmap b)
        {
            //add image to database
            //get id 
            byte[] image_byte_array;

            using (MemoryStream ms = new MemoryStream())
            {
                //converting image to byte array, ready to send to db
                b.Save(ms, ImageFormat.Bmp);
                image_byte_array = ms.ToArray();
                Console.WriteLine("byte length : " + image_byte_array.Length);
            }

        

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO images (image) VALUES (@image)";
            command.Parameters.AddWithValue("image", image_byte_array);

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
                    image_id = reader.GetInt32("last_insert_id()");
                    Console.WriteLine("IMAGE ID : " + image_id);
                }
            }

            conn.Close();

        }

        private void compare_tags(List<string> tag_list)
        {
            //compare database tags with the current tags passed in
            List<string> confirmed_tag_matches = new List<string>();
            List<string> new_tags = new List<string>();

            foreach (string a in tag_list)
            {
                if (database_tag_list.Any(s => s.Contains(a)))
                {
                    confirmed_tag_matches.Add(a);
                }
                else
                {
                    new_tags.Add(a);
                }
            }

            Console.WriteLine("FOUND THE FOLLOWING MATCHES WITH DATABASE TAGS:");
            confirmed_tag_matches.ForEach(Console.WriteLine);
            Console.WriteLine("NEW TAGS : ");
            new_tags.ForEach(Console.WriteLine);

            //send any new tags to database 
            add_new_tags_to_db(new_tags);

            //search database with matches to pull ids
            pull_id_for_existing_tags(confirmed_tag_matches);





        }

        private void pull_id_for_existing_tags(List<string> confirmed_tag_matches)
        {
            foreach (string tag in confirmed_tag_matches)
            {
                ConnectDB newConn = new ConnectDB();
                MySqlConnection conn = newConn.connect_db();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "SELECT * FROM tags WHERE tag_name = '"+ tag +"'";
                //command.Parameters.AddWithValue("tag", tag);

                command.Connection = conn;

                
                conn.Open();
                command.ExecuteNonQuery();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tag_id_list.Add(reader.GetUInt32("id"));
                    }
                }

                conn.Close();
            }
            Console.WriteLine("tag id list :");
            tag_id_list.ForEach(Console.WriteLine);
        }

        private void add_new_tags_to_db(List<string> new_tags)
        {

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

            
        }
    }
}

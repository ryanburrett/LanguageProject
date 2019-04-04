using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageProject
{
    class Get_Images_From_DB
    {

        public Get_Images_From_DB()
        {

        }

        public List<Image> get_all_images()
        {
            List<Image> image_list = new List<Image>();

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM images";
            command.Connection = conn;

            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(1)) { 
                        byte[] bytes = (byte[])reader["image"];
                    
                    
                        
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            try
                            {
                                Image img = Image.FromStream(ms);
                                Bitmap b = (Bitmap)img;
                                image_list.Add(img);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("ERROR WHILE TRYING TO CREATE IMAGE FROM MEMORY STREAM", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }

                        }
                    }

                    
                }

               
            }

            conn.Close();




            Console.WriteLine("image list length: " + image_list.Count);


            return image_list;

            
        }

        public List<Image> get_by_tag(string tag)
        {
            List<Image> image_list = new List<Image>();

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT i.image from images i inner join image_tag_map tm on i.id = tm.image_id inner join tags t on tm.tag_id = t.id where t.tag_name = '"+tag+"';";

            command.Connection = conn;
            

            
            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    try
                    {
                        byte[] bytes = (byte[])reader["image"];



                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            try
                            {
                                Image img = Image.FromStream(ms);
                                Bitmap b = (Bitmap)img;
                                image_list.Add(img);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("ERROR WHILE TRYING TO CREATE IMAGE FROM MEMORY STREAM", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR WHILE TRYING TO CAST TO BYTE ARRAY FROM SQL READER", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                    }




                }


            }

            conn.Close();




            Console.WriteLine("image list length: " + image_list.Count);


            return image_list;
        }

        public Dictionary<int, Image> get_ids_and_images()
        {
            
            Dictionary<int, Image> image_dictionary = new Dictionary<int, Image>();


            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM images";
            command.Connection = conn;

            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(1))
                    {
                        int id = reader.GetInt32("id");
                        byte[] bytes = (byte[])reader["image"];

                        

                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            try
                            {
                                Image img = Image.FromStream(ms);
                                //adding image and id to dictionary 
                                image_dictionary.Add(id, img);
                                Console.WriteLine("### Added iamge with id: "+id+" to dictionary###");
                                
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("ERROR WHILE TRYING TO CREATE IMAGE FROM MEMORY STREAM", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }

                        }
                    }


                }


            }

            conn.Close();

            return image_dictionary;

        }

        public Dictionary<int, Image> get_id_and_image_by_tag(string tag)
        {
           
            Dictionary<int, Image> image_dictionary = new Dictionary<int, Image>();

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            //query returns images along with respective image id
            command.CommandText = "SELECT i.id,i.image from images i inner join image_tag_map tm on i.id = tm.image_id inner join tags t on tm.tag_id = t.id where t.tag_name = '" + tag + "';";

            command.Connection = conn;



            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    try
                    {
                        int id = reader.GetInt32("id");
                        byte[] bytes = (byte[])reader["image"];



                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            try
                            {
                                Image img = Image.FromStream(ms);
                                image_dictionary.Add(id, img);
                                Console.WriteLine("ADDED IMAGE WITH TAG: "+tag+" and ID: "+id+" to dictionary");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("ERROR WHILE TRYING TO CREATE IMAGE FROM MEMORY STREAM", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR WHILE TRYING TO CAST TO BYTE ARRAY FROM SQL READER", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

            }

            conn.Close();

            return image_dictionary;

        }
        

    }
}

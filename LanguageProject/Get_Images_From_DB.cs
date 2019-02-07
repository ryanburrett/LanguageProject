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

                        
                    }
                        
                    


                }


            }

            conn.Close();




            Console.WriteLine("image list length: " + image_list.Count);


            return image_list;
        }

    }
}

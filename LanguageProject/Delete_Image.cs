using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class Delete_Image
    {

        public void delete_image(int id_to_delete)
        {

            //DELETE FROM `language_simplification`.`images` WHERE (`id` = '67');

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM images WHERE `id` = @id;";
            command.Parameters.AddWithValue("id", id_to_delete);

            command.Connection = conn;

            conn.Open();
            command.Prepare();
            command.ExecuteNonQuery();
            Console.WriteLine("Deleted Image");
            conn.Close();
        }

    }
}

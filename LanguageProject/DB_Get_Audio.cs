using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class DB_Get_Audio
    {

        


        public byte[] get_audio_from_db(string disease)
        {
            byte[] sound_stream=null;
            try
            {


                string get_audio = "select * from diseases where Name = '" + disease + "';";
                ConnectDB newConn = new ConnectDB();
                MySqlConnection conn = newConn.connect_db();
                MySqlCommand command = new MySqlCommand(get_audio, conn);

                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {




                    sound_stream = (byte[])reader["audio_description"];

                    Console.WriteLine("sound byte lengeth = " + sound_stream.Length);



                }
            }
            catch
            {
                Console.WriteLine("ERROR READING SOUND FROM DATABASE");
            }
           
            return sound_stream;
        }
    }
}

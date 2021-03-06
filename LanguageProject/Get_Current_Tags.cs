﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageProject
{
    class Get_Current_Tags
    {
        List<string> tag_list = new List<string>();

        public Get_Current_Tags()
        {
            
        }

        public List<string> get_tags()
        {
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM tags";
            command.Connection = conn;
            
            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                   tag_list.Add(reader.GetString("tag_name"));
                }
                
                // tag_list = tag_list.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                tag_list.ForEach(Console.WriteLine);
            }

            conn.Close();


            //remove any duplicate tags 
            List<string> tag_list_no_dupes = tag_list.Distinct().ToList<string>();



            return tag_list_no_dupes;
        }

        public Dictionary<int, string> get_ids_and_tags()
        {

            Dictionary<int, string> tag_dictionary = new Dictionary<int, string>();


            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM tags";
            command.Connection = conn;

            conn.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string tag = reader.GetString("tag_name");
                    tag_dictionary.Add(id, tag);
                    Console.WriteLine("ADDED TAG: "+tag+" WHICH HAS ID: "+ id);
                }

                
                
            }

            conn.Close();


            return tag_dictionary;

            // in future it will be worth sanatizing tags for duplicates. although this could be user validated on creation on new tags and therefore this check 
            // perhaps will not be needed 

            

           
        }
    }
}

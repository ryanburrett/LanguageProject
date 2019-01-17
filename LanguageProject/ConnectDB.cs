using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LanguageProject
{
    public class ConnectDB
    {
        //add connection to database

        public string myConnString = "server = localhost; user id = root; persistsecurityinfo=False;database=language_simplification;Password=1234";

        

        public MySqlConnection connect_db()
        {

            MySqlConnection myConn = new MySqlConnection(myConnString);
            return myConn;
        }

    }

  
}

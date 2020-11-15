using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace final.connections
{
    class Connection
    {

        private static MySqlConnection instance;

        private Connection(){
        
        }

        public static MySqlConnection GetInstance()
        {
            if(instance == null)
            {
                instance = new MySqlConnection("Server=localhost; Database=finallab2; Uid=root; Pwd=");
                instance.Open();
            }
            return instance;
        }


    }
}

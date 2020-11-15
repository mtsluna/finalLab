using final.connections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.daos
{
    class AutorDAO
    {
        public DataTable GetAll()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, CONCAT(nombre, ' ', apellido) as nombre FROM autor", Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}

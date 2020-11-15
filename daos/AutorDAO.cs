using final.connections;
using final.models;
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
        public DataTable GetAllWC()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, CONCAT(nombre, ' ', apellido) as nombre FROM autor", Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAll()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM autor", Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAllByText(String text)
        {
            MySqlCommand mySqlCommand;
            if (text.Trim().Equals(""))
            {
                mySqlCommand = new MySqlCommand("SELECT * FROM autor", Connection.GetInstance());
            }
            else
            {
                mySqlCommand = new MySqlCommand("SELECT * FROM autor WHERE CONCAT(nombre, ' ', apellido) LIKE '%" + text + "%'", Connection.GetInstance());
            }
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Delete(int index)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM autor WHERE id = " + index, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

        public void instertAutor(Autor autor)
        {
            String query = $"INSERT INTO autor(nombre, apellido) VALUES ('{autor.nombre}','{autor.apellido}')";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
        public void updateAutor(Autor autor)
        {
            String query = $"UPDATE autor SET nombre = '{autor.nombre}', apellido = '{autor.apellido}' WHERE id = {autor.id}";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
    }
}

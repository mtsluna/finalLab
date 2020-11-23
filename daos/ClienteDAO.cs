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
    class ClienteDAO
    {

        public DataTable GetAllWC()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, CONCAT(nombre, ' ', apellido) as nombre FROM clientes", Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAll()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM clientes", Connection.GetInstance());
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
                mySqlCommand = new MySqlCommand("SELECT * FROM clientes", Connection.GetInstance());
            }
            else
            {
                mySqlCommand = new MySqlCommand("SELECT * FROM clientes WHERE CONCAT(nombre, ' ', apellido, ' ', domicilio, ' ', telefono, ' ', fechaNacimiento, ' ', dni) LIKE '%" + text + "%'", Connection.GetInstance());
            }
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Delete(int index)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM clientes WHERE id = " + index, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

        public void instert(Cliente p)
        {
            String query = $"INSERT INTO clientes(nombre, apellido, domicilio, telefono, fechaNacimiento, dni) VALUES ('{p.nombre}','{p.apellido}','{p.domicilio}','{p.telefono}','{p.fechaNacimiento}','{p.dni}')";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
        public void update(Cliente p)
        {
            String query = $"UPDATE clientes SET nombre = '{p.nombre}', apellido = '{p.apellido}', domicilio = '{p.domicilio}', telefono = '{p.telefono}', fechaNacimiento = '{p.fechaNacimiento}', dni = '{p.dni}' WHERE id = {p.id}";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

    }
}

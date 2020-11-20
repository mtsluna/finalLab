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
    class AdministradorDAO
    {
        public DataTable GetAllWC()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, CONCAT(nombre, '', apellido) as nombre FROM administrador", Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAll()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM administrador", Connection.GetInstance());
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
                mySqlCommand = new MySqlCommand("SELECT * FROM administrador", Connection.GetInstance());
            }
            else
            {
                mySqlCommand = new MySqlCommand("SELECT * FROM administrador WHERE CONCAT(nombre, '', apellido) LIKE '%" + text + "%'", Connection.GetInstance());
            }
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Delete(int index)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM administrador WHERE id = " + index, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

        public void insertAdmin(Administrador admin)
        {
            String query = $"INSERT INTO administrador(nombre,apellido,telefono,dni,usuario,contraseña) VALUES ('{admin.nombre}','{admin.apellido}','{admin.telefono}','{admin.dni}','{admin.usuario}','{admin.contraseña}')";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

        public void updateAdmin(Administrador admin)
        {
            String query = $"UPDATE administrador SET nombre = '{admin.nombre}', apellido = '{admin.apellido}', telefono = '{admin.telefono}', dni = '{admin.dni}', usuario = '{admin.usuario}', contraseña = '{admin.contraseña}' WHERE id = {admin.id}";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
    }
}

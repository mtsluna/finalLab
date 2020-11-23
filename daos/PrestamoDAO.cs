using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using final.connections;
using final.models;

namespace final.daos
{
    class PrestamoDAO
    {
        public DataTable GetAll()
        {
            string query = $"SELECT p.id, p.fk_cliente as id_cliente, p.fk_libro as id_libro, p.fk_administrador as id_admin, CONCAT(c.nombre, ' ', c.apellido) as cliente, l.titulo as libro, p.fechaPrestamo, p.fechaDevolucion, CASE p.devuelto WHEN 'N' THEN 'No' ELSE 'Sí' END as devuelto, CONCAT(a.nombre, ' ', a.apellido) as admin FROM prestamos p INNER JOIN clientes c ON(p.fk_cliente = c.id) INNER JOIN libros l ON(p.fk_libro = l.id) INNER JOIN administrador a ON(p.fk_administrador = a.id)";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAllByText(String text)
        {
            string query = string.Empty;
            MySqlCommand mySqlCommand;
            if (text.Trim().Equals(""))
            {
                query = $"SELECT p.id, p.fk_cliente as id_cliente, p.fk_libro as id_libro, p.fk_administrador as id_admin, CONCAT(c.nombre, ' ', c.apellido) as cliente, l.titulo as libro, p.fechaPrestamo, p.fechaDevolucion, CASE p.devuelto WHEN 'N' THEN 'No' ELSE 'Sí' END as devuelto, CONCAT(a.nombre, ' ', a.apellido) as admin FROM prestamos p INNER JOIN clientes c ON(p.fk_cliente = c.id) INNER JOIN libros l ON(p.fk_libro = l.id) INNER JOIN administrador a ON(p.fk_administrador = a.id)";
                mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            }
            else
            {
                string like = "c.dni LIKE '%"+text+"%' OR CONCAT(c.nombre, ' ', c.apellido) LIKE '%"+text+"%' OR CONCAT(a.nombre, ' ', a.apellido) LIKE '%"+text+"%'";
                query = $"SELECT p.id, p.fk_cliente as id_cliente, p.fk_libro as id_libro, p.fk_administrador as id_admin, CONCAT(c.nombre, ' ', c.apellido) as cliente, l.titulo as libro, p.fechaPrestamo, p.fechaDevolucion, CASE p.devuelto WHEN 'N' THEN 'No' ELSE 'Sí' END as devuelto, CONCAT(a.nombre, ' ', a.apellido) as admin FROM prestamos p INNER JOIN clientes c ON(p.fk_cliente = c.id) INNER JOIN libros l ON(p.fk_libro = l.id) INNER JOIN administrador a ON(p.fk_administrador = a.id) WHERE " + like;
                mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            }
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void deleteLoan(int index)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM prestamos WHERE id = " + index, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

        public void instertLoan(Prestamo prestamo)
        {
            String query = $"INSERT INTO prestamos(fk_cliente, fk_libro, fechaPrestamo, fechaDevolucion, devuelto, fk_administrador) VALUES ({prestamo.cliente.id},{prestamo.libro.id},'{prestamo.fechaPrestamo}','{prestamo.fechaDevolucion}','{prestamo.devuelto}', {prestamo.administrador.id})";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
        public void updateLoan(Prestamo prestamo)
        {
            String query = $"UPDATE prestamos SET fk_cliente = '{prestamo.cliente.id}', fk_libro = '{prestamo.libro.id}', fechaDevolucion = '{prestamo.fechaDevolucion}', devuelto = '{prestamo.devuelto}', fk_administrador = {prestamo.administrador.id} WHERE id = {prestamo.id}";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
    }
}

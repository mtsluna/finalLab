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

    class LibroDAO
    {
        public DataTable GetAllWC()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, CONCAT(titulo, ' - ', edicion) as titulo FROM libros", Connection.GetInstance());
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAll()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM libros", Connection.GetInstance());
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
                mySqlCommand = new MySqlCommand("SELECT * FROM libros", Connection.GetInstance());
            }
            else
            {
                mySqlCommand = new MySqlCommand("SELECT * FROM libros INNER JOIN autor as au ON libros.fk_autor = au.id WHERE CONCAT(titulo, ' ', edicion, ' ', lugarPublicacion, ' ', año, ' ', paginas, ' ', isbn, ' ', au.nombre, ' ', au.apellido) LIKE '%" + text + "%'", Connection.GetInstance());
            }            
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Delete(int index)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM libros WHERE id = "+index, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

        public void instertBook(Libro libro)
        {
            String query = $"INSERT INTO libros(titulo, edicion, lugarPublicacion, año, paginas, isbn, fk_autor, descripcion) VALUES ('{libro.titulo}','{libro.edicion}','{libro.lugarPublicacion}','{libro.año}',{libro.paginas},'{libro.isbn}',{libro.autor.id},'{libro.descripcion}')";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }
        public void updateBook(Libro libro)
        {
            String query = $"UPDATE libros SET titulo = '{libro.titulo}', edicion = '{libro.edicion}', lugarPublicacion = '{libro.lugarPublicacion}', año = '{libro.año}', paginas = {libro.paginas}, isbn = '{libro.isbn}', fk_autor = {libro.autor.id}, descripcion = '{libro.descripcion}' WHERE id = {libro.id}";
            MySqlCommand mySqlCommand = new MySqlCommand(query, Connection.GetInstance());
            mySqlCommand.ExecuteNonQuery();
        }

    }

}

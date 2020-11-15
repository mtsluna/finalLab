using final.daos;
using final.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.controllers
{

    class LibroController
    {

        LibroDAO libroDAO = new LibroDAO();

        public DataTable FillAllBooks()
        {
            return libroDAO.GetAll();
        }

        public DataTable FillAllBooksByText(String text)
        {
            return libroDAO.GetAllByText(text);
        }

        public void deleteBook(int index)
        {
            libroDAO.Delete(index);
        }

        public void instertBook(Libro libro)
        {
            libroDAO.instertBook(libro);
        }
        public void updateBook(Libro libro)
        {
            libroDAO.updateBook(libro);
        }

    }
}

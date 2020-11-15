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
    class AutorController
    {
        AutorDAO autorDAO = new AutorDAO();

        public DataTable FillAll(bool concat)
        {
            if (concat)
            {
                return autorDAO.GetAllWC();
            }
            else
            {
                return autorDAO.GetAll();
            }
            
        }

        public void deleteAutor(int index)
        {
            autorDAO.Delete(index);
        }

        public DataTable FillAllAutorByText(String text)
        {
            return autorDAO.GetAllByText(text);
        }

        public void instertAutor(Autor autor)
        {
            autorDAO.instertAutor(autor);
        }
        public void updateAutor(Autor autor)
        {
            autorDAO.updateAutor(autor);
        }

    }
}

using final.daos;
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

        public DataTable FillAll()
        {
            return autorDAO.GetAll();
        }
    }
}

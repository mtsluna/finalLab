using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final.daos;
using final.models;
using System.Data;

namespace final.controllers
{
    class PrestamoController
    {
        PrestamoDAO prestamoDAO = new PrestamoDAO();

        public DataTable FillAllLoans()
        {
            return prestamoDAO.GetAll();
        }

        public void deleteLoan(int index)
        {
            prestamoDAO.deleteLoan(index);
        }

        public void instertLoan(Prestamo prestamo)
        {
            prestamoDAO.instertLoan(prestamo);
        }

        public void updateLoan(Prestamo prestamo)
        {
            prestamoDAO.updateLoan(prestamo);
        }
    }
}

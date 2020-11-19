using final.daos;
using final.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace final.controllers
{
    class AdministradorController
    {
        AdministradorDAO adminDAO = new AdministradorDAO();


        public DataTable FillAll(bool concat)
        {
            if (concat)
            {
                return adminDAO.GetAllWC();
            }
            else
            {
                return adminDAO.GetAll();
            }
        }

        public void deleteAdmin(int index)
        {
            adminDAO.Delete(index);
        }

        public DataTable FillAllAdminByText(String text)
        {
            return adminDAO.GetAllByText(text);
        }

        public void insertAdmin(Administrador admin)
        {
            adminDAO.insertAdmin(admin);
        }

        public void updateAdmin(Administrador admin)
        {
            adminDAO.updateAdmin(admin);
        }

        public bool verifyUsername(String username)
        {
            bool repeated = false;
           DataTable admins = adminDAO.GetAll();
            foreach (Administrador admin in admins.Rows)
            {
                if(admin.usuario == username)
                {
                    repeated = true;
                }
            }
            return repeated;
        }
    }
}

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
    class ClienteController
    {

        ClienteDAO clienteDAO = new ClienteDAO();

        public DataTable FillAll(bool concat)
        {
            if (concat)
            {
                return clienteDAO.GetAllWC();
            }
            else
            {
                return clienteDAO.GetAll();
            }

        }

        public void deleteCliente(int index)
        {
            clienteDAO.Delete(index);
        }

        public DataTable FillAllClienteByText(String text)
        {
            return clienteDAO.GetAllByText(text);
        }

        public void insert(Cliente p)
        {
            clienteDAO.instert(p);
        }
        public void update(Cliente p)
        {
            clienteDAO.update(p);
        }

    }
}

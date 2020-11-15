using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.models
{
    class Prestamo: Base
    {
        public DateTime fechaPrestamos;
        public DateTime fechaDevolucion;
        public bool devuelto;
        public Cliente cliente;
        public Libro libro;

        public Prestamo(Cliente cliente, Libro libro)
        {
            this.cliente = cliente;
            this.libro = libro;
        }

    }
}

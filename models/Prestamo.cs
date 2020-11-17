using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.models
{
    class Prestamo: Base
    {
        public String fechaPrestamo;
        public String fechaDevolucion;
        public char devuelto;
        public Cliente cliente;
        public Libro libro;
        public Administrador administrador;

        public Prestamo(Cliente cliente, Libro libro)
        {
            this.cliente = cliente;
            this.libro = libro;
            //this.administrador = administrador;
        }

    }
}

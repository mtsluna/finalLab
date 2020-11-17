using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.models
{
    class Libro: Base
    {
        public String titulo { get; set; }
        public String descripcion { get; set; }
        public String edicion { get; set; }
        public String lugarPublicacion { get; set; }
        public String año { get; set; }
        public int paginas { get; set; }
        public String isbn { get; set; }
        public Autor autor { get; set; }
        public int id { get; set; }

        public Libro(Autor autor)
        {
            this.autor = autor;
        }


    }
}

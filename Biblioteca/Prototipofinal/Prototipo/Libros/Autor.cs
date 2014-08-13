using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo.Libros
{
    class Autor
    {
        public int Idautor {get; set;}
        public string Nombre_autor { get; set; }
        public string Apellido_autor { get; set; }

        public Autor() { }

        public Autor(int pIdautor, string pNombre_autor, string pApellido_autor)
        {
            this.Idautor = pIdautor;
            this.Nombre_autor = pNombre_autor;
            this.Apellido_autor = pApellido_autor;
        }
    }
}

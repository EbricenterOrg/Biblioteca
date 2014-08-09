using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo
{
    class Persona
    {
       //public int Id { get; set; }
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Direccion { get; set; }
       public string Email { get; set; }
       public string Tipo { get; set; }
       public string Foto { get; set; }

       public Persona() { }

       public Persona(string pNombre, string pApellido, string pDireccion, string pEmail, string pTipo,string pFoto  )

       {
           //this.Id = pId;
           this.Nombre = pNombre;
           this.Apellido = pApellido;
           this.Direccion = pDireccion;
           this.Email = pEmail;
           this.Tipo = pTipo;
           this.Foto = pFoto; 

       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Autor: "Rodrigo Miranda"
 *Fecha: "1/Agosto/2014"
 *Comentario: "Este modulo contendra los atributos y variables declaradas de forma publica."
 */

namespace Prototipo
{
    class Persona
    {
       //public string vNombre { get; set; }
       //public string vApellido { get; set; }

       public int id_per { get; set; }
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Direccion { get; set; }
       public string Email { get; set; }
       //public string Tipo { get; set; }
       public string Foto { get; set; }
       public string id_tipersona { get; set; }


       public Persona() { }

       //public Persona(int pidpersona, string pNombre, string pApellido, string pDireccion, string pEmail, string pTipo, string pFoto, string ptipersona) //Constructor
        public Persona(int pidpersona, string pNombre, string pApellido, string pDireccion, string pEmail,string pFoto, string ptipersona) //Constructor

       {
           //this.vNombre = pNombre;
           //this.vApellido = pApellido;
           
           this.id_per = pidpersona;
           this.Nombre = pNombre;
           this.Apellido = pApellido;
           this.Direccion = pDireccion;
           this.Email = pEmail;
           //this.Tipo = pTipo;
           this.Foto = pFoto;
           this.id_tipersona = ptipersona;
       }
       
    }
}

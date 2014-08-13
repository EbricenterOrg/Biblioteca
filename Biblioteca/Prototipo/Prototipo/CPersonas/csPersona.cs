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
       
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Direccion { get; set; }
       public string Email { get; set; }
       public string Tipo { get; set; }
       public string Foto { get; set; }

       public Persona() { }

       public Persona(string pNombre, string pApellido, string pDireccion, string pEmail, string pTipo,string pFoto) //Constructor

       {
           
           this.Nombre = pNombre;
           this.Apellido = pApellido;
           this.Direccion = pDireccion;
           this.Email = pEmail;
           this.Tipo = pTipo;
           this.Foto = pFoto; 

       }
    }
}

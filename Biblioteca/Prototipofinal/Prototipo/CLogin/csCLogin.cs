using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo
{
    class CLogin
    {

       public int Id_Persona { get; set; }
       public string IdPersona { get; set; }
       public string Usuario { get; set; }
       public string Contra { get; set; }
       
       public CLogin() { }

       public CLogin(int pId_Persona,string pUsuario, string pContra, string pIdPersona) //Constructor

       {
           this.Id_Persona = pId_Persona;
           this.IdPersona = pIdPersona;
           this.Usuario = pUsuario;
           this.Contra = pContra;
       }
    }
}

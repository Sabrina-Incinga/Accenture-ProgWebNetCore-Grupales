using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaClase5.Entidades
{
   public class Alumno : Persona
    {
        public bool Regular { get;  set; }

        public Curso Curso { get; set; }

    }
}

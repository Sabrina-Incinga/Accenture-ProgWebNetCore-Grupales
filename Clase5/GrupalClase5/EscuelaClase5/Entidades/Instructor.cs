using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaClase5.Entidades
{
    public class Instructor : Persona
    {
        public List<Materia> Materias { get; set; }
    }
}

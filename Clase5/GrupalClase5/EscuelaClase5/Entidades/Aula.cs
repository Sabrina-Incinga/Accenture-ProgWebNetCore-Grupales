using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaClase5.Entidades
{
    public class Aula 
    {
        public int Capacidad { get; set; }
        public string Codigo { get; set; }

        public Clase Clase { get; set; }
    }
}

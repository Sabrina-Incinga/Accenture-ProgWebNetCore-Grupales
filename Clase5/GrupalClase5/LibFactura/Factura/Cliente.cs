using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Factura
{
    public class Cliente : Persona
    {
        public int Id { get; set; }
        public List<Factura> Facturas { get; set; }
        public Usuario Usuario { get; set; }

    }
}

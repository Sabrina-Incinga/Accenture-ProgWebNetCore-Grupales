using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Factura
{
    public class Factura
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
    }
}

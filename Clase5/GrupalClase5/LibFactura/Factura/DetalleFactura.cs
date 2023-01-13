using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Factura
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public Factura Factura { get; set; }
        public List<Producto> Productos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Factura
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public DetalleFactura NroDetalleFactura { get; set; }
        public Categoria Categoria { get; set; }
    }
}

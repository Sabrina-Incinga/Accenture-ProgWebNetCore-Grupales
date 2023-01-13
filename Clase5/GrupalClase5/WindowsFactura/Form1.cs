using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFactura.Factura;

namespace WindowsFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Producto producto1 = new Producto() { Id = 1, Nombre = "Carro", Precio = 3000};
            Producto producto2 = new Producto() { Id = 2, Nombre = "Pinza de corte", Precio = 500};
            List<Producto> productos = new List<Producto>() {producto1, producto2};
            Categoria ferreteria = new Categoria() { Id = 1, Nombre = "Ferreteria", Productos = productos};
            producto1.Categoria = ferreteria;
            producto2.Categoria = ferreteria;
            Cliente cliente = new Cliente() { Id = 1, Nombre = "Pedro", Apellido = "Picapiedra", DNI = "259879798" };
            Usuario usuario = new Usuario() { Id = 1, Cliente = cliente};
            Empleado empleado = new Empleado() { Id = 1, Legajo = "25s4df8er", Nombre = "Pable", Apellido = "Marmol", DNI = "232487546"};
            Factura factura = new Factura() {Id = 1, Cliente = cliente, Empleado = empleado};
            empleado.Facturas = new List<Factura> { factura };
            cliente.Facturas = new List<Factura> { factura};
            DetalleFactura detalleFactura = new DetalleFactura() { Id = 1, Productos = productos, Factura = factura };
            factura.Detalles = new List<DetalleFactura> { detalleFactura };

            producto1.NroDetalleFactura = detalleFactura;
            producto2.NroDetalleFactura = detalleFactura;

            txt_producto1.Text = $"Producto 1: {producto1.Nombre}, {producto1.Precio}, id de detalle factura: {producto1.NroDetalleFactura.Id}";
            txt_producto2.Text = $"Producto 2: {producto2.Nombre}, {producto2.Precio}, id de detalle factura: {producto2.NroDetalleFactura.Id}";

        }
    }
}

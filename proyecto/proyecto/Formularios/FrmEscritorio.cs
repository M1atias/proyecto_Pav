using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto.Formularios
{
    public partial class FrmEscritorio : Form
    {
        public FrmEscritorio()
        {
            InitializeComponent();
            Point coordenada = new Point(3, 3);

            TableFacturas.Width = 413;
            TableFacturas.Height = 333;
            TableProveedores.Width = 413;
            TableProveedores.Height = 333;
            TableProductos.Width = 413;
            TableProductos.Height = 333;
            TableClientes.Width = 413;
            TableClientes.Height = 333;

            TableFacturas.Location = coordenada;
            TableProveedores.Location = coordenada;
            TableProductos.Location = coordenada;
            TableClientes.Location = coordenada;

            BtnConsultarClientes.Width = 150;
            BtnConsultarProductos.Width = 150;
            BtnConsultarFacturas.Width = 150;
            BtnConsultarProveedores.Width = 150;
            BtnEliminarCliente.Width = 150;
            BtnEliminarProducto.Width = 150;
            BtnAnularFactura.Width = 150;
            BtnEliminarProveedor.Width = 150;
            BtnModificarCliente.Width = 150;
            BtnModificarProducto.Width = 150;
            BtnModificarFactura.Width = 150;
            BtnModificarProveedor.Width = 150;
            BtnNuevoCliente.Width = 150;
            BtnNuevoProducto.Width = 150;
            BtnNuevaFactura.Width = 180;
            BtnNuevoProveedor.Width = 150;

            BtnConsultarClientes.Height = 150;
            BtnConsultarProductos.Height = 150;
            BtnConsultarFacturas.Height = 150;
            BtnConsultarProveedores.Height = 150;
            BtnEliminarCliente.Height = 150;
            BtnEliminarProducto.Height = 150;
            BtnAnularFactura.Height = 150;
            BtnEliminarProveedor.Height = 150;
            BtnModificarCliente.Height = 150;
            BtnModificarProducto.Height = 150;
            BtnModificarFactura.Height = 150;
            BtnModificarProveedor.Height = 150;
            BtnNuevoCliente.Height = 150;
            BtnNuevoProducto.Height = 150;
            BtnNuevaFactura.Height = 150;
            BtnNuevoProveedor.Height = 150;
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            TableProductos.Visible = false;
            TableClientes.Visible = false;
            TableProveedores.Visible = false;
            TableFacturas.Visible = true;
            

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            TableFacturas.Visible = false;
            TableClientes.Visible = false;
            TableProveedores.Visible = false;
            TableProductos.Visible = true;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            TableFacturas.Visible = false;
            TableProductos.Visible = false;
            TableProveedores.Visible = false;
            TableClientes.Visible = true;
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            TableFacturas.Visible = false;
            TableProductos.Visible = false;
            TableClientes.Visible = false;
            TableProveedores.Visible = true;
            
        }

        private void PanelMenuSecundario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEscritorio_Load(object sender, EventArgs e)
        {

        }
    }
}

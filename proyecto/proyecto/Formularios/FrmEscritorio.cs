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

            BtnConsultarClientes.Width = 250;
            BtnConsultarProductos.Width = 250;
            BtnConsultarFacturas.Width = 250;
            BtnConsultarProveedores.Width = 250;
            BtnEliminarCliente.Width = 250;
            BtnEliminarProducto.Width = 250;
            BtnAnularFactura.Width = 250;
            BtnEliminarProveedor.Width = 250;
            BtnModificarCliente.Width = 250;
            BtnModificarProducto.Width = 250;
            BtnModificarFactura.Width = 250;
            BtnModificarProveedor.Width = 250;
            BtnNuevoCliente.Width = 250;
            BtnNuevoProducto.Width = 250;
            BtnNuevaFactura.Width = 250;
            BtnNuevoProveedor.Width = 250;
            BtnConsultarClientes.Height = 250;
            BtnConsultarProductos.Height = 250;
            BtnConsultarFacturas.Height = 250;
            BtnConsultarProveedores.Height = 250;
            BtnEliminarCliente.Height = 250;
            BtnEliminarProducto.Height = 250;
            BtnAnularFactura.Height = 250;
            BtnEliminarProveedor.Height = 250;
            BtnModificarCliente.Height = 250;
            BtnModificarProducto.Height = 250;
            BtnModificarFactura.Height = 250;
            BtnModificarProveedor.Height = 250;
            BtnNuevoCliente.Height = 250;
            BtnNuevoProducto.Height = 250;
            BtnNuevaFactura.Height = 250;
            BtnNuevoProveedor.Height = 250;
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

        private void MenuStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

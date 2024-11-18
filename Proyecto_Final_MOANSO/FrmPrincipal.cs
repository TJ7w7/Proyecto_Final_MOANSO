using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscarCliente = new FrmBuscarCliente();
            buscarCliente.Show();
        }

        private void registroProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.Show();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscarProducto = new FrmBuscarProducto();
            buscarProducto.Show();
        }
        private void registroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoriaProducto categoria = new FrmCategoriaProducto();
            categoria.Show();
        }
        private void registroSaborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaborProducto sabor = new FrmSaborProducto();   
            sabor.Show();
        }

        private void registroTransportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransportista transportista = new FrmTransportista();
            transportista.Show();
        }

        private void buscarTransportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarTransportista buscarTransportista = new FrmBuscarTransportista();
            buscarTransportista.Show();
        }

        private void registroFormasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFormasDePago formasDePago = new FrmFormasDePago();
            formasDePago.Show();
        }

        private void registroPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroOrdenPedido registroPedido = new FrmRegistroOrdenPedido();
            registroPedido.Show();
        }

        private void buscarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarOrdenPedido buscarPedido = new FrmBuscarOrdenPedido();
            buscarPedido.Show();
        }

        private void registroAsignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignacionTrasportista asignacionTrasportista = new FrmAsignacionTrasportista();
            asignacionTrasportista.Show();
        }

        private void registroVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroVenta registroVenta = new FrmRegistroVenta();
            registroVenta.Show();
        }

    }
}

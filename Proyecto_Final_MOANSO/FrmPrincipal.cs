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
            FrmClienteJuridico c = new FrmClienteJuridico();
            c.Show();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();
            categoria.Show();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSabores sabores = new FrmSabores();
            sabores.Show();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMoneda moneda = new FrmMoneda();
            moneda.Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPais pais = new FrmPais();
            pais.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegion region = new FrmRegion();
            region.Show();
        }

        private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento tipoDocumento = new FrmTipoDocumento();
            tipoDocumento.Show();
        }

        private void clienteJuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteJuridico clienteJuridico = new FrmClienteJuridico();
            clienteJuridico.Show();
        }

        private void clienteNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteNatural clienteNatural = new FrmClienteNatural();
            clienteNatural.Show();
        }
    }
}

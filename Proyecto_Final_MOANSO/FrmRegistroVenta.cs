using CapaEntidad;
using CapaLogica;
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
    public partial class FrmRegistroVenta : Form
    {
        public FrmRegistroVenta()
        {
            InitializeComponent();
            ListarPedidosConfirmados();
            CargarNumero();
        }

        public void ListarPedidosConfirmados()
        {
            dgvPedidosConfirmados.DataSource = LogPedido.Instancia.ListarPedidoConfirmados();
        }

        public void CargarNumero()
        {
            txtNroVenta.Text = LogVenta.Instancia.ContarFilas();
        }
        int id;
        string nroPedido;
        private void dgvPedidosConfirmados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPedidosConfirmados.Rows[e.RowIndex];
            id = int.Parse(filaActual.Cells[0].Value.ToString());
            nroPedido = filaActual.Cells[1].Value.ToString();

            txtNroPedido.Text = nroPedido;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EntVenta venta = new EntVenta();
            venta.NumeroVenta = txtNroVenta.Text;
            venta.OrdenPedidoId = id;
            MessageBox.Show("Error" + id);
            venta.Fecha = DateTime.Parse(dateTimePicker1.Value.ToString());

            LogVenta.Instancia.InsertarVenta(venta);
        }
    }
}

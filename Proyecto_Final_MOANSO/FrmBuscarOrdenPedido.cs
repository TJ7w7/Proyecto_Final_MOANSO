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
    public partial class FrmBuscarOrdenPedido : Form
    {
        public FrmBuscarOrdenPedido()
        {
            InitializeComponent();
            CargarPedidos();
        }
        public void CargarPedidos()
        {
            dgvPedido.DataSource = LogPedido.Instancia.ListarPedido();
        }
        public int OrdenPedidoId { get; private set; }
        public string NumeroPedido { get; private set; }
        //public int ClienteId { get; private set; }
        //public int FormaDePagoId { get; private set; }
        //public int PrecioTransporteId { get; private set; }
        //public decimal PrecioProductos { get; private set; } //traer tipo de vehiculo
        //public decimal PrecioFletes { get; private set; }
        //public decimal PrecioTotal { get; private set; }
        //public DateTime Fecha { get; private set; }
        //public string Estado { get; private set; }
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvPedido.Rows[e.RowIndex];
            OrdenPedidoId = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            NumeroPedido = filaSeleccionada.Cells[1].Value.ToString();
            //ClienteId = int.Parse(filaSeleccionada.Cells[3].Value.ToString());
            //FormaDePagoId = int.Parse(filaSeleccionada.Cells[4].Value.ToString());
            //PrecioTransporteId = int.Parse(filaSeleccionada.Cells[5].Value.ToString());
            //PrecioProductos = decimal.Parse(filaSeleccionada.Cells[6].Value.ToString());
            //PrecioFletes = decimal.Parse(filaSeleccionada.Cells[7].Value.ToString());
            //PrecioTotal = decimal.Parse(filaSeleccionada.Cells[8].Value.ToString());
            //Fecha = DateTime.Parse(filaSeleccionada.Cells[9].Value.ToString());
            //Estado = filaSeleccionada.Cells[10].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrdenPedidoId.ToString()))
            {
                MessageBox.Show("Debe Seleccionar un elemento");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

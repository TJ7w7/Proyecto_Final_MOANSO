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
    public partial class FrmBuscarPrecioTransporte : Form
    {
        public FrmBuscarPrecioTransporte()
        {
            InitializeComponent();
            CargarPrecios();
        }
        public string PrecioTransporteId { get; private set; }
        public string TipoTransporte { get; private set; }
        public string Empresa { get; private set; }
        public string OrigenRegion { get; private set; }
        public string DestinoRegion { get; private set; }
        public string Precio { get; private set; }


        public void CargarPrecios()
        {
            dgvPrecioTransporte.DataSource = LogPrecioTransporte.Instancia.ListarPrecioTransporte();

            dgvPrecioTransporte.Columns["EmpresaId"].Visible = false;
            dgvPrecioTransporte.Columns["OrigenRegionId"].Visible = false;
            dgvPrecioTransporte.Columns["DestinoRegionId"].Visible = false;
            dgvPrecioTransporte.Columns["MonedaId"].Visible = false;
            dgvPrecioTransporte.Columns["Moneda"].Visible = false;
            dgvPrecioTransporte.Columns["Estado"].Visible = false;

        }

        private void dgvPrecioTransporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvPrecioTransporte.Rows[e.RowIndex];

            PrecioTransporteId = filaSeleccionada.Cells[0].Value.ToString();
            TipoTransporte = filaSeleccionada.Cells[2].Value.ToString();
            Precio = filaSeleccionada.Cells[6].Value.ToString();
            Empresa = filaSeleccionada.Cells[8].Value.ToString();
            OrigenRegion = filaSeleccionada.Cells[9].Value.ToString();
            DestinoRegion = filaSeleccionada.Cells[10].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PrecioTransporteId.ToString()))
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

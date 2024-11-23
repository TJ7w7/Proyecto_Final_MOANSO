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
    public partial class FrmPrecioTransporte : Form
    {
        public FrmPrecioTransporte()
        {
            InitializeComponent();
            CargarEmpresa();
            CargarPrecioTransporte();
            CargarOrigenPais();
            CargarDestinoPais();
            CargarOrigenRegion();
            CargarDestinoRegion();
            CargarMoneda();
        }
        public void CargarPrecioTransporte()
        {
            dgvPrecioTransporte.DataSource = LogPrecioTransporte.Instancia.ListarPrecioTransporte();

            dgvPrecioTransporte.Columns["EmpresaId"].Visible = false;
            //dgvPrecioTransporte.Columns["OrigenPaisId"].Visible = false;
            dgvPrecioTransporte.Columns["OrigenRegionId"].Visible = false;
            //dgvPrecioTransporte.Columns["DestinoPaisId"].Visible = false;
            dgvPrecioTransporte.Columns["DestinoRegionId"].Visible = false;
            dgvPrecioTransporte.Columns["MonedaId"].Visible = false;

            dgvPrecioTransporte.Columns["PrecioTransporteId"].DisplayIndex = 0;
            dgvPrecioTransporte.Columns["EmpresaId"].DisplayIndex = 1;
            dgvPrecioTransporte.Columns["Empresa"].DisplayIndex = 2;
            dgvPrecioTransporte.Columns["TipoTransporte"].DisplayIndex = 3;
            //dgvPrecioTransporte.Columns["OrigenPaisId"].DisplayIndex = 3;
            //dgvPrecioTransporte.Columns["OrigenPais"].DisplayIndex = 4;
            dgvPrecioTransporte.Columns["OrigenRegionId"].DisplayIndex = 4;
            dgvPrecioTransporte.Columns["OrigenRegion"].DisplayIndex = 5;
            //dgvPrecioTransporte.Columns["DestinoPaisId"].DisplayIndex = 7;
            //dgvPrecioTransporte.Columns["DestinoPais"].DisplayIndex = 8;
            dgvPrecioTransporte.Columns["DestinoRegionId"].DisplayIndex = 6;
            dgvPrecioTransporte.Columns["DestinoRegion"].DisplayIndex = 7;
            dgvPrecioTransporte.Columns["MonedaId"].DisplayIndex = 8;
            dgvPrecioTransporte.Columns["Moneda"].DisplayIndex = 9;
            dgvPrecioTransporte.Columns["Precio"].DisplayIndex = 10;
            dgvPrecioTransporte.Columns["Estado"].DisplayIndex = 11;
        }
        public void CargarEmpresa()
        {
            cbEmpresaTransporte.DataSource = LogEmpresaTransporte.Instancia.ListarEmpresaTransporte();
            cbEmpresaTransporte.DisplayMember = "RazonSocial";
            cbEmpresaTransporte.ValueMember = "EmpresaTransporteId";

            cbEmpresaTransporte.SelectedIndex = -1;
        }
        public void CargarOrigenPais()
        {
            cbOrigenPais.DataSource = LogPais.Instancia.listarPais();
            cbOrigenPais.DisplayMember = "Nombre";
            cbOrigenPais.ValueMember = "PaisId";

            cbOrigenPais.SelectedIndex = -1;
        }

        public void CargarDestinoPais()
        {
            cbDestinoPais.DataSource = LogPais.Instancia.listarPais();
            cbDestinoPais.DisplayMember = "Nombre";
            cbDestinoPais.ValueMember = "PaisId";

            cbDestinoPais.SelectedIndex = -1;
        }

        public void CargarOrigenRegion()
        {
            cbOrigenRegion.DataSource = LogRegion.Instancia.ListarRegion();
            cbOrigenRegion.DisplayMember = "Nombre";
            cbOrigenRegion.ValueMember = "RegionId";

            cbOrigenRegion.SelectedIndex = -1;
        }

        public void CargarDestinoRegion()
        {
            cbDestinoRegion.DataSource = LogRegion.Instancia.ListarRegion();
            cbDestinoRegion.DisplayMember = "Nombre";
            cbDestinoRegion.ValueMember = "RegionId";

            cbDestinoRegion.SelectedIndex = -1;
        }

        public void CargarMoneda()
        {
            cbMoneda.DataSource = LogMoneda.Instancia.listarMoneda();
            cbMoneda.DisplayMember = "Nombre";
            cbMoneda.ValueMember = "MonedaId";

            cbMoneda.SelectedIndex = -1;
        }
        public void Limpiar()
        {
            cbEmpresaTransporte.SelectedIndex = -1;
            txtTipoTransporte.Text = "";
            cbOrigenPais.SelectedIndex = -1;
            cbDestinoPais.SelectedIndex = -1;
            cbOrigenRegion.SelectedIndex = -1;
            cbDestinoRegion.SelectedIndex = -1;
            cbMoneda.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTipoTransporte.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntPrecioTransporte pt = new EntPrecioTransporte();
                    pt.EmpresaId = int.Parse(cbEmpresaTransporte.SelectedValue.ToString());
                    pt.TipoTransporte = txtTipoTransporte.Text;
                    pt.OrigenRegionId = int.Parse(cbOrigenRegion.SelectedValue.ToString());
                    pt.DestinoRegionId = int.Parse(cbDestinoRegion.SelectedValue.ToString());
                    pt.MonedaId = int.Parse(cbMoneda.SelectedValue.ToString());
                    pt.Precio = decimal.Parse(txtPrecio.Text);
                    pt.Estado = cbxEstado.Checked;
                    LogPrecioTransporte.Instancia.InsertarPrecioTransporte(pt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarPrecioTransporte();
                Limpiar();
            }
        }
        public string id;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Porfavor Seleccione un elemento", "Error");
            }
            else
            {
                try
                {
                    EntPrecioTransporte pt = new EntPrecioTransporte();
                    pt.PrecioTransporteId = int.Parse(id);
                    pt.EmpresaId = int.Parse(cbEmpresaTransporte.SelectedValue.ToString());
                    pt.TipoTransporte = txtTipoTransporte.Text;
                    pt.OrigenRegionId = int.Parse(cbOrigenRegion.SelectedValue.ToString());
                    pt.DestinoRegionId = int.Parse(cbDestinoRegion.SelectedValue.ToString());
                    pt.MonedaId = int.Parse(cbMoneda.SelectedValue.ToString());
                    pt.Precio = decimal.Parse(txtPrecio.Text);
                    pt.Estado = cbxEstado.Checked;
                    LogPrecioTransporte.Instancia.EditarPrecioTransporte(pt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarPrecioTransporte();
                Limpiar();
            }
        }

        private void dgvPrecioTransporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPrecioTransporte.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            int empresaId = int.Parse(filaActual.Cells[1].Value.ToString());
            txtTipoTransporte.Text = filaActual.Cells[2].Value.ToString();
            int origenRegionId = int.Parse(filaActual.Cells[3].Value.ToString());
            int destinoRegionId = int.Parse(filaActual.Cells[4].Value.ToString());
            int monedaId = int.Parse(filaActual.Cells[5].Value.ToString());
            txtPrecio.Text = filaActual.Cells[6].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);

            cbEmpresaTransporte.SelectedValue = empresaId;
            cbOrigenRegion.SelectedValue = origenRegionId;
            cbDestinoRegion.SelectedValue = destinoRegionId;
            cbMoneda.SelectedValue = monedaId;
        }
    }
}

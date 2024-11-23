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
    public partial class FrmEmpresaTransporte : Form
    {
        public FrmEmpresaTransporte()
        {
            InitializeComponent();
            CargarEmpresaTransporte();
            CargarTipoDocumento();
        }

        public void CargarTipoDocumento()
        {
            cbTipoDocumento.DataSource = LogTipoDocumento.Instancia.listarTipoDocumento();
            cbTipoDocumento.DisplayMember = "Nombre";
            cbTipoDocumento.ValueMember = "TipoDocumentoId";

            cbTipoDocumento.SelectedIndex = -1;
        }

        public void CargarEmpresaTransporte()
        {
            dgvEmpresaTransporte.DataSource = LogEmpresaTransporte.Instancia.ListarEmpresaTransporte();

            dgvEmpresaTransporte.Columns["TipoDocumentoId"].Visible = false;

            dgvEmpresaTransporte.Columns["EmpresaTransporteId"].DisplayIndex = 0;
            dgvEmpresaTransporte.Columns["TipoDocumentoId"].DisplayIndex = 1;
            dgvEmpresaTransporte.Columns["TipoDocumento"].DisplayIndex = 2;
            dgvEmpresaTransporte.Columns["NumeroDocumento"].DisplayIndex = 3;
            dgvEmpresaTransporte.Columns["RazonSocial"].DisplayIndex = 4;
            dgvEmpresaTransporte.Columns["Direccion"].DisplayIndex = 5;
            dgvEmpresaTransporte.Columns["NumeroContacto"].DisplayIndex = 6;
            dgvEmpresaTransporte.Columns["Estado"].DisplayIndex = 7;
        }

        public void Limpiar()
        {
            cbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtNumeroContacto.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntEmpresaTransporte ep = new EntEmpresaTransporte();
                    ep.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString());
                    ep.NumeroDocumento = txtNumeroDocumento.Text;
                    ep.RazonSocial = txtRazonSocial.Text;
                    ep.Direccion = txtDireccion.Text;
                    ep.NumeroContacto = txtNumeroContacto.Text;
                    ep.Estado = cbxEstado.Checked;
                    LogEmpresaTransporte.Instancia.InsertarEmpresaTransporte(ep);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarEmpresaTransporte();
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
                    EntEmpresaTransporte ep = new EntEmpresaTransporte();
                    ep.EmpresaTransporteId = int.Parse(id);
                    ep.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString());
                    ep.NumeroDocumento = txtNumeroDocumento.Text;
                    ep.RazonSocial = txtRazonSocial.Text;
                    ep.Direccion = txtDireccion.Text;
                    ep.NumeroContacto = txtNumeroContacto.Text;
                    ep.Estado = cbxEstado.Checked;
                    LogEmpresaTransporte.Instancia.EditarEmpresaTransporte(ep);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarEmpresaTransporte();
                Limpiar();
            }
        }

        private void dgvEmpresaTransporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpresaTransporte.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            int tipoDocumentoId = int.Parse(filaActual.Cells[1].Value.ToString());
            txtNumeroDocumento.Text = filaActual.Cells[2].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[3].Value.ToString();
            txtDireccion.Text = filaActual.Cells[4].Value.ToString();
            txtNumeroContacto.Text = filaActual.Cells[5].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);

            cbTipoDocumento.SelectedValue = tipoDocumentoId;
        }
    }
}

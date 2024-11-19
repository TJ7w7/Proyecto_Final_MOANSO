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
    public partial class FrmClienteJuridico : Form
    {
        public FrmClienteJuridico()
        {
            InitializeComponent();
            CargarClienteJuridico();
            CargarTipoDocumento();
            CargarPais();
            CargarRegion();
        }
        public void CargarClienteJuridico()
        {
            dgvClienteJuridico.DataSource= LogCliente.Instancia.ListarClienteJuridico();
            
            dgvClienteJuridico.Columns["TipoDocumentoId"].Visible = false;
            dgvClienteJuridico.Columns["PaisId"].Visible=false;
            dgvClienteJuridico.Columns["RegionId"].Visible = false;

            dgvClienteJuridico.Columns["ClienteId"].DisplayIndex = 0;
            dgvClienteJuridico.Columns["TipoDocumentoId"].DisplayIndex = 1;
            dgvClienteJuridico.Columns["TipoDocumento"].DisplayIndex = 2;
            dgvClienteJuridico.Columns["NumeroDocumento"].DisplayIndex = 3;
            dgvClienteJuridico.Columns["RazonSocial"].DisplayIndex = 4;
            dgvClienteJuridico.Columns["PaisId"].DisplayIndex = 5;
            dgvClienteJuridico.Columns["Pais"].DisplayIndex = 6;
            dgvClienteJuridico.Columns["RegionId"].DisplayIndex = 7;
            dgvClienteJuridico.Columns["Region"].DisplayIndex = 8;
            dgvClienteJuridico.Columns["Direccion"].DisplayIndex = 9;
            dgvClienteJuridico.Columns["NumeroContacto"].DisplayIndex = 10;
            dgvClienteJuridico.Columns["Estado"].DisplayIndex = 11;

        }
        public void CargarTipoDocumento()
        {
            cbTipoDocumento.DataSource = LogTipoDocumento.Instancia.listarTipoDocumento();
            cbTipoDocumento.DisplayMember = "Nombre";
            cbTipoDocumento.ValueMember = "TipoDocumentoId";

            cbTipoDocumento.SelectedIndex = -1;
        }

        public void CargarPais()
        {
            cbPais.DataSource = LogPais.Instancia.listarPais();
            cbPais.DisplayMember = "Nombre";
            cbPais.ValueMember = "PaisId";

            cbPais.SelectedIndex = -1;
        }

        public void CargarRegion()
        {
            cbRegion.DataSource = LogRegion.Instancia.ListarRegion();
            cbRegion.DisplayMember = "Nombre";
            cbRegion.ValueMember = "RegionId";

            cbRegion.SelectedIndex = -1;
        }

        public void Limpiar()
        {
            cbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Text = "";
            txtRazonSocial.Text = "";
            cbPais.SelectedIndex = -1;
            cbRegion.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtNumeroContacto.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text == "" || cbTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntClienteJuridico cj = new EntClienteJuridico();
                    EntCliente c = new EntCliente();
                    c.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString()); 
                    c.NumeroDocumento = txtNumeroDocumento.Text;
                    c.PaisId = int.Parse(cbPais.SelectedValue.ToString());
                    c.RegionId = int.Parse(cbRegion.SelectedValue.ToString());
                    c.Direccion = txtDireccion.Text;
                    c.NumeroContacto = txtNumeroContacto.Text;
                    c.Estado = cbxEstado.Checked;
                    cj.RazonSocial = txtRazonSocial.Text;
                    LogCliente.Instancia.InsertarClienteJuridico(c, cj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarClienteJuridico();
                Limpiar();
            }
        }
        public string id;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntClienteJuridico cj = new EntClienteJuridico();
                    cj.ClienteId = int.Parse(id);
                    cj.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString());
                    cj.NumeroDocumento = txtNumeroDocumento.Text;
                    cj.PaisId = int.Parse(cbPais.SelectedValue.ToString());
                    cj.RegionId = int.Parse(cbRegion.SelectedValue.ToString());
                    cj.Direccion = txtDireccion.Text;
                    cj.NumeroContacto = txtNumeroContacto.Text;
                    cj.Estado = cbxEstado.Checked;
                    cj.RazonSocial = txtRazonSocial.Text;
                    LogCliente.Instancia.EditarClienteJuridico(cj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarClienteJuridico();
                Limpiar();
            }
        }
        private void dgvClienteJuridico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvClienteJuridico.Rows[e.RowIndex];
            txtRazonSocial.Text = filaActual.Cells[0].Value.ToString();
            id = filaActual.Cells[1].Value.ToString();
            int tipoDocumentoId = int.Parse(filaActual.Cells[2].Value.ToString());
            txtNumeroDocumento.Text = filaActual.Cells[3].Value.ToString();
            int paisId = int.Parse(filaActual.Cells[4].Value.ToString());
            int regionId = int.Parse(filaActual.Cells[5].Value.ToString());
            txtDireccion.Text = filaActual.Cells[6].Value.ToString();
            txtNumeroContacto.Text = filaActual.Cells[7].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);

            cbTipoDocumento.SelectedValue = tipoDocumentoId;
            cbPais.SelectedValue = paisId;
            cbRegion.SelectedValue = regionId;
            
        }
    }
}

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
    public partial class FrmClienteNatural : Form
    {
        public FrmClienteNatural()
        {
            InitializeComponent();
            CargarClienteNatural();

            CargarPais();
            CargarTipoDocumento();
            CargarRegion();
        }
        public void CargarClienteNatural()
        {
            dgvClienteNatural.DataSource = LogCliente.Instancia.ListarClienteNatural();

            dgvClienteNatural.Columns["TipoDocumentoId"].Visible = false;
            dgvClienteNatural.Columns["PaisId"].Visible = false;
            dgvClienteNatural.Columns["RegionId"].Visible = false;

            dgvClienteNatural.Columns["ClienteId"].DisplayIndex = 0;
            dgvClienteNatural.Columns["TipoDocumentoId"].DisplayIndex = 1;
            dgvClienteNatural.Columns["TipoDocumento"].DisplayIndex = 2;
            dgvClienteNatural.Columns["NumeroDocumento"].DisplayIndex = 3;
            dgvClienteNatural.Columns["Nombres"].DisplayIndex = 4; // no se que pasa xddd
            dgvClienteNatural.Columns["Apellidos"].DisplayIndex = 5;
            dgvClienteNatural.Columns["PaisId"].DisplayIndex = 6;
            dgvClienteNatural.Columns["Pais"].DisplayIndex = 7;
            dgvClienteNatural.Columns["RegionId"].DisplayIndex = 8;
            dgvClienteNatural.Columns["Region"].DisplayIndex = 9;
            dgvClienteNatural.Columns["Direccion"].DisplayIndex = 10;
            dgvClienteNatural.Columns["NumeroContacto"].DisplayIndex = 11;
            dgvClienteNatural.Columns["Estado"].DisplayIndex = 12;

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
            txtNombre.Text = "";
            txtApellidos.Text = "";
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
                    EntClienteNatural cn = new EntClienteNatural();
                    EntCliente c = new EntCliente();
                    c.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString());
                    c.NumeroDocumento = txtNumeroDocumento.Text;
                    c.PaisId = int.Parse(cbPais.SelectedValue.ToString());
                    c.RegionId = int.Parse(cbRegion.SelectedValue.ToString());
                    c.Direccion = txtDireccion.Text;
                    c.NumeroContacto = txtNumeroContacto.Text;
                    c.Estado = cbxEstado.Checked;
                    cn.Nombres = txtNombre.Text;
                    cn.Apellidos = txtApellidos.Text;
                    LogCliente.Instancia.InsertarClienteNatural(c, cn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarClienteNatural();
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
                    EntClienteNatural cn = new EntClienteNatural();
                    cn.ClienteId = int.Parse(id);
                    cn.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString());
                    cn.NumeroDocumento = txtNumeroDocumento.Text;
                    cn.PaisId = int.Parse(cbPais.SelectedValue.ToString());
                    cn.RegionId = int.Parse(cbRegion.SelectedValue.ToString());
                    cn.Direccion = txtDireccion.Text;
                    cn.NumeroContacto = txtNumeroContacto.Text;
                    cn.Estado = cbxEstado.Checked;
                    cn.Nombres = txtNombre.Text;
                    cn.Apellidos = txtApellidos.Text;
                    LogCliente.Instancia.EditarClienteNatural(cn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarClienteNatural();
                Limpiar();
            }
        }

        private void dgvClienteNatural_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvClienteNatural.Rows[e.RowIndex];
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtApellidos.Text = filaActual.Cells[1].Value.ToString();
            id = filaActual.Cells[2].Value.ToString();
            int tipoDocumentoId = int.Parse(filaActual.Cells[3].Value.ToString());
            txtNumeroDocumento.Text = filaActual.Cells[4].Value.ToString();
            int paisId = int.Parse(filaActual.Cells[5].Value.ToString());
            int regionId = int.Parse(filaActual.Cells[6].Value.ToString());
            txtDireccion.Text = filaActual.Cells[7].Value.ToString();
            txtNumeroContacto.Text = filaActual.Cells[8].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[9].Value);

            cbTipoDocumento.SelectedValue = tipoDocumentoId;
            cbPais.SelectedValue = paisId;
            cbRegion.SelectedValue = regionId;
        }
    }
}

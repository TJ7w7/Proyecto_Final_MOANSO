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
    public partial class FrmRegion : Form
    {
        public FrmRegion()
        {
            InitializeComponent();
            CargarRegion();
            CargarPais();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
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
            dgvRegion.DataSource = LogRegion.Instancia.ListarRegion();
            
            dgvRegion.Columns["PaisId"].Visible = false;
            dgvRegion.Columns["Aduana"].Visible = false;

            dgvRegion.Columns["PaisId"].DisplayIndex = 0;
            dgvRegion.Columns["RegionId"].DisplayIndex = 1;
            dgvRegion.Columns["CodigoArea"].DisplayIndex = 2;
            dgvRegion.Columns["Nombre"].DisplayIndex = 3;
            dgvRegion.Columns["NombrePais"].DisplayIndex = 4;
            dgvRegion.Columns["Estado"].DisplayIndex = 5;
            dgvRegion.Columns["Aduana"].DisplayIndex = 6;
        }
        public void Limpiar()
        {
            cbPais.SelectedIndex = -1;
            txtNombre.Text = "";
            txtCodigoArea.Text = "";
            cbxEstado.Checked = false;
            cbxAduana.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntRegion re = new EntRegion();
                    re.PaisId = int.Parse(cbPais.SelectedValue.ToString());
                    re.CodigoArea = int.Parse(txtCodigoArea.Text);
                    re.Nombre = txtNombre.Text;
                    re.Estado = cbxEstado.Checked;
                    re.Aduana = cbxAduana.Checked;
                    LogRegion.Instancia.InsertarRegion(re);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarRegion();
                Limpiar();
            }
        }
        public string id;
        private bool activarCellClick = false;
        private void dgvRegion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!activarCellClick)
            {
                return;
            }

            DataGridViewRow filaActual = dgvRegion.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            int paisId = int.Parse(filaActual.Cells[1].Value.ToString());
            txtCodigoArea.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            cbxAduana.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

            cbPais.SelectedValue = paisId;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            activarCellClick = true;
            Limpiar();
        }

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
                    EntRegion re = new EntRegion();
                    re.RegionId = int.Parse(id);
                    re.PaisId = int.Parse(cbPais.SelectedValue.ToString());
                    re.CodigoArea = int.Parse(txtCodigoArea.Text);
                    re.Nombre = txtNombre.Text;
                    re.Estado = cbxEstado.Checked;
                    re.Aduana = cbxAduana.Checked;
                    LogRegion.Instancia.EditarRegion(re);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarRegion();
                Limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            activarCellClick = false;
            Limpiar();
        }
    }
}

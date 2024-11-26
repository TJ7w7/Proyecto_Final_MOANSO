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
    public partial class FrmTipoDocumento : Form
    {
        public FrmTipoDocumento()
        {
            InitializeComponent();
            CargarTipoDocumento();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
        }
        public void CargarTipoDocumento()
        {
            dgvTipoDocumento.DataSource = LogTipoDocumento.Instancia.listarTipoDocumento();

            dgvTipoDocumento.Columns["ClienteJuridico"].Visible = false;
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            cbxLongitudExacta.Checked = false;
            txtLongitudMinima.Text = "";
            txtLongitudMaxima.Text = "";
            cbxAlfanumerico.Checked = false;
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtLongitudMinima.Text == "" || txtLongitudMaxima.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntTipoDocumento tp = new EntTipoDocumento();
                    tp.Nombre = txtNombre.Text;
                    tp.LongitudExacta = cbxLongitudExacta.Checked;
                    tp.LongitudMaxima = int.Parse(txtLongitudMaxima.Text);
                    tp.LongitudMinima = int.Parse(txtLongitudMinima.Text);
                    tp.Alfanumerico = cbxAlfanumerico.Checked;
                    tp.ClienteJuridico = cbxClienteJuridico.Checked;
                    tp.Estado = cbxEstado.Checked;
                    LogTipoDocumento.Instancia.InsertarTipoDocumento(tp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarTipoDocumento();
                Limpiar();
            }
        }
        private bool activarCellClick = false;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnAgregar.Enabled = false;
            activarCellClick = true;
            Limpiar();
        }

        private void dgvTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!activarCellClick)
            {
                return;
            }

            if (e.RowIndex >= 0) // Asegúrate de no seleccionar el encabezado
            {
                DataGridViewRow filaActual = dgvTipoDocumento.Rows[e.RowIndex];
                id = filaActual.Cells[0].Value.ToString();
                txtNombre.Text = filaActual.Cells[1].Value.ToString();
                cbxLongitudExacta.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
                txtLongitudMinima.Text = filaActual.Cells[3].Value.ToString();
                txtLongitudMaxima.Text = filaActual.Cells[4].Value.ToString();
                cbxAlfanumerico.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
                cbxClienteJuridico.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
                cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
            }
        }

        private void txtLongitudMinima_TextChanged(object sender, EventArgs e)
        {
            if (cbxLongitudExacta.Checked)
            {
                txtLongitudMaxima.Text = txtLongitudMinima.Text;
            }
        }

        private void cbxLongitudExacta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLongitudExacta.Checked)
            {
                txtLongitudMaxima.Enabled = false;
                txtLongitudMaxima.Text = txtLongitudMinima.Text;
            }
            else
            {
                txtLongitudMaxima.Enabled=true;
                txtLongitudMaxima.Text = string.Empty;
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
                    EntTipoDocumento tp = new EntTipoDocumento();
                    tp.TipoDocumentoId = int.Parse(id);
                    tp.Nombre = txtNombre.Text;
                    tp.LongitudExacta = cbxLongitudExacta.Checked;
                    tp.LongitudMaxima = int.Parse(txtLongitudMaxima.Text);
                    tp.LongitudMinima = int.Parse(txtLongitudMinima.Text);
                    tp.Alfanumerico = cbxAlfanumerico.Checked;
                    tp.ClienteJuridico = cbxClienteJuridico.Checked;
                    tp.Estado = cbxEstado.Checked;
                    LogTipoDocumento.Instancia.EditarTipoDocumento(tp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarTipoDocumento();
                Limpiar();
                activarCellClick = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            activarCellClick = false;
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

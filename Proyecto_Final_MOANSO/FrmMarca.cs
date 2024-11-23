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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
            CargarMarca();
        }
        public void CargarMarca()
        {

            dgvMarca.DataSource = LogMarca.Instancia.listarMarca();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtDescripcion.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntMarca ma = new EntMarca();
                    ma.Nombre = txtNombre.Text;
                    ma.Descripcion = txtDescripcion.Text;
                    ma.Estado = cbxEstado.Checked;
                    LogMarca.Instancia.InsertarMarca(ma);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarMarca();
                Limpiar();
            }
        }
        public string id;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Porfavor Seleccione un elemento", "Error");
            }
            else
            {
                try
                {
                    EntMarca ma = new EntMarca();
                    ma.MarcaId = int.Parse(id);
                    ma.Nombre = txtNombre.Text;
                    ma.Descripcion = txtDescripcion.Text;
                    ma.Estado = cbxEstado.Checked;
                    LogMarca.Instancia.EditarMarca(ma);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarMarca();
                Limpiar();
            }
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMarca.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}

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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CargarCategoria();
        }

        public void CargarCategoria()
        {
            dgvCategoria.DataSource = LogCategoria.Instancia.listarCategoria();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbxEstado.Checked = false;
        }

        public string id;

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

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
                    EntCategoria cat = new EntCategoria();
                    cat.CategoriaId = int.Parse(id);
                    cat.Nombre = txtNombre.Text;
                    cat.Descripcion = txtDescripcion.Text;
                    cat.Estado = cbxEstado.Checked;
                    LogCategoria.Instancia.EditarCategoria(cat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarCategoria();
                Limpiar();
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtDescripcion.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntCategoria cat = new EntCategoria();
                    cat.Nombre = txtNombre.Text;
                    cat.Descripcion = txtDescripcion.Text;
                    cat.Estado = cbxEstado.Checked;
                    LogCategoria.Instancia.InsertarCategoria(cat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarCategoria();
                Limpiar();
            }
        }
    }
}

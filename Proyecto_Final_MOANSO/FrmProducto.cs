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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            CargarProducto();
            CargarCategoria();
            CargarSabores();
        }

        public void CargarProducto()
        {
            dgvProducto.DataSource = LogProducto.Instancia.ListarProducto();
            dgvProducto.Columns["CategoriaId"].Visible = false;
            dgvProducto.Columns["SaboresId"].Visible = false;

            dgvProducto.Columns["ProductoId"].DisplayIndex = 0;
            dgvProducto.Columns["Nombre"].DisplayIndex = 1;
            dgvProducto.Columns["CategoriaId"].DisplayIndex = 2;
            dgvProducto.Columns["Categoria"].DisplayIndex = 3;
            dgvProducto.Columns["SaboresId"].DisplayIndex = 4;
            dgvProducto.Columns["Sabores"].DisplayIndex = 5;
            dgvProducto.Columns["Descripcion"].DisplayIndex = 6;
            dgvProducto.Columns["Estado"].DisplayIndex = 7;
        }

        public void CargarCategoria()
        {
            cbCategoria.DataSource = LogCategoria.Instancia.listarCategoria();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "CategoriaId";

            cbCategoria.SelectedIndex = -1;
        }

        public void CargarSabores()
        {
            cbSabores.DataSource = LogSabores.Instancia.listarSabores();
            cbSabores.DisplayMember = "Nombre";
            cbSabores.ValueMember = "SaboresId";

            cbSabores.SelectedIndex = -1;
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            cbCategoria.SelectedIndex = -1;
            cbSabores.SelectedIndex = -1;
            txtDescripcion.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntProducto p = new EntProducto();
                    p.Nombre = txtNombre.Text;
                    p.CategoriaId = int.Parse(cbCategoria.SelectedValue.ToString());
                    p.SaboresId = int.Parse(cbSabores.SelectedValue.ToString());
                    p.Descripcion = txtDescripcion.Text;
                    p.Estado = cbxEstado.Checked;
                    LogProducto.Instancia.InsertarProducto(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarProducto();
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
                    EntProducto p = new EntProducto();
                    p.ProductoId = int.Parse(id);
                    p.Nombre = txtNombre.Text;
                    p.CategoriaId = int.Parse(cbCategoria.SelectedValue.ToString());
                    p.SaboresId = int.Parse(cbSabores.SelectedValue.ToString());
                    p.Descripcion = txtDescripcion.Text;
                    p.Estado = cbxEstado.Checked;
                    LogProducto.Instancia.EditarProducto(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarProducto();
                Limpiar();
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            int categoriaId = int.Parse(filaActual.Cells[2].Value.ToString());
            int saboresId = int.Parse(filaActual.Cells[3].Value.ToString());
            txtDescripcion.Text = filaActual.Cells[4].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
            
            cbCategoria.SelectedValue = categoriaId;
            cbSabores.SelectedValue = saboresId;
        }
    }
}

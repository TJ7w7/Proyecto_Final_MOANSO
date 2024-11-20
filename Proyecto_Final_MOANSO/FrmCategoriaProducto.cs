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
    public partial class FrmCategoriaProducto : Form
    {
        public FrmCategoriaProducto()
        {
            InitializeComponent();
            dgvCategoria.Enabled = false;
            CargarCategorias();
            dgvCategoria.RowHeaderMouseClick += dgvCategoria_RowHeaderMouseClick;

            this.CenterToScreen();
        }

        private void btnAgregaCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                EntCategoria nuevaCategoria = new EntCategoria
                {
                    Nombre = txtNombreCategoria.Text.Trim(),
                    Estado = cbEstadoCategoria.Checked 
                };

                bool resultado = LogCategoria.Instancia.GuardarCategoria(nuevaCategoria);

                if (resultado)
                {
                    MessageBox.Show("Categoría guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificaCategoria_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                // Obtener el ID de la categoría seleccionada desde la fila
                var categoriaId = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells["CategoriaId"].Value);

                // Crear la entidad con los datos del formulario
                EntCategoria categoria = new EntCategoria
                {
                    CategoriaId = categoriaId,  // Necesario solo para identificar el registro
                    Nombre = txtNombreCategoria.Text.Trim(),
                    Estado = cbEstadoCategoria.Checked
                };

                // Actualizar los datos
                try
                {
                    LogCategoria.Instancia.ActualizarCategoria(categoria);
                    MessageBox.Show("Categoría actualizada correctamente.");

                    // Recargar el DataGridView
                    dgvCategoria.DataSource = LogCategoria.Instancia.ObtenerCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la categoría: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para actualizar.");
            }
        }
        private void btnEliminaCategoria_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                // Obtener el ID de la categoría seleccionada
                var categoriaId = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells["CategoriaId"].Value);

                // Confirmar la eliminación
                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta categoría?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar a la capa lógica para eliminar
                        LogCategoria.Instancia.EliminarCategoria(categoriaId);
                        MessageBox.Show("Categoría eliminada correctamente.");

                        // Recargar el DataGridView
                        dgvCategoria.DataSource = LogCategoria.Instancia.ObtenerCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la categoría: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para eliminar.");
            }
        }
        private void dgvCategoria_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que sea una fila válida
            {
                // Obtener los datos de la fila seleccionada
                var filaSeleccionada = dgvCategoria.Rows[e.RowIndex];

                txtNombreCategoria.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                cbEstadoCategoria.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Estado"].Value);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                List<EntCategoria> categorias = LogCategoria.Instancia.ObtenerCategorias();
                dgvCategoria.DataSource = LogCategoria.Instancia.ObtenerCategorias();

                dgvCategoria.DataSource = null; 
                dgvCategoria.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            dgvCategoria.Enabled = true;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            dgvCategoria.Enabled = false;
        }

        private void btnSalirFrmCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

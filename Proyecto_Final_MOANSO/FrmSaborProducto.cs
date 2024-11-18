using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmSaborProducto : Form
    {
        public FrmSaborProducto()
        {
            InitializeComponent();
            dgvSabor.Enabled = false;
            CargarSabores();
            this.dgvSabor.RowHeaderMouseClick += dgvSabor_RowHeaderMouseClick;

            this.CenterToScreen();
        }

        private void btnAgregaSabor_Click(object sender, EventArgs e)
        {
            try
            {
                EntSabores nuevoSabor = new EntSabores
                {
                    Nombre = txtNombreSabor.Text.Trim(),
                    Estado = cbEstadoSabor.Checked
                };

                bool resultado = LogSabores.Instancia.GuardarSabores(nuevoSabor);

                if (resultado)
                {
                    MessageBox.Show("Nombre de sabor guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarSabores();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar nombre de sabor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificaSabor_Click(object sender, EventArgs e)
        {
            if (dgvSabor.SelectedRows.Count > 0)
            {
                var saboresid = Convert.ToInt32(dgvSabor.SelectedRows[0].Cells["SaboresId"].Value);

                EntSabores sabores = new EntSabores
                {
                    SaboresId = saboresid,  
                    Nombre = txtNombreSabor.Text.Trim(),
                    Estado = cbEstadoSabor.Checked
                };

                try
                {
                    LogSabores.Instancia.ModificarSabores(sabores);
                    MessageBox.Show("Nombre de sabor actualizado correctamente.");

                    dgvSabor.DataSource = LogSabores.Instancia.ObtenerSabores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar sabores: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre para actualizar.");
            }
        }

        private void btnEliminaSabor_Click(object sender, EventArgs e)
        {
            if (dgvSabor.SelectedRows.Count > 0)
            {
                var saboresId = Convert.ToInt32(dgvSabor.SelectedRows[0].Cells["SaboresId"].Value);

                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este nombre de sabor?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        LogSabores.Instancia.EliminarSabores(saboresId);
                        MessageBox.Show("Nombre de sabor eliminado correctamente.");

                        dgvSabor.DataSource = LogSabores.Instancia.ObtenerSabores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el nombre de sabor: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre de sabor para eliminar.");
            }
        }

        private void btnHabilitarSabor_Click(object sender, EventArgs e)
        {
            dgvSabor.Enabled = true;
        }

        private void btnDeshabilitarSabor_Click(object sender, EventArgs e)
        {
            dgvSabor.Enabled = false;
        }

        private void btnSalirFrmSabor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvSabor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var filaSeleccionada = dgvSabor.Rows[e.RowIndex];

                txtNombreSabor.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                cbEstadoSabor.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Estado"].Value);
            }
        }

        private void CargarSabores()
        {
            try
            {
                List<EntSabores> sabores = LogSabores.Instancia.ObtenerSabores();
                dgvSabor.DataSource = LogSabores.Instancia.ObtenerSabores();

                dgvSabor.DataSource = null;
                dgvSabor.DataSource = sabores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los sabores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class FrmRegiones : Form
    {
        public FrmRegiones()
        {
            InitializeComponent();
            CargarDivisionesAdministrativas();
        }

        private void CargarDivisionesAdministrativas()
        {
            List<EntDivisionesAdministrativas> region = LogDivisionesAdministrativas.Instancia.ObtenerDivisionesAdministrativas();
            dgvRegionesCorea.DataSource = region;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvRegionesCorea.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRegionesCorea.SelectedRows[0].Cells["DivisionesAdministrativasId"].Value);
                bool estadoActual = Convert.ToBoolean(dgvRegionesCorea.SelectedRows[0].Cells["Estado"].Value);
                bool nuevoEstado = !estadoActual;

                // Llama al método de la capa lógica para actualizar el estado
                bool exito = LogDivisionesAdministrativas.Instancia.CambiarEstadoDivision(id, nuevoEstado);

                if (exito)
                {
                    MessageBox.Show("El estado se ha cambiado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDivisionesAdministrativas();
                }
                else
                {
                    MessageBox.Show("Hubo un error al cambiar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para cambiar el estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

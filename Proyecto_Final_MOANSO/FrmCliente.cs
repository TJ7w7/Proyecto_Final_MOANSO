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
    public partial class FrmCliente : Form
    {
        private LogicaCliente logicacliente = new LogicaCliente();
        private int clienteIdSeleccionado;
        public FrmCliente()
        {
            InitializeComponent();
            CargarClientes();
            CargarRegiones();

            cbRegCli.SelectedIndex = -1;
            txtBRN_RUC.Enabled = false;

            radioRUC.CheckedChanged += radioBRN_CheckedChanged;
            radioBRN.CheckedChanged += radioBRN_CheckedChanged;

        }

        private void CargarClientes()
        {
            dtgridCliente.DataSource = logicacliente.ListarClientes();
        }
        private void CargarRegiones()
        {
            try
            {
                // Obtener la lista de divisiones administrativas
                List<EntDivisionesAdministrativas> divisiones = LogDivisionesAdministrativas.Instancia.ObtenerDivisionesAdministrativas();

                // Establecer la DataSource del ComboBox
                cbRegCli.DataSource = divisiones;

                // Establecer las propiedades a mostrar y el valor
                cbRegCli.DisplayMember = "Nombre";  // La propiedad que se mostrará
                cbRegCli.ValueMember = "DivisionesAdministrativasId";  // La propiedad que se usará como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación para DivisionesAdministrativasId
                int divisionesAdministrativasId;
                if (!int.TryParse(txtRegionID.Text, out divisionesAdministrativasId))
                {
                    MessageBox.Show("Por favor, selecciona una región válida.");
                    return;
                }

                Cliente cliente = new Cliente
                {
                    BRN_RUC = txtBRN_RUC.Text,
                    Nombre = txtNombre.Text,
                    DivisionesAdministrativasId = divisionesAdministrativasId,
                    Direccion = txtDireccion.Text,
                    NumeroContacto = txtNumCli.Text,
                };

                // Llamar a la capa lógica para registrar el cliente
                bool registrado = LogicaCliente.Instancia.RegistrarCliente(cliente);
                CargarClientes();
                LimpiarCampos();

                if (registrado)
                {
                    MessageBox.Show("Cliente registrado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteIdSeleccionado > 0)
            {
                ModificarCliente(clienteIdSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (clienteIdSeleccionado > 0)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    EliminarCliente(clienteIdSeleccionado);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }

        }

        private void dtgridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgridCliente.Rows[e.RowIndex];

                clienteIdSeleccionado = row.Cells["ClienteId"].Value != null ? Convert.ToInt32(row.Cells["ClienteId"].Value) : 0;

                txtBRN_RUC.Text = row.Cells["BRN_RUC"].Value?.ToString() ?? "";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = row.Cells["Direccion"].Value?.ToString() ?? "";
                txtNumCli.Text = row.Cells["NumeroContacto"].Value?.ToString() ?? "";
            }
        }
        // Método para modificar un cliente existente
        private void ModificarCliente(int clienteId)
        {
            try
            {
                // Validación para DivisionesAdministrativasId
                int divisionesAdministrativasId;
                if (!int.TryParse(txtRegionID.Text, out divisionesAdministrativasId))
                {
                    MessageBox.Show("Por favor, selecciona una región válida.");
                    return;
                }

                Cliente cliente = new Cliente
                {
                    ClienteId = clienteId,
                    BRN_RUC = txtBRN_RUC.Text,
                    Nombre = txtNombre.Text,
                    DivisionesAdministrativasId = divisionesAdministrativasId,
                    Direccion = txtDireccion.Text,
                    NumeroContacto = txtNumCli.Text
                };

                bool modificado = LogicaCliente.Instancia.ModificarCliente(cliente);

                if (modificado)
                {
                    MessageBox.Show("Cliente modificado con éxito.");
                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void EliminarCliente(int clienteId)
        {
            try
            {
                bool eliminado = LogicaCliente.Instancia.EliminarCliente(clienteId);

                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado con éxito.");
                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtBRN_RUC.Clear();
            txtNombre.Clear();
            cbRegCli.SelectedIndex = -1;
            txtDireccion.Clear();
            txtNumCli.Clear();
            txtRegionID.Clear();
            clienteIdSeleccionado = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegiones_Click(object sender, EventArgs e)
        {
            FrmRegiones mostrarregiones = new FrmRegiones();
            mostrarregiones.Show();
        }

        private void radioBRN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRUC.Checked || radioBRN.Checked)
            {
                txtBRN_RUC.Clear();
                txtBRN_RUC.Enabled = true;
            }
            else
            {
                txtBRN_RUC.Enabled = false;
            }
        }

        private void txtNumCli_TextChanged(object sender, EventArgs e)
        {
            //formato de número telefónico
            string telefono = txtNumCli.Text.Replace(" ", "").Replace("+82", "").Trim();

            //Generar espacios
            if (telefono.Length > 0)
            {
                telefono = $"+82 {telefono}";
                if (telefono.Length > 6)
                {
                    telefono = telefono.Insert(6, " ");
                }

                if (telefono.Length > 11)
                {
                    telefono = telefono.Insert(11, " ");
                }
            }

            if (telefono.Length > 16)
            {
                telefono = telefono.Substring(0, 16);
            }

            txtNumCli.Text = telefono;
            txtNumCli.SelectionStart = telefono.Length;
        }

        private void txtNumCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbRegCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRegCli.SelectedItem != null)
            {
                var selectedDivision = (EntDivisionesAdministrativas)cbRegCli.SelectedItem;
                txtRegionID.Text = selectedDivision.DivisionesAdministrativasId.ToString();

                int codigoDeArea = selectedDivision.CodigodeArea;
                txtNumCli.Text = $"+82 {codigoDeArea} ";
            }
            else
            {
                txtNumCli.Text = "";
                txtRegionID.Text = "00";
            }
        }

        private void FormatearComoBRN()
        {
            // Formato (XXX-XX-XXXXX)
            string formatoBRN = txtBRN_RUC.Text;
            formatoBRN = new string(formatoBRN.Where(char.IsDigit).ToArray());

            if (formatoBRN.Length > 10)
            {
                formatoBRN = formatoBRN.Substring(0, 10);
            }

            // Insertar guiones
            if (formatoBRN.Length > 3)
            {
                formatoBRN = formatoBRN.Insert(3, "-");
            }
            if (formatoBRN.Length > 6)
            {
                formatoBRN = formatoBRN.Insert(6, "-");
            }

            txtBRN_RUC.Text = formatoBRN;
            txtBRN_RUC.SelectionStart = formatoBRN.Length;
        }

        private void FormatearComoRUC()
        {
            string formatoRUC = txtBRN_RUC.Text;
            formatoRUC = new string(formatoRUC.Where(char.IsDigit).ToArray());
            if (formatoRUC.Length > 10)
            {
                formatoRUC = formatoRUC.Substring(0, 10);
            }
            txtBRN_RUC.Text = formatoRUC;
            txtBRN_RUC.SelectionStart = formatoRUC.Length;
        }

        private void txtBRN_RUC_TextChanged(object sender, EventArgs e)
        {
            if (radioRUC.Checked)
            {
                FormatearComoRUC();
            }
            else if (radioBRN.Checked)
            {
                FormatearComoBRN();
            }
        }
    }
}

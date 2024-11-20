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
    public partial class Cliente_Natural : Form
    {
        public Cliente_Natural()
        {
            InitializeComponent();
            CargarCombos();
            CargarClientesNaturales();
        }
        private void CargarCombos()
        {
            try
            {
                // Cargar cmbTipoDocumento
                cmbTipoDocumento.DataSource = LogicaTipoDocumento.Instancia.ObtenerTipoDocumentos();
                cmbTipoDocumento.DisplayMember = "Nombre";
                cmbTipoDocumento.ValueMember = "TipoDocumentoId";

                // Cargar cmbRegion
                cmbRegion.DataSource = LogicaRegion.Instancia.ListarRegiones();
                cmbRegion.DisplayMember = "Nombre";
                cmbRegion.ValueMember = "RegionId";

                // Cargar cmbPais
                cmbPais.DataSource = LogicaPais.Instancia.ListarPaises();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.ValueMember = "PaisId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos: " + ex.Message);
            }
        }
        private void CargarClientesNaturales()
        {
            try
            {
                dgvClienteNatural.DataSource = LogicaClienteNatural.Instancia.ObtenerTodosLosClientesNaturales();

                // Ajustar los encabezados de las columnas (opcional)
                dgvClienteNatural.Columns["ClienteId"].HeaderText = "ID Cliente";
                dgvClienteNatural.Columns["TipoDocumento"].HeaderText = "Tipo de Documento";
                dgvClienteNatural.Columns["NroDocumento"].HeaderText = "N° de Documento";
                dgvClienteNatural.Columns["Nombres"].HeaderText = "Nombres";
                dgvClienteNatural.Columns["Apellidos"].HeaderText = "Apellidos";
                dgvClienteNatural.Columns["Pais"].HeaderText = "Pais";
                dgvClienteNatural.Columns["Region"].HeaderText = "Región";
                dgvClienteNatural.Columns["Direccion"].HeaderText = "Dirección";
                dgvClienteNatural.Columns["NumeroContacto"].HeaderText = "N° de Contacto";
                dgvClienteNatural.Columns["Estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes jurídicos: " + ex.Message);
            }
        }



        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtnumerodocumento.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtapellido.Text) ||
                    string.IsNullOrWhiteSpace(txtnumerocontacto.Text) ||
                    string.IsNullOrWhiteSpace(txtdireccion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Validar que se haya seleccionado un valor en los combobox
                if (cmbTipoDocumento.SelectedValue == null || cmbTipoDocumento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de documento.");
                    return;
                }

                if (cmbRegion.SelectedValue == null || cmbRegion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una región.");
                    return;
                }

                if (cmbPais.SelectedValue == null || cmbPais.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un país.");
                    return;
                }

                // Crear objetos cliente y clienteJurídico con los datos del formulario
                Cliente cliente = new Cliente
                {
                    TipoDocumentoId = Convert.ToInt32(cmbTipoDocumento.SelectedValue),
                    PaisId = Convert.ToInt32(cmbPais.SelectedValue),
                    RegionId = Convert.ToInt32(cmbRegion.SelectedValue),
                    Direccion = txtdireccion.Text,
                    NumeroContacto = txtnumerocontacto.Text,
                    Estado = checkEstado.Checked 
                };

                Cliente_natural cliente_Natural = new Cliente_natural
                {
                    NroDocumento = txtnumerodocumento.Text,
                    Nombres = txtnombre.Text,
                    Apellidos = txtapellido.Text
                };

                // Insertar cliente y clienteJuridico
                bool resultado = LogicaClienteNatural.Instancia.InsertarClienteNatural(cliente, cliente_Natural);

                if (resultado)
                {
                    MessageBox.Show("Cliente Natural registrado exitosamente.");
                    LimpiarCampos(); // Limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show("Error al registrar el cliente natural.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente natural: " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada
                if (dgvClienteNatural.CurrentRow == null || dgvClienteNatural.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Seleccione un cliente natural para modificar.");
                    return;
                }

                // Obtener el ID del cliente jurídico seleccionado
                int clienteId = Convert.ToInt32(dgvClienteNatural.CurrentRow.Cells[0].Value); // Cambiar [0] por el índice correcto si no es la primera columna

                // Validar que los campos estén completos
                if (string.IsNullOrWhiteSpace(txtnumerodocumento.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtapellido.Text) ||
                    string.IsNullOrWhiteSpace(txtdireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtnumerocontacto.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Crear objetos con los nuevos datos
                Cliente cliente = new Cliente
                {
                    ClienteId = clienteId,
                    TipoDocumentoId = Convert.ToInt32(cmbTipoDocumento.SelectedValue),
                    PaisId = Convert.ToInt32(cmbPais.SelectedValue),
                    RegionId = Convert.ToInt32(cmbRegion.SelectedValue),
                    Direccion = txtdireccion.Text,
                    NumeroContacto = txtnumerocontacto.Text,
                    Estado = checkEstado.Checked
                };

                Cliente_natural clienteNatural = new Cliente_natural
                {
                    ClienteId = clienteId,
                    NroDocumento = txtnumerodocumento.Text,
                    Nombres = txtnombre.Text,
                    Apellidos = txtapellido.Text
                };

                // Actualizar en la base de datos
                bool resultado = LogicaClienteNatural.Instancia.ModificarClienteNatural(cliente, clienteNatural);

                if (resultado)
                {
                    MessageBox.Show("Cliente Natural modificado exitosamente.");
                    CargarClientesNaturales(); // Recargar el DataGridView
                    LimpiarCampos(); // Limpiar los controles del formulario
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente natural.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método para limpiar el formulario
        private void LimpiarCampos()
        {
            cmbTipoDocumento.SelectedIndex = -1;
            cmbRegion.SelectedIndex = -1;
            cmbPais.SelectedIndex = -1;
            txtnumerodocumento.Clear();
            txtnumerocontacto.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtdireccion.Clear();
            checkEstado.Checked = false;
        }

        private void dgvClienteNatural_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se seleccionó una fila válida
            {
                DataGridViewRow filaSeleccionada = dgvClienteNatural.Rows[e.RowIndex];

                // Asignar los valores de la fila seleccionada a los controles del formulario
                txtnumerodocumento.Text = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
                txtnombre.Text = filaSeleccionada.Cells["Nombres"].Value.ToString();
                txtapellido.Text = filaSeleccionada.Cells["Apellidos"].Value.ToString();
                txtdireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                txtnumerocontacto.Text = filaSeleccionada.Cells["NumeroContacto"].Value.ToString();

                cmbTipoDocumento.Text = filaSeleccionada.Cells["TipoDocumento"].Value.ToString();
                cmbPais.Text = filaSeleccionada.Cells["Pais"].Value.ToString();
                cmbRegion.Text = filaSeleccionada.Cells["Region"].Value.ToString();

                // Convertir el estado a un checkbox
                checkEstado.Checked = filaSeleccionada.Cells["Estado"].Value.ToString() == "Activo";
            }
        }
    }
}

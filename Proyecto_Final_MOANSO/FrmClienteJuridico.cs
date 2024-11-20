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
    public partial class Cliente_Juridico : Form
    {
        public Cliente_Juridico()
        {
            InitializeComponent();
            CargarCombos();
            CargarClientesJuridicos();
            
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
        private void CargarClientesJuridicos()
        {
            try
            {
                dgvClienteJuridico.DataSource = LogicaClienteJuridico.Instancia.ObtenerClientesJuridicos();

                // Ajustar los encabezados de las columnas (opcional)
                dgvClienteJuridico.Columns["ClienteId"].HeaderText = "ID Cliente";
                dgvClienteJuridico.Columns["TipoDocumento"].HeaderText = "Tipo de Documento";
                dgvClienteJuridico.Columns["NumeroDocumento"].HeaderText = "N° de Documento";
                dgvClienteJuridico.Columns["RazonSocial"].HeaderText = "Razón Social";
                dgvClienteJuridico.Columns["Pais"].HeaderText = "País";
                dgvClienteJuridico.Columns["Region"].HeaderText = "Región";
                dgvClienteJuridico.Columns["Direccion"].HeaderText = "Dirección";
                dgvClienteJuridico.Columns["NumeroContacto"].HeaderText = "N° de Contacto";
                dgvClienteJuridico.Columns["Estado"].HeaderText = "Estado";
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
                    string.IsNullOrWhiteSpace(txtnumeroContacto.Text) ||
                    string.IsNullOrWhiteSpace(txtrazonsocial.Text) ||
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
                    NumeroContacto = txtnumeroContacto.Text,
                    Estado = checkEstado.Checked // Convertir el estado a 1 o 0
                };

                Cliente_juridico clienteJuridico = new Cliente_juridico
                {
                    NumeroDocumento = txtnumerodocumento.Text,
                    RazonSocial = txtrazonsocial.Text
                };

                // Insertar cliente y clienteJuridico
                bool resultado = LogicaClienteJuridico.Instancia.InsertarClienteJuridico(cliente, clienteJuridico);

                if (resultado)
                {
                    MessageBox.Show("Cliente Jurídico registrado exitosamente.");
                    LimpiarCampos(); // Limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show("Error al registrar el cliente jurídico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente jurídico: " + ex.Message);
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
                if (dgvClienteJuridico.CurrentRow == null || dgvClienteJuridico.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Seleccione un cliente jurídico para modificar.");
                    return;
                }

                // Obtener el ID del cliente jurídico seleccionado
                int clienteId = Convert.ToInt32(dgvClienteJuridico.CurrentRow.Cells[0].Value); // Cambiar [0] por el índice correcto si no es la primera columna

                // Validar que los campos estén completos
                if (string.IsNullOrWhiteSpace(txtnumerodocumento.Text) ||
                    string.IsNullOrWhiteSpace(txtrazonsocial.Text) ||
                    string.IsNullOrWhiteSpace(txtdireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtnumeroContacto.Text))
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
                    NumeroContacto = txtnumeroContacto.Text,
                    Estado = checkEstado.Checked
                };

                Cliente_juridico clienteJuridico = new Cliente_juridico
                {
                    ClienteId = clienteId,
                    NumeroDocumento = txtnumerodocumento.Text,
                    RazonSocial = txtrazonsocial.Text
                };

                // Actualizar en la base de datos
                bool resultado = LogicaClienteJuridico.Instancia.ModificarClienteJuridico(cliente, clienteJuridico);

                if (resultado)
                {
                    MessageBox.Show("Cliente Jurídico modificado exitosamente.");
                    CargarClientesJuridicos(); // Recargar el DataGridView
                    LimpiarCampos(); // Limpiar los controles del formulario
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente jurídico.");
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
            txtnumeroContacto.Clear();
            txtrazonsocial.Clear();
            txtdireccion.Clear();
            checkEstado.Checked = false;
        }

       
        //no se porque llame su evento
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvClienteJuridico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se seleccionó una fila válida
            {
                DataGridViewRow filaSeleccionada = dgvClienteJuridico.Rows[e.RowIndex];

                // Asignar los valores de la fila seleccionada a los controles del formulario
                txtnumerodocumento.Text = filaSeleccionada.Cells["NumeroDocumento"].Value.ToString();
                txtrazonsocial.Text = filaSeleccionada.Cells["RazonSocial"].Value.ToString();
                txtdireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                txtnumeroContacto.Text = filaSeleccionada.Cells["NumeroContacto"].Value.ToString();

                cmbTipoDocumento.Text = filaSeleccionada.Cells["TipoDocumento"].Value.ToString();
                cmbPais.Text = filaSeleccionada.Cells["Pais"].Value.ToString();
                cmbRegion.Text = filaSeleccionada.Cells["Region"].Value.ToString();

                // Convertir el estado a un checkbox
                checkEstado.Checked = filaSeleccionada.Cells["Estado"].Value.ToString() == "Activo";
            }
        }
    }
}

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
    public partial class FrmBuscarCliente : Form
    {
        private LogCliente logicacliente = LogCliente.Instancia;
        public FrmBuscarCliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            LogCliente logCliente = new LogCliente();
            dtgridCliente.DataSource = logCliente.ListarClientes();
        }

        private void BuscarClientePorBRN(string brn)
        {
            // Utiliza el método de la capa lógica para buscar el cliente por BRN
            DataTable resultado = logicacliente.BuscarClientePorBRN(brn);

            // Verifica si se encontraron resultados
            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró un cliente con el BRN especificado.");
            }
            else
            {
                dtgridCliente.DataSource = resultado;
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBRN.Text))
            {
                MessageBox.Show("Por favor, ingresa el BRN para buscar el cliente");
                return;
            }

            BuscarClientePorBRN(txtBRN.Text);
            Limpiar();
        }

        private void Limpiar()
        {
            txtBRN.Text = "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dtgridCliente.SelectedRows.Count > 0)
            {
                // Obtener el clienteid de la fila seleccionada
                int clienteid = Convert.ToInt32(dtgridCliente.SelectedRows[0].Cells["clienteid"].Value);

                // Llamar al método de la Capa Lógica para obtener el cliente
                EntCliente cliente = LogCliente.Instancia.ObtenerClientePorId(clienteid);

                // Usar la instancia actual de FrmDetalleCliente para actualizar los TextBox
                FrmRegistroOrdenPedido frmDetalle = (FrmRegistroOrdenPedido)Application.OpenForms["FrmRegistroOrdenPedido"];
                if (frmDetalle != null)
                {
                    frmDetalle.LlenarTextBox(cliente); // Llamadada de actualización de textbox
                }
                else
                {
                    MessageBox.Show("El formulario de Orden Pedido no está abierto. " +
                        "Por lo tanto no puede hacer el llamado de un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

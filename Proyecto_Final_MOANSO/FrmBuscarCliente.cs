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
        private LogicaCliente logicacliente = LogicaCliente.Instancia;

        public FrmBuscarCliente()
        {

            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dtgridCliente.DataSource = logicacliente.ListarClientes();
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}

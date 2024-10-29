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
        public FrmBuscarCliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        string connectionString = "Data Source=localhost;Initial Catalog=DB_SistemaVenta;Integrated Security=True;";
        private void CargarClientes()
        {
            string query = "SELECT ClienteId, BRN, Nombre, Direccion FROM Cliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgridCliente.DataSource = table;
            }
        }
        private void BuscarClientePorBRN(string brn)
        {
            string query = "SELECT ClienteId, BRN, Nombre, Direccion FROM Cliente WHERE BRN = @BRN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BRN", brn);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Verifica si se encontraron resultados
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró un cliente con el BRN especificado.");
                        return;
                    }

                    dtgridCliente.DataSource = table;
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBRN.Text))
            {
                MessageBox.Show("Por favor, ingresa el BRN para buscar el cliente.");
                return;
            }

            BuscarClientePorBRN(txtBRN.Text);
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void Limpiar()
        {
            txtBRN.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

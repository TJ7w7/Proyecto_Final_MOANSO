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
        public FrmCliente()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string query = "INSERT INTO Cliente (BRN, Nombre, Direccion) VALUES (@BRN, @Nombre, @Direccion)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BRN", txtBRN.Text);
                command.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                command.Parameters.AddWithValue("@Direccion", txtdireccion.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Cliente registrado correctamente.");

            Limpiar();
            CargarClientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteIdSeleccionado != 0) // Asegurarse de que hay un cliente seleccionado
            {
                ModificarCliente(clienteIdSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para modificar.");
            }
            Limpiar();
            CargarClientes();
        }

        private int clienteIdSeleccionado;



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (clienteIdSeleccionado != 0) // Verificar que hay un cliente seleccionado
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
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.");
            }
        }

        private void dtgridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgridCliente.Rows[e.RowIndex];

                clienteIdSeleccionado = Convert.ToInt32(row.Cells["ClienteId"].Value);

                // Mostrar los valores en los textbox
                txtBRN.Text = row.Cells["BRN"].Value.ToString();
                txtnombre.Text = row.Cells["Nombre"].Value.ToString();
                txtdireccion.Text = row.Cells["Direccion"].Value.ToString();
            }
        }
        // Método para modificar un cliente existente
        private void ModificarCliente(int clienteId)
        {
            string query = "UPDATE Cliente SET BRN = @BRN, Nombre = @Nombre, Direccion = @Direccion WHERE ClienteId = @ClienteId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Asignación de parámetros
                command.Parameters.AddWithValue("@BRN", txtBRN.Text);
                command.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                command.Parameters.AddWithValue("@Direccion", txtdireccion.Text);
                command.Parameters.AddWithValue("@ClienteId", clienteId);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Cliente modificado correctamente.");
        }

        private void EliminarCliente(int clienteId)
        {
            string deleteQuery = "DELETE FROM Cliente WHERE ClienteId = @ClienteId";
            string reseedQuery = "DBCC CHECKIDENT ('Cliente', RESEED, 0)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ClienteId", clienteId);
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Verificar si la tabla está vacia
            int count;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string countQuery = "SELECT COUNT(*) FROM Cliente";
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            // Si la tabla está vacia, reiniciar el identity de sql
            if (count == 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(reseedQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cliente eliminado correctamente.");
            Limpiar();
            CargarClientes();
        }
        private void Limpiar()
        {
            txtBRN.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBRN.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtdireccion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar");
                return false;
            }
            return true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
            dgvBuscarProducto.Columns.Clear();
            dgvBuscarProducto.Columns.Add("ProductoId", "ID");
            dgvBuscarProducto.Columns.Add("Nombre", "Nombre");
            dgvBuscarProducto.Columns.Add("CategoriaId", "Categoría");
            dgvBuscarProducto.Columns.Add("SaboresId", "Sabor");
            dgvBuscarProducto.Columns.Add("Stock", "Stock");
            dgvBuscarProducto.Columns.Add("Descontinuado", "Descontinuado");
            dgvBuscarProducto.Columns.Add("Imagen", "Imagen");

            CargarProductos();
            dgvBuscarProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.CenterToScreen();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreBusqueda = txtNomBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreBusqueda))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para buscar.");
                    return;
                }

                var productos = LogProducto.Instancia.BuscarProductoPorNombre(nombreBusqueda);

                dgvBuscarProducto.Rows.Clear();

                foreach (var producto in productos)
                {
                    dgvBuscarProducto.Rows.Add(producto.Productoid, producto.Nombre, producto.CategoriaId, producto.SaboresId, producto.Stock, producto.Descontinuado, producto.Imagen);
                }

                if (productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos que coincidan con el nombre.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void CargarProductos()
        {
            try
            {
                // Conexión a la base de datos
                string connectionString = "Data Source=DESKTOP-KESOU6D\\SQLEXPRESS; Initial Catalog=DB_SistemaVenta; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                ProductoId, 
                                Nombre, 
                                CategoriaId, 
                                SaboresId, 
                                Stock, 
                                Descontinuado, 
                                Imagen 
                             FROM Producto";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    // Limpia las filas existentes en el DataGridView
                    dgvBuscarProducto.Rows.Clear();

                    // Agrega los productos al DataGridView
                    while (dr.Read())
                    {
                        dgvBuscarProducto.Rows.Add(
                            dr["ProductoId"],
                            dr["Nombre"],
                            dr["CategoriaId"],
                            dr["SaboresId"],
                            dr["Stock"],
                            (bool)dr["Descontinuado"] ? "Sí" : "No",
                            dr["Imagen"] // Puedes manejar la visualización de imágenes aquí
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }

        private void btnCerrarBP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

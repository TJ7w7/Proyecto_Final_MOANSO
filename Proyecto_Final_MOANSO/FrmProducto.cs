using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            gbDatos.Enabled = false;
            dgvProductos.Enabled = false;
            // Agregar columnas del DataGridView
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("ProductoId", "ID");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("CategoriaId", "Categoría");
            dgvProductos.Columns.Add("SaboresId", "Sabor");
            dgvProductos.Columns.Add("Stock", "Stock");
            dgvProductos.Columns.Add("Descontinuado", "Descontinuado");
            dgvProductos.Columns.Add("Imagen", "Imagen");

            // Agregar las opciones predeterminadas a los ComboBox
            cmbCategoria.Items.Clear();
            cmbSabores.Items.Clear();

            cmbCategoria.Items.Add("Seleccione una Categoría");
            cmbSabores.Items.Add("Seleccione Sabor de Producto");

            cmbCategoria.SelectedIndex = 0;
            cmbSabores.SelectedIndex = 0;

            CargarProductos();
            CargarCombos();
            dgvProductos.RowHeaderMouseClick += (dgvProductos_RowHeaderMouseClick);

            this.CenterToScreen();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedValue == null || cmbSabores.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoría y un sabor.");
                    return;
                }

                EntProducto producto = new EntProducto
                {
                    Nombre = txtNombreProducto.Text,
                    CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue),
                    SaboresId = Convert.ToInt32(cmbSabores.SelectedValue),
                    Stock = Convert.ToInt32(txtStockProductos.Text),
                    Descontinuado = cbEstadoProducto.Checked,
                    Imagen = ConvertirImagenABytes(pbxImagen.Image)

                };

                if (LogProducto.Instancia.GuardarProducto(producto))
                {
                    MessageBox.Show("Producto guardado correctamente.");
                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Seleccionar imagen";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Carga la imagen seleccionada en el PictureBox
                        pbxImagen.Image = Image.FromFile(openFileDialog.FileName);
                        pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }
        private void btnModificarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedValue == null || cmbSabores.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoría y un sabor.");
                    return;
                }

                EntProducto producto = new EntProducto
                {
                    Productoid = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ProductoId"].Value),
                    Nombre = txtNombreProducto.Text,
                    CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue),
                    SaboresId = Convert.ToInt32(cmbSabores.SelectedValue),
                    Stock = Convert.ToInt32(txtStockProductos.Text),
                    Descontinuado = cbEstadoProducto.Checked,
                    Imagen = ConvertirImagenABytes(pbxImagen.Image) // Convierte la imagen seleccionada
                };

                // Actualiza el producto en la base de datos
                if (LogProducto.Instancia.ModificarProducto(producto))
                {
                    MessageBox.Show("Producto modificado correctamente.");
                    CargarProductos(); // Refresca el DataGridView
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0) // Verifica que se haya seleccionado una fila
                {
                    // Confirmación de eliminación
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Obtener el ProductoId de la fila seleccionada
                        int productoId = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value); // Suponiendo que la columna 0 es ProductoId

                        // Llamar al método en la capa lógica para eliminar el producto
                        if (LogProducto.Instancia.EliminarProducto(productoId))
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                            CargarProductos(); // Recargar los productos para reflejar la eliminación
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            dgvProductos.Enabled = true;
        }
        private void btnDeshabilitarProductos_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            dgvProductos.Enabled = false;
        }
        private void btnSalirFrmProducto_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    dgvProductos.Rows.Clear();

                    // Agrega los productos al DataGridView
                    while (dr.Read())
                    {
                        dgvProductos.Rows.Add(
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

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void CargarCombos()
        {
            try
            {
                // Suponiendo que ya tienes un método para obtener las categorías
                List<EntCategoria> categorias = LogCategoria.Instancia.ObtenerCategoriasCMB();
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría
                cmbCategoria.ValueMember = "CategoriaId";  // El valor asociado será el CategoriaId

                // Suponiendo que ya tienes un método para obtener los sabores
                List<EntSabores> sabores = LogSabores.Instancia.ObtenerSaboresCMB();
                cmbSabores.DataSource = sabores;
                cmbSabores.DisplayMember = "Nombre";  // Mostrar el nombre del sabor
                cmbSabores.ValueMember = "SaboresId";  // El valor asociado será el SaboresId
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en los combobox: {ex.Message}");
            }
        }
        private Image ConvertirBytesAImagen(byte[] imagenBytes)
        {
            if (imagenBytes == null || imagenBytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void dgvProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no se seleccionen encabezados
            {
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                // Verificar si el valor de la celda es null o DBNull antes de asignar
                txtNombreProducto.Text = filaSeleccionada.Cells[1].Value != DBNull.Value && filaSeleccionada.Cells[1].Value != null
                    ? filaSeleccionada.Cells[1].Value.ToString() : string.Empty;

                cmbCategoria.SelectedValue = filaSeleccionada.Cells[2].Value != DBNull.Value && filaSeleccionada.Cells[2].Value != null
                    ? Convert.ToInt32(filaSeleccionada.Cells[2].Value) : 0;

                cmbSabores.SelectedValue = filaSeleccionada.Cells[3].Value != DBNull.Value && filaSeleccionada.Cells[3].Value != null
                    ? Convert.ToInt32(filaSeleccionada.Cells[3].Value) : 0;

                txtStockProductos.Text = filaSeleccionada.Cells[4].Value != DBNull.Value && filaSeleccionada.Cells[4].Value != null
                    ? filaSeleccionada.Cells[4].Value.ToString() : string.Empty;

                cbEstadoProducto.Checked = filaSeleccionada.Cells[5].Value != DBNull.Value && filaSeleccionada.Cells[5].Value != null
                    && filaSeleccionada.Cells[5].Value.ToString() == "Sí";

                // Verificar y cargar la imagen si está disponible
                if (filaSeleccionada.Cells[6].Value != DBNull.Value && filaSeleccionada.Cells[6].Value != null)
                {
                    byte[] imagenBytes = (byte[])filaSeleccionada.Cells[6].Value;
                    pbxImagen.Image = ConvertirBytesAImagen(imagenBytes);
                }
                else
                {
                    pbxImagen.Image = null; // Si no hay imagen, puedes limpiar la imagen
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            cmbCategoria.SelectedIndex = -1; // Desmarcar cualquier selección
            cmbSabores.SelectedIndex = -1; // Desmarcar cualquier selección
            txtStockProductos.Clear();
            cbEstadoProducto.Checked = false; // Desmarcar el checkbox
            pbxImagen.Image = null; // Limpiar la imagen
        }

    }
}

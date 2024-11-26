using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            CargarProducto();
            CargarCategoria();
            CargarSabores();
            CargarMarca();
        }
        public void CargarTipoProducto()
        {
            dgvTipoPresentaciones.DataSource= LogTipoPresentacion.Instancia.ListarTipoPresentacion(int.Parse(id));
        }

        public void CargarProducto()
        {
            dgvProducto.DataSource = LogProducto.Instancia.ListarProducto();
            dgvProducto.Columns["MarcaId"].Visible = false;
            dgvProducto.Columns["CategoriaId"].Visible = false;
            dgvProducto.Columns["SaboresId"].Visible = false;
            dgvProducto.Columns["Imagen"].Visible = false;

            dgvProducto.Columns["ProductoId"].DisplayIndex = 0;
            dgvProducto.Columns["Codigo"].DisplayIndex = 1;
            dgvProducto.Columns["Codigo"].DisplayIndex = 2;
            dgvProducto.Columns["MarcaId"].DisplayIndex = 3;
            dgvProducto.Columns["Marca"].DisplayIndex = 4;
            dgvProducto.Columns["Categoria"].DisplayIndex = 5;
            dgvProducto.Columns["SaboresId"].DisplayIndex = 6;
            dgvProducto.Columns["Sabores"].DisplayIndex = 7;
            dgvProducto.Columns["Descripcion"].DisplayIndex = 8;
            dgvProducto.Columns["Imagen"].DisplayIndex = 9;
            dgvProducto.Columns["Estado"].DisplayIndex = 10;
        }
        public void CargarMarca()
        {
            cbMarca.DataSource = LogMarca.Instancia.listarMarca();
            cbMarca.DisplayMember = "Nombre";
            cbMarca.ValueMember = "MarcaId";

            cbMarca.SelectedIndex = -1;
        }

        public void CargarCategoria()
        {
            cbCategoria.DataSource = LogCategoria.Instancia.listarCategoria();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "CategoriaId";

            cbCategoria.SelectedIndex = -1;
        }

        public void CargarSabores()
        {
            cbSabores.DataSource = LogSabores.Instancia.listarSabores();
            cbSabores.DisplayMember = "Nombre";
            cbSabores.ValueMember = "SaboresId";

            cbSabores.SelectedIndex = -1;
        }

        public void LimpiarProducto()
        {
            txtCodigo.Text = "";
            cbMarca.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbSabores.SelectedIndex = -1;
            txtDescripcionProducto.Text = "";
            cbxEstado.Checked = false;
        }
        public void LimpiarTipoPresentacion()
        {
            txtTipoPresentacion.Text = "";
            txtStock.Text = "";
            txtPrecioConIGV.Text = "";
            txtPrecioSinIGV.Text = "";
            txtPesoPresentacion.Text = "";
            txtLargo.Text = "";
            txtAncho.Text = "";
            txtAlto.Text = "";
            cbxEstado.Checked = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pbImagen.Image != null)
            {
                string rutaImagen = ofdImagen.FileName;
                string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string carpetaDestino = Path.Combine(carpeta, "Imagenes_DB");

                Directory.CreateDirectory(carpetaDestino);

                string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                File.Copy(rutaImagen, imagenDestino);

                try
                {
                    EntProducto p = new EntProducto();
                    p.Codigo = txtCodigo.Text;
                    p.MarcaId = int.Parse(cbMarca.SelectedValue.ToString());
                    p.CategoriaId = int.Parse(cbCategoria.SelectedValue.ToString());
                    p.SaboresId = int.Parse(cbSabores.SelectedValue.ToString());
                    p.Descripcion = txtDescripcionProducto.Text;
                    p.Imagen = rutaImagen;
                    p.Estado = cbxEstado.Checked;
                    LogProducto.Instancia.InsertarProducto(p);
                    CargarProducto();
                    LimpiarProducto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una imagen");
            }
        }
        public string id;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Porfavor Seleccione un elemento", "Error");
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text)) // Verificar que hay un producto seleccionado
                {
                    try
                    {
                        // Crear instancia del producto
                        EntProducto p = new EntProducto();
                        p.ProductoId = int.Parse(id);
                        p.Codigo = txtCodigo.Text;
                        p.MarcaId = int.Parse(cbMarca.SelectedValue.ToString());
                        p.CategoriaId = int.Parse(cbCategoria.SelectedValue.ToString());
                        p.SaboresId = int.Parse(cbSabores.SelectedValue.ToString());
                        p.Descripcion = txtDescripcionProducto.Text;
                        p.Estado = cbxEstado.Checked;

                        // Verificar si hay una nueva imagen seleccionada
                        if (ofdImagen.FileName != null && File.Exists(ofdImagen.FileName))
                        {
                            string rutaImagen = ofdImagen.FileName;
                            string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            string carpetaDestino = Path.Combine(carpeta, "Imagenes_DB");

                            Directory.CreateDirectory(carpetaDestino);

                            string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                            File.Copy(rutaImagen, imagenDestino, true); // Sobrescribir si existe
                            p.Imagen = imagenDestino; // Actualizar la ruta de la imagen
                        }

                        // Llamar al método para actualizar el producto
                        LogProducto.Instancia.EditarProducto(p);

                        // Recargar la lista de productos y limpiar los campos
                        CargarProducto();
                        LimpiarProducto();

                        MessageBox.Show("Producto actualizado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para editar.");
                }
                //CargarProducto();
                //LimpiarProducto();
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtCodigo.Text = filaActual.Cells[1].Value.ToString();
            int marcaIdId = int.Parse(filaActual.Cells[2].Value.ToString());
            int categoriaId = int.Parse(filaActual.Cells[3].Value.ToString());
            int saboresId = int.Parse(filaActual.Cells[4].Value.ToString());
            txtDescripcionProducto.Text = filaActual.Cells[5].Value.ToString();
            string imagen = filaActual.Cells[6].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);

            cbMarca.SelectedValue = marcaIdId;
            cbCategoria.SelectedValue = categoriaId;
            cbSabores.SelectedValue = saboresId;
            pbImagen.Image = Image.FromFile(imagen);
            
            CargarTipoProducto();
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            ofdImagen.Filter = "Archivos de Imagen | *.jpg; *.png; *.jpeg";
            try
            {
                if (ofdImagen.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ofdImagen.FileName;
                    pbImagen.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            EntTipoPresentacion p = new EntTipoPresentacion();
            p.ProductoId = int.Parse(id);
            p.TipoPresentacion = txtTipoPresentacion.Text;
            p.Stock = int.Parse(txtStock.Text);
            p.PrecioConIGV = decimal.Parse(txtPrecioConIGV.Text);
            p.PrecioSinIGV = decimal.Parse(txtPrecioSinIGV.Text);
            p.Peso = decimal.Parse(txtPesoPresentacion.Text);
            p.Largo = int.Parse(txtLargo.Text);
            p.Ancho = int.Parse(txtAncho.Text);
            p.Alto = int.Parse(txtAlto.Text);
            p.Estado = cbxEstado.Checked;
            LogTipoPresentacion.Instancia.InsertarTipoPresentacion(p);
            CargarTipoProducto();
        }
    }
}

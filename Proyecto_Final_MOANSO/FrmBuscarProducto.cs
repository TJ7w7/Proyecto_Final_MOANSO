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
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
            CargaraProductos();
        }
        public string Codigo { get; private set; }
        public string Descripcion { get; private set; }
        public string TipoPresentacionId { get; private set; }
        public string TipoPresentacion { get; private set; }
        public string PrecioConIGV { get; private set; }
        public string PrecioSinIGV { get; private set; }
        public string Peso { get; private set; }
        public string Largo { get; private set; }
        public string Ancho { get; private set; }
        public string Alto { get; private set; }

        public void CargaraProductos()
        {
            dgvProductos.DataSource = LogProducto.Instancia.ListarProductoTipoPresentaciones();

            dgvProductos.Columns["MarcaId"].Visible = false;
            dgvProductos.Columns["Marca"].Visible = false;
            dgvProductos.Columns["CategoriaId"].Visible = false;
            dgvProductos.Columns["Categoria"].Visible = false;
            dgvProductos.Columns["SaboresId"].Visible = false;
            dgvProductos.Columns["Sabores"].Visible = false;
            dgvProductos.Columns["Imagen"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            dgvProductos.Columns["TipoPresentacionId"].Visible = false;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];
            Codigo = filaSeleccionada.Cells[1].Value.ToString();
            Descripcion = filaSeleccionada.Cells[5].Value.ToString();
            TipoPresentacionId = filaSeleccionada.Cells[8].Value.ToString();
            TipoPresentacion = filaSeleccionada.Cells[9].Value.ToString();
            PrecioConIGV = filaSeleccionada.Cells[10].Value.ToString();
            PrecioSinIGV = filaSeleccionada.Cells[11].Value.ToString();
            Peso = filaSeleccionada.Cells[12].Value.ToString();
            Largo = filaSeleccionada.Cells[13].Value.ToString();
            Ancho = filaSeleccionada.Cells[14].Value.ToString();
            Alto = filaSeleccionada.Cells[15].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TipoPresentacionId))
            {
                MessageBox.Show("Debe Seleccionar un elemento");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

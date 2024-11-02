using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_MOANSO.FrmRegistroOrdenPedido;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmRegistroOrdenPedido : Form
    {
        public FrmRegistroOrdenPedido()
        {
            InitializeComponent();

            txtBRN_RUC.Text = "de la Empresa";
            txtNombre.Text = "de la Empresa";
            txtNumTelef.Text = "teléfono de la Empresa";

            txtBRN_RUC.KeyPress += new KeyPressEventHandler(txtRUC_KeyPress);
            txtNumTelef.KeyPress += new KeyPressEventHandler(txtNúmero_KeyPress);
            txtBRN_RUC.MaxLength = 10;
        }

        private void CargarDatosEnDataGridView()
        {
            List<EntPedido> pedidos = ObtenerListaDePedidos(); // Puedes obtenerla de otra fuente si es necesario
            dgvOrdenPedido.DataSource = pedidos;
        }

        private List<EntPedido> ObtenerListaDePedidos()
        {
            // Aquí puedes obtener datos de prueba o consultar la base de datos más adelante
            return new List<EntPedido>
            {
            new EntPedido { IDPedido = 1, RUC = 123456, Nombre = "Cliente 1", 
                Region = "Región 1", Celular = 987654321, IDProducto = 101, 
                Categoria = "Categoría 1", Producto = "Producto 1", Cantidad = 5, 
                Precio = 100, CalleCorea = "Calle 1", EstadodelPedido = true },
            };
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscarProducto = new FrmBuscarProducto();
            buscarProducto.Show();
        }

        // Permitir solo números
        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNúmero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRUC_Click(object sender, EventArgs e)
        {
            txtBRN_RUC.Text = string.Empty;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscarCliente = new FrmBuscarCliente();
            buscarCliente.Show();
        }

        private void FrmRegistroOrdenPedido_Load(object sender, EventArgs e)
        {

        }
    }
}

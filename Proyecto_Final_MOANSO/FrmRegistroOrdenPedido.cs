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
            InitializeComboBox();

            txtBRN.Enabled = false;
            txtNombre.Enabled = false;
            txtNumTelef.Enabled = false;
            CbNumReg.Enabled = false;
            CbNumReg.SelectedIndex = -1;

            txtBRN.Text = "de la Empresa";
            txtNombre.Text = "de la Empresa";
            txtNumTelef.Text = "teléfono de la Empresa";
            CbNumReg.Text = "de la Región";

            txtBRN.KeyPress += new KeyPressEventHandler(txtRUC_KeyPress);
            txtNumTelef.KeyPress += new KeyPressEventHandler(txtNúmero_KeyPress);
            txtBRN.MaxLength = 10; // Limitar la entrada a 10 caracteres
        }

        public class Region
        {
            public string Nombre { get; set; }
            public int Numero { get; set; }

            public override string ToString()
            {
                return Numero.ToString();
            }
        }

        private void InitializeComboBox()
        {
            // Crear una lista de regiones y sus números
            List<Region> regiones = new List<Region>
            {
                new Region { Nombre = "Busan", Numero = 1 },
                new Region { Nombre = "Chungcheong del Norte", Numero = 2 },
                new Region { Nombre = "Chungcheong del Sur", Numero = 3 },
                new Region { Nombre = "Daegu", Numero = 4 },
                new Region { Nombre = "Daejeon", Numero = 5 },
                new Region { Nombre = "Gangwon", Numero = 6 },
                new Region { Nombre = "Gwangju", Numero = 7 },
                new Region { Nombre = "Gyeonggi", Numero = 8 },
                new Region { Nombre = "Gyeongsang del Norte", Numero = 9 },
                new Region { Nombre = "Gyeongsang del Sur", Numero = 10 },
                new Region { Nombre = "Incheon", Numero = 11 },
                new Region { Nombre = "Jeju", Numero = 12 },
                new Region { Nombre = "Jeolla del Norte", Numero = 13 },
                new Region { Nombre = "Jeolla del Sur", Numero = 14 },
                new Region { Nombre = "Sejong", Numero = 15 },
                new Region { Nombre = "Seúl", Numero = 16 },
                new Region { Nombre = "Ulsan", Numero = 17 }
            };
            CbNumReg.DataSource = regiones;
            CbNumReg.DisplayMember = "Nombre";
            CbNumReg.ValueMember = "Numero";

            CbNumReg.SelectedIndexChanged += CbNumReg_SelectedIndexChanged;
        }

        private void CbNumReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbNumReg.SelectedItem is Region selected)
            {
                // Actualizar el ComboBox para mostrar el número de la región
                CbNumReg.Text = selected.Numero.ToString(); // Mostrar el número
            }
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
            txtBRN.Text = string.Empty;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void txtNúmero_Click(object sender, EventArgs e)
        {
            txtNumTelef.Text = string.Empty;
        }
    }
}

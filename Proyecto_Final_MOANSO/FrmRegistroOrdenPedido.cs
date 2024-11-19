using CapaEntidad;
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
        }

        private void MostrarNombreDivision(int idDivision)
        {
            // Llama a la capa lógica para obtener el nombre de la división
            string nombreDivision = LogDivisionesAdministrativas.Instancia.ObtenerNombreDivisionPorId(idDivision);

            // Muestra el nombre en txtRegionDes o un mensaje si el ID no tiene nombre asociado
            if (!string.IsNullOrEmpty(nombreDivision))
            {
                txtRegionDes.Text = nombreDivision;
            }
            else
            {
                txtRegionDes.Text = "División no encontrada";
            }
        }

        public void LlenarTextBox(EntCliente cliente)
        {
            //txtcliid.Text = cliente.ClienteId.ToString();
            //txtBRN_RUC.Text = cliente.BRN_RUC;
            //txtNombreCli.Text = cliente.Nombre;
            //txtIdRegion.Text = cliente.DivisionesAdministrativasId.ToString();
            //txtCalleDes.Text = cliente.Direccion;
            //txtNumTelef.Text = cliente.NumeroContacto;
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //FrmBuscarCliente buscarCliente = new FrmBuscarCliente();
            //buscarCliente.Show();
        }

        private void txtIdRegion_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdRegion.Text, out int idDivision))
            {
                MostrarNombreDivision(idDivision);
            }
            else
            {
                txtRegionDes.Text = "";
            }
        }
    }
}

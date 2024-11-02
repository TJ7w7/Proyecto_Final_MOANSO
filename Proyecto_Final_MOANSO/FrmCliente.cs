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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            CargarRegiones();
            CargarClientes();
            cbRegCli.SelectedIndex = -1;
            txtBRN_RUC.Enabled = false;

            radioRUC.CheckedChanged += radioBRN_CheckedChanged;
            radioBRN.CheckedChanged += radioBRN_CheckedChanged;
        }

        private void CargarRegiones()
        {
            try
            {
                List<string> nombres = LogDivisionesAdministrativas.Instancia.ObtenerNombres();
                cbRegCli.DataSource = nombres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtBRN_RUC_TextChanged(object sender, EventArgs e)
        {
            if (radioRUC.Checked)
            {
                FormatearComoRUC();
            }
            else if (radioBRN.Checked)
            {
                FormatearComoBRN();
            }
        }

        private void radioBRN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRUC.Checked || radioBRN.Checked)
            {
                txtBRN_RUC.Clear();
                txtBRN_RUC.Enabled = true;
            }
            else
            {
                txtBRN_RUC.Enabled = false;
            }
        }

        private void FormatearComoRUC()
        {
            string formatoRUC = txtBRN_RUC.Text;
            formatoRUC = new string(formatoRUC.Where(char.IsDigit).ToArray()); 
            if (formatoRUC.Length > 10)
            {
                formatoRUC = formatoRUC.Substring(0, 10); 
            }
            txtBRN_RUC.Text = formatoRUC;
            txtBRN_RUC.SelectionStart = formatoRUC.Length;
        }

        private void FormatearComoBRN()
        {
            // Formato (XXX-XX-XXXXX)
            string formatoBRN = txtBRN_RUC.Text;
            formatoBRN = new string(formatoBRN.Where(char.IsDigit).ToArray()); 

            if (formatoBRN.Length > 10)
            {
                formatoBRN = formatoBRN.Substring(0, 10); 
            }

            // Insertar guiones
            if (formatoBRN.Length > 3)
            {
                formatoBRN = formatoBRN.Insert(3, "-");
            }
            if (formatoBRN.Length > 6)
            {
                formatoBRN = formatoBRN.Insert(6, "-");
            }

            txtBRN_RUC.Text = formatoBRN;
            txtBRN_RUC.SelectionStart = formatoBRN.Length; 
        }

        private void txtNumCli_TextChanged(object sender, EventArgs e)
        {
            //formato de número telefónico
            string telefono = txtNumCli.Text.Replace(" ", "").Replace("+82","").Trim();

            //Generar espacios
            if (telefono.Length > 0)
            {
                telefono = $"+82 {telefono}";
                if (telefono.Length > 6) 
                {
                    telefono = telefono.Insert(6, " "); 
                }

                if (telefono.Length > 11) 
                {
                    telefono = telefono.Insert(11, " ");
                }
            }

            if (telefono.Length > 16)
            {
                telefono = telefono.Substring(0, 16);
            }

            txtNumCli.Text = telefono;
            txtNumCli.SelectionStart = telefono.Length;
        }
        private void cbRegCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRegCli.SelectedItem != null)
            {
                string region = cbRegCli.SelectedItem.ToString();
                int CodigoDeArea = LogDivisionesAdministrativas.Instancia.ObtenerCodigoDeArea(region);

                // Establece el código de área
                txtNumCli.Text = $"+82 {CodigoDeArea} ";
            }
            else
            {
                txtNumCli.Text = ""; 
            }
        }

        private void txtNumCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarClientes()
        {
            LogCliente logCliente = new LogCliente();
            dgvClientesRegistrados.DataSource = logCliente.ListarClientes();
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            try
            {
                string brnRuc = txtBRN_RUC.Text;
                string nombre = txtNombre.Text;
                int divisionesAdministrativasId = Convert.ToInt32(cbRegCli.SelectedValue);
                string direccion = txtDireccion.Text;
                string numeroContacto = txtNumCli.Text;

                LogCliente logCliente = new LogCliente();
                logCliente.AgregarCliente(brnRuc, nombre, divisionesAdministrativasId, direccion, numeroContacto);

                MessageBox.Show("Cliente registrado exitosamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtBRN_RUC.Clear();
            txtNombre.Clear();
            cbRegCli.SelectedIndex = -1; 
            txtDireccion.Clear();
            txtNumCli.Clear();
        }
    }
}

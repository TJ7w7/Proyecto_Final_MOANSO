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

namespace Proyecto_Final_MOANSO
{
    public partial class FrmFormasDePago : Form
    {
        public FrmFormasDePago()
        {
            InitializeComponent();
            CargarFormasDePago();
        }

        public void CargarFormasDePago()
        {
            dgvFormasDePago.DataSource = LogFormasDePago.Instancia.listarFormasDePago();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            cbxClienteExtranjero.Checked = false;
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntFormasDePago fp = new EntFormasDePago();
                    fp.Nombre = txtNombre.Text;
                    fp.ClienteExtranjero = cbxClienteExtranjero.Checked;
                    fp.Estado = cbxEstado.Checked;
                    LogFormasDePago.Instancia.InsertarFormasDePago(fp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarFormasDePago();
                Limpiar();
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
                try
                {
                    EntFormasDePago fp = new EntFormasDePago();
                    fp.FormasDePagoId = int.Parse(id);
                    fp.Nombre = txtNombre.Text;
                    fp.ClienteExtranjero = cbxClienteExtranjero.Checked;
                    fp.Estado = cbxEstado.Checked;
                    LogFormasDePago.Instancia.EditarFormasDePago(fp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarFormasDePago();
                Limpiar();
            }
        }

        private void dgvFormasDePago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvFormasDePago.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cbxClienteExtranjero.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}
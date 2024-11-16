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
    public partial class FrmMoneda : Form
    {
        public FrmMoneda()
        {
            InitializeComponent();
            CargarMoneda();
        }
        public void CargarMoneda()
        {
            dgvMoneda.DataSource = LogSabores.Instancia.listarSabores();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtCodigoIso.Text = "";
            txtTasaCambio.Text = "";
            cbxEstado.Checked = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtCodigoIso.Text == "" && txtTasaCambio.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntMoneda mon = new EntMoneda();
                    mon.CodigoISO = txtCodigoIso.Text;
                    mon.Nombre = txtNombre.Text;
                    mon.TasaCambio = decimal.Parse(txtTasaCambio.Text);
                    mon.FechaActualizacion = DateTime.Parse(dtpFechaActualizacion.Text);
                    mon.Estado = cbxEstado.Checked;
                    LogMoneda.Instancia.InsertarMoneda(mon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarMoneda();
                Limpiar();
            }
        }
        public string id;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Porfavor Seleccione un elemento", "Error");
            }
            else
            {
                try
                {
                    EntMoneda mon = new EntMoneda();
                    mon.MonedaId = int.Parse(id);
                    mon.CodigoISO = txtCodigoIso.Text;
                    mon.Nombre = txtNombre.Text;
                    mon.TasaCambio = decimal.Parse(txtTasaCambio.Text);
                    mon.FechaActualizacion = DateTime.Parse(dtpFechaActualizacion.Text);
                    mon.Estado = cbxEstado.Checked;
                    LogMoneda.Instancia.InsertarMoneda(mon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarMoneda();
                Limpiar();
            }
        }
        private void dgvMoneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMoneda.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtCodigoIso.Text = filaActual.Cells[2].Value.ToString();
            txtTasaCambio.Text = filaActual.Cells[3].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
    }
}

using CapaEntidad;
using CapaLogica;
using System;
using System.Collections;
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
    public partial class FrmPais : Form
    {
        public FrmPais()
        {
            InitializeComponent();
            CargarPais();
            CargarMonedas();

        }
        public void CargarMonedas()
        {
            cbMoneda.DataSource = LogMoneda.Instancia.listarMoneda();
            cbMoneda.DisplayMember= "CodigoISO";
            cbMoneda.ValueMember = "MonedaId";

            cbMoneda.SelectedIndex = -1;
        }

        public void CargarPais()
        {
            dgvPais.DataSource = LogPais.Instancia.listarPais();
            dgvPais.Columns["MonedaId"].Visible = false;

            dgvPais.Columns["PaisId"].DisplayIndex = 0;
            dgvPais.Columns["MonedaId"].DisplayIndex = 1;
            dgvPais.Columns["Nombre"].DisplayIndex = 2;
            dgvPais.Columns["CodigoISO"].DisplayIndex = 3;
            dgvPais.Columns["CodigoTelefono"].DisplayIndex = 4;
            dgvPais.Columns["NombreMoneda"].DisplayIndex = 5;
            dgvPais.Columns["Estado"].DisplayIndex = 6;


            ////Elimina las columnas y las crea, podiendo asiganar nombre a las columnas y el orden
            //dgvPais.Columns.Clear();

            //// Crear columnas en el orden deseado
            //dgvPais.Columns.Add("Nombre", "Nombre");
            //dgvPais.Columns.Add("CodigoISO", "Código ISO");
            //dgvPais.Columns.Add("CodigoTelefono", "Código Teléfono");
            //dgvPais.Columns.Add("NombreMoneda", "Nombre Moneda");

            //// Asignar datos
            //foreach (var pais in LogPais.Instancia.listarPais())
            //{
            //    dgvPais.Rows.Add(pais.Nombre, pais.CodigoISO, pais.CodigoTelefono, pais.NombreMoneda);
            //}

        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtCodigoIso.Text = "";
            txtCodigoTelefono.Text = "";
            cbxEstado.Checked = false;
            cbMoneda.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtCodigoIso.Text == "" && txtCodigoTelefono.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntPais pa = new EntPais();
                    pa.CodigoISO = txtCodigoIso.Text;
                    pa.Nombre = txtNombre.Text;
                    pa.CodigoISO = txtCodigoIso.Text;
                    pa.CodigoTelefono = txtCodigoTelefono.Text;
                    pa.MonedaId = int.Parse(cbMoneda.SelectedValue.ToString());
                    pa.Estado = cbxEstado.Checked;
                    LogPais.Instancia.InsertarPais(pa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarPais();
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
                    EntPais pa = new EntPais();
                    pa.PaisId = int.Parse(id);
                    pa.Nombre = txtNombre.Text;
                    pa.CodigoISO = txtCodigoIso.Text;
                    pa.CodigoTelefono = txtCodigoTelefono.Text;
                    pa.MonedaId = int.Parse(cbMoneda.SelectedValue.ToString());
                    pa.Estado = cbxEstado.Checked;
                    LogPais.Instancia.EditarPais(pa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarPais();
                Limpiar();
            }
        }

        private void dgvPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPais.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtCodigoIso.Text = filaActual.Cells[2].Value.ToString();
            txtCodigoTelefono.Text = filaActual.Cells[3].Value.ToString();
            int monedaId = int.Parse(filaActual.Cells[4].Value.ToString());
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

            cbMoneda.SelectedValue = monedaId;
        }
    }
}

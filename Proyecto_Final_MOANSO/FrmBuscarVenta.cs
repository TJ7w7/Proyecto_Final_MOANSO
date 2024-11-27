using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmBuscarVenta : Form
    {
        public FrmBuscarVenta()
        {
            InitializeComponent();
            cargarVenta();
        }
        public void cargarVenta()
        {
            dgvVentas.DataSource = LogVenta.Instancia.ListarVenta();
        }

        public int idVenta {  get; private set; }
        public string numeroVenta { get; private set; }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvVentas.Rows[e.RowIndex];
            idVenta = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            numeroVenta = filaSeleccionada.Cells[1].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idVenta.ToString()))
            {
                MessageBox.Show("Debe Seleccionar un elemento");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

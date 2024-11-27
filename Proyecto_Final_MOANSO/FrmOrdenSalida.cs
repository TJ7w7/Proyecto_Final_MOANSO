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
    public partial class FrmOrdenSalida : Form
    {
        public FrmOrdenSalida()
        {
            InitializeComponent();
            CargarOrdenSalida();
            CargarNuemro();
        }
        public void CargarOrdenSalida()
        {
            dgvOrdenSalida.DataSource = LogOrdenSalida.Instancia.listarOrdenSalida();
        }

        public void CargarNuemro()
        {
            txtNroOrdenSalida.Text = LogOrdenSalida.Instancia.ContarFilas();
        }
        int ventaId;
        string numeroVenta;
        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            FrmBuscarVenta frmBuscarVenta = new FrmBuscarVenta();
            if (frmBuscarVenta.ShowDialog() == DialogResult.OK)
            {
                ventaId = frmBuscarVenta.idVenta;
                numeroVenta = frmBuscarVenta.numeroVenta;

                txtNroVenta.Text = numeroVenta;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EntOrdenSalida ordenSalida = new EntOrdenSalida();
            ordenSalida.NumeroOrdenSalida = txtNroOrdenSalida.Text;
            ordenSalida.VentaId = ventaId;
            ordenSalida.Fecha = DateTime.Parse(dateTimePicker1.Text);

            LogOrdenSalida.Instancia.InsertarOrdenSalidaa(ordenSalida);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

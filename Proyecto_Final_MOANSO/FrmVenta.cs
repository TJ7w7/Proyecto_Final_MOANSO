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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
            CargarVentas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroVenta frmRegistroVenta = new FrmRegistroVenta();
            frmRegistroVenta.Show();
        }

        public void CargarVentas()
        {
            dgvVenta.DataSource = LogVenta.Instancia.ListarVenta();
        }
    }
}

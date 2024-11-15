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
    public partial class FrmAsignacionTrasportista : Form
    {
        public FrmAsignacionTrasportista()
        {
            InitializeComponent();
        }

        private void btnBuscarTransportista_Click(object sender, EventArgs e)
        {
            FrmBuscarTransportista buscarTransportista = new FrmBuscarTransportista();
            buscarTransportista.Show();
        }

        private void btnBuscarOrdenPedido_Click(object sender, EventArgs e)
        {
            FrmBuscarOrdenPedido buscarOrdenPedido = new FrmBuscarOrdenPedido();
            buscarOrdenPedido.Show();
        }
    }
}

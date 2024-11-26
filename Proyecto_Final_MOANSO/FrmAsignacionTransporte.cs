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
    public partial class FrmAsignacionTransporte : Form
    {
        public FrmAsignacionTransporte()
        {
            InitializeComponent();
            cargarTipoDocumento();
            cargarAsignaciones();
        }
        public void cargarAsignaciones()
        {
            dgvAsignacionTransporte.DataSource = LogAsignacionTransporte.Instancia.ListarAsignacion();
        }
        public void cargarTipoDocumento()
        {
            cbTipoDocumento.DataSource = LogTipoDocumento.Instancia.listarTipoDocumento();
            cbTipoDocumento.DisplayMember = "Nombre";
            cbTipoDocumento.ValueMember = "TipoDocumentoId";

            cbTipoDocumento.SelectedIndex = -1;
        }
        int PedidoId;
        string Codigo;
        private void btnBuscarOrdenPedido_Click(object sender, EventArgs e)
        {
            FrmBuscarOrdenPedido buscarOrdenPedido = new FrmBuscarOrdenPedido();
            
            if(buscarOrdenPedido.ShowDialog() == DialogResult.OK)
            {
                PedidoId = buscarOrdenPedido.OrdenPedidoId;
                Codigo = buscarOrdenPedido.NumeroPedido.ToString();

                txtNroPedido.Text = Codigo;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EntConductor conductor = new EntConductor();
            conductor.TipoDocumentoId = int.Parse(cbTipoDocumento.SelectedValue.ToString());
            conductor.NumeroDocumento = txtNroDocumento.Text;
            conductor.Nombre = txtNombres.Text;
            conductor.Apellido = txtApellidos.Text;
            conductor.licencia = txtLicencia.Text;

            int conductorid = LogAsignacionTransporte.Instancia.InsertarConductor(conductor);

            EntVehiculo vehiculo = new EntVehiculo();
            vehiculo.TipoVehiculo = txtTipoVehiculo.Text;
            vehiculo.Matricula = txtMatricula.Text;

            int vehiculoid = LogAsignacionTransporte.Instancia.InsertarVehiculo(vehiculo);

            EntAsignacionTransporte asignacionTransporte = new EntAsignacionTransporte();
            asignacionTransporte.OrdenPedidoId = PedidoId;
            asignacionTransporte.ConductorId = conductorid;
            asignacionTransporte.VehiculoId = vehiculoid;
            asignacionTransporte.Estado = cbxEstado.Checked;

            LogAsignacionTransporte.Instancia.InsertarAsignacionTransporte(asignacionTransporte);

        }
    }
}

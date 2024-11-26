using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private Button button;
        private Panel panel;

        private Form frmhijo;
        public FrmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            panel = new Panel();
            panel.Size = new Size(7,50);
            panelMenu.Controls.Add(panel);
            
            IniciarSubMenu();
        }

        private void ActivateButton(object sendBtn)
        {
            if(sendBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)sendBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(212, 160, 23);
                currentBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = System.Drawing.Color.DarkOliveGreen;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(183, 65, 14);
                currentBtn.ForeColor = System.Drawing.Color.FromArgb(212, 160, 23);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.FromArgb(212, 160, 23);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void ActivateButtonPanel(object sendBtn)
        {
            if (sendBtn != null)
            {
                DisableButtonPanel();
                button = (Button)sendBtn;
                button.BackColor = System.Drawing.Color.FromArgb(212, 160, 23);
                button.ForeColor = System.Drawing.Color.DarkOliveGreen;
                button.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = System.Drawing.Color.DarkOliveGreen;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //panel.BackColor = System.Drawing.Color.DarkOliveGreen;
                //panel.Location = new Point(0, button.Location.Y);
                //panel.Visible = true;
                //panel.BringToFront();

                Point relativeLocation = button.Parent.PointToScreen(button.Location);
                Point panelParentLocation = panel.Parent.PointToScreen(Point.Empty);

                panel.Location = new Point(0, relativeLocation.Y - panelParentLocation.Y);
                panel.Height = button.Height; // Ajustar el tamaño al del botón
                panel.BackColor = System.Drawing.Color.DarkOliveGreen;
                panel.Visible = true;
                panel.BringToFront();
            }
        }

        private void DisableButtonPanel()
        {
            if (button != null)
            {
                button.BackColor = System.Drawing.Color.FromArgb(183, 65, 14);
                button.ForeColor = System.Drawing.Color.FromArgb(212, 160, 23);
                button.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.IconColor = System.Drawing.Color.FromArgb(212, 160, 23);
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ResetPanel()
        {
            DisableButtonPanel();
            panel.Visible = false;
        }

        private void IniciarSubMenu()
        {
            panelProductos.Visible=false;
            panelCliente.Visible=false;
        }

        private void OcultarSubMenu()
        {
            if(panelProductos.Visible == true)
                panelProductos.Visible = false;
            if(panelCliente.Visible == true)
                panelCliente.Visible = false;
        }

        public void MostrarSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        public void AbrirFormularios(Form hijo)
        {
            if(frmhijo != null)
            {
                frmhijo.Close();
            }
            frmhijo= hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(hijo);
            panelEscritorio.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteJuridico c = new FrmClienteJuridico();
            c.Show();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.Show();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscarProducto = new FrmBuscarProducto();
            buscarProducto.Show();
        }

        private void registroTransportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresaTransporte transportista = new FrmEmpresaTransporte();
            transportista.Show();
        }

        private void buscarTransportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarTransportista buscarTransportista = new FrmBuscarTransportista();
            buscarTransportista.Show();
        }

        private void registroFormasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFormasDePago formasDePago = new FrmFormasDePago();
            formasDePago.Show();
        }

        private void registroPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroOrdenPedido registroPedido = new FrmRegistroOrdenPedido();
            registroPedido.Show();
        }

        private void buscarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarOrdenPedido buscarPedido = new FrmBuscarOrdenPedido();
            buscarPedido.Show();
        }

        private void registroAsignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignacionTransporte asignacionTrasportista = new FrmAsignacionTransporte();
            asignacionTrasportista.Show();
        }

        private void registroVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta Venta = new FrmVenta();
            Venta.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();
            categoria.Show();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSabores sabores = new FrmSabores();
            sabores.Show();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMoneda moneda = new FrmMoneda();
            moneda.Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPais pais = new FrmPais();
            pais.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegion region = new FrmRegion();
            region.Show();
        }

        private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento tipoDocumento = new FrmTipoDocumento();
            tipoDocumento.Show();
        }

        private void clienteJuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteJuridico clienteJuridico = new FrmClienteJuridico();
            clienteJuridico.Show();
        }

        private void clienteNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteNatural clienteNatural = new FrmClienteNatural();
            clienteNatural.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OcultarSubMenu();
            MostrarSubMenu(panelCliente);
            DisableButtonPanel();
            panel.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            ResetPanel();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            MostrarSubMenu(panelProductos);
            DisableButtonPanel();
            panel.Visible = false;
        }

        private void btnClienteNatural_Click(object sender, EventArgs e)
        {
            ActivateButtonPanel(sender);
            AbrirFormularios(new FrmClienteNatural());
        }

        private void btnClienteJuridico_Click(object sender, EventArgs e)
        {
            ActivateButtonPanel(sender);
            AbrirFormularios(new FrmClienteJuridico());
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            ActivateButtonPanel(sender);
            AbrirFormularios(new FrmProducto());
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca marca = new FrmMarca();
            marca.Show();
        }

        private void precioTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrecioTransporte precioTransporte = new FrmPrecioTransporte();
            precioTransporte.Show();
        }
    }
}

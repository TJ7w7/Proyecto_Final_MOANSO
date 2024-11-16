namespace Proyecto_Final_MOANSO
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroTransportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTransportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroFormasDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionTrasportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsignacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.transportistasToolStripMenuItem,
            this.formasDePagoToolStripMenuItem,
            this.asignacionTrasportistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPedidoToolStripMenuItem,
            this.buscarPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // registroPedidoToolStripMenuItem
            // 
            this.registroPedidoToolStripMenuItem.Name = "registroPedidoToolStripMenuItem";
            this.registroPedidoToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.registroPedidoToolStripMenuItem.Text = "Registro Pedido";
            this.registroPedidoToolStripMenuItem.Click += new System.EventHandler(this.registroPedidoToolStripMenuItem_Click);
            // 
            // buscarPedidoToolStripMenuItem
            // 
            this.buscarPedidoToolStripMenuItem.Name = "buscarPedidoToolStripMenuItem";
            this.buscarPedidoToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.buscarPedidoToolStripMenuItem.Text = "Buscar Pedido";
            this.buscarPedidoToolStripMenuItem.Click += new System.EventHandler(this.buscarPedidoToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroVentaToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // registroVentaToolStripMenuItem
            // 
            this.registroVentaToolStripMenuItem.Name = "registroVentaToolStripMenuItem";
            this.registroVentaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.registroVentaToolStripMenuItem.Text = "Registro Venta";
            this.registroVentaToolStripMenuItem.Click += new System.EventHandler(this.registroVentaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClientesToolStripMenuItem,
            this.buscarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registroClientesToolStripMenuItem
            // 
            this.registroClientesToolStripMenuItem.Name = "registroClientesToolStripMenuItem";
            this.registroClientesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.registroClientesToolStripMenuItem.Text = "Registro Cliente";
            this.registroClientesToolStripMenuItem.Click += new System.EventHandler(this.registroClientesToolStripMenuItem_Click);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.buscarClientesToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroProductoToolStripMenuItem,
            this.buscarProductoToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.saboresToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productoToolStripMenuItem.Text = "Productos";
            // 
            // registroProductoToolStripMenuItem
            // 
            this.registroProductoToolStripMenuItem.Name = "registroProductoToolStripMenuItem";
            this.registroProductoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroProductoToolStripMenuItem.Text = "Registro Producto";
            this.registroProductoToolStripMenuItem.Click += new System.EventHandler(this.registroProductoToolStripMenuItem_Click);
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            this.buscarProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
            // 
            // transportistasToolStripMenuItem
            // 
            this.transportistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroTransportistasToolStripMenuItem,
            this.buscarTransportistasToolStripMenuItem});
            this.transportistasToolStripMenuItem.Name = "transportistasToolStripMenuItem";
            this.transportistasToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.transportistasToolStripMenuItem.Text = "Transportistas";
            // 
            // registroTransportistasToolStripMenuItem
            // 
            this.registroTransportistasToolStripMenuItem.Name = "registroTransportistasToolStripMenuItem";
            this.registroTransportistasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.registroTransportistasToolStripMenuItem.Text = "Registro Transportista";
            this.registroTransportistasToolStripMenuItem.Click += new System.EventHandler(this.registroTransportistasToolStripMenuItem_Click);
            // 
            // buscarTransportistasToolStripMenuItem
            // 
            this.buscarTransportistasToolStripMenuItem.Name = "buscarTransportistasToolStripMenuItem";
            this.buscarTransportistasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.buscarTransportistasToolStripMenuItem.Text = "Buscar Transportista";
            this.buscarTransportistasToolStripMenuItem.Click += new System.EventHandler(this.buscarTransportistasToolStripMenuItem_Click);
            // 
            // formasDePagoToolStripMenuItem
            // 
            this.formasDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroFormasDePagoToolStripMenuItem});
            this.formasDePagoToolStripMenuItem.Name = "formasDePagoToolStripMenuItem";
            this.formasDePagoToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.formasDePagoToolStripMenuItem.Text = "Formas de Pago";
            // 
            // registroFormasDePagoToolStripMenuItem
            // 
            this.registroFormasDePagoToolStripMenuItem.Name = "registroFormasDePagoToolStripMenuItem";
            this.registroFormasDePagoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.registroFormasDePagoToolStripMenuItem.Text = "Registro Forma de Pago";
            this.registroFormasDePagoToolStripMenuItem.Click += new System.EventHandler(this.registroFormasDePagoToolStripMenuItem_Click);
            // 
            // asignacionTrasportistaToolStripMenuItem
            // 
            this.asignacionTrasportistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAsignacionToolStripMenuItem});
            this.asignacionTrasportistaToolStripMenuItem.Name = "asignacionTrasportistaToolStripMenuItem";
            this.asignacionTrasportistaToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.asignacionTrasportistaToolStripMenuItem.Text = "Asignacion Trasportista";
            // 
            // registroAsignacionToolStripMenuItem
            // 
            this.registroAsignacionToolStripMenuItem.Name = "registroAsignacionToolStripMenuItem";
            this.registroAsignacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroAsignacionToolStripMenuItem.Text = "Registro Asignacion";
            this.registroAsignacionToolStripMenuItem.Click += new System.EventHandler(this.registroAsignacionToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // saboresToolStripMenuItem
            // 
            this.saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            this.saboresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saboresToolStripMenuItem.Text = "Sabores";
            this.saboresToolStripMenuItem.Click += new System.EventHandler(this.saboresToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 585);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroTransportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTransportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroFormasDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionTrasportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsignacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saboresToolStripMenuItem;
    }
}


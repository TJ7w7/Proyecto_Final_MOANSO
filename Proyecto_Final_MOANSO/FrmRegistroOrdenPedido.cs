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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using static Proyecto_Final_MOANSO.FrmRegistroOrdenPedido;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmRegistroOrdenPedido : Form
    {
        public FrmRegistroOrdenPedido()
        {
            InitializeComponent();
            CargarFormasDePago();
            CargarDataGrid();
            ContarFilas();
        }
        public void LimpiarFormulario()
        {
            // Limpiar campos de texto
            txtCodigoProducto.Text = "";
            txtProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtNombreCliente.Text = "";
            txtNumeroDocumento.Text = "";

            // Restablecer el valor de los controles numéricos
            numericUpDown.Value = 0;

            // Limpiar ComboBox de Forma de Pago
            cbFormaDePago.SelectedIndex = -1;

            // Limpiar ComboBox de Estado de Pedido
            cbEstadoPedido.SelectedIndex = -1;

            // Restablecer el DataGridView
            dgvOrdenPedido.Rows.Clear();

            // Reiniciar los totales
            lblTotalProductos.Text = "Total Productos: 0.00";
            lblTotalFlete.Text = "Total Flete: 0.00";
            lblTotalGeneral.Text = "Total General: 0.00";

            // Reiniciar variables
            codigo = "";
            descripcion = "";
            tipoPresentacionId = 0;
            tipoPresentacion = "";
            precioConIGV = 0;
            precioSinIGV = 0;
            peso = 0;
            largo = 0;
            ancho = 0;
            alto = 0;
            cantidad = 0;
            subtotalproducto = 0;

            precioTransporteId = 0;
            tipoTransporte = "";
            empresa = "";
            precio = 0;
            origenRegion = "";
            destinoRegion = "";

            PP = 0;
            PT = 0;
            PA = 0;

            idCliente = 0;

            // Restaurar fecha actual
            dateTimePicker.Value = DateTime.Now;
        }
        public void ContarFilas()
        {
            string totalFilas = LogPedido.Instancia.ContarFilas();
            txtNroPedido.Text = totalFilas;
        }
        public void CargarDataGrid()
        {
            dgvOrdenPedido.Columns.Clear();
            dgvOrdenPedido.Columns.Add("Codigo", "Codigo");
            dgvOrdenPedido.Columns.Add("Descripcion", "Descripción");
            dgvOrdenPedido.Columns.Add("Cantidad", "Cantidad");
            dgvOrdenPedido.Columns.Add("Precio", "Precio Unitario");
            dgvOrdenPedido.Columns.Add("SubTotal", "Sub Total");
            dgvOrdenPedido.Columns.Add("TipoPresentacionId", "Tipo Presentacion Id");

            dgvOrdenPedido.Columns.Add("Peso", "Peso");
            dgvOrdenPedido.Columns.Add("Largo", "Largo");
            dgvOrdenPedido.Columns.Add("Ancho", "Ancho");
            dgvOrdenPedido.Columns.Add("Alto", "Alto");

            dgvOrdenPedido.Columns["TipoPresentacionId"].Visible = false;
            dgvOrdenPedido.Columns["Peso"].Visible = false;
            dgvOrdenPedido.Columns["Largo"].Visible = false;
            dgvOrdenPedido.Columns["Ancho"].Visible = false;
            dgvOrdenPedido.Columns["Alto"].Visible = false;
        }
        public void CargarFormasDePago()
        {
            cbFormaDePago.DataSource = LogFormasDePago.Instancia.listarFormasDePago();
            cbFormaDePago.DisplayMember = "Nombre";
            cbFormaDePago.ValueMember = "FormasDePagoId";

            cbFormaDePago.SelectedIndex = -1;
        }
        public void Limpiar()
        {
            txtCodigoProducto.Text = "";
            txtProducto.Text = "";
            txtPrecioProducto.Text = "";
            numericUpDown.Value = 0;
        }
        public string codigo;
        public string descripcion;
        public int tipoPresentacionId;
        public string tipoPresentacion;
        public decimal precioConIGV;
        public decimal precioSinIGV;
        public decimal peso;
        public decimal largo;
        public decimal ancho;
        public decimal alto;
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscarProducto = new FrmBuscarProducto();
            if(buscarProducto.ShowDialog() == DialogResult.OK)
            {
                codigo = buscarProducto.Codigo;
                descripcion = buscarProducto.Descripcion;
                tipoPresentacionId = int.Parse(buscarProducto.TipoPresentacionId);
                tipoPresentacion = buscarProducto.TipoPresentacion;
                precioConIGV = decimal.Parse(buscarProducto.PrecioConIGV);
                precioSinIGV = decimal.Parse(buscarProducto.PrecioSinIGV);
                peso = decimal.Parse(buscarProducto.Peso);
                largo = decimal.Parse(buscarProducto.Largo);
                ancho = decimal.Parse(buscarProducto.Ancho);
                alto = decimal.Parse(buscarProducto.Alto);

                txtCodigoProducto.Text = codigo;
                txtProducto.Text = $"{descripcion} {tipoPresentacion}";
            }
        }
        private bool EsFilaTransporte(DataGridViewRow row)
        {
            return row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "Transporte";
        }

        private List<EntPedidoDetalle> ObtenerDetallesDesdeGrid()
        {
            List<EntPedidoDetalle> listaDetalles = new List<EntPedidoDetalle>();

            foreach (DataGridViewRow row in dgvOrdenPedido.Rows)
            {
                if (!EsFilaTransporte(row) && row.Cells["Codigo"].Value != null) // Ignorar la fila de transporte
                {
                    EntPedidoDetalle detalle = new EntPedidoDetalle();

                    detalle.TipoPresentacionId = Convert.ToInt32(row.Cells["TipoPresentacionId"].Value);
                    detalle.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    detalle.PrecioTotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    listaDetalles.Add(detalle);
                }
            }

            return listaDetalles;
        }
        // Permitir solo números
        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public int idCliente;
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text == "")
            {
                MessageBox.Show("Ingrese Un Numero de Documento");
                return;
            }
            string nroDocumento = txtNumeroDocumento.Text;
            string primeroDigitos = nroDocumento.Substring(0, 2);
            if (primeroDigitos == "10")
            {
                try
                {

                    EntClienteNatural clienteNatural = LogCliente.Instancia.BuscarClienteNatural(nroDocumento);

                    if (clienteNatural == null)
                    {
                        DialogResult result = MessageBox.Show("Cliente no encontrado ¿Deseas registrarlo?", "Confirmar accion",
                                          MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (result == DialogResult.Yes) 
                        { 
                            FrmClienteNatural frmclienteNatural = new FrmClienteNatural();
                            frmclienteNatural.Show();
                        }
                    }
                    else
                    {
                        txtNombreCliente.Text = $"{clienteNatural.Apellidos} {clienteNatural.Nombres}";
                        idCliente = clienteNatural.ClienteId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(primeroDigitos == "20")
            {
                EntClienteJuridico clienteJuridico = LogCliente.Instancia.BuscarClienteJuridico(nroDocumento);
                
                if (clienteJuridico == null)
                {
                    DialogResult result = MessageBox.Show("Cliente no encontrado ¿Deseas registrarlo?", "Confirmar accion",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        FrmClienteJuridico frmclienteJuridico = new FrmClienteJuridico();
                        frmclienteJuridico.Show();
                    }
                }
                else
                {
                    txtNombreCliente.Text = $"{clienteJuridico.RazonSocial}";
                    idCliente = clienteJuridico.ClienteId;
                }
            }

        }
        public decimal cantidad;
        public decimal subtotalproducto;

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cantidad = numericUpDown.Value;

            subtotalproducto = precioConIGV * cantidad;

            txtPrecioProducto.Text = subtotalproducto.ToString();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvOrdenPedido.Rows)
            {
                if (fila.Cells["Codigo"].Value?.ToString() == codigo)
                {
                    MessageBox.Show("El producto ya a sido agregado.", "Advertencia");
                    return;
                }
            }
            
            dgvOrdenPedido.Rows.Add(codigo, descripcion + tipoPresentacion, cantidad, precioConIGV, subtotalproducto, tipoPresentacionId, peso, largo,ancho,alto);
            Limpiar();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                EntPedido entPedido = new EntPedido();
                entPedido.NumeroPedido = txtNroPedido.Text;
                entPedido.ClienteId = idCliente;
                entPedido.FormaDePagoId = int.Parse(cbFormaDePago.SelectedValue.ToString());
                entPedido.PrecioTransporteId = precioTransporteId;
                entPedido.PrecioProductos = PP;
                entPedido.PrecioFletes = PT;
                entPedido.PrecioTotal = PA;
                entPedido.Fecha = DateTime.Parse(dateTimePicker.Text);
                entPedido.Estado = cbEstadoPedido.SelectedItem.ToString();

                List<EntPedidoDetalle> detalles = ObtenerDetallesDesdeGrid();

                LogPedidoDetalle.Instancia.GuardarPedidoCompleto(entPedido, detalles);

                MessageBox.Show("Guardado con exito");
                Limpiar();
                ContarFilas();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private decimal CalcularFleteTotal(string tipoTransporte, decimal precioUnitario)
        {
            decimal pesoTotal = 0;
            decimal volumenTotal = 0;
            decimal fleteTotal = 0;

            // Recorrer las filas de productos en el DataGridView
            foreach (DataGridViewRow row in dgvOrdenPedido.Rows)
            {
                // Ignorar filas que no sean productos
                if (row.Cells["Codigo"].Value != null && row.Cells["Codigo"].Value.ToString() != "Transporte")
                {
                    decimal peso = Convert.ToDecimal(row.Cells["Peso"].Value); // Peso en kg
                    decimal largo = Convert.ToDecimal(row.Cells["Largo"].Value); // Largo en cm
                    decimal ancho = Convert.ToDecimal(row.Cells["Ancho"].Value); // Ancho en cm
                    decimal alto = Convert.ToDecimal(row.Cells["Alto"].Value);   // Alto en cm

                    // Calcular volumen en m³
                    decimal volumen = (largo * ancho * alto) / 1000000M; // cm³ a m³
                    volumenTotal += volumen;

                    // Sumar peso
                    pesoTotal += peso;
                }
            }

            if (tipoTransporte == "Maritimo")
            {
                // Usar el mayor entre peso total y volumen total
                fleteTotal = Math.Round(Math.Max(pesoTotal, volumenTotal) * precioUnitario, 2);
            }
            else if (tipoTransporte == "Aereo")
            {
                // Calcular peso volumétrico (en kg)
                decimal pesoVolumetrico = volumenTotal * 166.67M; // 6000 cm³ por kg
                fleteTotal = Math.Round(Math.Max(pesoTotal, volumenTotal) * precioUnitario, 2);
            }

            return fleteTotal; // Valor predeterminado si no se reconoce el transporte
        }

        public int precioTransporteId;
        public string tipoTransporte;
        public string empresa;
        public decimal precio;
        public string origenRegion;
        public string destinoRegion;

        private void btnAgregarPrecioTransporte_Click(object sender, EventArgs e)
        {
            FrmBuscarPrecioTransporte buscarPrecioTransporte = new FrmBuscarPrecioTransporte();
            if (buscarPrecioTransporte.ShowDialog() == DialogResult.OK)
            {
                precioTransporteId = int.Parse(buscarPrecioTransporte.PrecioTransporteId);
                tipoTransporte = buscarPrecioTransporte.TipoTransporte.ToString();
                empresa = buscarPrecioTransporte.Empresa.ToString();
                precio = decimal.Parse(buscarPrecioTransporte.Precio);
                origenRegion = buscarPrecioTransporte.OrigenRegion.ToString();
                destinoRegion = buscarPrecioTransporte.DestinoRegion.ToString();

                decimal fleteTotal = CalcularFleteTotal(tipoTransporte, precio);

                bool transporteExiste = false;

                foreach (DataGridViewRow row in dgvOrdenPedido.Rows)
                {
                    if (row.Cells["Codigo"].Value != null && row.Cells["Codigo"].Value.ToString() == "Transporte")
                    {
                        row.Cells["SubTotal"].Value = fleteTotal;
                        transporteExiste = true;
                        break;
                    }
                }

                // Si no existe la fila de transporte, agregarla
                if (!transporteExiste)
                {
                    dgvOrdenPedido.Rows.Add("Transporte", empresa + "-" + tipoTransporte + "-" + origenRegion + "-" + destinoRegion, "", "", fleteTotal);
                }
            }
        }
        public decimal PP;
        public decimal PT;
        public decimal PA;
        private void CalcularTotales()
        {
            // Variables para almacenar los totales
            double totalProductos = 0;
            double precioFlete = 0;
            double totalGeneral;

            // Recorrer las filas del DataGridView
            foreach (DataGridViewRow row in dgvOrdenPedido.Rows)
            {
                // Verifica que la fila no sea nueva (fila en blanco para agregar datos)
                if (row.IsNewRow) continue;

                // Verificar que las celdas necesarias no sean nulas
                if (row.Cells["Codigo"]?.Value == null || row.Cells["SubTotal"]?.Value == null) continue;

                // Identificar si la fila corresponde al precio del flete
                if (row.Cells["codigo"].Value?.ToString()?.ToLower() == "transporte")
                {
                    // Intenta obtener el precio del flete
                    if (double.TryParse(row.Cells["SubTotal"].Value?.ToString(), out double flete))
                    {
                        precioFlete = flete;
                    }
                    continue;
                }

                // Sumar precios de productos (excluyendo el flete)
                if (double.TryParse(row.Cells["SubTotal"].Value?.ToString(), out double precioProducto))
                {
                    totalProductos += precioProducto;
                }
            }

            // Calcular el total general
            totalGeneral = totalProductos + precioFlete;

            PP = decimal.Parse(totalProductos.ToString());
            PT = decimal.Parse(precioFlete.ToString());
            PA = decimal.Parse(totalGeneral.ToString());

            // Mostrar resultados en los Labels
            lblTotalProductos.Text = $"Total Productos: {totalProductos}";
            lblTotalFlete.Text = $"Total Flete: {precioFlete}";
            lblTotalGeneral.Text = $"Total General: {totalGeneral}";
        }

        private void dgvOrdenPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotales();
        }
    }
}

namespace Proyecto_Final_MOANSO
{
    partial class FrmBuscarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrarBP = new System.Windows.Forms.Button();
            this.dgvBuscarProducto = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionaP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarBP
            // 
            this.btnCerrarBP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBP.Location = new System.Drawing.Point(578, 353);
            this.btnCerrarBP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarBP.Name = "btnCerrarBP";
            this.btnCerrarBP.Size = new System.Drawing.Size(74, 29);
            this.btnCerrarBP.TabIndex = 9;
            this.btnCerrarBP.Text = "Cerrar";
            this.btnCerrarBP.UseVisualStyleBackColor = true;
            // 
            // dgvBuscarProducto
            // 
            this.dgvBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProducto.Location = new System.Drawing.Point(20, 91);
            this.dgvBuscarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBuscarProducto.Name = "dgvBuscarProducto";
            this.dgvBuscarProducto.RowHeadersWidth = 51;
            this.dgvBuscarProducto.RowTemplate.Height = 24;
            this.dgvBuscarProducto.Size = new System.Drawing.Size(631, 242);
            this.dgvBuscarProducto.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(20, 354);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 26);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreProducto.Location = new System.Drawing.Point(20, 52);
            this.txbNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(240, 27);
            this.txbNombreProducto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // btnSeleccionaP
            // 
            this.btnSeleccionaP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionaP.Location = new System.Drawing.Point(111, 353);
            this.btnSeleccionaP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionaP.Name = "btnSeleccionaP";
            this.btnSeleccionaP.Size = new System.Drawing.Size(93, 29);
            this.btnSeleccionaP.TabIndex = 10;
            this.btnSeleccionaP.Text = "Seleccionar";
            this.btnSeleccionaP.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 400);
            this.Controls.Add(this.btnSeleccionaP);
            this.Controls.Add(this.btnCerrarBP);
            this.Controls.Add(this.dgvBuscarProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbNombreProducto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarBP;
        private System.Windows.Forms.DataGridView dgvBuscarProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionaP;
    }
}
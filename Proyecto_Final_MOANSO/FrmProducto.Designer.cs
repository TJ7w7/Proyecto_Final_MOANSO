namespace Proyecto_Final_MOANSO
{
    partial class FrmProducto
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
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnDeshabilitarP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstadoP = new System.Windows.Forms.CheckBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarP.Location = new System.Drawing.Point(604, 470);
            this.btnCerrarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(100, 28);
            this.btnCerrarP.TabIndex = 14;
            this.btnCerrarP.Text = "Cerrar";
            this.btnCerrarP.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(16, 250);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(688, 195);
            this.dgvProductos.TabIndex = 13;
            // 
            // btnDeshabilitarP
            // 
            this.btnDeshabilitarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarP.Location = new System.Drawing.Point(200, 470);
            this.btnDeshabilitarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitarP.Name = "btnDeshabilitarP";
            this.btnDeshabilitarP.Size = new System.Drawing.Size(100, 28);
            this.btnDeshabilitarP.TabIndex = 11;
            this.btnDeshabilitarP.Text = "Deshabilitar";
            this.btnDeshabilitarP.UseVisualStyleBackColor = true;
            // 
            // btnEditarP
            // 
            this.btnEditarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.Location = new System.Drawing.Point(113, 470);
            this.btnEditarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(71, 28);
            this.btnEditarP.TabIndex = 10;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.UseVisualStyleBackColor = true;
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoP.Location = new System.Drawing.Point(19, 470);
            this.btnNuevoP.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(71, 28);
            this.btnNuevoP.TabIndex = 9;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcionP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStockP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbEstadoP);
            this.groupBox1.Controls.Add(this.txtNombreP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarP);
            this.groupBox1.Controls.Add(this.btnModificarP);
            this.groupBox1.Controls.Add(this.btnCancelarP);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(686, 227);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtDescripcionP
            // 
            this.txtDescripcionP.Location = new System.Drawing.Point(111, 174);
            this.txtDescripcionP.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionP.Name = "txtDescripcionP";
            this.txtDescripcionP.Size = new System.Drawing.Size(252, 27);
            this.txtDescripcionP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripcion:";
            // 
            // txtStockP
            // 
            this.txtStockP.Location = new System.Drawing.Point(111, 129);
            this.txtStockP.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockP.Name = "txtStockP";
            this.txtStockP.Size = new System.Drawing.Size(90, 27);
            this.txtStockP.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock:";
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(111, 84);
            this.txtPrecioP.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(90, 27);
            this.txtPrecioP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // cbEstadoP
            // 
            this.cbEstadoP.AutoSize = true;
            this.cbEstadoP.Location = new System.Drawing.Point(451, 34);
            this.cbEstadoP.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoP.Name = "cbEstadoP";
            this.cbEstadoP.Size = new System.Drawing.Size(75, 23);
            this.cbEstadoP.TabIndex = 5;
            this.cbEstadoP.Text = "Estado";
            this.cbEstadoP.UseVisualStyleBackColor = true;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(111, 35);
            this.txtNombreP.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(194, 27);
            this.txtNombreP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.Location = new System.Drawing.Point(586, 53);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(81, 31);
            this.btnAgregarP.TabIndex = 0;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnModificarP
            // 
            this.btnModificarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarP.Location = new System.Drawing.Point(586, 103);
            this.btnModificarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(81, 32);
            this.btnModificarP.TabIndex = 1;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarP.Location = new System.Drawing.Point(586, 156);
            this.btnCancelarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(81, 28);
            this.btnCancelarP.TabIndex = 2;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnDeshabilitarP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.btnNuevoP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnDeshabilitarP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEstadoP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionP;
        private System.Windows.Forms.Label label5;
    }
}
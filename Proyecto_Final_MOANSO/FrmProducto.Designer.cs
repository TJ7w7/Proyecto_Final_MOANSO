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
            this.btnSalirFrmProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnDeshabilitarProductos = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cmbSabores = new System.Windows.Forms.ComboBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtStockProductos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstadoProducto = new System.Windows.Forms.CheckBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirFrmProducto
            // 
            this.btnSalirFrmProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirFrmProducto.Location = new System.Drawing.Point(824, 547);
            this.btnSalirFrmProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirFrmProducto.Name = "btnSalirFrmProducto";
            this.btnSalirFrmProducto.Size = new System.Drawing.Size(100, 28);
            this.btnSalirFrmProducto.TabIndex = 14;
            this.btnSalirFrmProducto.Text = "Salir";
            this.btnSalirFrmProducto.UseVisualStyleBackColor = true;
            this.btnSalirFrmProducto.Click += new System.EventHandler(this.btnSalirFrmProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 318);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(915, 215);
            this.dgvProductos.TabIndex = 13;
            // 
            // btnDeshabilitarProductos
            // 
            this.btnDeshabilitarProductos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarProductos.Location = new System.Drawing.Point(122, 547);
            this.btnDeshabilitarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitarProductos.Name = "btnDeshabilitarProductos";
            this.btnDeshabilitarProductos.Size = new System.Drawing.Size(100, 28);
            this.btnDeshabilitarProductos.TabIndex = 11;
            this.btnDeshabilitarProductos.Text = "Deshabilitar";
            this.btnDeshabilitarProductos.UseVisualStyleBackColor = true;
            this.btnDeshabilitarProductos.Click += new System.EventHandler(this.btnDeshabilitarProductos_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(17, 547);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(71, 28);
            this.btnNuevoProducto.TabIndex = 9;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbSabores);
            this.gbDatos.Controls.Add(this.btnAgregarImagen);
            this.gbDatos.Controls.Add(this.txtStockProductos);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.pbxImagen);
            this.gbDatos.Controls.Add(this.cmbCategoria);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.cbEstadoProducto);
            this.gbDatos.Controls.Add(this.txtNombreProducto);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.btnAgregarP);
            this.gbDatos.Controls.Add(this.btnModificarP);
            this.gbDatos.Controls.Add(this.btnEliminarProductos);
            this.gbDatos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(11, 10);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(921, 292);
            this.gbDatos.TabIndex = 15;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cmbSabores
            // 
            this.cmbSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSabores.FormattingEnabled = true;
            this.cmbSabores.Location = new System.Drawing.Point(111, 142);
            this.cmbSabores.Name = "cmbSabores";
            this.cmbSabores.Size = new System.Drawing.Size(315, 27);
            this.cmbSabores.TabIndex = 23;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(708, 85);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(102, 55);
            this.btnAgregarImagen.TabIndex = 16;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtStockProductos
            // 
            this.txtStockProductos.Location = new System.Drawing.Point(111, 189);
            this.txtStockProductos.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockProductos.Name = "txtStockProductos";
            this.txtStockProductos.Size = new System.Drawing.Size(315, 27);
            this.txtStockProductos.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stock:";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(482, 34);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(198, 242);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 20;
            this.pbxImagen.TabStop = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(111, 85);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(315, 27);
            this.cmbCategoria.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sabor:";
            // 
            // cbEstadoProducto
            // 
            this.cbEstadoProducto.AutoSize = true;
            this.cbEstadoProducto.Location = new System.Drawing.Point(721, 40);
            this.cbEstadoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoProducto.Name = "cbEstadoProducto";
            this.cbEstadoProducto.Size = new System.Drawing.Size(75, 23);
            this.cbEstadoProducto.TabIndex = 5;
            this.cbEstadoProducto.Text = "Estado";
            this.cbEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(111, 34);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(315, 27);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.Location = new System.Drawing.Point(832, 44);
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
            this.btnModificarP.Location = new System.Drawing.Point(832, 93);
            this.btnModificarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(81, 32);
            this.btnModificarP.TabIndex = 1;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductos.Location = new System.Drawing.Point(832, 147);
            this.btnEliminarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(81, 28);
            this.btnEliminarProductos.TabIndex = 2;
            this.btnEliminarProductos.Text = "Eliminar";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 586);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnSalirFrmProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnDeshabilitarProductos);
            this.Controls.Add(this.btnNuevoProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalirFrmProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnDeshabilitarProductos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.CheckBox cbEstadoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txtStockProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.ComboBox cmbSabores;
    }
}
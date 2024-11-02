namespace Proyecto_Final_MOANSO
{
    partial class FrmCliente
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRUC = new System.Windows.Forms.RadioButton();
            this.radioBRN = new System.Windows.Forms.RadioButton();
            this.btnInsertarCambio = new System.Windows.Forms.Button();
            this.cbRegCli = new System.Windows.Forms.ComboBox();
            this.txtNumCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.chbxEstadoCliente = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBRN_RUC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarCli = new System.Windows.Forms.Button();
            this.btnModificarCli = new System.Windows.Forms.Button();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvClientesRegistrados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(9, 515);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 32);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRUC);
            this.groupBox1.Controls.Add(this.radioBRN);
            this.groupBox1.Controls.Add(this.btnInsertarCambio);
            this.groupBox1.Controls.Add(this.cbRegCli);
            this.groupBox1.Controls.Add(this.txtNumCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.chbxEstadoCliente);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtBRN_RUC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEliminarCli);
            this.groupBox1.Controls.Add(this.btnModificarCli);
            this.groupBox1.Controls.Add(this.btnAgregarCli);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(630, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente (Empresa)";
            // 
            // radioRUC
            // 
            this.radioRUC.AutoSize = true;
            this.radioRUC.Location = new System.Drawing.Point(441, 42);
            this.radioRUC.Name = "radioRUC";
            this.radioRUC.Size = new System.Drawing.Size(58, 23);
            this.radioRUC.TabIndex = 28;
            this.radioRUC.TabStop = true;
            this.radioRUC.Text = "RUC";
            this.radioRUC.UseVisualStyleBackColor = true;
            // 
            // radioBRN
            // 
            this.radioBRN.AutoSize = true;
            this.radioBRN.Location = new System.Drawing.Point(380, 42);
            this.radioBRN.Name = "radioBRN";
            this.radioBRN.Size = new System.Drawing.Size(57, 23);
            this.radioBRN.TabIndex = 27;
            this.radioBRN.TabStop = true;
            this.radioBRN.Text = "BRN";
            this.radioBRN.UseVisualStyleBackColor = true;
            this.radioBRN.CheckedChanged += new System.EventHandler(this.radioBRN_CheckedChanged);
            // 
            // btnInsertarCambio
            // 
            this.btnInsertarCambio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarCambio.Location = new System.Drawing.Point(518, 131);
            this.btnInsertarCambio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarCambio.Name = "btnInsertarCambio";
            this.btnInsertarCambio.Size = new System.Drawing.Size(86, 32);
            this.btnInsertarCambio.TabIndex = 26;
            this.btnInsertarCambio.Text = "Insertar";
            this.btnInsertarCambio.UseVisualStyleBackColor = true;
            // 
            // cbRegCli
            // 
            this.cbRegCli.FormattingEnabled = true;
            this.cbRegCli.Location = new System.Drawing.Point(167, 115);
            this.cbRegCli.Name = "cbRegCli";
            this.cbRegCli.Size = new System.Drawing.Size(207, 27);
            this.cbRegCli.TabIndex = 25;
            this.cbRegCli.SelectedIndexChanged += new System.EventHandler(this.cbRegCli_SelectedIndexChanged);
            // 
            // txtNumCli
            // 
            this.txtNumCli.Location = new System.Drawing.Point(167, 198);
            this.txtNumCli.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCli.Name = "txtNumCli";
            this.txtNumCli.Size = new System.Drawing.Size(207, 27);
            this.txtNumCli.TabIndex = 24;
            this.txtNumCli.TextChanged += new System.EventHandler(this.txtNumCli_TextChanged);
            this.txtNumCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCli_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Numero Telefonico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre Comercial:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(167, 155);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(207, 27);
            this.txtDireccion.TabIndex = 20;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(80, 159);
            this.Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(80, 19);
            this.Direccion.TabIndex = 19;
            this.Direccion.Text = "Direccion:";
            // 
            // chbxEstadoCliente
            // 
            this.chbxEstadoCliente.AutoSize = true;
            this.chbxEstadoCliente.Location = new System.Drawing.Point(397, 119);
            this.chbxEstadoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.chbxEstadoCliente.Name = "chbxEstadoCliente";
            this.chbxEstadoCliente.Size = new System.Drawing.Size(102, 23);
            this.chbxEstadoCliente.TabIndex = 18;
            this.chbxEstadoCliente.Text = "Disponible";
            this.chbxEstadoCliente.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 27);
            this.txtNombre.TabIndex = 16;
            // 
            // txtBRN_RUC
            // 
            this.txtBRN_RUC.Location = new System.Drawing.Point(167, 41);
            this.txtBRN_RUC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBRN_RUC.Name = "txtBRN_RUC";
            this.txtBRN_RUC.Size = new System.Drawing.Size(207, 27);
            this.txtBRN_RUC.TabIndex = 15;
            this.txtBRN_RUC.TextChanged += new System.EventHandler(this.txtBRN_RUC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Region:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "BRN/RUC:";
            // 
            // btnEliminarCli
            // 
            this.btnEliminarCli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCli.Location = new System.Drawing.Point(518, 175);
            this.btnEliminarCli.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCli.Name = "btnEliminarCli";
            this.btnEliminarCli.Size = new System.Drawing.Size(86, 32);
            this.btnEliminarCli.TabIndex = 10;
            this.btnEliminarCli.Text = "Eliminar";
            this.btnEliminarCli.UseVisualStyleBackColor = true;
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCli.Location = new System.Drawing.Point(518, 89);
            this.btnModificarCli.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(86, 32);
            this.btnModificarCli.TabIndex = 9;
            this.btnModificarCli.Text = "Modificar";
            this.btnModificarCli.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCli.Location = new System.Drawing.Point(518, 45);
            this.btnAgregarCli.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(86, 32);
            this.btnAgregarCli.TabIndex = 1;
            this.btnAgregarCli.Text = "Agregar";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(88, 515);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 32);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(166, 515);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(104, 32);
            this.btnDeshabilitar.TabIndex = 6;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(573, 514);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvClientesRegistrados
            // 
            this.dgvClientesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesRegistrados.Location = new System.Drawing.Point(9, 256);
            this.dgvClientesRegistrados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientesRegistrados.Name = "dgvClientesRegistrados";
            this.dgvClientesRegistrados.RowHeadersWidth = 51;
            this.dgvClientesRegistrados.RowTemplate.Height = 24;
            this.dgvClientesRegistrados.Size = new System.Drawing.Size(630, 244);
            this.dgvClientesRegistrados.TabIndex = 8;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 557);
            this.Controls.Add(this.dgvClientesRegistrados);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvClientesRegistrados;
        private System.Windows.Forms.Button btnEliminarCli;
        private System.Windows.Forms.Button btnModificarCli;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbxEstadoCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBRN_RUC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRegCli;
        private System.Windows.Forms.Button btnInsertarCambio;
        private System.Windows.Forms.RadioButton radioRUC;
        private System.Windows.Forms.RadioButton radioBRN;
    }
}
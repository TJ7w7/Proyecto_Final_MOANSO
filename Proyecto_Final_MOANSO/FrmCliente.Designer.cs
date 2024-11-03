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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.txtBRN_RUC = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgridCliente = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnRegiones = new System.Windows.Forms.Button();
            this.radioRUC = new System.Windows.Forms.RadioButton();
            this.radioBRN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRegCli = new System.Windows.Forms.ComboBox();
            this.txtRegionID = new System.Windows.Forms.TextBox();
            this.txtNumCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 93);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(255, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(56, 96);
            this.Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 41;
            this.Direccion.Text = "Direccion";
            // 
            // txtBRN_RUC
            // 
            this.txtBRN_RUC.Location = new System.Drawing.Point(129, 54);
            this.txtBRN_RUC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBRN_RUC.MaxLength = 12;
            this.txtBRN_RUC.Name = "txtBRN_RUC";
            this.txtBRN_RUC.Size = new System.Drawing.Size(255, 20);
            this.txtBRN_RUC.TabIndex = 40;
            this.txtBRN_RUC.TextChanged += new System.EventHandler(this.txtBRN_RUC_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "BRN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre Comercial";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(22, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 32);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(22, 231);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 32);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(22, 171);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 32);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgridCliente
            // 
            this.dtgridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridCliente.Location = new System.Drawing.Point(129, 171);
            this.dtgridCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dtgridCliente.Name = "dtgridCliente";
            this.dtgridCliente.RowHeadersWidth = 51;
            this.dtgridCliente.RowTemplate.Height = 24;
            this.dtgridCliente.Size = new System.Drawing.Size(489, 232);
            this.dtgridCliente.TabIndex = 33;
            this.dtgridCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridCliente_CellClick);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(552, 430);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(66, 32);
            this.btnsalir.TabIndex = 32;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnRegiones
            // 
            this.btnRegiones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegiones.Location = new System.Drawing.Point(22, 340);
            this.btnRegiones.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegiones.Name = "btnRegiones";
            this.btnRegiones.Size = new System.Drawing.Size(86, 32);
            this.btnRegiones.TabIndex = 43;
            this.btnRegiones.Text = "Revisar";
            this.btnRegiones.UseVisualStyleBackColor = true;
            this.btnRegiones.Click += new System.EventHandler(this.btnRegiones_Click);
            // 
            // radioRUC
            // 
            this.radioRUC.AutoSize = true;
            this.radioRUC.Location = new System.Drawing.Point(73, 140);
            this.radioRUC.Name = "radioRUC";
            this.radioRUC.Size = new System.Drawing.Size(48, 17);
            this.radioRUC.TabIndex = 45;
            this.radioRUC.TabStop = true;
            this.radioRUC.Text = "RUC";
            this.radioRUC.UseVisualStyleBackColor = true;
            // 
            // radioBRN
            // 
            this.radioBRN.AutoSize = true;
            this.radioBRN.Location = new System.Drawing.Point(12, 140);
            this.radioBRN.Name = "radioBRN";
            this.radioBRN.Size = new System.Drawing.Size(48, 17);
            this.radioBRN.TabIndex = 44;
            this.radioBRN.TabStop = true;
            this.radioBRN.Text = "BRN";
            this.radioBRN.UseVisualStyleBackColor = true;
            this.radioBRN.CheckedChanged += new System.EventHandler(this.radioBRN_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Region";
            // 
            // cbRegCli
            // 
            this.cbRegCli.FormattingEnabled = true;
            this.cbRegCli.Location = new System.Drawing.Point(450, 18);
            this.cbRegCli.Name = "cbRegCli";
            this.cbRegCli.Size = new System.Drawing.Size(121, 21);
            this.cbRegCli.TabIndex = 47;
            this.cbRegCli.SelectedIndexChanged += new System.EventHandler(this.cbRegCli_SelectedIndexChanged);
            // 
            // txtRegionID
            // 
            this.txtRegionID.Location = new System.Drawing.Point(577, 18);
            this.txtRegionID.Name = "txtRegionID";
            this.txtRegionID.Size = new System.Drawing.Size(41, 20);
            this.txtRegionID.TabIndex = 48;
            // 
            // txtNumCli
            // 
            this.txtNumCli.Location = new System.Drawing.Point(506, 54);
            this.txtNumCli.Name = "txtNumCli";
            this.txtNumCli.Size = new System.Drawing.Size(112, 20);
            this.txtNumCli.TabIndex = 49;
            this.txtNumCli.TextChanged += new System.EventHandler(this.txtNumCli_TextChanged);
            this.txtNumCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCli_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Numero Telefonico";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumCli);
            this.Controls.Add(this.txtRegionID);
            this.Controls.Add(this.cbRegCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioRUC);
            this.Controls.Add(this.radioBRN);
            this.Controls.Add(this.btnRegiones);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.txtBRN_RUC);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgridCliente);
            this.Controls.Add(this.btnsalir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox txtBRN_RUC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgridCliente;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnRegiones;
        private System.Windows.Forms.RadioButton radioRUC;
        private System.Windows.Forms.RadioButton radioBRN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegCli;
        private System.Windows.Forms.TextBox txtRegionID;
        private System.Windows.Forms.TextBox txtNumCli;
        private System.Windows.Forms.Label label4;
    }
}
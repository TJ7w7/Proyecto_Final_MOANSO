namespace Proyecto_Final_MOANSO
{
    partial class FrmAsignacionTrasportista
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbLicencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNroDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTransportista = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txvIdOrdenPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarOrdenPedido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarOrdenPedido);
            this.groupBox1.Controls.Add(this.txvIdOrdenPedido);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 878);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden Pedido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(384, 817);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 39);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 698);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transportista";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbxTipoVehiculo);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txbMatricula);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 508);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 156);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vehiculo";
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(142, 39);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(206, 32);
            this.cbxTipoVehiculo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Matricula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo:";
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(142, 96);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(206, 32);
            this.txbMatricula.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txbLicencia);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txbTelefono);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txbNroDocumento);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txbApellidos);
            this.groupBox4.Controls.Add(this.txbNombres);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 318);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conductor";
            // 
            // txbLicencia
            // 
            this.txbLicencia.Location = new System.Drawing.Point(180, 260);
            this.txbLicencia.Name = "txbLicencia";
            this.txbLicencia.Size = new System.Drawing.Size(242, 32);
            this.txbLicencia.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Licencia:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(180, 219);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(242, 32);
            this.txbTelefono.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefono:";
            // 
            // txbNroDocumento
            // 
            this.txbNroDocumento.Location = new System.Drawing.Point(180, 84);
            this.txbNroDocumento.Name = "txbNroDocumento";
            this.txbNroDocumento.Size = new System.Drawing.Size(242, 32);
            this.txbNroDocumento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos:";
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(180, 176);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(242, 32);
            this.txbApellidos.TabIndex = 4;
            // 
            // txbNombres
            // 
            this.txbNombres.Location = new System.Drawing.Point(180, 129);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(242, 32);
            this.txbNombres.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarTransportista);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Empresa";
            // 
            // btnBuscarTransportista
            // 
            this.btnBuscarTransportista.Location = new System.Drawing.Point(360, 45);
            this.btnBuscarTransportista.Name = "btnBuscarTransportista";
            this.btnBuscarTransportista.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarTransportista.TabIndex = 2;
            this.btnBuscarTransportista.Text = "...";
            this.btnBuscarTransportista.UseVisualStyleBackColor = true;
            this.btnBuscarTransportista.Click += new System.EventHandler(this.btnBuscarTransportista_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(111, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 32);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 817);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 39);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1058, 937);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(145, 924);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(138, 39);
            this.btnDeshabilitar.TabIndex = 10;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 924);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 39);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(567, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 862);
            this.dataGridView1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tipo Documento:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Id:";
            // 
            // txvIdOrdenPedido
            // 
            this.txvIdOrdenPedido.Location = new System.Drawing.Point(97, 49);
            this.txvIdOrdenPedido.Name = "txvIdOrdenPedido";
            this.txvIdOrdenPedido.Size = new System.Drawing.Size(242, 32);
            this.txvIdOrdenPedido.TabIndex = 13;
            // 
            // btnBuscarOrdenPedido
            // 
            this.btnBuscarOrdenPedido.Location = new System.Drawing.Point(384, 48);
            this.btnBuscarOrdenPedido.Name = "btnBuscarOrdenPedido";
            this.btnBuscarOrdenPedido.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarOrdenPedido.TabIndex = 3;
            this.btnBuscarOrdenPedido.Text = "...";
            this.btnBuscarOrdenPedido.UseVisualStyleBackColor = true;
            this.btnBuscarOrdenPedido.Click += new System.EventHandler(this.btnBuscarOrdenPedido_Click);
            // 
            // FrmAsignacionTrasportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 988);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAsignacionTrasportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion Trasportista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarTransportista;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbNroDocumento;
        private System.Windows.Forms.TextBox txbLicencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarOrdenPedido;
        private System.Windows.Forms.TextBox txvIdOrdenPedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}
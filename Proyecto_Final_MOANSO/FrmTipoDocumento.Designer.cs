namespace Proyecto_Final_MOANSO
{
    partial class FrmTipoDocumento
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
            this.cbxClienteJuridico = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.cbxAlfanumerico = new System.Windows.Forms.CheckBox();
            this.cbxLongitudExacta = new System.Windows.Forms.CheckBox();
            this.txtLongitudMaxima = new System.Windows.Forms.TextBox();
            this.txtLongitudMinima = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTipoDocumento = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxClienteJuridico);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.cbxAlfanumerico);
            this.groupBox1.Controls.Add(this.cbxLongitudExacta);
            this.groupBox1.Controls.Add(this.txtLongitudMaxima);
            this.groupBox1.Controls.Add(this.txtLongitudMinima);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TipoDocumento";
            // 
            // cbxClienteJuridico
            // 
            this.cbxClienteJuridico.AutoSize = true;
            this.cbxClienteJuridico.Location = new System.Drawing.Point(522, 135);
            this.cbxClienteJuridico.Name = "cbxClienteJuridico";
            this.cbxClienteJuridico.Size = new System.Drawing.Size(161, 28);
            this.cbxClienteJuridico.TabIndex = 11;
            this.cbxClienteJuridico.Text = "ClienteJuridico";
            this.cbxClienteJuridico.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(774, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 33);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(774, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 33);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(522, 173);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(92, 28);
            this.cbxEstado.TabIndex = 8;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // cbxAlfanumerico
            // 
            this.cbxAlfanumerico.AutoSize = true;
            this.cbxAlfanumerico.Location = new System.Drawing.Point(522, 93);
            this.cbxAlfanumerico.Name = "cbxAlfanumerico";
            this.cbxAlfanumerico.Size = new System.Drawing.Size(148, 28);
            this.cbxAlfanumerico.TabIndex = 7;
            this.cbxAlfanumerico.Text = "Alfanumerico";
            this.cbxAlfanumerico.UseVisualStyleBackColor = true;
            // 
            // cbxLongitudExacta
            // 
            this.cbxLongitudExacta.AutoSize = true;
            this.cbxLongitudExacta.Location = new System.Drawing.Point(522, 51);
            this.cbxLongitudExacta.Name = "cbxLongitudExacta";
            this.cbxLongitudExacta.Size = new System.Drawing.Size(168, 28);
            this.cbxLongitudExacta.TabIndex = 6;
            this.cbxLongitudExacta.Text = "LongitudExacta";
            this.cbxLongitudExacta.UseVisualStyleBackColor = true;
            this.cbxLongitudExacta.CheckedChanged += new System.EventHandler(this.cbxLongitudExacta_CheckedChanged);
            // 
            // txtLongitudMaxima
            // 
            this.txtLongitudMaxima.Location = new System.Drawing.Point(223, 132);
            this.txtLongitudMaxima.Name = "txtLongitudMaxima";
            this.txtLongitudMaxima.Size = new System.Drawing.Size(140, 32);
            this.txtLongitudMaxima.TabIndex = 5;
            // 
            // txtLongitudMinima
            // 
            this.txtLongitudMinima.Location = new System.Drawing.Point(223, 90);
            this.txtLongitudMinima.Name = "txtLongitudMinima";
            this.txtLongitudMinima.Size = new System.Drawing.Size(140, 32);
            this.txtLongitudMinima.TabIndex = 4;
            this.txtLongitudMinima.TextChanged += new System.EventHandler(this.txtLongitudMinima_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 32);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Longitud Maxima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud Minima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvTipoDocumento
            // 
            this.dgvTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDocumento.Location = new System.Drawing.Point(13, 225);
            this.dgvTipoDocumento.Name = "dgvTipoDocumento";
            this.dgvTipoDocumento.RowHeadersWidth = 51;
            this.dgvTipoDocumento.RowTemplate.Height = 24;
            this.dgvTipoDocumento.Size = new System.Drawing.Size(905, 314);
            this.dgvTipoDocumento.TabIndex = 1;
            this.dgvTipoDocumento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoDocumento_CellClick);
            // 
            // FrmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 551);
            this.Controls.Add(this.dgvTipoDocumento);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTipoDocumento";
            this.Text = "FrmTipoDocumento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLongitudMaxima;
        private System.Windows.Forms.TextBox txtLongitudMinima;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.CheckBox cbxAlfanumerico;
        private System.Windows.Forms.CheckBox cbxLongitudExacta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTipoDocumento;
        private System.Windows.Forms.CheckBox cbxClienteJuridico;
    }
}
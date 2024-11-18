namespace Proyecto_Final_MOANSO
{
    partial class FrmCategoriaProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregaCategoria = new System.Windows.Forms.Button();
            this.btnModificaCategoria = new System.Windows.Forms.Button();
            this.btnEliminaCategoria = new System.Windows.Forms.Button();
            this.cbEstadoCategoria = new System.Windows.Forms.CheckBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalirFrmCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Categoría:";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNombreCategoria.Location = new System.Drawing.Point(193, 22);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(176, 27);
            this.txtNombreCategoria.TabIndex = 1;
            // 
            // btnAgregaCategoria
            // 
            this.btnAgregaCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAgregaCategoria.Location = new System.Drawing.Point(451, 66);
            this.btnAgregaCategoria.Name = "btnAgregaCategoria";
            this.btnAgregaCategoria.Size = new System.Drawing.Size(84, 31);
            this.btnAgregaCategoria.TabIndex = 2;
            this.btnAgregaCategoria.Text = "Agregar";
            this.btnAgregaCategoria.UseVisualStyleBackColor = true;
            this.btnAgregaCategoria.Click += new System.EventHandler(this.btnAgregaCategoria_Click);
            // 
            // btnModificaCategoria
            // 
            this.btnModificaCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnModificaCategoria.Location = new System.Drawing.Point(451, 128);
            this.btnModificaCategoria.Name = "btnModificaCategoria";
            this.btnModificaCategoria.Size = new System.Drawing.Size(84, 30);
            this.btnModificaCategoria.TabIndex = 3;
            this.btnModificaCategoria.Text = "Modificar";
            this.btnModificaCategoria.UseVisualStyleBackColor = true;
            this.btnModificaCategoria.Click += new System.EventHandler(this.btnModificaCategoria_Click);
            // 
            // btnEliminaCategoria
            // 
            this.btnEliminaCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEliminaCategoria.Location = new System.Drawing.Point(451, 187);
            this.btnEliminaCategoria.Name = "btnEliminaCategoria";
            this.btnEliminaCategoria.Size = new System.Drawing.Size(84, 29);
            this.btnEliminaCategoria.TabIndex = 4;
            this.btnEliminaCategoria.Text = "Eliminar";
            this.btnEliminaCategoria.UseVisualStyleBackColor = true;
            this.btnEliminaCategoria.Click += new System.EventHandler(this.btnEliminaCategoria_Click);
            // 
            // cbEstadoCategoria
            // 
            this.cbEstadoCategoria.AutoSize = true;
            this.cbEstadoCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbEstadoCategoria.Location = new System.Drawing.Point(412, 24);
            this.cbEstadoCategoria.Name = "cbEstadoCategoria";
            this.cbEstadoCategoria.Size = new System.Drawing.Size(75, 23);
            this.cbEstadoCategoria.TabIndex = 5;
            this.cbEstadoCategoria.Text = "Estado";
            this.cbEstadoCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(16, 66);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(353, 150);
            this.dgvCategoria.TabIndex = 6;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHabilitar.Location = new System.Drawing.Point(16, 244);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(86, 30);
            this.btnHabilitar.TabIndex = 7;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeshabilitar.Location = new System.Drawing.Point(263, 244);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(106, 30);
            this.btnDeshabilitar.TabIndex = 8;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnSalirFrmCategoria
            // 
            this.btnSalirFrmCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSalirFrmCategoria.Location = new System.Drawing.Point(463, 258);
            this.btnSalirFrmCategoria.Name = "btnSalirFrmCategoria";
            this.btnSalirFrmCategoria.Size = new System.Drawing.Size(81, 31);
            this.btnSalirFrmCategoria.TabIndex = 9;
            this.btnSalirFrmCategoria.Text = "Salir";
            this.btnSalirFrmCategoria.UseVisualStyleBackColor = true;
            this.btnSalirFrmCategoria.Click += new System.EventHandler(this.btnSalirFrmCategoria_Click);
            // 
            // FrmCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 301);
            this.Controls.Add(this.btnSalirFrmCategoria);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.cbEstadoCategoria);
            this.Controls.Add(this.btnEliminaCategoria);
            this.Controls.Add(this.btnModificaCategoria);
            this.Controls.Add(this.btnAgregaCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategoriaProducto";
            this.Text = "FrmCategoriaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnAgregaCategoria;
        private System.Windows.Forms.Button btnModificaCategoria;
        private System.Windows.Forms.Button btnEliminaCategoria;
        private System.Windows.Forms.CheckBox cbEstadoCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalirFrmCategoria;
    }
}
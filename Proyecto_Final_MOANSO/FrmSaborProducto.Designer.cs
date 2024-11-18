namespace Proyecto_Final_MOANSO
{
    partial class FrmSaborProducto
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
            this.txtNombreSabor = new System.Windows.Forms.TextBox();
            this.btnModificaSabor = new System.Windows.Forms.Button();
            this.btnAgregaSabor = new System.Windows.Forms.Button();
            this.dgvSabor = new System.Windows.Forms.DataGridView();
            this.cbEstadoSabor = new System.Windows.Forms.CheckBox();
            this.btnEliminaSabor = new System.Windows.Forms.Button();
            this.btnHabilitarSabor = new System.Windows.Forms.Button();
            this.btnDeshabilitarSabor = new System.Windows.Forms.Button();
            this.btnSalirFrmSabor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor:";
            // 
            // txtNombreSabor
            // 
            this.txtNombreSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNombreSabor.Location = new System.Drawing.Point(78, 21);
            this.txtNombreSabor.Name = "txtNombreSabor";
            this.txtNombreSabor.Size = new System.Drawing.Size(246, 27);
            this.txtNombreSabor.TabIndex = 1;
            // 
            // btnModificaSabor
            // 
            this.btnModificaSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnModificaSabor.Location = new System.Drawing.Point(469, 69);
            this.btnModificaSabor.Name = "btnModificaSabor";
            this.btnModificaSabor.Size = new System.Drawing.Size(84, 30);
            this.btnModificaSabor.TabIndex = 2;
            this.btnModificaSabor.Text = "Modificar";
            this.btnModificaSabor.UseVisualStyleBackColor = true;
            this.btnModificaSabor.Click += new System.EventHandler(this.btnModificaSabor_Click);
            // 
            // btnAgregaSabor
            // 
            this.btnAgregaSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAgregaSabor.Location = new System.Drawing.Point(366, 69);
            this.btnAgregaSabor.Name = "btnAgregaSabor";
            this.btnAgregaSabor.Size = new System.Drawing.Size(84, 31);
            this.btnAgregaSabor.TabIndex = 3;
            this.btnAgregaSabor.Text = "Agregar";
            this.btnAgregaSabor.UseVisualStyleBackColor = true;
            this.btnAgregaSabor.Click += new System.EventHandler(this.btnAgregaSabor_Click);
            // 
            // dgvSabor
            // 
            this.dgvSabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabor.Location = new System.Drawing.Point(20, 69);
            this.dgvSabor.Name = "dgvSabor";
            this.dgvSabor.Size = new System.Drawing.Size(304, 340);
            this.dgvSabor.TabIndex = 4;
            // 
            // cbEstadoSabor
            // 
            this.cbEstadoSabor.AutoSize = true;
            this.cbEstadoSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbEstadoSabor.Location = new System.Drawing.Point(375, 21);
            this.cbEstadoSabor.Name = "cbEstadoSabor";
            this.cbEstadoSabor.Size = new System.Drawing.Size(75, 23);
            this.cbEstadoSabor.TabIndex = 5;
            this.cbEstadoSabor.Text = "Estado";
            this.cbEstadoSabor.UseVisualStyleBackColor = true;
            // 
            // btnEliminaSabor
            // 
            this.btnEliminaSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEliminaSabor.Location = new System.Drawing.Point(366, 133);
            this.btnEliminaSabor.Name = "btnEliminaSabor";
            this.btnEliminaSabor.Size = new System.Drawing.Size(84, 29);
            this.btnEliminaSabor.TabIndex = 6;
            this.btnEliminaSabor.Text = "Eliminar";
            this.btnEliminaSabor.UseVisualStyleBackColor = true;
            this.btnEliminaSabor.Click += new System.EventHandler(this.btnEliminaSabor_Click);
            // 
            // btnHabilitarSabor
            // 
            this.btnHabilitarSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHabilitarSabor.Location = new System.Drawing.Point(469, 132);
            this.btnHabilitarSabor.Name = "btnHabilitarSabor";
            this.btnHabilitarSabor.Size = new System.Drawing.Size(86, 30);
            this.btnHabilitarSabor.TabIndex = 7;
            this.btnHabilitarSabor.Text = "Habilitar";
            this.btnHabilitarSabor.UseVisualStyleBackColor = true;
            this.btnHabilitarSabor.Click += new System.EventHandler(this.btnHabilitarSabor_Click);
            // 
            // btnDeshabilitarSabor
            // 
            this.btnDeshabilitarSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeshabilitarSabor.Location = new System.Drawing.Point(414, 193);
            this.btnDeshabilitarSabor.Name = "btnDeshabilitarSabor";
            this.btnDeshabilitarSabor.Size = new System.Drawing.Size(106, 30);
            this.btnDeshabilitarSabor.TabIndex = 8;
            this.btnDeshabilitarSabor.Text = "Deshabilitar";
            this.btnDeshabilitarSabor.UseVisualStyleBackColor = true;
            this.btnDeshabilitarSabor.Click += new System.EventHandler(this.btnDeshabilitarSabor_Click);
            // 
            // btnSalirFrmSabor
            // 
            this.btnSalirFrmSabor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSalirFrmSabor.Location = new System.Drawing.Point(463, 391);
            this.btnSalirFrmSabor.Name = "btnSalirFrmSabor";
            this.btnSalirFrmSabor.Size = new System.Drawing.Size(81, 31);
            this.btnSalirFrmSabor.TabIndex = 9;
            this.btnSalirFrmSabor.Text = "Salir";
            this.btnSalirFrmSabor.UseVisualStyleBackColor = true;
            this.btnSalirFrmSabor.Click += new System.EventHandler(this.btnSalirFrmSabor_Click);
            // 
            // FrmSaborProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 434);
            this.Controls.Add(this.btnSalirFrmSabor);
            this.Controls.Add(this.btnDeshabilitarSabor);
            this.Controls.Add(this.btnHabilitarSabor);
            this.Controls.Add(this.btnEliminaSabor);
            this.Controls.Add(this.cbEstadoSabor);
            this.Controls.Add(this.dgvSabor);
            this.Controls.Add(this.btnAgregaSabor);
            this.Controls.Add(this.btnModificaSabor);
            this.Controls.Add(this.txtNombreSabor);
            this.Controls.Add(this.label1);
            this.Name = "FrmSaborProducto";
            this.Text = "FrmSaborProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreSabor;
        private System.Windows.Forms.Button btnModificaSabor;
        private System.Windows.Forms.Button btnAgregaSabor;
        private System.Windows.Forms.DataGridView dgvSabor;
        private System.Windows.Forms.CheckBox cbEstadoSabor;
        private System.Windows.Forms.Button btnEliminaSabor;
        private System.Windows.Forms.Button btnHabilitarSabor;
        private System.Windows.Forms.Button btnDeshabilitarSabor;
        private System.Windows.Forms.Button btnSalirFrmSabor;
    }
}
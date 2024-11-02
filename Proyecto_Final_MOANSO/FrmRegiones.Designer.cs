namespace Proyecto_Final_MOANSO
{
    partial class FrmRegiones
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
            this.dgvRegionesCorea = new System.Windows.Forms.DataGridView();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegionesCorea)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegionesCorea
            // 
            this.dgvRegionesCorea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegionesCorea.Location = new System.Drawing.Point(12, 66);
            this.dgvRegionesCorea.Name = "dgvRegionesCorea";
            this.dgvRegionesCorea.Size = new System.Drawing.Size(540, 258);
            this.dgvRegionesCorea.TabIndex = 0;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCambiarEstado.Location = new System.Drawing.Point(186, 19);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(81, 29);
            this.btnCambiarEstado.TabIndex = 18;
            this.btnCambiarEstado.Text = "Cambiar";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione una región:";
            // 
            // FrmRegiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.dgvRegionesCorea);
            this.Name = "FrmRegiones";
            this.Text = "FrmRegiones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegionesCorea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegionesCorea;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Label label1;
    }
}
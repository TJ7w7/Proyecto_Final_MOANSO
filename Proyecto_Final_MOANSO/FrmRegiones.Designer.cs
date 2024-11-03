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
            this.label1 = new System.Windows.Forms.Label();
            this.btncambiar = new System.Windows.Forms.Button();
            this.dtgridRegiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridRegiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Seleccione una región:";
            // 
            // btncambiar
            // 
            this.btncambiar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btncambiar.Location = new System.Drawing.Point(186, 16);
            this.btncambiar.Margin = new System.Windows.Forms.Padding(2);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(81, 29);
            this.btncambiar.TabIndex = 21;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // dtgridRegiones
            // 
            this.dtgridRegiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridRegiones.Location = new System.Drawing.Point(12, 63);
            this.dtgridRegiones.Name = "dtgridRegiones";
            this.dtgridRegiones.Size = new System.Drawing.Size(540, 258);
            this.dtgridRegiones.TabIndex = 20;
            // 
            // FrmRegiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.dtgridRegiones);
            this.Name = "FrmRegiones";
            this.Text = "FrmRegiones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridRegiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.DataGridView dtgridRegiones;
    }
}
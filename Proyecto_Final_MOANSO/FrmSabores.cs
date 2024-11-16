using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Proyecto_Final_MOANSO
{
    public partial class FrmSabores : Form
    {
        public FrmSabores()
        {
            InitializeComponent();
            CargarSabores();
        }

        public void CargarSabores()
        {
            
           dgvSabores.DataSource = LogSabores.Instancia.listarSabores();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtDescripcion.Text == "")
            {
                MessageBox.Show("Porfavor Complete los datos", "Error");
            }
            else
            {
                try
                {
                    EntSabores sab = new EntSabores();
                    sab.Nombre = txtNombre.Text;
                    sab.Descripcion = txtDescripcion.Text;
                    sab.Estado = cbxEstado.Checked;
                    LogSabores.Instancia.InsertarSabores(sab);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarSabores();
                Limpiar();
            }
        }

        public string id;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Porfavor Seleccione un elemento", "Error");
            }
            else
            {
                try
                {
                    EntSabores sab = new EntSabores();
                    sab.SaboresId = int.Parse(id);
                    sab.Nombre = txtNombre.Text;
                    sab.Descripcion = txtDescripcion.Text;
                    sab.Estado = cbxEstado.Checked;
                    LogSabores.Instancia.EditarSabores(sab);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                CargarSabores();
                Limpiar();
            }
        }

        private void dgvSabores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvSabores.Rows[e.RowIndex];
            id = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}

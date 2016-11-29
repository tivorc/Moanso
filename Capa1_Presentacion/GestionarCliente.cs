using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa1_Presentacion
{
    public partial class GestionarCliente : Form
    {
        public GestionarCliente()
        {
            InitializeComponent();
            deshabilitar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            habilitar();
        }
        public void deshabilitar()
        {
            txtID.Enabled = false;
            txtnumerodocumento.Enabled = false;
            txtnombre.Enabled = false;
            txtapellidos.Enabled = false;
            cbTipoDocumento.Enabled = false;
            btnGuardar.Enabled = false;
            btncancelar.Enabled = false;
            
        }

        public void habilitar()
        {
            txtID.Enabled = true;
            txtnumerodocumento.Enabled = true;
            txtnombre.Enabled = true;
            txtapellidos.Enabled = true;
            cbTipoDocumento.Enabled = true;
            btnGuardar.Enabled = true;
            btncancelar.Enabled = true;
        }
    }
}

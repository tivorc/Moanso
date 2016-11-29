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
            txtnumerodocumento.Enabled = false;
            txtnombre.Enabled = false;
            txtapellidopaterno.Enabled = false;
            txtapellidomaterno.Enabled = false;
            txtdireccion.Enabled = false;
            txttelefono.Enabled = false;
            rdbclientenatural.Enabled = false;
            rbdclientejuridico.Enabled = false;
            txtruc.Enabled = false;
            txtrazonsocial.Enabled = false;
            
        }

        public void habilitar()
        {
            txtnumerodocumento.Enabled = true;
            txtnombre.Enabled = true;
            txtapellidopaterno.Enabled = true;
            txtapellidomaterno.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
            rdbclientenatural.Enabled = true;
            rbdclientejuridico.Enabled = true;
            txtruc.Enabled = true;
            txtrazonsocial.Enabled = true;
        }
    }
}

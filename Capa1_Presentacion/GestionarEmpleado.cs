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
    public partial class GestionarEmpleado : Form
    {
        public GestionarEmpleado()
        {
            InitializeComponent();
            deshabilitar();
        }

        private void GestionarEmpleado_Load(object sender, EventArgs e)
        {

        }
        private void deshabilitar()
        {
            txtId.Enabled = false;
            txtNumeroDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            cbTipoEmpleado.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            cbTipoDocumento.Enabled = false;
        }
        private void habilitar()
        {
            txtId.Enabled = true;
            txtNumeroDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            cbTipoEmpleado.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            cbTipoDocumento.Enabled = true;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            habilitar();
        }
    }
}

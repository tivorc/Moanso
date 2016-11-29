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
    public partial class GestionarPago : Form
    {
        public GestionarPago()
        {
            InitializeComponent();
            deshabilitar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
        private void deshabilitar()
        {
            txtDniCliente.Enabled = false;
            btnSeleccionarCliente.Enabled = false;
            btnGenerarComprobante.Enabled = false;
        }
        private void habilitar()
        {
            txtDniCliente.Enabled = true;
            btnSeleccionarCliente.Enabled = true;
            btnGenerarComprobante.Enabled = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            habilitar();
        }
    }
}

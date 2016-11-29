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
          
        }

        private void GestionarEmpleado_Load(object sender, EventArgs e)
        {

        }
       
       

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            datosEmpleado.Show();
            this.Hide();    
        }
    }
}

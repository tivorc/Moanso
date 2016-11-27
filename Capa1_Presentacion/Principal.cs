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
    public partial class Principal : Form
    {
        GestionarHabitacion gestionarHabitacion = new GestionarHabitacion();
        GestionarReserva gestionarReserva = new GestionarReserva();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            gestionarHabitacion.Show();
            this.Hide();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            gestionarReserva.Show();
            this.Hide();
        }
    }
}

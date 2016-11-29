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
        GestionarEmpleado gestionarEmpleado = new GestionarEmpleado();
        GestionarReserva gestionarReserva = new GestionarReserva();
        GestionarPago gestionarPago = new GestionarPago();
        TipoHabitacion tipoHabitacion = new TipoHabitacion();
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

        private void btnPago_Click(object sender, EventArgs e)
        {
            gestionarPago.Show();
            this.Hide();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            gestionarEmpleado.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoHabitacion.Show();
            this.Hide();
        }
    }
}

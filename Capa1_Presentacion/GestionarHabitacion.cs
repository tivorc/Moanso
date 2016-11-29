using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa2_Aplicacion;
using Capa3_Dominio;

namespace Capa1_Presentacion
{
    public partial class GestionarHabitacion : Form
    {
        public GestionarHabitacion()
        {
            InitializeComponent();
            ejecutarConsulta();
            Deshabilitar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
        private void ejecutarConsulta()
        {
            try
            {
                GestionarHabitacionServicio gestionarhabitacionservicio = new GestionarHabitacionServicio();
                List<Habitacion> listahabitacion = gestionarhabitacionservicio.MostrarHabitaciones();
                if (listahabitacion.Count > 0) // para verificar si existen filas
                {
                    tablaHabitacion.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                    BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                    datosEnlazados.DataSource = listahabitacion;
                    tablaHabitacion.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                    //configurarColumnasDataGridView();
                    tablaHabitacion.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada
                }
                else
                {
                    tablaHabitacion.Rows.Clear(); // se eliminan todas las filas existentes del DataGridView
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema a ejecutar la consula de alumnos. \n\nIntente de nuevo o verifique con el Administrador."+err.ToString(), "AquariumSof: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void iniciarConsulta()
        {
            ejecutarConsulta("");
            //texNombre.Text = "";
            //texNombre.Focus();
        }
        private void FormGestionarAlumnos_Shown(object sender, EventArgs e)
        {
            iniciarConsulta();
        }
        */
        private void Deshabilitar()
        {
            txtnumero.Enabled = false;
            cbPiso.Enabled = false;
            cbEstado.Enabled = false;
            txtnombre.Enabled = false;
            txtdescripcion.Enabled = false;
            txtPreciohora.Enabled = false;
            txtpreciodia.Enabled = false;
        }

        private void Habilitar()
        {
            txtnumero.Enabled = true;
            cbPiso.Enabled = true;
            cbEstado.Enabled = true;
            txtnombre.Enabled = true;
            txtdescripcion.Enabled = true;
            txtPreciohora.Enabled = true;
            txtpreciodia.Enabled = true;
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void cbPiso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

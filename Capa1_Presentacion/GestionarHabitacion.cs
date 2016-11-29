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
        
        Habitacion habitacion;
        private const int ACCION_CREAR = 1;
        private const int ACCION_MODIFICAR = 2;
        private int tipoAccion;

        public GestionarHabitacion()
        {
            InitializeComponent();
            tipoAccion = ACCION_CREAR;
            this.habitacion = new Habitacion();
            Deshabilitar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
        
        public GestionarHabitacion(Habitacion habitacion)
        {
            InitializeComponent();
            tipoAccion = ACCION_MODIFICAR;
            this.habitacion = habitacion;
            txtNumeroHabitacion.Text = habitacion.Numero;
            comboboxTipo.SelectedText = habitacion.Tipo_habitacion;
            txtPrecio.Text = habitacion.Precio.ToString();
            comboboxEstado.SelectedText = habitacion.Estado;
        }
        private void Deshabilitar()
        {
            txtIDHabitacion.Enabled = false;
            txtNumeroHabitacion.Enabled = false;
            comboboxTipo.Enabled = false;
            txtPrecio.Enabled = false;
            comboboxEstado.Enabled = false;
        }

        private void Habilitar()
        {
            txtIDHabitacion.Enabled = false;
            txtNumeroHabitacion.Enabled = true;
            comboboxTipo.Enabled = true;
            txtPrecio.Enabled = true;
            comboboxEstado.Enabled = true;
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            Habilitar();
            
        }

        private void cbPiso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tablaHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarHabitacion_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            // se recupera el valor de cada caja de texto con su propiedad Text
            // y se eliminan los espacios en blanco a la izquierda y derecha de cada caja de texto con su método Trim()
            habitacion.Numero = txtNumeroHabitacion.Text.Trim();
            habitacion.Tipo_habitacion = comboboxTipo.Text.Trim();
            habitacion.Precio = double.Parse(txtPrecio.Text.Trim());
            habitacion.Estado = comboboxEstado.Text.Trim();

            // se compara la longitud de las cadenas que son obligatorias
            if (habitacion.Numero.Length == 0 || habitacion.Tipo_habitacion.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el numero de habitacion y el tipo de habitaciones", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroHabitacion.Focus();
                return;
            }
            try
            {
                GestionarHabitacionServicio gestionarHabitacionServicio = new GestionarHabitacionServicio();
                if (tipoAccion == ACCION_CREAR)
                {
                    registros_afectados = gestionarHabitacionServicio.guardarHabitacion(habitacion);
                    if (registros_afectados == 1)
                        MessageBox.Show("La Habitacion fue creado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("La Habitacion no pudo ser creado, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    registros_afectados = gestionarHabitacionServicio.modificarHabitacion(habitacion);
                    if (registros_afectados == 1)
                        MessageBox.Show("La Habitacion fue modificado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("La Habitacion seleccionado no existe, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               // Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar La Habitacion. \n\nIntente de nuevo o verifique con el Administrador.", "AquariumSoft: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*private void btnGuardarHabitacion_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            habitacion.Numero = txtNumeroHabitacion.Text.Trim();
            habitacion.Tipo_habitacion = comboboxTipo.SelectedText.Trim();
            habitacion.Precio = double.Parse(txtPrecio.Text.Trim());
            habitacion.Estado = comboboxEstado.SelectedText.Trim();

            if (habitacion.Numero.Length == 0 || habitacion.Tipo_habitacion.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el numero de habitacion y el tipo de habitacion", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroHabitacion.Focus();
                return;
            }
            try
            {
                GestionarHabitacionServicio gestionarHabitacionServicio = new GestionarHabitacionServicio();
                if (tipoAccion == ACCION_CREAR)
                {
                    registros_afectados = gestionarHabitacionServicio.guardarHabitacion(habitacion);
                    if (registros_afectados == 1)
                        MessageBox.Show("La Habitacion fue creado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("La Habitacion no pudo ser creado, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    registros_afectados = gestionarHabitacionServicio.modificarHabitacion(habitacion);
                    if (registros_afectados == 1)
                        MessageBox.Show("La Habitacion fue modificado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("La Habitacion seleccionado no existe, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar La Habitacion. \n\nIntente de nuevo o verifique con el Administrador.", "AquariumSoft: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


    }
}


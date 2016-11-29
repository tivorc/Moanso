using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa3_Dominio;
using Capa2_Aplicacion;

namespace Capa1_Presentacion
{
    public partial class DatosEmpleado : Form
    {
        Empleado empleado;
        private const int ACCION_CREAR = 1;
        private const int ACCION_MODIFICAR = 2;
        private int tipoAccion;
        public DatosEmpleado()
        {
            InitializeComponent();
            tipoAccion = ACCION_CREAR;
            this.empleado = new Empleado();
            Deshabilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            empleado.Numero_documento = txtNumeroDocumento.Text;
            empleado.Nombre = txtNombre.Text.Trim();
            empleado.Apellidos = txtApellidos.Text.Trim();
            empleado.Telefono = txtTelefono.Text.Trim();
            empleado.Tipo_empleado = comboboxTipoEmpleado.Text.Trim();
            empleado.Nombre_usuario = txtUsuario.Text.Trim();
            empleado.Contraseña = txtContraseña.Text.Trim();
            empleado.Tipo_documento = comboboxTipoDocumento.Text.Trim();
            if (empleado.Numero_documento.Length == 0 || empleado.Tipo_empleado.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el numero de habitacion y el tipo de habitaciones", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroDocumento.Focus();
                return;
            }
            try
            {
                GestionarEmpleadoServicio gestionarEmpleadoServicio = new GestionarEmpleadoServicio();
                if (tipoAccion == ACCION_CREAR)
                {
                    registros_afectados = gestionarEmpleadoServicio.guardarEmpleado(empleado);
                    if (registros_afectados == 1)
                        MessageBox.Show("La Habitacion fue creado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("La Habitacion no pudo ser creado, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    registros_afectados = gestionarEmpleadoServicio.modificarEmpleado(empleado);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Habilitar();
        }
        public DatosEmpleado(Empleado empleado)
        {
            InitializeComponent();
            tipoAccion = ACCION_MODIFICAR;
            this.empleado = empleado;
            txtNumeroDocumento.Text = empleado.Numero_documento;
            txtNombre.Text = empleado.Nombre;
            txtApellidos.Text = empleado.Apellidos;
            txtTelefono.Text = empleado.Telefono;
            comboboxTipoEmpleado.SelectedText = empleado.Tipo_empleado;
            txtUsuario.Text = empleado.Nombre_usuario;
            txtContraseña.Text = empleado.Contraseña;
            comboboxTipoDocumento.SelectedText = empleado.Tipo_documento;
        }
        private void Deshabilitar()
        {
            txtNumeroDocumento.Enabled= false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            comboboxTipoEmpleado.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            comboboxTipoDocumento.Enabled = false;
        }

        private void Habilitar()
        {
           // txtID.Enabled = true;
            txtNumeroDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            comboboxTipoEmpleado.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            comboboxTipoDocumento.Enabled = true;
        }
    }
}

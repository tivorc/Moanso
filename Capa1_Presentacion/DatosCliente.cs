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
    public partial class DatosCliente : Form
    {
        Cliente cliente;
        private const int ACCION_CREAR = 1;
        private const int ACCION_MODIFICAR = 2;
        private int tipoAccion;
        public DatosCliente()
        {
            InitializeComponent();
            tipoAccion = ACCION_CREAR;
            this.cliente = new Cliente();
            Deshabilitar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            cliente.Numero_documento = txtNumero.Text.Trim();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellidos = txtApellido.Text.Trim();
            cliente.Tipo_documento = comboBox1.Text.Trim();

            if (cliente.Numero_documento.Length == 0 || cliente.Tipo_documento.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el numero documento y tipo documento", "HOTEL ISIS: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
                return;
            }
            try
            {
                GestionarClienteServicio gestionarClienteServicio = new GestionarClienteServicio();
                if (tipoAccion == ACCION_CREAR)
                {
                    registros_afectados = gestionarClienteServicio.guardarCliente(cliente);
                    if (registros_afectados == 1)
                        MessageBox.Show("El cliente fue creado.", "HOTEL ISIS: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El cliente no pudo ser creado, verifique.", "HOTEL ISIS: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    registros_afectados = gestionarClienteServicio.modificarCliente(cliente);
                    if (registros_afectados == 1)
                        MessageBox.Show("El cliente fue modificado.", "HOTEL ISIS: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El cliente seleccionado no existe, verifique.", "HOTEL ISIS: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al guardar El cliente. \n\nIntente de nuevo o verifique con el Administrador.", "HOTEL ISIS: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DatosCliente(Cliente cliente)
        {
            InitializeComponent();
            tipoAccion = ACCION_MODIFICAR;
            this.cliente = cliente;
            txtNumero.Text = cliente.Numero_documento;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellidos;
            comboBox1.SelectedText = cliente.Tipo_documento;
        }
        private void Deshabilitar()
        {
            txtNumero.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void Habilitar()
        {
            // txtIDHabitacion.Enabled = true;
            txtNumero.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Habilitar();
        }
    }
}

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
    public partial class GestionarCliente : Form
    {

        Cliente cliente;
        private const int ACCION_CREAR = 1;
        private const int ACCION_MODIFICAR = 2;
        private int tipoAcciones;

        public GestionarCliente()
        {
            InitializeComponent();
            tipoAccion = ACCION_CREAR;
            this.cliente = new Cliente();
           // deshabilitar();
        }
        private void configurarColumnasDataGridView()
        {
            DataGridViewColumn columna0, columna1, columna2, columna3, columna4; // objetos columna
            // modificar los encabezados de columnas de la tabla
            columna0 = tablaclientes.Columns[0]; // se recupera la columna Id
            columna0.Visible = false; // se oculta la columna
            columna1 = tablaclientes.Columns[1]; // se recupera la columna nombre
            columna1.HeaderText = "NumeroDocumento"; // se asigna el encabezado de columna
            columna1.Width = 200; // se asigna el ancho de la columna
            columna2 = tablaclientes.Columns[2];
            columna2.HeaderText = "Nombre";
            columna2.Width = 80;
            columna3 = tablaclientes.Columns[3];
            columna3.HeaderText = "Apellido_Paterno";
            columna3.Width = 200;
            columna4 = tablaclientes.Columns[4];
            columna4.HeaderText = "Apellido_Materno";
            columna4.Width = 200;
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           // habilitar();
        }
       /* public void deshabilitar()
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
        */
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}

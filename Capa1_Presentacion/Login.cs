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
    public partial class Login : Form
    {
        Principal principal = new Principal();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            string usuario;
            string password;
            usuario = txtUsuario.Text;
            password = txtContraseña.Text;
            if (usuario.Equals("admin") && password.Equals("123"))
            {
                MessageBox.Show(this, "Bienvenido","HOTEL ISIS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                principal.Show();

            }
            else
            {
                MessageBox.Show(this, "Datos incorrectos","ALERTA",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.Enter))
            {
                Principal principal = new Principal();
                string usuario;
                string password;
                usuario = txtUsuario.Text;
                password = txtContraseña.Text;
                if (usuario.Equals("admin") && password.Equals("123"))
                {
                    MessageBox.Show(this, "Bienvenido", "HOTEL ISIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    principal.Show();

                }
                else
                {
                    MessageBox.Show(this, "Datos incorrectos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

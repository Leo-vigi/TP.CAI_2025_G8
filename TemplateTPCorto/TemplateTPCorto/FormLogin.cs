using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private string usuarioAutenticado;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            LoginNegocio loginNegocio = new LoginNegocio();
            string resultado = loginNegocio.IntentarLogin(usuario, password);

            if (resultado == "Login exitoso") // Ajusta esto según tu sistema
            {
                usuarioAutenticado = usuario; // Guarda el usuario autenticado
                MessageBox.Show("Bienvenido, " + usuarioAutenticado, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       
        }

        private void buttonCambiarcontraenlogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuarioAutenticado);
            formCambio.ShowDialog();
            this.Show(); // vuelve a mostrarlo una vez cerrado el formcambiarcontraseña
        }



    }
}
}

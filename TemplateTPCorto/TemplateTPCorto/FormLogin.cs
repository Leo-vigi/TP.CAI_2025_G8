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

            if (resultado == "Login exitoso")
            {
                usuarioAutenticado = usuario;
                MessageBox.Show("Bienvenido, " + usuarioAutenticado, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    // Abre FormUsuario
                    //MessageBox.Show("Creando instancia de FormUsuario...");
                    FormUsuario formUsuario = new FormUsuario(usuario);
                    this.Hide();
                    formUsuario.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir Formulario de Usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
            if (resultado == "PRIMER_LOGIN")
            {
                MessageBox.Show("Este es su primer login, cambie su contraseña.", "Primer acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuario);
                this.Hide();
                formCambio.ShowDialog();
                this.Show();
                return;
            }
            else if (resultado == "FORZAR_CAMBIO_CONTRASEÑA")
            {
                MessageBox.Show("Tu contraseña ha expirado. Debes actualizarla.", "Cambio Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuario);
                this.Hide();
                formCambio.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //No se usa en el form Login, ya que se esta usando en el Form Usuario
        private void buttonCambiarcontraenlogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuarioAutenticado);
            formCambio.ShowDialog();
            this.Show(); // vuelve a mostrarlo una vez cerrado el formcambiarcontraseña
        }



    }
}


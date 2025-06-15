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

            if (resultado == "FORZAR_CAMBIO_CONTRASEÑA")  // 🔥 Verificamos si el usuario debe cambiar la contraseña
            {
                MessageBox.Show("Debes cambiar tu contraseña antes de continuar.", "Cambio Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuario);
                this.Hide();
                formCambio.ShowDialog();
                this.Show();
                return;
            }





            if (resultado.StartsWith("Redirigir a FormGenericoperfiles con perfil:"))
            {
                usuarioAutenticado = usuario;
                string perfil = resultado.Replace("Redirigir a FormGenericoperfiles con perfil:", "").Trim();

                Console.WriteLine($" En FormLogin - Perfil extraído correctamente: {perfil}");

                MessageBox.Show($"Bienvenido, {usuarioAutenticado}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    FormUsuario formUsuario = new FormUsuario(usuarioAutenticado, perfil);
                    this.Hide();
                    formUsuario.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir FormUsuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string resultadoLogin = loginNegocio.IntentarLogin(usuario, password);

            if (resultadoLogin == "PRIMER LOGIN")
            {
                MessageBox.Show("Este es tu primer inicio de sesión. Debes cambiar tu contraseña.", "Primer Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuario);
                formCambio.ShowDialog();
                this.Show();
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

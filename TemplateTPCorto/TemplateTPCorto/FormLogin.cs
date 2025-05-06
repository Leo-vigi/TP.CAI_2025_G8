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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;

            //LoginNegocio loginNegocio = new LoginNegocio();
            //Credencial credencial = loginNegocio.login(usuario, password);


            LoginNegocio loginNegocio = new LoginNegocio();
            string resultado = loginNegocio.IntentarLogin(usuario, password);

            MessageBox.Show(resultado, "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}

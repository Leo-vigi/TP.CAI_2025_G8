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
    public partial class Formcambiarcontraseña : Form
    {
        private string usuarioAutenticado;

        public Formcambiarcontraseña(string usuario)
        {
            InitializeComponent();
            usuarioAutenticado = usuario;
        }


        private void buttoncambiar_Click(object sender, EventArgs e)
        {
            string contraseñaActual = textBoxContraactual.Text;
            string nuevaContraseña = textBoxcontranueva.Text;
            string repetirContraseña = textBoxrepetircontra.Text;

            if (!nuevaContraseña.Equals(repetirContraseña))
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginNegocio loginNegocio = new LoginNegocio();
            string usuario = usuarioAutenticado; 
            string resultado = loginNegocio.CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);

            MessageBox.Show(resultado, "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}

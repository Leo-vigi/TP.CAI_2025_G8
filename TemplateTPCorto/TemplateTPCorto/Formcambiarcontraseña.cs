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
            string contraseñaActual = textBoxContraactual.Text.Trim();
            string nuevaContraseña = textBoxcontranueva.Text.Trim();
            string repetirContraseña = textBoxrepetircontra.Text.Trim();

            Console.WriteLine($"Contraseña actual: {contraseñaActual}");
            Console.WriteLine($"Nueva contraseña: {nuevaContraseña}");
            Console.WriteLine($"Repetir contraseña: {repetirContraseña}");

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formcambiarcontraseña_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

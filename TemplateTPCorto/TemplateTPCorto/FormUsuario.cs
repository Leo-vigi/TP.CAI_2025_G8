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
    public partial class FormUsuario : Form
    {
        //Este form se carga cuando el usuario ingreso exitosamente y tiene un login de menos de 30 dias

        private string usuarioAutenticado;
        public FormUsuario(string usuario)
        {
            InitializeComponent();
            usuarioAutenticado = usuario;
            //MessageBox.Show("FormUsuario se cargo correctamente");
        }

        //Fue hecho para test del load form del usuario
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("FormUsuario cargado correctamente");
        }


        private void buttonCambiarcontraenlogin_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual y muestra el de cambio de contraseña
            Formcambiarcontraseña formCambio = new Formcambiarcontraseña(usuarioAutenticado);
            this.Hide();
            formCambio.ShowDialog();
            this.Show(); // Vuelve a mostrar FormUsuario después del cambio

        }
    }
}

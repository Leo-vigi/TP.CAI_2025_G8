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
    public partial class FormgenericoPerfiles : Form
    {
        private string usuario;
        private string perfil;

        public FormgenericoPerfiles(string usuario, string perfil)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.perfil = perfil;
            Console.WriteLine($"✅ Perfil recibido en FormgenericoPerfiles: {this.perfil}"); // 🔥 Depuración

            // ✅ Mensaje de bienvenida en lblPerfil
            lblPerfil.Text = $"Bienvenido {usuario}, tu perfil es: {perfil}";

            // ✅ Mostrar el perfil identificado en el TextBox
            txtPerfil.Text = perfil;

            // ✅ Cargar opciones en ComboBox según perfil
            CargarOpcionesPorPerfil();
        }

        private void CargarOpcionesPorPerfil()
        {
            comboBoxAcciones.Items.Clear();

            switch (perfil.Trim().ToLower())
            {
                case "supervisor":
                    comboBoxAcciones.Items.Add("Modificar Persona");
                    comboBoxAcciones.Items.Add("Desbloquear Credencial");
                    break;
                case "administrador":
                    comboBoxAcciones.Items.Add("Autorizaciones");
                    break;
                case "operador":
                    // No agrega ninguna opción
                    MessageBox.Show("No hay acciones disponibles para el perfil Operador.",
                                    "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    MessageBox.Show("Perfil no reconocido. No tienes acciones disponibles.",
                                    "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            if (comboBoxAcciones.Items.Count > 0)
            {
                comboBoxAcciones.SelectedIndex = 0; // Preselecciona la primera opción
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (comboBoxAcciones.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una opción válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccion = comboBoxAcciones.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Modificar Persona":
                    FormModificarPersona formModificar = new FormModificarPersona();
                    formModificar.ShowDialog();
                    break;
                case "Desbloquear Credencial":
                    FormDesbloquearcredencial formDesbloquear = new FormDesbloquearcredencial();
                    formDesbloquear.ShowDialog();
                    break;
                case "Autorizaciones":
                    FormAutorizaciones formAutorizaciones = new FormAutorizaciones(perfil);
                    formAutorizaciones.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Opción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }




}

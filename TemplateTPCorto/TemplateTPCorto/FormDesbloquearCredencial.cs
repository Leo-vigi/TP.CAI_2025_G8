using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormDesbloquearcredencial : Form
    {
        private string legajoActual;
        private string nombreUsuarioActual;
        private string fechaAltaActual;

        public FormDesbloquearcredencial()
        {
            InitializeComponent();
        }

        private void txtlegajo_Leave(object sender, EventArgs e)
        {
            string legajo = txtlegajo.Text.Trim();
            string rutaCredenciales = "credenciales.csv";

            if (!File.Exists(rutaCredenciales))
            {
                MessageBox.Show("Archivo credenciales.csv no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lineas = File.ReadAllLines(rutaCredenciales).Skip(1);
            var credencial = lineas.Select(line => line.Split(';')).FirstOrDefault(fields => fields[0] == legajo);

            if (credencial != null)
            {
                legajoActual = legajo;
                nombreUsuarioActual = credencial[1];
                fechaAltaActual = credencial[3];
                txtvieja.Text = credencial[2];
            }
            else
            {
                MessageBox.Show("Legajo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            string legajoModificado = txtlegajo.Text.Trim();
            string nuevaContraseña = txtnueva.Text.Trim();

            if (legajoModificado != legajoActual)
            {
                MessageBox.Show("No se puede cambiar el número de legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rutaOperaciones = "operaciones_cambio_credencial.csv";

            if (!File.Exists(rutaOperaciones))
            {
                File.WriteAllText(rutaOperaciones, "idOperacion;legajo;nombreUsuario;contrasena;fechaAlta;fechaUltimoLogin\n");
            }

            int nuevoId = File.ReadAllLines(rutaOperaciones).Skip(1).Count() + 1;
            string nuevaOperacion = $"{nuevoId};{legajoActual};{nombreUsuarioActual};{nuevaContraseña};{fechaAltaActual};{DateTime.Now:dd/MM/yyyy}";
            File.AppendAllText(rutaOperaciones, nuevaOperacion + Environment.NewLine);

            MessageBox.Show("Solicitud de cambio registrada. Un administrador debe aprobarla.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}

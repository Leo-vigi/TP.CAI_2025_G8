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
    public partial class FormAutorizaciones : Form
    {
        private string perfilUsuario;

        public FormAutorizaciones(string perfil)
        {
            InitializeComponent();
            perfilUsuario = perfil;

            // ✅ Validar si el usuario es Administrador
            if (perfilUsuario.ToLower() != "administrador")
            {
                MessageBox.Show("Acceso restringido. Solo los Administradores pueden supervisar las autorizaciones.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // ✅ Cargar solicitudes pendientes
            CargarSolicitudes();
        }

        private void CargarSolicitudes()
        {
            string rutaPersonas = "operaciones_cambio_persona.csv";
            string rutaCredenciales = "operaciones_cambio_credencial.csv";

            listBoxpersona.Items.Clear();
            listBoxcredenciales.Items.Clear();

            if (File.Exists(rutaPersonas))
            {
                var solicitudesPersonas = File.ReadAllLines(rutaPersonas).Skip(1);
                foreach (var solicitud in solicitudesPersonas)
                {
                    listBoxpersona.Items.Add(solicitud);
                }
            }

            if (File.Exists(rutaCredenciales))
            {
                var solicitudesCredenciales = File.ReadAllLines(rutaCredenciales).Skip(1);
                foreach (var solicitud in solicitudesCredenciales)
                {
                    listBoxcredenciales.Items.Add(solicitud);
                }
            }
        }

        private void btnpersona_Click(object sender, EventArgs e)
        {
            if (listBoxpersona.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una solicitud para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string solicitudSeleccionada = listBoxpersona.SelectedItem.ToString();
            ProcesarCambioPersona(solicitudSeleccionada);

            listBoxpersona.Items.Remove(listBoxpersona.SelectedItem);
            MessageBox.Show("Cambio aprobado y registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancelarpersona_Click(object sender, EventArgs e)
        {
            if (listBoxpersona.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una solicitud para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxpersona.Items.Remove(listBoxpersona.SelectedItem);
            MessageBox.Show("Solicitud cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncredenciales_Click(object sender, EventArgs e)
        {
            if (listBoxcredenciales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una solicitud para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string solicitudSeleccionada = listBoxcredenciales.SelectedItem.ToString();
            ProcesarCambioCredencial(solicitudSeleccionada);

            listBoxcredenciales.Items.Remove(listBoxcredenciales.SelectedItem);
            MessageBox.Show("Cambio aprobado y registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancelarcredenciales_Click(object sender, EventArgs e)
        {
            if (listBoxcredenciales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una solicitud para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxcredenciales.Items.Remove(listBoxcredenciales.SelectedItem);
            MessageBox.Show("Solicitud cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProcesarCambioPersona(string datos)
        {
            string rutaPersona = "persona.csv";
            string rutaOperaciones = "operación_cambio_persona.csv";
            string[] campos = datos.Split(';');

            if (!File.Exists(rutaOperaciones))
            {
                File.WriteAllText(rutaOperaciones, "idOperacion;legajo;nombre;apellido;dni;fecha_ingreso\n");
            }

            int nuevoId = File.ReadAllLines(rutaOperaciones).Skip(1).Count() + 1;
            string nuevaOperacion = $"{nuevoId};{campos[1]};{campos[2]};{campos[3]};{campos[4]};{campos[5]}";
            File.AppendAllText(rutaOperaciones, nuevaOperacion + Environment.NewLine);
        }

        private void ProcesarCambioCredencial(string datos)
        {
            string rutaCredenciales = "credenciales.csv";
            string rutaUsuarios = "Usuario_perfil.csv";
            string rutaOperaciones = "operación_cambio_credencial.csv";
            string[] campos = datos.Split(';');

            string idPerfil = File.ReadAllLines(rutaUsuarios).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(fields => fields[0] == campos[1])?[1] ?? "Sin perfil";

            if (!File.Exists(rutaOperaciones))
            {
                File.WriteAllText(rutaOperaciones, "idOperacion;legajo;nombreUsuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin\n");
            }

            int nuevoId = File.ReadAllLines(rutaOperaciones).Skip(1).Count() + 1;
            string nuevaOperacion = $"{nuevoId};{campos[1]};{campos[2]};{campos[3]};{idPerfil};{campos[4]};{DateTime.Now:dd/MM/yyyy}";
            File.AppendAllText(rutaOperaciones, nuevaOperacion + Environment.NewLine);
        }
    }

}

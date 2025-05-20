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
        // Ruta base donde se encuentran todos los archivos CSV.
        private readonly string basePath = @"C:\Users\Diego\Documents\Repo cai\TP.CAI_2025_G8\CARPETA PUNTO 4\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas";
        private string perfilUsuario;

        public FormAutorizaciones(string perfil)
        {
            InitializeComponent();
            perfilUsuario = perfil;

            // Vinculación de eventos para las solicitudes de persona
            btncargarpersonas.Click += btncargarpersonas_Click;
            btnpersona.Click += btnpersona_Click;
            btncancelarpersona.Click += btncancelarpersona_Click;

            // Vinculación de eventos para las solicitudes de credencial
            btncargarcredenciales.Click += btncargarcredenciales_Click;
            btncredenciales.Click += btncredenciales_Click;
            btncancelarcredenciales.Click += btncancelarcredenciales_Click;

            // Solo Administradores pueden supervisar
            if (perfilUsuario.ToLower() != "administrador")
            {
                MessageBox.Show("Acceso restringido. Solo los Administradores pueden supervisar las autorizaciones.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region Modificaciones de Persona
        // Carga las solicitudes de persona desde operacion_cambio_persona.csv al ListBoxPersona.
        private void btncargarpersonas_Click(object sender, EventArgs e)
        {
            string rutaOperacionesPersona = Path.Combine(basePath, "operacion_cambio_persona.csv");
            listBoxpersona.Items.Clear();

            if (!File.Exists(rutaOperacionesPersona))
            {
                MessageBox.Show("No hay solicitudes pendientes para persona.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se leen todas las líneas omitiendo el encabezado
            var lineas = File.ReadAllLines(rutaOperacionesPersona, Encoding.UTF8).Skip(1);
            foreach (var linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                    listBoxpersona.Items.Add(linea);
            }
            MessageBox.Show("Solicitudes de persona cargadas.", "Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Al aprobar una solicitud, se aplica el cambio en persona.csv.
        // La solicitud tiene el formato: idOperacion;legajo;nombre;apellido;dni;fecha_ingreso
        private void btnpersona_Click(object sender, EventArgs e)
        {
            if (listBoxpersona.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una solicitud de persona para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string solicitud = listBoxpersona.SelectedItem.ToString();
            AplicarCambioPersona(solicitud);

            listBoxpersona.Items.Remove(listBoxpersona.SelectedItem);
            MessageBox.Show("Datos de persona cargados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AplicarCambioPersona(string solicitud)
        {
            // Se espera que el formato sea: idOperacion;legajo;nombre;apellido;dni;fecha_ingreso
            string[] datos = solicitud.Split(';');
            if (datos.Length < 6)
            {
                MessageBox.Show("La solicitud de persona no tiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string legajo = datos[1];
            string nombre = datos[2];
            string apellido = datos[3];
            string dni = datos[4];
            string fechaIngreso = datos[5];

            string rutaPersona = Path.Combine(basePath, "persona.csv");
            if (!File.Exists(rutaPersona))
            {
                MessageBox.Show("El archivo persona.csv no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lineasPersona = File.ReadAllLines(rutaPersona, Encoding.UTF8).ToList();
            bool actualizado = false;

            // Se asume que la primera línea es el encabezado.
            for (int i = 1; i < lineasPersona.Count; i++)
            {
                var campos = lineasPersona[i].Split(';');
                if (campos.Length < 5)
                    continue;
                if (campos[0] == legajo)
                {
                    // Actualizamos: legajo;nombre;apellido;dni;fecha_ingreso
                    lineasPersona[i] = $"{legajo};{nombre};{apellido};{dni};{fechaIngreso}";
                    actualizado = true;
                    break;
                }
            }

            if (actualizado)
                File.WriteAllLines(rutaPersona, lineasPersona, Encoding.UTF8);
            else
                MessageBox.Show("No se encontró el legajo en persona.csv para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Cancela las solicitudes de persona (vacía el ListBox y resetea el archivo operacion_cambio_persona.csv).
        private void btncancelarpersona_Click(object sender, EventArgs e)
        {
            string rutaOperacionesPersona = Path.Combine(basePath, "operacion_cambio_persona.csv");
            listBoxpersona.Items.Clear();

            if (File.Exists(rutaOperacionesPersona))
                File.WriteAllText(rutaOperacionesPersona, "idOperacion;legajo;nombre;apellido;dni;fecha_ingreso" + Environment.NewLine, Encoding.UTF8);

            MessageBox.Show("Solicitudes de persona canceladas.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Modificaciones de Credencial
        // Carga las solicitudes de credencial desde operacion_cambio_credencial.csv al ListBoxCredenciales.
        private void btncargarcredenciales_Click(object sender, EventArgs e)
        {
            string rutaOperacionesCred = Path.Combine(basePath, "operacion_cambio_credencial.csv");
            listBoxcredenciales.Items.Clear();

            if (!File.Exists(rutaOperacionesCred))
            {
                MessageBox.Show("No hay solicitudes pendientes para credenciales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lineas = File.ReadAllLines(rutaOperacionesCred, Encoding.UTF8).Skip(1);
            foreach (var linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                    listBoxcredenciales.Items.Add(linea);
            }
            MessageBox.Show("Solicitudes de credenciales cargadas.", "Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Al aprobar una solicitud, se actualiza el archivo credenciales.csv.
        // La solicitud tiene el formato: idOperacion;legajo;nombreUuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin
        private void btncredenciales_Click(object sender, EventArgs e)
        {
            if (listBoxcredenciales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una solicitud de credenciales para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string solicitud = listBoxcredenciales.SelectedItem.ToString();
            AplicarCambioCredencial(solicitud);

            listBoxcredenciales.Items.Remove(listBoxcredenciales.SelectedItem);
            MessageBox.Show("Datos de credenciales cargados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AplicarCambioCredencial(string solicitud)
        {
            // Se espera que el formato sea: idOperacion;legajo;nombreUuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin
            string[] datos = solicitud.Split(';');
            if (datos.Length < 7)
            {
                MessageBox.Show("La solicitud de credenciales no tiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string legajo = datos[1];
            string nuevaContraseña = datos[3];

            string rutaCredenciales = Path.Combine(basePath, "credenciales.csv");
            if (!File.Exists(rutaCredenciales))
            {
                MessageBox.Show("El archivo credenciales.csv no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lineasCredenciales = File.ReadAllLines(rutaCredenciales, Encoding.UTF8).ToList();
            bool actualizado = false;

            // Se asume que la primera línea es el encabezado.
            for (int i = 1; i < lineasCredenciales.Count; i++)
            {
                var campos = lineasCredenciales[i].Split(';');
                if (campos.Length < 5)
                    continue;
                if (campos[0] == legajo)
                {
                    // Actualiza la contraseña (índice 2) y la fecha de último login (índice 4) con la fecha/hora actual.
                    campos[2] = nuevaContraseña;
                    campos[4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lineasCredenciales[i] = string.Join(";", campos);
                    actualizado = true;
                    break;
                }
            }

            if (actualizado)
                File.WriteAllLines(rutaCredenciales, lineasCredenciales, Encoding.UTF8);
            else
                MessageBox.Show("No se encontró el legajo en credenciales.csv para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Cancela las solicitudes de credenciales (limpia el ListBoxCredenciales y resetea el archivo operacion_cambio_credencial.csv).
        private void btncancelarcredenciales_Click(object sender, EventArgs e)
        {
            string rutaOperacionesCred = Path.Combine(basePath, "operacion_cambio_credencial.csv");
            listBoxcredenciales.Items.Clear();

            if (File.Exists(rutaOperacionesCred))
                File.WriteAllText(rutaOperacionesCred,
                    "idOperacion;legajo;nombreUuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin" + Environment.NewLine,
                    Encoding.UTF8);

            MessageBox.Show("Solicitudes de credenciales canceladas.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }




}

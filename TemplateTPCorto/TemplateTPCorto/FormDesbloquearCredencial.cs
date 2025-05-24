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
using static Persistencia.DataBase.DataBaseUtils;

namespace TemplateTPCorto
{
    public partial class FormDesbloquearcredencial : Form
    {
        // Variables para guardar los datos del registro obtenido de credenciales.csv
        private string legajoActual;
        private string nombreUsuarioActual;
        private string idPerfilActual;
        private string fechaAltaActual;

        public FormDesbloquearcredencial()
        {
            InitializeComponent();

            // Asignación de eventos para los botones
            btncargar.Click += new EventHandler(btncargar_Click);
            btncambiar.Click += new EventHandler(btncambiar_Click);
        }

        // Evento del botón Cargar: invoca la carga de datos desde credenciales.csv
        private void btncargar_Click(object sender, EventArgs e)
        {
            CargarDatosCredencial();
        }

        private void CargarDatosCredencial()
        {
            string legajo = txtlegajo.Text.Trim();
            string rutaCredenciales = DatabaseUtils.GetFilePath("credenciales.csv");

            if (!File.Exists(rutaCredenciales))
            {
                MessageBox.Show(" Archivo credenciales.csv no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($" Buscando legajo {legajo} en {rutaCredenciales}");
            var lineas = File.ReadAllLines(rutaCredenciales).Skip(1);

            foreach (var linea in lineas)
            {
                var datos = linea.Split(';').Select(d => d.Trim()).ToArray();
                if (datos.Length >= 5 && datos[0] == legajo)
                {
                    legajoActual = legajo;
                    nombreUsuarioActual = datos[1];
                    txtvieja.Text = datos[2];
                    fechaAltaActual = datos[3];
                    idPerfilActual = "";

                    Console.WriteLine($" Registro encontrado: legajo={legajoActual}, usuario={nombreUsuarioActual}, fechaAlta={fechaAltaActual}");
                    return;
                }
            }

            MessageBox.Show(" Legajo no encontrado en credenciales.csv.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = txtnueva.Text.Trim();
            if (string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Ingrese la nueva contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string legajoModificado = txtlegajo.Text.Trim();
            if (legajoModificado != legajoActual)
            {
                MessageBox.Show("No se puede cambiar el número de legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rutaOperaciones = DatabaseUtils.GetFilePath("operacion_cambio_credencial.csv");

            try
            {
                string directorio = Path.GetDirectoryName(rutaOperaciones);
                if (!Directory.Exists(directorio))
                {
                    Console.WriteLine($" Directorio no encontrado: {directorio}. Se creará.");
                    Directory.CreateDirectory(directorio);
                }

                if (!File.Exists(rutaOperaciones))
                {
                    Console.WriteLine(" operacion_cambio_credencial.csv no existe. Creando nuevo archivo con encabezado.");
                    File.WriteAllText(rutaOperaciones,
                        "idOperacion;legajo;nombreUsuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin" + Environment.NewLine,
                        Encoding.UTF8);
                }
                else
                {
                    string contenido = File.ReadAllText(rutaOperaciones, Encoding.UTF8);
                    if (!contenido.EndsWith("\n"))
                    {
                        File.AppendAllText(rutaOperaciones, Environment.NewLine, Encoding.UTF8);
                    }
                }

                string[] lineasExistentes = File.ReadAllLines(rutaOperaciones, Encoding.UTF8);
                int nuevoId = lineasExistentes.Length;

                string fechaUltimoLogin = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                string nuevaOperacion = $"{nuevoId};{legajoActual};{nombreUsuarioActual};{nuevaContraseña};{idPerfilActual};{fechaAltaActual};{fechaUltimoLogin}";

                using (StreamWriter sw = new StreamWriter(rutaOperaciones, true, Encoding.UTF8))
                {
                    sw.WriteLine(nuevaOperacion);
                }

                Console.WriteLine($" Solicitud registrada: {nuevaOperacion}");
                MessageBox.Show(" Solicitud de cambio de credencial registrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(" Error: " + ex.ToString());
            }
        }

        private void FormDesbloquearcredencial_Load(object sender, EventArgs e)
        {

        }
    }
}










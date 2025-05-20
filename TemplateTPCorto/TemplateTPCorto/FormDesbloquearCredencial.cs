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
        // Variables para guardar los datos del registro obtenido de credenciales.csv
        private string legajoActual;
        private string nombreUsuarioActual;
        private string idPerfilActual;  // Como tu CSV no trae idPerfil, usamos un valor predeterminado (cadena vacía)
        private string fechaAltaActual;

        // Ruta base donde se encuentran todos los archivos CSV.
        private readonly string basePath = @"C:\Users\Diego\Documents\Repo cai\TP.CAI_2025_G8\CARPETA PUNTO 4\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas";

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

        // Método que recorre credenciales.csv y carga el registro buscado por legajo.
        // El formato de credenciales.csv es:
        // legajo;nombreUsuario;contrasena;fechaAlta;fechaUltimoLogin
        private void CargarDatosCredencial()
        {
            string legajo = txtlegajo.Text.Trim();
            // Construimos la ruta completa usando la ruta base
            string rutaCredenciales = Path.Combine(basePath, "credenciales.csv");

            if (!File.Exists(rutaCredenciales))
            {
                MessageBox.Show("⚠️ Archivo credenciales.csv no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($"🔎 Buscando legajo {legajo} en {rutaCredenciales}");
            var lineas = File.ReadAllLines(rutaCredenciales).Skip(1); // Saltamos el encabezado

            foreach (var linea in lineas)
            {
                var datos = linea.Split(';').Select(d => d.Trim()).ToArray();
                // Ahora se espera que el CSV tenga al menos 5 columnas: legajo;nombreUsuario;contrasena;fechaAlta;fechaUltimoLogin
                if (datos.Length >= 5 && datos[0] == legajo)
                {
                    legajoActual = legajo;
                    nombreUsuarioActual = datos[1];
                    // datos[2] es la contraseña actual
                    txtvieja.Text = datos[2];
                    fechaAltaActual = datos[3];
                    // Como el CSV no posee idPerfil, se asigna un valor predeterminado; podés cambiarlo si requiere otro valor.
                    idPerfilActual = "";

                    Console.WriteLine($"✅ Registro encontrado: legajo={legajoActual}, usuario={nombreUsuarioActual}, fechaAlta={fechaAltaActual}");
                    return;
                }
            }

            MessageBox.Show("❌ Legajo no encontrado en credenciales.csv.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Evento del botón Cambiar: guarda la solicitud de cambio en operacion_cambio_credencial.csv
        // Formato de registro:
        // idOperacion;legajo;nombreUuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin
        private void btncambiar_Click(object sender, EventArgs e)
        {
            // Obtengo la nueva contraseña ingresada
            string nuevaContraseña = txtnueva.Text.Trim();
            if (string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Ingrese la nueva contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos que el legajo no haya sido alterado
            string legajoModificado = txtlegajo.Text.Trim();
            if (legajoModificado != legajoActual)
            {
                MessageBox.Show("No se puede cambiar el número de legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construimos la ruta completa para el archivo de operaciones
            string rutaOperaciones = Path.Combine(basePath, "operacion_cambio_credencial.csv");

            try
            {
                // Verificar (y crear si es necesario) el directorio
                string directorio = Path.GetDirectoryName(rutaOperaciones);
                if (!Directory.Exists(directorio))
                {
                    Console.WriteLine($"⚠️ Directorio no encontrado: {directorio}. Se creará.");
                    Directory.CreateDirectory(directorio);
                }

                // Si el archivo no existe, lo creamos con el encabezado
                if (!File.Exists(rutaOperaciones))
                {
                    Console.WriteLine("⚠️ operacion_cambio_credencial.csv no existe. Creando nuevo archivo con encabezado.");
                    File.WriteAllText(rutaOperaciones,
                        "idOperacion;legajo;nombreUuario;contrasena;idPerfil;fechaAlta;fechaUltimoLogin" + Environment.NewLine,
                        Encoding.UTF8);
                }
                else
                {
                    // Si el archivo existe, verificamos que termine con un salto de línea; si no, lo agregamos.
                    string contenido = File.ReadAllText(rutaOperaciones, Encoding.UTF8);
                    if (!contenido.EndsWith("\n"))
                    {
                        File.AppendAllText(rutaOperaciones, Environment.NewLine, Encoding.UTF8);
                    }
                }

                // Calcular el nuevo ID en función de la cantidad de líneas existentes (la primera es el encabezado)
                string[] lineasExistentes = File.ReadAllLines(rutaOperaciones, Encoding.UTF8);
                int nuevoId = lineasExistentes.Length;  // Si sólo existe el encabezado, nuevoId será 1

                // Se actualiza la fecha de último login a la fecha y hora actual
                string fechaUltimoLogin = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Armar la nueva línea siguiendo el formato requerido
                string nuevaOperacion = $"{nuevoId};{legajoActual};{nombreUsuarioActual};{nuevaContraseña};{idPerfilActual};{fechaAltaActual};{fechaUltimoLogin}";

                // Agregar la nueva operación al archivo en modo Append
                using (StreamWriter sw = new StreamWriter(rutaOperaciones, true, Encoding.UTF8))
                {
                    sw.WriteLine(nuevaOperacion);
                }

                Console.WriteLine($"✅ Solicitud registrada: {nuevaOperacion}");
                MessageBox.Show("✅ Solicitud de cambio de credencial registrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("❌ Error: " + ex.ToString());
            }
        }
    }

}




    




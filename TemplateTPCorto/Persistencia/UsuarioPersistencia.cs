using Datos;
using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Persistencia.DataBase.DataBaseUtils;

namespace Persistencia
{
    public class UsuarioPersistencia
    {
        public Credencial Login(string username)
        {
            List<String> registros = DatabaseUtils.BuscarRegistro("credenciales.csv");

            if (registros.Count == 0)
            {
                Console.WriteLine("Archivo credenciales.csv vacío o no encontrado.");
                return null;
            }

            foreach (string registro in registros.Skip(1)) // Omitimos la primera línea (cabecera)
            {
                Credencial credencial = new Credencial(registro);
                Console.WriteLine($"Comparando usuario: [{credencial.NombreUsuario}] vs [{username}]");

                if (credencial.NombreUsuario.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Usuario encontrado: {credencial.NombreUsuario}");
                    return credencial;
                }
            }

            Console.WriteLine("Usuario no encontrado en credenciales.csv.");
            return null;
        }

        public Credencial ObtenerCredencial(string username)
        {
            List<string> registros = DatabaseUtils.BuscarRegistro("credenciales.csv");

            if (registros.Count == 0)
            {
                Console.WriteLine("Archivo credenciales.csv vacío o no encontrado.");
                return null;
            }

            foreach (string registro in registros.Skip(1)) // Omitimos la primera línea (cabecera)
            {
                Credencial credencial = new Credencial(registro);
                Console.WriteLine($"Comparando usuario: [{credencial.NombreUsuario}] vs [{username}]");

                if (credencial.NombreUsuario.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Usuario encontrado: {credencial.NombreUsuario}");
                    return credencial;
                }
            }

            Console.WriteLine("Usuario no encontrado en credenciales.csv.");
            return null;
        }


        public bool EstaBloqueado(string username)
        {
            List<string> bloqueados = DatabaseUtils.BuscarRegistro("usuario_bloqueado.csv");

            Console.WriteLine($"Verificando si {username} está bloqueado...");

            return bloqueados.Skip(1).Any(l => l.Trim() == ObtenerCredencial(username)?.Legajo);
        }

        public void RegistrarIntentoFallido(string username)
        {
            Credencial credencial = ObtenerCredencial(username);
            if (credencial != null)
            {
                string legajo = credencial.Legajo;
                string fechaIntento = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                Console.WriteLine($"Registrando intento fallido: {legajo};{fechaIntento}");

                DatabaseUtils.AgregarRegistro("login_intentos.csv", $"{legajo};{fechaIntento}");
            }
            else
            {
                Console.WriteLine("No se pudo registrar el intento porque no se encontró la credencial.");
            }
        }

        public int ObtenerIntentos(string username)
        {
            Credencial credencial = ObtenerCredencial(username);
            if (credencial == null) return 0;

            string legajo = credencial.Legajo;
            List<string> intentos = DatabaseUtils.BuscarRegistro("login_intentos.csv");

            int contador = intentos.Skip(1) // Omitimos la cabecera
                .Count(linea => linea.StartsWith(legajo + ";"));

            Console.WriteLine($"Intentos fallidos del usuario {legajo}: {contador}");
            return contador;
        }

        public void LimpiarIntentos(string username)
        {
            Credencial credencial = ObtenerCredencial(username);
            if (credencial == null) return;

            string legajo = credencial.Legajo;
            Console.WriteLine($"Limpiando intentos de usuario {legajo}");
            DatabaseUtils.BorrarRegistro(legajo, "login_intentos.csv");
        }

        public void BloquearUsuario(string username)
        {
            Credencial credencial = ObtenerCredencial(username);
            if (credencial != null)
            {
                string legajo = credencial.Legajo;
                Console.WriteLine($"Intentando bloquear usuario con legajo: {legajo}");

                List<string> registrosBloqueados = DatabaseUtils.BuscarRegistro("usuario_bloqueado.csv");

                if (!registrosBloqueados.Contains(legajo))
                {
                    DatabaseUtils.AgregarRegistro("usuario_bloqueado.csv", legajo);
                    Console.WriteLine($"Usuario {legajo} bloqueado correctamente.");
                }
                else
                {
                    Console.WriteLine($"Usuario {legajo} ya estaba bloqueado, no se duplica.");
                }
            }
            else
            {
                Console.WriteLine("No se pudo bloquear usuario porque no se encontró la credencial.");
            }
        }

        public void ActualizarContrasena(string usuario, string nuevaContrasena)
        {
            List<string> registros = DatabaseUtils.BuscarRegistro("credenciales.csv");
            if (registros.Count == 0) return;

            for (int i = 1; i < registros.Count; i++) // Omitimos la cabecera
            {
                string[] campos = registros[i].Split(';');
                if (campos[1].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    campos[2] = nuevaContrasena.Trim();
                    campos[4] = DateTime.Now.ToString("d/M/yyyy");
                    registros[i] = string.Join(";", campos);
                    break;
                }
            }

            string rutaArchivo = DatabaseUtils.GetFilePath("credenciales.csv");

            try
            {
                Console.WriteLine($"Verificando archivo: {rutaArchivo}");
                Console.WriteLine($"Archivo existe: {File.Exists(rutaArchivo)}");

                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (string linea in registros)
                    {
                        sw.WriteLine(linea);
                    }
                }

                Console.WriteLine("Contraseña y fecha de último login actualizadas correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }
        public void ActualizarFechaUltimoLogin(string usuario)
        {
            string rutaCredenciales = DatabaseUtils.GetFilePath("credenciales.csv");

            if (!File.Exists(rutaCredenciales))
                return;

            var registros = File.ReadAllLines(rutaCredenciales).ToList();

            for (int i = 1; i < registros.Count; i++) // Omitimos la cabecera
            {
                string[] datos = registros[i].Split(';');

                if (datos.Length >= 5 && datos[1].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    datos[4] = DateTime.Now.ToString("d/M/yyyy HH:mm:ss"); // 🔹 Actualiza la fecha de último login
                    registros[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(rutaCredenciales, registros, Encoding.UTF8);
        }

    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Negocio
{
        public class UsuarioNegocio
        {
            public string AutenticarYRedirigir(string nombreUsuario, string password)
            {
                string rutaCredenciales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persistencia", "DataBase", "credenciales.csv");
                string rutaUsuarioPerfil = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persistencia", "DataBase", "usuario_perfil.csv");
                string rutaPerfil = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persistencia", "DataBase", "perfil.csv");

                // ✅ Validar usuario en credenciales.csv y obtener legajo
                if (!File.Exists(rutaCredenciales)) return "Error: Archivo credenciales.csv no encontrado.";
                var datosUsuario = File.ReadAllLines(rutaCredenciales).Skip(1)
                    .Select(line => line.Split(';'))
                    .FirstOrDefault(datos => datos[1] == nombreUsuario && datos[2] == password);

                if (datosUsuario == null) return "Usuario o contraseña incorrectos.";
                string legajo = datosUsuario[0];
                DateTime fechaUltimoLogin = DateTime.Parse(datosUsuario[4]);

                // ✅ Verificar si la contraseña está vencida
                if (fechaUltimoLogin == DateTime.MinValue) return "PRIMER_LOGIN";
                if (DateTime.Now.Subtract(fechaUltimoLogin).TotalDays > 90) return "FORZAR_CAMBIO_CONTRASEÑA";

                // ✅ Obtener ID de perfil en usuario_perfil.csv
                if (!File.Exists(rutaUsuarioPerfil)) return "Error: Archivo usuario_perfil.csv no encontrado.";
                var datosPerfil = File.ReadAllLines(rutaUsuarioPerfil).Skip(1)
                    .Select(line => line.Split(';'))
                    .FirstOrDefault(datos => datos[0] == legajo);

                if (datosPerfil == null) return "El usuario no tiene un perfil asignado.";
                string idPerfil = datosPerfil[1];

                // ✅ Obtener nombre del perfil en perfil.csv
                if (!File.Exists(rutaPerfil)) return "Error: Archivo perfil.csv no encontrado.";
                var nombrePerfil = File.ReadAllLines(rutaPerfil).Skip(1)
                    .Select(line => line.Split(';'))
                    .FirstOrDefault(datos => datos[0] == idPerfil)?
                    .LastOrDefault();

                if (string.IsNullOrEmpty(nombrePerfil)) return "Perfil no encontrado.";

                // ✅ Redirigir a FormGenericoperfiles con el perfil
                return $"Redirigir a FormGenericoperfiles con perfil: {nombrePerfil}";
            }
        }
    }




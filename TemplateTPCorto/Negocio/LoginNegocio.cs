using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class LoginNegocio
    {
        public Credencial login(String usuario, String password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();

            Credencial credencial = usuarioPersistencia.login(usuario);

            if (credencial.Contrasena.Equals(password))
            {
                return credencial;
            }
            return null;
        }


        UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();


        public string IntentarLogin(string usuario, string password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();

            if (usuarioPersistencia.EstaBloqueado(usuario))
                return "El usuario está bloqueado. No puede ingresar.";

            Credencial credencial = usuarioPersistencia.ObtenerCredencial(usuario);
            if (credencial == null)
                return "Usuario no encontrado.";

            if (!credencial.Contrasena.Equals(password))
            {
                usuarioPersistencia.RegistrarIntentoFallido(usuario);
                int intentos = usuarioPersistencia.ObtenerIntentos(usuario);

                if (intentos >= 3)
                {
                    usuarioPersistencia.BloquearUsuario(usuario);
                    return "Usuario bloqueado por demasiados intentos fallidos.";
                }

                return $"Credenciales incorrectas. Intentos restantes: {3 - intentos}";
            }

            // ✅ Verificar si el usuario requiere cambio de contraseña
            if (credencial.FechaUltimoLogin == DateTime.MinValue)
                return "PRIMER_LOGIN";

            if (credencial.ContrasenaExpirada())
                return "FORZAR_CAMBIO_CONTRASEÑA";

            // ✅ Obtener el perfil correctamente
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            string perfil = usuarioNegocio.AutenticarYRedirigir(usuario, password);

            if (!perfil.StartsWith("Redirigir")) return "Error al obtener el perfil del usuario.";

            Console.WriteLine($"🔍 En LoginNegocio - Perfil obtenido correctamente: {perfil}");

            return perfil;
        }



        // : Método para obtener el perfil del usuario
        public string ObtenerPerfil(string usuario)
        {
            string rutaCredenciales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persistencia", "DataBase", "credenciales.csv");
            string rutaUsuarioPerfil = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persistencia", "DataBase", "usuario_perfil.csv");
            string rutaPerfil = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persistencia", "DataBase", "perfil.csv");

            // ✅ Buscar legajo del usuario en credenciales.csv
            if (!File.Exists(rutaCredenciales)) return "Error: Archivo credenciales.csv no encontrado.";
            var datosUsuario = File.ReadAllLines(rutaCredenciales).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(datos => datos[1].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase));

            if (datosUsuario == null) return "Usuario no encontrado.";
            string legajo = datosUsuario[0].Trim();

            // ✅ Buscar ID de perfil en usuario_perfil.csv
            if (!File.Exists(rutaUsuarioPerfil)) return "Error: Archivo usuario_perfil.csv no encontrado.";
            var datosPerfil = File.ReadAllLines(rutaUsuarioPerfil).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(datos => datos[0].Trim() == legajo);

            if (datosPerfil == null) return "El usuario no tiene un perfil asignado.";
            string idPerfil = datosPerfil[1].Trim();

            // ✅ Buscar nombre del perfil en perfil.csv
            if (!File.Exists(rutaPerfil)) return "Error: Archivo perfil.csv no encontrado.";
            var perfilEncontrado = File.ReadAllLines(rutaPerfil).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(datos => datos[0].Trim() == idPerfil);

            if (perfilEncontrado == null) return "Perfil no encontrado.";
            string nombrePerfil = perfilEncontrado[1].Trim();

            Console.WriteLine($"Perfil obtenido correctamente: {nombrePerfil}"); // 🔥 Debug para verificar en consola

            return nombrePerfil; // ✅ Retorna el nombre del perfil en lugar de un ID
        }


        /*public string CambiarContraseña(string usuario, string contrasenaActual, string nuevaContrasena)
        {
            Credencial credencial = usuarioPersistencia.ObtenerCredencial(usuario);

            if (credencial == null) return "Usuario no encontrado.";

            // Lista para almacenar los errores de validación
            List<string> errores = new List<string>();
            if (!credencial.Contrasena.Equals(contrasenaActual))
                errores.Add("Contraseña actual incorrecta.");

            if (nuevaContrasena.Equals(credencial.Contrasena))
                errores.Add("La nueva contraseña debe ser diferente a la anterior.");

            if (string.IsNullOrWhiteSpace(nuevaContrasena) || nuevaContrasena.Length > 8)
                errores.Add("La nueva contraseña debe tener al menos 8 caracteres y no debe ser vacia.");

            // Si hay errores, los concatenamos y los mostramos
            if (errores.Count > 0)
                return string.Join("\n", errores);

            // Si todas las validaciones se cumplen, actualiza la contraseña
            usuarioPersistencia.ActualizarContrasena(usuario, nuevaContrasena);

            return "Contraseña actualizada correctamente.";
        }
        */

        public string CambiarContraseña(string usuario, string contrasenaActual, string nuevaContrasena)
        {
            Credencial credencial = usuarioPersistencia.ObtenerCredencial(usuario);

            if (credencial == null) return "Usuario no encontrado.";

            List<string> errores = new List<string>();

            if (!credencial.Contrasena.Equals(contrasenaActual.Trim()))
                errores.Add("Contraseña actual incorrecta.");

            if (nuevaContrasena.Trim().Equals(credencial.Contrasena))
                errores.Add("La nueva contraseña debe ser diferente a la anterior.");

            // Corrección: La condición ahora verifica que la contraseña sea MENOR a 8 caracteres en lugar de mayor.
            if (string.IsNullOrWhiteSpace(nuevaContrasena) || nuevaContrasena.Trim().Length < 8)
                errores.Add("La nueva contraseña debe tener al menos 8 caracteres y no debe ser vacía.");

            if (errores.Count > 0)
                return string.Join(Environment.NewLine, errores);

            // Si todas las validaciones pasan, actualiza la contraseña
            usuarioPersistencia.ActualizarContrasena(usuario, nuevaContrasena.Trim());

            return "Contraseña actualizada correctamente.";
        }
        


    }
}

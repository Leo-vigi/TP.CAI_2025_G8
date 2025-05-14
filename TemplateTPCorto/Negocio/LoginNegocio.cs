using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
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
            if (usuarioPersistencia.EstaBloqueado(usuario))
                return " El usuario está bloqueado. No puede ingresar.";

            Credencial credencial = usuarioPersistencia.ObtenerCredencial(usuario);
            if (credencial == null)
                return " Usuario no encontrado.";

            
            

            if (!credencial.Contrasena.Equals(password))
            {
                usuarioPersistencia.RegistrarIntentoFallido(usuario);
                int intentos = usuarioPersistencia.ObtenerIntentos(usuario);
                

                if (intentos >= 3)
                {
                    usuarioPersistencia.BloquearUsuario(usuario);
                    return " Usuario bloqueado por demasiados intentos fallidos.";
                }
               
                return $" Credenciales incorrectas. Intentos restantes: {3 - intentos}";
            }
            // 🔹 NUEVO: Validación de primer login (si `fechaUltimoLogin` está vacío)
            if (credencial.FechaUltimoLogin == DateTime.MinValue)
            {
                return "PRIMER_LOGIN";
            }


            // Verifica la expiración de contraseña
            if (credencial.ContrasenaExpirada())
            {
                return "FORZAR_CAMBIO_CONTRASEÑA";
            }
           
            // Si el usuario ingresa correctamente en el tercer intento, limpiamos el registro de intentos fallidos
            usuarioPersistencia.LimpiarIntentos(usuario);
            string perfil = ObtenerPerfil(usuario);
            return $"Login exitoso;Perfil:{perfil}";

        }

        // : Método para obtener el perfil del usuario
        public string ObtenerPerfil(string usuario)
        {
            List<string> registros = usuarioPersistencia.BuscarRegistro("usuario_perfil.csv");

            foreach (string registro in registros.Skip(1)) // Omitimos cabecera
            {
                string[] datos = registro.Split(';'); // Ejemplo: "12345;Supervisor"
                if (datos[0].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return datos[1]; // Retorna el perfil del usuario
                }
            }
            return "SinPerfil"; // Si no se encuentra, retorna un valor por defecto
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

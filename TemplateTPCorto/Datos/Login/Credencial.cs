using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Credencial
    {
        private string _legajo;
        private string _nombreUsuario;
        private string _contrasena;
        private DateTime _fechaAlta;
        private DateTime _fechaUltimoLogin;

        public string Legajo { get => _legajo; set => _legajo = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaUltimoLogin { get => _fechaUltimoLogin; set => _fechaUltimoLogin = value; } //  Mantiene acceso sin duplicación

        public Credencial(string registro)
        {
            string[] datos = registro.Split(';');
            this._legajo = datos[0];
            this._nombreUsuario = datos[1];
            this._contrasena = datos[2];

            string[] formatos = { "d/M/yyyy", "d/M/yyyy HH:mm:ss" };
            this._fechaAlta = DateTime.ParseExact(datos[3].Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None);

            if (string.IsNullOrWhiteSpace(datos[4]?.Trim()))
                this._fechaUltimoLogin = DateTime.MinValue;
            else
                this._fechaUltimoLogin = DateTime.ParseExact(datos[4].Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None);

        }

        public bool ContrasenaExpirada()
        {
            return (DateTime.Now - _fechaUltimoLogin).TotalDays >= 30;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaProductos
    {
        int _id;
        String _detalle;

        public int Id { get => _id; set => _id = value; }
        public string Detalle { get => _detalle; set => _detalle = value; }

        public CategoriaProductos(int id, string detalle)
        {
            _id = id;
            _detalle = detalle;
        }

        public override string ToString()
        {
            return Detalle;
        }
    }
}

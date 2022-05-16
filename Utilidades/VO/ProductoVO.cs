using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    /// <summary>
    /// Clase con los datos de cada producto
    /// </summary>
    public class ProductoVO
    {
        private int idProducto;
        private string nombre;
        private double precioUd;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioUd { get => precioUd; set => precioUd = value; }
    }
}

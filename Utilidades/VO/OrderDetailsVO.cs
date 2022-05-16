using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class OrderDetailsVO
    {
        private int idPedido;
        private int idProducto;
        private double precioUd;
        private double cantidad;
        private double total;
        private string producto;

        #region Constructores
        public OrderDetailsVO()
        {
        }

        #endregion


        #region Metodos
        /// <summary>
        /// Calcula el total de la compra realizada redondeado a dos decimales
        /// </summary>
        public void calculaTotal() {

            this.total = Math.Round(this.cantidad * precioUd, 2);
        }


        /// <summary>
        /// Devuelve si el producto se compraro mas veces de las pasadas como parametro
        /// </summary>
        public bool seComproMasVeces(int numVeces) {
            if (cantidad >= numVeces) {
                return true;
            }
            return false;
        }

        #endregion


        #region Propiedades
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Producto { get => producto; set => producto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public double PrecioUd { get => precioUd; set => precioUd = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Total { get => total; set => total = value; }

        #endregion
    }
}

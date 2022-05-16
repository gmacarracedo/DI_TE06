using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class OrderVO
    {
        #region Atributos

        private int idPedido;
        private string idCliente;
        private DateTime fechaPedido;
        private DateTime fechaEnvio;
        private string direccion;
        private double total;

        private List<OrderDetailsVO> listaDetallesCompra;


        #endregion

        #region Metodos

        /// <summary>
        /// Calcula el total de cada compra realizada sumando los totales de cada detalle de compra
        /// </summary>
        public void calculaTotal() {
            // Aña al total la suma del total de cada detalle de compra
            foreach (OrderDetailsVO detalleCompra in listaDetallesCompra)
            {
                this.total += detalleCompra.Total;
            }
        }

        #endregion


        #region Propiedades

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
       
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
       
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<OrderDetailsVO> DetallesCompra { get => listaDetallesCompra; set => listaDetallesCompra = value; }
        public double Total { get => total; set => total = value; }

        #endregion
    }
}

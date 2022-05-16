using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_ServerDAL;
using Utilidades.VO;

namespace GestionBLL
{
    public class OperacionesBLL
    {
        // Llama a DAL para pedir la lista de clientes
        public static List<string> BuscarListaClientes() {
            Console.WriteLine("BuscarListaClientes");

            List<string> listaClientes = ConsultasBD.buscaListaClientes();
            return listaClientes;
        }

        // Llama al DAL para pedir las compras realizadas por un cliente
        public static List<OrderVO> BuscarComprasCliente(string idCliente) {

            List<OrderVO> listaCompras = ConsultasBD.ComprasCliente(idCliente);
            return listaCompras;
        }

        // Llama al DAL para obtener la informacion personal de un cliente
        public static CustomerInfoVO GetInfoCliente(string idCliente) {

            CustomerInfoVO infoCliente = ConsultasBD.GetInfoCliente(idCliente);
            return infoCliente;
        }

        // Llama al DAL para obtener la lista de fechas en las que un cliente hizo una compra
        public static List<DateTime> BuscaFechasCompraCliente(string idCliente) {

            List<DateTime> fechasCompra = ConsultasBD.GetFechasComprasCliente(idCliente);
            return fechasCompra;
        }

        // Llama al DAL para obtener los ids de cada compra que hizo un cliente en una fecha determinada
        public static List<int> BuscaIdsCompra(string idCliente, string fecha) {

            List<int> listaIdsCompra = ConsultasBD.GetIdsComprasCliente(idCliente, fecha);
            
            return listaIdsCompra;
        }

        // Llama al DAL para obtener las compras realizadas en una fecha determinada
        public static List<OrderVO> BuscaComprasPorFecha(string fecha, string idCliente) {
            List<OrderVO> comprasPorFecha = ConsultasBD.GetComprasPorFecha(fecha, idCliente);
            return comprasPorFecha;
        }

        // Llama al DAL para obtener la lista con los detalles de cada compra
        public static List<OrderDetailsVO> BuscaDetallesCompra(string idCompra) {
            List<OrderDetailsVO> detallesCompra = ConsultasBD.GetDetallesCompra(idCompra);
            return detallesCompra;
 
        }

        // Llama al DAL para obtener la lista de productos
        public static List<ProductoVO> BuscaNombresProducto() {
            List<ProductoVO> listaProductos = ConsultasBD.GetNombresProducto();
            return listaProductos;
        }

        // Llama al DALpara obtener la lista de Empleados
        public static List<string> BuscaEmpleados() {
            List<string> listaEmpleados = ConsultasBD.GetNombresEmpleados();
            return listaEmpleados;
        }

    }


}

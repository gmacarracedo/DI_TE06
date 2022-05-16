using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Utilidades.VO;

namespace SQL_ServerDAL
{
    public class ConsultasBD {
       
        /// <summary>
        /// Establece conexion con la base de datos
        /// </summary>
        /// Devuelve la conexion
        private static SqlConnection estableceConexion() {

            Console.WriteLine("Dentro de establece conexion");
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");

            try
            {
                // Abre conexion
                conn.Open();
                Console.WriteLine("Conexion establecida con exito");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error al establecer conexion: " + e.Message);

            }
            return conn;
        }


        /// <summary>
        /// Hace peticion de todos los clientes a la base de datos
        /// </summary>
        /// Devuelve lista con todos los nombres de los clientes
        public static List<string> buscaListaClientes() {
            List<string> listaClientes = new List<string>();
           
            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select CustomerID from dbo.Customers";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // REcorre los datos obtenidos y los añade a la lista
                while (dataReader.Read()) {
                    string customerID = dataReader.GetValue(0).ToString();
                    listaClientes.Add(customerID);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            } catch (Exception e) {
                Console.WriteLine("No se pudo obtener la lista de clientes: " + e);
            } finally {
                conexion.Close();
            }

            return listaClientes;
        }


        /// <summary>
        /// Hace peticion a la BD de todas las compras de un cliente determinado
        /// </summary>
        /// <param name="idCliente"></param>
        /// Devuelve la lista de compras en un objeto OrderVO
        public static List<OrderVO> ComprasCliente(string idCliente) {

            List<OrderVO> comprasCliente = new List<OrderVO>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select * from dbo.Orders where CustomerID = '" + idCliente + "'";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // REcorre los datos obtenidos y los añade a la lista
                while (dataReader.Read())
                {
                    OrderVO unaCompra = new OrderVO();

                    // Asigna los datos de las compras del cliente que se paso como parametro
                    unaCompra.IdPedido = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    unaCompra.IdCliente = dataReader.GetValue(1).ToString();
                    unaCompra.FechaPedido = DateTime.Parse(dataReader.GetValue(3).ToString());
                    unaCompra.FechaEnvio = DateTime.Parse(dataReader.GetValue(5).ToString());
                    unaCompra.Direccion = dataReader.GetValue(9).ToString();

                    // Añade los detalles de compra para sintetizar el total
                    unaCompra.DetallesCompra = GetDetallesCompra(dataReader.GetValue(0).ToString());
                    unaCompra.calculaTotal();

                    // Añade la compra a la lista
                    comprasCliente.Add(unaCompra);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo obtener la lista de clientes: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return comprasCliente;
            
        }

        /// <summary>
        /// Hace peticion a la BD de la informacion personal del cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// Devuelve un objeto CustomerInfoVo con llos datos recogidos de la BD
        public static CustomerInfoVO GetInfoCliente(string idCliente)
        {

            CustomerInfoVO infoCliente = new CustomerInfoVO();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select * from dbo.Customers where CustomerID = '" + idCliente + "'";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // Añade los adatos obtenidos
                while (dataReader.Read())
                {
                    infoCliente.IdCliente = dataReader.GetValue(0).ToString();
                    infoCliente.NombreCompania = dataReader.GetValue(1).ToString();
                    infoCliente.NombreContacto = dataReader.GetValue(2).ToString();
                    infoCliente.TituloContacto = dataReader.GetValue(3).ToString();
                    infoCliente.Direccion = dataReader.GetValue(4).ToString();
                    infoCliente.Ciudad = dataReader.GetValue(5).ToString();
                    infoCliente.Pais = dataReader.GetValue(8).ToString();
                    infoCliente.Telefono = dataReader.GetValue(9).ToString();
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo obtener la informacion del cliente: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return infoCliente;

        }


        // Devuelve la lista de las fechas que compro el cliente que se le pasa como parametro
        public static List<DateTime> GetFechasComprasCliente(string idCliente)
        {

            List<DateTime> listaFechas = new List<DateTime>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select OrderDate from dbo.Orders where CustomerID = '" + idCliente + "'";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // Añade los adatos obtenidos
                while (dataReader.Read())
                {
                    DateTime unaFecha = new DateTime();
                    unaFecha = DateTime.Parse(dataReader.GetValue(0).ToString());
                    listaFechas.Add(unaFecha);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudieron obtener las fechas de compra: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return listaFechas;

        }

        /// <summary>
        /// Hace peticion a la BD de los ids de las compras que realizo un cliente en una fecha determinada
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="fecha"></param>
        /// Devuelve lista de ids de compra
        public static List<int> GetIdsComprasCliente(string idCliente, string fecha)
        {

            List<int> listaIds = new List<int>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select OrderID from dbo.Orders where CustomerID = '" + idCliente + "'";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // Añade los adatos obtenidos
                while (dataReader.Read())
                {
                    int unID = (int) Int64.Parse( dataReader.GetValue(0).ToString());
                    listaIds.Add(unID);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudieron obtener los id de Compra: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return listaIds;

        }


        /// <summary>
        /// Hace peticion a la BD e los detalles de una compra para un id determinado
        /// </summary>
        /// <param name="idCompra"></param>
        /// Devuelve lista de OrderDetailsVO con los datos de la compra detallada
        public static List<OrderDetailsVO>  GetDetallesCompra(string idCompra)
        {
            // Realiza un consulta para obtener todos los nombre de producto
            List<ProductoVO> listaProductos = GetNombresProducto();


            List<OrderDetailsVO> listaDetallesCompra = new List<OrderDetailsVO>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select * from dbo.[Order Details] where OrderID = '" + idCompra + "'";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // Añade los adatos obtenidos
                while (dataReader.Read())
                {
                    OrderDetailsVO detallesCompra = new OrderDetailsVO();

                    detallesCompra.IdPedido = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    detallesCompra.IdProducto = (int)Int64.Parse(dataReader.GetValue(1).ToString());
                    detallesCompra.PrecioUd = (double)Double.Parse(dataReader.GetValue(2).ToString());
                    detallesCompra.Cantidad = (double)Double.Parse(dataReader.GetValue(3).ToString());

                    // Calcula el total antes de añadir el detalle de compra a la lista
                    detallesCompra.calculaTotal();

                    // Recorre la lista de productos para añadir el nombre que coincide con el id de compra
                    foreach (ProductoVO unProducto in listaProductos)
                    {
                        if (unProducto.IdProducto == detallesCompra.IdProducto) {
                            detallesCompra.Producto = unProducto.Nombre;
                        }
                    }

                    listaDetallesCompra.Add(detallesCompra);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudieron obtener los detalles de Compra: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return listaDetallesCompra;

        }

        public static List<OrderVO> GetComprasPorFecha(string fecha, string idCliente) {
            List<OrderVO> listaComprasPorFecha = new List<OrderVO>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select * from dbo.Orders where OrderDate = '" + fecha + "'" + " and CustomerID = '" + idCliente + "'";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // Añade los adatos obtenidos
                while (dataReader.Read())
                {
                    OrderVO unaCompra = new OrderVO();

                    // Asigna los datos de las compras del cliente que se paso como parametro
                    unaCompra.IdPedido = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    unaCompra.IdCliente = dataReader.GetValue(1).ToString();
                    unaCompra.FechaPedido = DateTime.Parse(dataReader.GetValue(3).ToString());
                    unaCompra.FechaEnvio = DateTime.Parse(dataReader.GetValue(5).ToString());
                    unaCompra.Direccion = dataReader.GetValue(9).ToString();

                    // Calcula el total de la compra realizada despues de obtener los detalles de compra
                    unaCompra.DetallesCompra = GetDetallesCompra(dataReader.GetValue(0).ToString());
                    unaCompra.calculaTotal();

                    // Añade la comprar recogida a la lista
                    listaComprasPorFecha.Add(unaCompra);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudieron obtener las fechas de compra: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return listaComprasPorFecha;
        }


        /// <summary>
        /// Hace peticion a la BD ce los productos disponibles
        /// </summary>
        /// Devuelve objeto ProductoVO con los datos de cada producto
        public static List<ProductoVO> GetNombresProducto()
        {

            List<ProductoVO> listaProductos = new List<ProductoVO>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select ProductID, ProductName, UnitPrice from dbo.Products";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // Añade los adatos obtenidos
                while (dataReader.Read())
                {
                    ProductoVO producto = new ProductoVO();

                    producto.IdProducto = (int)Int64.Parse(dataReader.GetValue(0).ToString());
                    producto.Nombre = dataReader.GetValue(1).ToString();
                    producto.PrecioUd = (double)Double.Parse(dataReader.GetValue(2).ToString());

                    listaProductos.Add(producto);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudieron obtener los productos: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return listaProductos;
        }



        // Pide los nombres de los empleados y los devuelve en una lista
        public static List<string> GetNombresEmpleados()
        {
            List<string> nombresEmpleados = new List<string>();

            SqlConnection conexion = estableceConexion();

            // Comando para consulta
            SqlCommand command;
            string consulta = "select FirstName from dbo.Employees";
            // Objeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                command = new SqlCommand(consulta, conexion);

                // Hace la consulta 
                dataReader = command.ExecuteReader();

                // REcorre los datos obtenidos y los añade a la lista
                while (dataReader.Read())
                {
                    string nombreEmpleado = dataReader.GetValue(0).ToString();
                    nombresEmpleados.Add(nombreEmpleado);
                }
                // Cierre del lector de datos y command
                dataReader.Close();
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudieron obtener los nombres de los empeados: " + e);
            }
            finally
            {
                conexion.Close();
            }

            return nombresEmpleados;
        }




    }
}

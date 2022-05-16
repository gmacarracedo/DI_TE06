using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GestionBLL;
using NorthWind_InterfazGrafica.Reportes;
using Utilidades.VO;


namespace NorthWind_InterfazGrafica
{
    public partial class Form1 : Form
    {

        private string clienteSeleccionado = String.Empty;
        string[] tiposInforme = { "Crystal Reports", "Microsoft Reporting" };

        public Form1()
        {
            InitializeComponent();
            inicializaComboBoxClientes();
            inicializaComboInformes();
            bloqueaOpciones();
            aplicaColores();
            //  listaColores = creaListaColores();

            // Inicializa los tooltips de los filtros de busqueda
            tTip_Ayuda.SetToolTip(comboB_idCompra, "Seleccion el id de compra para ver los detalles en la tabla de abajo");
            tTip_Ayuda.SetToolTip(comboB_ComprasFecha, "Selecciona una fecha para ver las compras realizadas en la misma");
            tTip_Ayuda.SetToolTip(comboB_Clientes, "Selecciona un cliente para ver sus compras");

            // Inicializa los tooltips de la parte de informes
            tTip_Ayuda.SetToolTip(comb_Reportes, "Selecciona la herramienta con la que quieres generar el informe");

            // Inicializa los tooltips de las graficas
            tTip_Ayuda.SetToolTip(chartProductosComprados, "Productos mas comprados por el cliente seleccionado");
        }

      

        /// Inicializa el comboBox con el nombre de cada cliente haciendo una consulta a la BD a traves del BLL
        /// </summary>
        private void inicializaComboBoxClientes()
        {
            List<string> listaClientes;
            listaClientes = OperacionesBLL.BuscarListaClientes();

            // Asigna al comboBox_Clientes la lista de clientes recogida de la BD
            comboB_Clientes.DataSource = listaClientes;
            // El item seleccionado por defecto comienza siendo nulo
            comboB_Clientes.SelectedItem = null;
            
        }


        // Inicializa el comboBox de fechas con las fechas en las que compro el cliente seleccionado
        private void inicializaComboBoxFechas()
        {
            List<DateTime> listaFechas;
            listaFechas = OperacionesBLL.BuscaFechasCompraCliente(clienteSeleccionado);
            comboB_ComprasFecha.DataSource = listaFechas;
            // Iniciara con un item sleccionado en nulo
            comboB_ComprasFecha.SelectedItem = null;
            
        }


        // Inicializa combo box con los ids de las compras que hizo el cliente seleccionado
        private void iniciaComboBoxIdsCompra()
        {
            string fechaSeleccionada = String.Empty;

            if (comboB_ComprasFecha.SelectedItem != null)
            {
                fechaSeleccionada = comboB_ComprasFecha.SelectedItem.ToString(); ;
            }

            List<int> idsCompra;
            idsCompra = OperacionesBLL.BuscaIdsCompra(clienteSeleccionado, fechaSeleccionada);

            comboB_idCompra.DataSource = idsCompra;
            // Item seleccionado comenzara siendo nulo
            comboB_idCompra.SelectedItem = null;
        }


        // Muestra la informacion basica del cliente
        private void InfoCliente() {
            tB_MuestraInfo.Text = String.Empty;

            if (comboB_Clientes.SelectedItem != null)
            {
                clienteSeleccionado = comboB_Clientes.SelectedItem.ToString();
            }

            CustomerInfoVO infoCliente = OperacionesBLL.GetInfoCliente(clienteSeleccionado);

            // Añade los datos al TB
            tB_MuestraInfo.AppendText(Environment.NewLine);
            tB_MuestraInfo.AppendText("ID Cliente: " + infoCliente.IdCliente + Environment.NewLine);
            tB_MuestraInfo.AppendText(Environment.NewLine);
            tB_MuestraInfo.AppendText("Nombre de compañia: " + infoCliente.NombreCompania + Environment.NewLine);
            tB_MuestraInfo.AppendText(Environment.NewLine);
            tB_MuestraInfo.AppendText("Nombre contacto: " + infoCliente.NombreContacto + Environment.NewLine);
        }


        // Muestra la informacion del cliente, obtenida de la BD en el TextBox de informacion
        private void but_InfoClientes_Click(object sender, EventArgs e)
        {
            tB_MuestraInfo.Text = String.Empty;
            
            if (comboB_Clientes.SelectedItem != null) {
                clienteSeleccionado = comboB_Clientes.SelectedItem.ToString();
            }
            
            CustomerInfoVO infoCliente = OperacionesBLL.GetInfoCliente(clienteSeleccionado);

            // Añade los datos al TB
            
            tB_MuestraInfo.AppendText("ID Cliente: " + infoCliente.IdCliente + Environment.NewLine);
            tB_MuestraInfo.AppendText("Nombre de compañia: " + infoCliente.NombreCompania + Environment.NewLine);
            tB_MuestraInfo.AppendText("Nombre contacto: " + infoCliente.NombreContacto + Environment.NewLine);
            tB_MuestraInfo.AppendText(Environment.NewLine);
            tB_MuestraInfo.AppendText("Direccion : " + Environment.NewLine);
            tB_MuestraInfo.AppendText(infoCliente.Direccion + Environment.NewLine);
            tB_MuestraInfo.AppendText(infoCliente.Ciudad + ", " + infoCliente.Pais + Environment.NewLine);
            tB_MuestraInfo.AppendText(Environment.NewLine);
            tB_MuestraInfo.AppendText("Telefono: " + infoCliente.Telefono);
        } 


        // Muestra todas las compras hechas por el cliente en un dataGridView
        private void but_ListaCompras_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = comboB_Clientes.SelectedItem.ToString();
            List<OrderVO> listaComprasUsuario;
            listaComprasUsuario = OperacionesBLL.BuscarComprasCliente(clienteSeleccionado);

            // Asigna la lista al GridView
            dataGV_Compras.DataSource = listaComprasUsuario;
            // Elimina la columna con el id del cliente para sinstetizar los datos
            dataGV_Compras.Columns.Remove("IdCliente");
        }


       // Muestra compras de una fecha determinada
        private void verComprasFecha(object sender, EventArgs e)
        {
            List<OrderVO> comprasPorFecha;

            // Si se eligio una fecha carga las compras de la fecha seleccionada, para el usuario elegido en el DataGridView
            if (comboB_ComprasFecha.SelectedItem != null && comboB_Clientes.SelectedItem != null) {
                comprasPorFecha = OperacionesBLL.BuscaComprasPorFecha(comboB_ComprasFecha.SelectedItem.ToString(), comboB_Clientes.SelectedItem.ToString());
                dataGV_Compras.DataSource = comprasPorFecha;
                // Elimina columna con el identificador del cliente
                dataGV_Compras.Columns.Remove("IdCliente");
            }
        }


        // Hace una llamada a la BD para mostrar los detellase de compra en grafico cuando se elige un id para unaCompra determinada
        private void verDetallesCompra(object sender, EventArgs e)
        {     
            string idCompra = String.Empty;

            if (comboB_idCompra.SelectedItem != null) 
                {
                    idCompra = comboB_idCompra.SelectedItem.ToString();
                }

                // Consulta detalles de compra a la BBDD y los en el dataGRidView
                List<OrderDetailsVO> comprasDetalladas;
                comprasDetalladas = OperacionesBLL.BuscaDetallesCompra(idCompra);
                dataGV_DetallesCompra.DataSource = comprasDetalladas;

                // Elimina la columna idProducto para sintetizar datos y mejorar legibilidad
                dataGV_DetallesCompra.Columns.Remove("IdProducto");
               
        }


        // Bloquea los filtros de busqueda y menu de seleccion hasta que se elige un cliente
        private void bloqueaOpciones() {
         
            but_InfoClientes.Enabled = false;
            but_ListaCompras.Enabled = false;
            but_ProductosMasComprados.Enabled = false;
          
            comboB_ComprasFecha.Enabled = false;
            comboB_idCompra.Enabled = false;
        }


        // Desbloquea los filtros de busqueda y menu de seleccion una vez se eligio un cliente
        private void desbloqueaOpciones() {
            
            but_InfoClientes.Enabled = true;
            but_ListaCompras.Enabled = true;
            but_ProductosMasComprados.Enabled = true;

            comboB_ComprasFecha.Enabled = true;
            comboB_idCompra.Enabled = true;
        }


        

        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);
            Color fondoTlpDatos = Color.SlateGray;
            tLP_Base.BackColor = fondoBase;
            tLP_Busquedas.ForeColor = Color.White;
            tLP_Datos.BackColor = fondoTlpDatos;
            lab_Herramienta.ForeColor = Color.White;
          
        }


        // Limpia e inicializa los datos cada vez que se elige un cliente
        private void Limpia_InicialidaDatos(object sender, EventArgs e)
        {
            // Imicializa el cliente seleccionado y carga su informacion
            if (comboB_Clientes.SelectedItem != null)
            {
                clienteSeleccionado = comboB_Clientes.SelectedItem.ToString();
                InfoCliente();
            }


            // Si ya se selecciono un cliente inicializa los filtros de fecha e id de compra y desbloquea los menus
            if (clienteSeleccionado != String.Empty)
            {
                // Inincia el comboBox de fechas
                inicializaComboBoxFechas();
                // Inicia el comboBox de ids de Compra
                iniciaComboBoxIdsCompra();

                desbloqueaOpciones();

            }
           
            // Borra los datos cargados en los dataGRigView
            dataGV_Compras.DataSource = null;
            dataGV_DetallesCompra.DataSource = null;
            // Borra los datos cargados el el chartView
            chartProductosComprados.Series.Clear();
            chartProductosComprados.Titles.Clear();


        }

        // Muestra los productos mas comprados
        private void ProductosMasComprados(object sender, EventArgs e)
        {
            
            // REcoge todas las compras del cliente seleccionado
            clienteSeleccionado = comboB_Clientes.SelectedItem.ToString();
            List<OrderVO> listaComprasUsuario;
            listaComprasUsuario = OperacionesBLL.BuscarComprasCliente(clienteSeleccionado);

            // Recorre cada compra y recoge cada detalle de compra añadiendo a la lista de detalles de compra
            List<List<OrderDetailsVO>> listaDetallesCompra = new List<List<OrderDetailsVO>>();
            foreach (OrderVO unaCompra in listaComprasUsuario) {
                List<OrderDetailsVO> detallesCompra = OperacionesBLL.BuscaDetallesCompra(unaCompra.IdPedido.ToString());
                listaDetallesCompra.Add(detallesCompra);
            }
            

            // Crea la lista de productos que se compraron mas de 20 veces
            List<OrderDetailsVO> productosMasComprados = new List<OrderDetailsVO>();

            // Recorre la lista con los detalles de cada compra para encontrar los que se compraron mas de 20 veces
            foreach (List<OrderDetailsVO> detallesCompra in listaDetallesCompra) {
                for (int i = 0; i < detallesCompra.Count; i++) {
                    // Recogera un maximo de 10 productos
                    if (productosMasComprados.Count < 7) {
                        if (detallesCompra[i].seComproMasVeces(22))
                        {
                            productosMasComprados.Add(detallesCompra[i]);
                        }
                    }
                   
                }

                // Si no se encuentran productos comprados mas de 20 veces se hace una peticion de los que se compraron mas de 10
                if (productosMasComprados.Count == 0)
                {
                    for (int i = 0; i < detallesCompra.Count; i++) {
                        if (productosMasComprados.Count < 7) {
                            if (detallesCompra[i].seComproMasVeces(10)) {
                                productosMasComprados.Add(detallesCompra[i]);
                            }
                        }
                    }
                }
            }

        
            // ---------- Grafico Chart --------------//

            // Ejes para cantidad comprada y nombre de producto
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();


            for (int i = 0; i < productosMasComprados.Count; i++)
            {
                // Añade al eje y la cantidad que se compraron de un producto
                y1.Add(productosMasComprados[i].Cantidad);
                // el eje x1 (azul) con los nombres de producto
                x1.Add(productosMasComprados[i].Producto);
            }

            // Limpia las series del grafica
            chartProductosComprados.Series.Clear();
          
            // Añade una serie con cada nombre de producto comprobando previamente que no se ha añadido ya
            foreach (string unProducto in x1) {
                 if (chartProductosComprados.Series.IndexOf(unProducto) == -1)
                 {
                    chartProductosComprados.Series.Add(unProducto);
                    // Añade a cada serie el los ejes con los productos que se compron de esta
                    chartProductosComprados.Series[unProducto].Points.DataBindXY(x1.ToArray(), y1.ToArray());
                }
            }
            // Establece color al grafico
            chartProductosComprados.Palette = ChartColorPalette.Bright;
            
            chartProductosComprados.ChartAreas[0].AxisX.Title = "Nombre Producto";
            chartProductosComprados.ChartAreas[0].AxisY.Title = "Cantidad";

            chartProductosComprados.ChartAreas[0].AxisY.LabelStyle.Angle = -90;

            chartProductosComprados.Titles.Clear();
            chartProductosComprados.Titles.Add("Detalles de compra");

        }


        // Inicializa comboBox de seleccion de tipo de informe
        private void inicializaComboInformes() {
            comb_Reportes.DataSource = tiposInforme;
        }


        // Abre las opciones de informes que se pueden generar con la herramienta elegida, CrystalReports o MicrosoftReporting
        private void GenerarInforme(object sender, EventArgs e)
        {
            string herramientaReporte = comb_Reportes.Text;
            Asistente_De_Informes opcionesInforme;

            // Si la herramienta elegida es de Crystal Reports envia un titulo sino otro
            if (herramientaReporte.Equals(tiposInforme[0]))
            {
                opcionesInforme = new Asistente_De_Informes(herramientaReporte, "INFORMES CRYSTAL REPORTS");
            }
            else {
                opcionesInforme = new Asistente_De_Informes(herramientaReporte, "INFORMES MICROSOFT REPORTING");
            }
            
            opcionesInforme.Show();
           
        }

        // Abre el Pop up de info de la aplicacion
        private void button1_Click(object sender, EventArgs e)
        {
            About_PopUp popUp = new About_PopUp();
            popUp.Show();
        }


        // Abre el manual de usuario
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://D:\\Dashboard_NorthWinds2\\NorthWind_InterfazGrafica\\Resources\\ManualUsuario\\ManualUsuario.chm");
        }

        // Cierra la aplicacion
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Abre el asistente de informes de Crystal Reports
        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Asistente_De_Informes opcionesInforme = new Asistente_De_Informes(tiposInforme[0], "INFORMES CRYSTAL REPORTS");
            opcionesInforme.Show();
        }



        // Abre el asistente de informes de Microsfot Reporting
        private void microsoftReportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistente_De_Informes opcionesInforme = new Asistente_De_Informes(tiposInforme[1], "INFORMES MICROSOFT REPORTING");
            opcionesInforme.Show();
        }

        // Abre el popUp AboutMe
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_PopUp popUp = new About_PopUp();
            popUp.Show();
        }
    }

 
}

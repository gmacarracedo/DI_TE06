using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBLL;
using NorthWind_InterfazGrafica.Reportes.MicrosoftReporting;

namespace NorthWind_InterfazGrafica.Reportes
{
   
    public partial class PideIdCliente : Form
    {
        string tipoInforme = string.Empty;

        public PideIdCliente(string tipoInforme)
        {
            InitializeComponent();
            aplicaColores();
            inicializaComboBoxClientes();
            this.tipoInforme = tipoInforme;
        }

        

        /// Inicializa el comboBox con el nombre de cada cliente haciendo una consulta a la BD a traves del BLL
        /// </summary>
        private void inicializaComboBoxClientes()
        {
            List<string> listaClientes;
            listaClientes = OperacionesBLL.BuscarListaClientes();

            // Asigna al comboBox_Clientes la lista de clientes recogida de la BD
            comboB_EligeIdCliente.DataSource = listaClientes;
        }

        // Abre un nuevo informe con el cliente elegido en el comboBox
        private void but_PideIdCliente_Click_1(object sender, EventArgs e)
        {
            string idCliente = comboB_EligeIdCliente.SelectedItem.ToString();

            if (tipoInforme.Equals("Crystal Reports"))
            {
                Reporte_ComprasPorCliente informeComprasCliente = new Reporte_ComprasPorCliente(idCliente);
                informeComprasCliente.Show();
            }
            else
            {
                ReportViewer_ComprasPorCliente informeMR_ComprasCliente = new ReportViewer_ComprasPorCliente(idCliente);
                informeMR_ComprasCliente.Show();
            }

            // Se cierra el formulario
            this.Dispose();
        }


        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);
            tLP_PideIdCliente.BackColor = fondoBase;
            lab_PideIdCliente.ForeColor = Color.White;
        }
    }
}

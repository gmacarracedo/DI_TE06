using NorthWind_InterfazGrafica.Reportes;
using NorthWind_InterfazGrafica.Reportes.MicrosoftReporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind_InterfazGrafica
{
    public partial class Asistente_De_Informes : Form
    {
        string tipoReporte = string.Empty;
        string titulo = string.Empty;

        public Asistente_De_Informes(string tipoReporte, string titulo)
        {
            this.tipoReporte = tipoReporte;
            this.titulo = titulo;

            InitializeComponent();
            aplicaColores();
        }


        // Abre el formulario para elegir el año del que se desea generar el informe
        private void but_Rep_ProductosMasVendidos_Click(object sender, EventArgs e)
        {
            
             PideAño pideAño = new PideAño(tipoReporte);
             pideAño.Show();
        }

        // Abre el formulario que pide el nombre del empleado para filtrar los datos del informe
        private void but_Rep_GananciasVentasVendedor_Click(object sender, EventArgs e)
        {
         
            PideNombreEmpleado pideEmpleado = new PideNombreEmpleado(tipoReporte);
            pideEmpleado.Show();

        }

        private void but_Rep_PedidosFecha_Click(object sender, EventArgs e)
        {
           
            PideFechas pideFechas = new PideFechas(tipoReporte);
            pideFechas.Show();
        }


        // Abre el formulario que pedira el cliente del que se deben mostrar las compras
        private void but_Rep_ComprasPorCliente_Click(object sender, EventArgs e)
        {
            PideIdCliente formPideIdCliente = new PideIdCliente(tipoReporte);
            formPideIdCliente.Show();
        }


        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);
            lab_titulo.BackColor = fondoBase;
            lab_titulo.ForeColor = Color.White;
            lab_titulo.Text = titulo;

        }
    }
}

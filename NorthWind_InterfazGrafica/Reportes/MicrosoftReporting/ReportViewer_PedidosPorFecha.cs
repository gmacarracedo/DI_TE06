using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind_InterfazGrafica.Reportes.MicrosoftReporting
{ 

    public partial class ReportViewer_PedidosPorFecha : Form
    {
        string fecha_Desde;
        string fecha_Hasta;

        public ReportViewer_PedidosPorFecha(string fecha_Desde, string fecha_Hasta)
        {
            this.fecha_Desde = fecha_Desde;
            this.fecha_Hasta = fecha_Hasta;
            InitializeComponent();
        }

        private void ReportViewer_PedidosPorFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReport.DataTable_Pedidos_Entre_Fechas' Puede moverla o quitarla según sea necesario.
            try
            {
                this.DataTable_Pedidos_Entre_FechasTableAdapter.Fill(this.DataSetReport.DataTable_Pedidos_Entre_Fechas, DateTime.Parse(fecha_Desde), DateTime.Parse(fecha_Hasta));
            }
            catch(Exception er) {
                this.DataTable_Pedidos_Entre_FechasTableAdapter.Fill(this.DataSetReport.DataTable_Pedidos_Entre_Fechas, DateTime.Parse(fecha_Desde), DateTime.Parse(fecha_Hasta));
                Console.WriteLine(er);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}

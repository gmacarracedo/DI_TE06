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
    public partial class PideFechas : Form
    {
        private string tipoReporte;

        public PideFechas(string tipoReporte)
        {
            this.tipoReporte = tipoReporte;
            InitializeComponent();
            aplicaColores();

            // Inicializa toolTip
            tTip_Ayuda.SetToolTip(dateTP_Fecha_Desde, "Fecha desde la que se generaran los datos del informe");
            tTip_Ayuda.SetToolTip(dateTP_HastaFecha, "Fecha hasta laque se generaran los datos del informe");
        }

        private void but_PedidoEntreFechas_Click(object sender, EventArgs e)
        {
            string desdeFecha = dateTP_Fecha_Desde.Text;
            string hastaFecha = dateTP_HastaFecha.Text;

            if (tipoReporte.Equals("Crystal Reports"))
            {
                Reporte_Pedidos_Fecha informePedidosFecha = new Reporte_Pedidos_Fecha(desdeFecha, hastaFecha);
                informePedidosFecha.Show();
            }
            else {
                ReportViewer_PedidosPorFecha informeMR_PedidosPorFecha = new ReportViewer_PedidosPorFecha(desdeFecha, hastaFecha);
                informeMR_PedidosPorFecha.Show();
            }

            // Se cierra el formulario
            this.Dispose();

        }


        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);
            
            lab_PideFechas.ForeColor = Color.White;
            lab_DesdeFecha.ForeColor = Color.White;
            lab_HastaFecha.ForeColor = Color.White;

            tLP_Base.BackColor = fondoBase;
        }
    }
}

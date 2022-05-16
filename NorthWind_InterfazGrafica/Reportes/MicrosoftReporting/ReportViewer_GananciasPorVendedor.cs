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
    public partial class ReportViewer_GananciasPorVendedor : Form
    {
        private string nombreVendedor;
        public ReportViewer_GananciasPorVendedor(String nombreVendedor)
        {
            InitializeComponent();
            this.nombreVendedor = nombreVendedor;
        }

        private void ReportViewer_GananciasPorVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReport.DataTable_GananciasVendedor' Puede moverla o quitarla según sea necesario.
            this.DataTable_GananciasVendedorTableAdapter.Fill(this.DataSetReport.DataTable_GananciasVendedor, nombreVendedor);

            this.reportViewer1.RefreshReport();
        }
    }
}

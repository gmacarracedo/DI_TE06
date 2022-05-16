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
    public partial class ReportViewer_ProductosMasVendidos : Form
    {
        private int anio;

        public ReportViewer_ProductosMasVendidos(int anio)
        {
            this.anio = anio;
            InitializeComponent();
        }

        // Carga el informce con el año elegido
        private void ReportViewer_ProductosMasVendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReport.DataTable2' Puede moverla o quitarla según sea necesario.
            try
            {
                this.DataTable2TableAdapter.Fill(this.DataSetReport.DataTable2, anio);
            }
            catch (Exception er) {
                this.DataTable2TableAdapter.Fill(this.DataSetReport.DataTable2, anio);
                Console.WriteLine(er);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

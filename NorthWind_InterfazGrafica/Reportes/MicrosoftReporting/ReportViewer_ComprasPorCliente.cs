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
    public partial class ReportViewer_ComprasPorCliente : Form
    {
        private string idCliente;

        // Se le pasa el idCliente al constructor para que se filtre la peticion a la BD
        public ReportViewer_ComprasPorCliente(string idCliente)
        {
            this.idCliente = idCliente;
            InitializeComponent();
        }

        private void ReportViewer_ComprasPorCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReport.DataTable_ComprasCliente' Puede moverla o quitarla según sea necesario.
            this.DataTable_ComprasClienteTableAdapter.Fill(this.DataSetReport.DataTable_ComprasCliente, idCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind_InterfazGrafica.Reportes
{
    public partial class Reporte_ComprasPorCliente : Form
    {
        public Reporte_ComprasPorCliente(string idCliente)
        {
            InitializeComponent();

            // Asigna el idCliente como parametro de busqueda
            ComprasPorCliente1.SetParameterValue("idCliente", idCliente);
        }
    }
}

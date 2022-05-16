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
    public partial class Reporte_GananciasVentasVendedor : Form
    {
        public Reporte_GananciasVentasVendedor(string nombreEmpleado)
        {
            InitializeComponent();

            // Paso el parametro al informe para que filtre los datos por el nombre del vendedor
            Ganancias_De_Ventas_Por_Vendedor1.SetParameterValue("nombreEmpleado", nombreEmpleado);
        }
    }
}

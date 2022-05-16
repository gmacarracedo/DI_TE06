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
    public partial class Reporte_Pedidos_Fecha : Form
    {
       
    
        public Reporte_Pedidos_Fecha(string desdeFecha, string hastaFecha)
        {
            InitializeComponent();
            // Asigno los parametros de fecha elegidos por el usuario
            Pedidos_Por_Fecha1.SetParameterValue("Desde_fecha", DateTime.Parse(desdeFecha));
            Pedidos_Por_Fecha1.SetParameterValue("Hasta_fecha", DateTime.Parse(hastaFecha));

        }

  
    }
}

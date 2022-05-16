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
    public partial class PideNombreEmpleado : Form
    {
        private string tipoInforme;

        public PideNombreEmpleado(string tipoInforme)
        {
            InitializeComponent();
            aplicaColores();
            this.tipoInforme = tipoInforme;
            inicializaComboBEmpleados();

            // Inicializa tooltip
            tTip_Ayuda.SetToolTip(comboB_PideNombreEmpleado, "Elige el nombre del empleado del que deseas generar el informe");
        }

        // Envia al informe correspondiente el parametro con el nombre elegido segun sea de Crystal Reports o MicrosoftReporting
        private void but_PideNombreEmpleado_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = comboB_PideNombreEmpleado.SelectedItem.ToString();

            if (tipoInforme.Equals("Crystal Reports"))
            {
                Reporte_GananciasVentasVendedor informeVentasVendedor = new Reporte_GananciasVentasVendedor(nombreEmpleado);
                informeVentasVendedor.Show();
            }
            else {
                ReportViewer_GananciasPorVendedor informeMR_VentasVendedor = new ReportViewer_GananciasPorVendedor(nombreEmpleado);
                informeMR_VentasVendedor.Show();
            }

            // Se cierra el formulario
            this.Dispose();
        }

        // Inicializa el comboBox con los nombres de cada empleado
        private void inicializaComboBEmpleados() {

            List<string> listaNombres = OperacionesBLL.BuscaEmpleados();
            
            comboB_PideNombreEmpleado.DataSource = listaNombres;
        }


        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);
            tLP_Base.BackColor = fondoBase;
            lab_PideNombreempleado.ForeColor = Color.White;
        }
    }
}

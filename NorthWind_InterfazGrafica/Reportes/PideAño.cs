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
    public partial class PideAño : Form
    {
        private string tipoInforme = string.Empty;

        public PideAño(string tipoInforme)
        {
            this.tipoInforme = tipoInforme;
            InitializeComponent();
            aplicaColores();

            //Inicializa tooltip de ayuda
            tTip_Ayuda.SetToolTip(numericBox, "Año del que se generaran los datos del informe");
        }

        // Abre el informe de los productos mas vendidos
        private void but_PideAño_Click(object sender, EventArgs e)
        {
            int anioInforme = 0;

            if (numericBox.Text != "") {
                anioInforme = (int) Int32.Parse(numericBox.Text);
                

                if (tipoInforme.Equals("Crystal Reports"))
                {
                    Reporte_ProductosMasVendidos informeMasVendidos = new Reporte_ProductosMasVendidos(anioInforme);
                    informeMasVendidos.Show();
                }
                else
                {
                    ReportViewer_ProductosMasVendidos rV_ProductosMasVendidos = new ReportViewer_ProductosMasVendidos(anioInforme);
                    rV_ProductosMasVendidos.Show();
                }

                // Se cierra el formulario
                this.Dispose();
            }
            
        }


        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);
            lab_PideAño.BackColor = fondoBase;
            lab_PideAño.ForeColor = Color.White;
        }
    }
}

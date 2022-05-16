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
    public partial class About_PopUp : Form
    {
        public About_PopUp()
        {
            InitializeComponent();
            muestraInfo();
            aplicaColores();

            // Inicializa HelpProvider
            helpProv_Ayuda.SetHelpString(checkBox1, "Activa la casilla si deseas recibir un aviso cuando la aplicacion se actulice a una nueva version");
            helpProv_Ayuda.SetHelpString(but_Aceptar, "Pulsa para aceptar los cambios");
        }

        private void muestraInfo() {
            textBox1.Text = Environment.NewLine
                            + "Esta aplicación a sido realizada como tarea de aprendizaje para la asignatura de Diseño de Interfaces del modulo de" +
                            " Desarrollo de Aplicaciones Multiplataforma. "
                            + Environment.NewLine
                            + "Esta permitido su uso como ejemplo o en beneficio del aprendizaje para otros estudiantes que cursen esta misma" +
                            " asignatura o similar";
        }

        // Aplica los colores personalizados
        private void aplicaColores()
        {
            Color fondoBase = new Color();
            fondoBase = Color.FromArgb(55, 55, 77);

            lab_About.ForeColor = Color.White;
            checkBox1.ForeColor = Color.White;

            tLP_Base.BackColor = fondoBase;
        }

        private void but_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

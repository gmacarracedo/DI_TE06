
namespace NorthWind_InterfazGrafica.Reportes.MicrosoftReporting
{
    partial class ReportViewer_GananciasPorVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReport = new NorthWind_InterfazGrafica.Reportes.MicrosoftReporting.DataSetReport();
            this.DataTable_GananciasVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_GananciasVendedorTableAdapter = new NorthWind_InterfazGrafica.Reportes.MicrosoftReporting.DataSetReportTableAdapters.DataTable_GananciasVendedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_GananciasVendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_GananciasVendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NorthWind_InterfazGrafica.Reportes.MicrosoftReporting.MReport_Ganancias_Ventas_Po" +
    "r_Vendedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_GananciasVendedorBindingSource
            // 
            this.DataTable_GananciasVendedorBindingSource.DataMember = "DataTable_GananciasVendedor";
            this.DataTable_GananciasVendedorBindingSource.DataSource = this.DataSetReport;
            // 
            // DataTable_GananciasVendedorTableAdapter
            // 
            this.DataTable_GananciasVendedorTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer_GananciasPorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer_GananciasPorVendedor";
            this.Text = "ReportViewer_GananciasPorVendedor";
            this.Load += new System.EventHandler(this.ReportViewer_GananciasPorVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_GananciasVendedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable_GananciasVendedorBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.DataTable_GananciasVendedorTableAdapter DataTable_GananciasVendedorTableAdapter;
    }
}
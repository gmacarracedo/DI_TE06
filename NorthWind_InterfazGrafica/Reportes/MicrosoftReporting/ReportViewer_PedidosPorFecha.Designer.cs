
namespace NorthWind_InterfazGrafica.Reportes.MicrosoftReporting
{
    partial class ReportViewer_PedidosPorFecha
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
            this.DataTable_Pedidos_Entre_FechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_Pedidos_Entre_FechasTableAdapter = new NorthWind_InterfazGrafica.Reportes.MicrosoftReporting.DataSetReportTableAdapters.DataTable_Pedidos_Entre_FechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Pedidos_Entre_FechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_Pedidos_Entre_FechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NorthWind_InterfazGrafica.Reportes.MicrosoftReporting.MReport_PedidosPorFecha.rdl" +
    "c";
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
            // DataTable_Pedidos_Entre_FechasBindingSource
            // 
            this.DataTable_Pedidos_Entre_FechasBindingSource.DataMember = "DataTable_Pedidos_Entre_Fechas";
            this.DataTable_Pedidos_Entre_FechasBindingSource.DataSource = this.DataSetReport;
            // 
            // DataTable_Pedidos_Entre_FechasTableAdapter
            // 
            this.DataTable_Pedidos_Entre_FechasTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer_PedidosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer_PedidosPorFecha";
            this.Text = "ReportViewer_PedidosPorFecha";
            this.Load += new System.EventHandler(this.ReportViewer_PedidosPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Pedidos_Entre_FechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable_Pedidos_Entre_FechasBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.DataTable_Pedidos_Entre_FechasTableAdapter DataTable_Pedidos_Entre_FechasTableAdapter;
    }
}
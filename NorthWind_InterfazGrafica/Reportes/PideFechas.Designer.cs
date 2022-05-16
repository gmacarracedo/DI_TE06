
namespace NorthWind_InterfazGrafica
{
    partial class PideFechas
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
            this.tLP_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTP_HastaFecha = new System.Windows.Forms.DateTimePicker();
            this.lab_HastaFecha = new System.Windows.Forms.Label();
            this.lab_DesdeFecha = new System.Windows.Forms.Label();
            this.dateTP_Fecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_PideFechas = new System.Windows.Forms.Label();
            this.but_PedidoEntreFechas = new System.Windows.Forms.Button();
            this.tTip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.tLP_Base.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Base
            // 
            this.tLP_Base.ColumnCount = 1;
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Base.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tLP_Base.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tLP_Base.Controls.Add(this.but_PedidoEntreFechas, 0, 2);
            this.tLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Base.Name = "tLP_Base";
            this.tLP_Base.RowCount = 3;
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.64502F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.32035F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
            this.tLP_Base.Size = new System.Drawing.Size(484, 231);
            this.tLP_Base.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dateTP_HastaFecha, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lab_HastaFecha, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lab_DesdeFecha, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTP_Fecha_Desde, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTP_HastaFecha
            // 
            this.dateTP_HastaFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTP_HastaFecha.Location = new System.Drawing.Point(242, 64);
            this.dateTP_HastaFecha.Name = "dateTP_HastaFecha";
            this.dateTP_HastaFecha.Size = new System.Drawing.Size(233, 26);
            this.dateTP_HastaFecha.TabIndex = 4;
            // 
            // lab_HastaFecha
            // 
            this.lab_HastaFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_HastaFecha.AutoSize = true;
            this.lab_HastaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_HastaFecha.Location = new System.Drawing.Point(242, 18);
            this.lab_HastaFecha.Name = "lab_HastaFecha";
            this.lab_HastaFecha.Size = new System.Drawing.Size(127, 25);
            this.lab_HastaFecha.TabIndex = 3;
            this.lab_HastaFecha.Text = "Hasta fecha: ";
            // 
            // lab_DesdeFecha
            // 
            this.lab_DesdeFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_DesdeFecha.AutoSize = true;
            this.lab_DesdeFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DesdeFecha.Location = new System.Drawing.Point(3, 18);
            this.lab_DesdeFecha.Name = "lab_DesdeFecha";
            this.lab_DesdeFecha.Size = new System.Drawing.Size(133, 25);
            this.lab_DesdeFecha.TabIndex = 1;
            this.lab_DesdeFecha.Text = "Desde fecha: ";
            // 
            // dateTP_Fecha_Desde
            // 
            this.dateTP_Fecha_Desde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTP_Fecha_Desde.Location = new System.Drawing.Point(3, 64);
            this.dateTP_Fecha_Desde.Name = "dateTP_Fecha_Desde";
            this.dateTP_Fecha_Desde.Size = new System.Drawing.Size(233, 26);
            this.dateTP_Fecha_Desde.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lab_PideFechas, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 43);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lab_PideFechas
            // 
            this.lab_PideFechas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_PideFechas.AutoSize = true;
            this.lab_PideFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PideFechas.Location = new System.Drawing.Point(100, 14);
            this.lab_PideFechas.Name = "lab_PideFechas";
            this.lab_PideFechas.Size = new System.Drawing.Size(277, 29);
            this.lab_PideFechas.TabIndex = 2;
            this.lab_PideFechas.Text = "Pedidos entre las fechas";
            // 
            // but_PedidoEntreFechas
            // 
            this.but_PedidoEntreFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_PedidoEntreFechas.Location = new System.Drawing.Point(3, 158);
            this.but_PedidoEntreFechas.Name = "but_PedidoEntreFechas";
            this.but_PedidoEntreFechas.Size = new System.Drawing.Size(478, 70);
            this.but_PedidoEntreFechas.TabIndex = 2;
            this.but_PedidoEntreFechas.Text = "Generar informe";
            this.but_PedidoEntreFechas.UseVisualStyleBackColor = true;
            this.but_PedidoEntreFechas.Click += new System.EventHandler(this.but_PedidoEntreFechas_Click);
            // 
            // PideFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.tLP_Base);
            this.Name = "PideFechas";
            this.Text = "PideFechas";
            this.tLP_Base.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Base;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTP_HastaFecha;
        private System.Windows.Forms.Label lab_HastaFecha;
        private System.Windows.Forms.Label lab_DesdeFecha;
        private System.Windows.Forms.DateTimePicker dateTP_Fecha_Desde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lab_PideFechas;
        private System.Windows.Forms.Button but_PedidoEntreFechas;
        private System.Windows.Forms.ToolTip tTip_Ayuda;
    }
}
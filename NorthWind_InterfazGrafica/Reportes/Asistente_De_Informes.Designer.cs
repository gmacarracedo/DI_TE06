
namespace NorthWind_InterfazGrafica
{
    partial class Asistente_De_Informes
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
            this.tLP_Base = new System.Windows.Forms.TableLayoutPanel();
            this.lab_titulo = new System.Windows.Forms.Label();
            this.but_Rep_ProductosMasVendidos = new System.Windows.Forms.Button();
            this.but_Rep_GananciasVentasVendedor = new System.Windows.Forms.Button();
            this.but_Rep_PedidosFecha = new System.Windows.Forms.Button();
            this.but_Rep_ComprasPorCliente = new System.Windows.Forms.Button();
            this.tLP_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Base
            // 
            this.tLP_Base.ColumnCount = 1;
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Base.Controls.Add(this.but_Rep_ProductosMasVendidos, 0, 1);
            this.tLP_Base.Controls.Add(this.but_Rep_GananciasVentasVendedor, 0, 2);
            this.tLP_Base.Controls.Add(this.but_Rep_PedidosFecha, 0, 3);
            this.tLP_Base.Controls.Add(this.but_Rep_ComprasPorCliente, 0, 4);
            this.tLP_Base.Controls.Add(this.lab_titulo, 0, 0);
            this.tLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Base.Name = "tLP_Base";
            this.tLP_Base.RowCount = 5;
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Base.Size = new System.Drawing.Size(800, 450);
            this.tLP_Base.TabIndex = 0;
            // 
            // lab_titulo
            // 
            this.lab_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_titulo.AutoSize = true;
            this.lab_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_titulo.Location = new System.Drawing.Point(3, 0);
            this.lab_titulo.Name = "lab_titulo";
            this.lab_titulo.Size = new System.Drawing.Size(794, 93);
            this.lab_titulo.TabIndex = 0;
            this.lab_titulo.Text = "Informes ";
            this.lab_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_Rep_ProductosMasVendidos
            // 
            this.but_Rep_ProductosMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Rep_ProductosMasVendidos.Location = new System.Drawing.Point(3, 96);
            this.but_Rep_ProductosMasVendidos.Name = "but_Rep_ProductosMasVendidos";
            this.but_Rep_ProductosMasVendidos.Size = new System.Drawing.Size(794, 87);
            this.but_Rep_ProductosMasVendidos.TabIndex = 4;
            this.but_Rep_ProductosMasVendidos.Text = "Productos mas vendidos por año";
            this.but_Rep_ProductosMasVendidos.UseVisualStyleBackColor = true;
            this.but_Rep_ProductosMasVendidos.Click += new System.EventHandler(this.but_Rep_ProductosMasVendidos_Click);
            // 
            // but_Rep_GananciasVentasVendedor
            // 
            this.but_Rep_GananciasVentasVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Rep_GananciasVentasVendedor.Location = new System.Drawing.Point(3, 189);
            this.but_Rep_GananciasVentasVendedor.Name = "but_Rep_GananciasVentasVendedor";
            this.but_Rep_GananciasVentasVendedor.Size = new System.Drawing.Size(794, 87);
            this.but_Rep_GananciasVentasVendedor.TabIndex = 5;
            this.but_Rep_GananciasVentasVendedor.Text = "Ganancias de ventas por vendedor";
            this.but_Rep_GananciasVentasVendedor.UseVisualStyleBackColor = true;
            this.but_Rep_GananciasVentasVendedor.Click += new System.EventHandler(this.but_Rep_GananciasVentasVendedor_Click);
            // 
            // but_Rep_PedidosFecha
            // 
            this.but_Rep_PedidosFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Rep_PedidosFecha.Location = new System.Drawing.Point(3, 282);
            this.but_Rep_PedidosFecha.Name = "but_Rep_PedidosFecha";
            this.but_Rep_PedidosFecha.Size = new System.Drawing.Size(794, 87);
            this.but_Rep_PedidosFecha.TabIndex = 6;
            this.but_Rep_PedidosFecha.Text = "Pedidos por fecha";
            this.but_Rep_PedidosFecha.UseVisualStyleBackColor = true;
            this.but_Rep_PedidosFecha.Click += new System.EventHandler(this.but_Rep_PedidosFecha_Click);
            // 
            // but_Rep_ComprasPorCliente
            // 
            this.but_Rep_ComprasPorCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Rep_ComprasPorCliente.Location = new System.Drawing.Point(3, 375);
            this.but_Rep_ComprasPorCliente.Name = "but_Rep_ComprasPorCliente";
            this.but_Rep_ComprasPorCliente.Size = new System.Drawing.Size(794, 72);
            this.but_Rep_ComprasPorCliente.TabIndex = 7;
            this.but_Rep_ComprasPorCliente.Text = "Compras por cliente";
            this.but_Rep_ComprasPorCliente.UseVisualStyleBackColor = true;
            this.but_Rep_ComprasPorCliente.Click += new System.EventHandler(this.but_Rep_ComprasPorCliente_Click);
            // 
            // Asistente_De_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tLP_Base);
            this.Name = "Asistente_De_Informes";
            this.Text = "Asistente de informes";
            this.tLP_Base.ResumeLayout(false);
            this.tLP_Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Base;
        private System.Windows.Forms.Button but_Rep_ProductosMasVendidos;
        private System.Windows.Forms.Button but_Rep_GananciasVentasVendedor;
        private System.Windows.Forms.Button but_Rep_PedidosFecha;
        private System.Windows.Forms.Button but_Rep_ComprasPorCliente;
        private System.Windows.Forms.Label lab_titulo;
    }
}
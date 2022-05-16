
namespace NorthWind_InterfazGrafica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tLP_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Cabecera = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.tLP_Busquedas = new System.Windows.Forms.TableLayoutPanel();
            this.comboB_ComprasFecha = new System.Windows.Forms.ComboBox();
            this.comboB_Clientes = new System.Windows.Forms.ComboBox();
            this.lab_ComprasFecha = new System.Windows.Forms.Label();
            this.lab_Cliente = new System.Windows.Forms.Label();
            this.lab_idCompra = new System.Windows.Forms.Label();
            this.comboB_idCompra = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftReportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tLP_Informacion = new System.Windows.Forms.TableLayoutPanel();
            this.tLPanel_Seleccion = new System.Windows.Forms.TableLayoutPanel();
            this.but_InfoClientes = new System.Windows.Forms.Button();
            this.but_ListaCompras = new System.Windows.Forms.Button();
            this.but_ProductosMasComprados = new System.Windows.Forms.Button();
            this.tLP_Reportes = new System.Windows.Forms.TableLayoutPanel();
            this.but_GeneraInforme = new System.Windows.Forms.Button();
            this.comb_Reportes = new System.Windows.Forms.ComboBox();
            this.lab_Reportes = new System.Windows.Forms.Label();
            this.lab_Herramienta = new System.Windows.Forms.Label();
            this.tLP_Datos = new System.Windows.Forms.TableLayoutPanel();
            this.chartProductosComprados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tB_MuestraInfo = new System.Windows.Forms.TextBox();
            this.dataGV_Compras = new System.Windows.Forms.DataGridView();
            this.dataGV_DetallesCompra = new System.Windows.Forms.DataGridView();
            this.lab_InfoCliente = new System.Windows.Forms.Label();
            this.lab_ProductosComprados = new System.Windows.Forms.Label();
            this.lab_Compras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tTip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.tLP_Base.SuspendLayout();
            this.tLP_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tLP_Busquedas.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tLP_Informacion.SuspendLayout();
            this.tLPanel_Seleccion.SuspendLayout();
            this.tLP_Reportes.SuspendLayout();
            this.tLP_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DetallesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // tLP_Base
            // 
            this.tLP_Base.ColumnCount = 1;
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Base.Controls.Add(this.tLP_Cabecera, 0, 0);
            this.tLP_Base.Controls.Add(this.tLP_Informacion, 0, 1);
            this.tLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Base.Name = "tLP_Base";
            this.tLP_Base.RowCount = 2;
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.81506F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.18494F));
            this.tLP_Base.Size = new System.Drawing.Size(1520, 757);
            this.tLP_Base.TabIndex = 0;
            // 
            // tLP_Cabecera
            // 
            this.tLP_Cabecera.ColumnCount = 2;
            this.tLP_Cabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.8744F));
            this.tLP_Cabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.1256F));
            this.tLP_Cabecera.Controls.Add(this.pictureBox_Logo, 0, 1);
            this.tLP_Cabecera.Controls.Add(this.tLP_Busquedas, 1, 1);
            this.tLP_Cabecera.Controls.Add(this.menuStrip, 1, 0);
            this.tLP_Cabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Cabecera.Location = new System.Drawing.Point(3, 3);
            this.tLP_Cabecera.Name = "tLP_Cabecera";
            this.tLP_Cabecera.RowCount = 2;
            this.tLP_Cabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.38889F));
            this.tLP_Cabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.61111F));
            this.tLP_Cabecera.Size = new System.Drawing.Size(1514, 144);
            this.tLP_Cabecera.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Logo.Image = global::NorthWind_InterfazGrafica.Properties.Resources.NORTHWINDS__1_;
            this.pictureBox_Logo.InitialImage = global::NorthWind_InterfazGrafica.Properties.Resources.NORTHWINDS__1_;
            this.pictureBox_Logo.Location = new System.Drawing.Point(15, 41);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(148, 100);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 6;
            this.pictureBox_Logo.TabStop = false;
            // 
            // tLP_Busquedas
            // 
            this.tLP_Busquedas.ColumnCount = 3;
            this.tLP_Busquedas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_Busquedas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_Busquedas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_Busquedas.Controls.Add(this.comboB_ComprasFecha, 1, 1);
            this.tLP_Busquedas.Controls.Add(this.comboB_Clientes, 0, 1);
            this.tLP_Busquedas.Controls.Add(this.lab_ComprasFecha, 1, 0);
            this.tLP_Busquedas.Controls.Add(this.lab_Cliente, 0, 0);
            this.tLP_Busquedas.Controls.Add(this.lab_idCompra, 2, 0);
            this.tLP_Busquedas.Controls.Add(this.comboB_idCompra, 2, 1);
            this.tLP_Busquedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Busquedas.Location = new System.Drawing.Point(288, 41);
            this.tLP_Busquedas.Name = "tLP_Busquedas";
            this.tLP_Busquedas.RowCount = 2;
            this.tLP_Busquedas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Busquedas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Busquedas.Size = new System.Drawing.Size(1223, 100);
            this.tLP_Busquedas.TabIndex = 4;
            // 
            // comboB_ComprasFecha
            // 
            this.comboB_ComprasFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_ComprasFecha.FormattingEnabled = true;
            this.comboB_ComprasFecha.Location = new System.Drawing.Point(410, 53);
            this.comboB_ComprasFecha.Name = "comboB_ComprasFecha";
            this.comboB_ComprasFecha.Size = new System.Drawing.Size(401, 28);
            this.comboB_ComprasFecha.TabIndex = 14;
            this.comboB_ComprasFecha.SelectionChangeCommitted += new System.EventHandler(this.verComprasFecha);
            // 
            // comboB_Clientes
            // 
            this.comboB_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_Clientes.FormattingEnabled = true;
            this.comboB_Clientes.Location = new System.Drawing.Point(3, 53);
            this.comboB_Clientes.Name = "comboB_Clientes";
            this.comboB_Clientes.Size = new System.Drawing.Size(401, 28);
            this.comboB_Clientes.TabIndex = 13;
            this.comboB_Clientes.SelectionChangeCommitted += new System.EventHandler(this.Limpia_InicialidaDatos);
            // 
            // lab_ComprasFecha
            // 
            this.lab_ComprasFecha.AutoSize = true;
            this.lab_ComprasFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_ComprasFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ComprasFecha.Location = new System.Drawing.Point(410, 0);
            this.lab_ComprasFecha.Name = "lab_ComprasFecha";
            this.lab_ComprasFecha.Size = new System.Drawing.Size(401, 50);
            this.lab_ComprasFecha.TabIndex = 12;
            this.lab_ComprasFecha.Text = "Compras por fecha : ";
            this.lab_ComprasFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_Cliente
            // 
            this.lab_Cliente.AutoSize = true;
            this.lab_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Cliente.Location = new System.Drawing.Point(3, 0);
            this.lab_Cliente.Name = "lab_Cliente";
            this.lab_Cliente.Size = new System.Drawing.Size(401, 50);
            this.lab_Cliente.TabIndex = 11;
            this.lab_Cliente.Text = "Cliente: ";
            this.lab_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_idCompra
            // 
            this.lab_idCompra.AutoSize = true;
            this.lab_idCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_idCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_idCompra.Location = new System.Drawing.Point(817, 0);
            this.lab_idCompra.Name = "lab_idCompra";
            this.lab_idCompra.Size = new System.Drawing.Size(403, 50);
            this.lab_idCompra.TabIndex = 10;
            this.lab_idCompra.Text = "Compras por ID";
            this.lab_idCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboB_idCompra
            // 
            this.comboB_idCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboB_idCompra.FormattingEnabled = true;
            this.comboB_idCompra.Location = new System.Drawing.Point(817, 53);
            this.comboB_idCompra.Name = "comboB_idCompra";
            this.comboB_idCompra.Size = new System.Drawing.Size(403, 28);
            this.comboB_idCompra.TabIndex = 8;
            this.comboB_idCompra.SelectionChangeCommitted += new System.EventHandler(this.verDetallesCompra);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = global::NorthWind_InterfazGrafica.Properties.Settings.Default.Slate;
            this.menuStrip.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::NorthWind_InterfazGrafica.Properties.Settings.Default, "Slate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(285, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1229, 36);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.microsoftReportingToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.herramientasToolStripMenuItem.Text = "Informes";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.informesToolStripMenuItem.Text = "Crystal Reports";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // microsoftReportingToolStripMenuItem
            // 
            this.microsoftReportingToolStripMenuItem.Name = "microsoftReportingToolStripMenuItem";
            this.microsoftReportingToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.microsoftReportingToolStripMenuItem.Text = "Microsoft Reporting";
            this.microsoftReportingToolStripMenuItem.Click += new System.EventHandler(this.microsoftReportingToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tLP_Informacion
            // 
            this.tLP_Informacion.ColumnCount = 2;
            this.tLP_Informacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.14894F));
            this.tLP_Informacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.85107F));
            this.tLP_Informacion.Controls.Add(this.tLPanel_Seleccion, 0, 0);
            this.tLP_Informacion.Controls.Add(this.tLP_Datos, 1, 0);
            this.tLP_Informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Informacion.Location = new System.Drawing.Point(3, 153);
            this.tLP_Informacion.Name = "tLP_Informacion";
            this.tLP_Informacion.RowCount = 1;
            this.tLP_Informacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Informacion.Size = new System.Drawing.Size(1514, 601);
            this.tLP_Informacion.TabIndex = 1;
            // 
            // tLPanel_Seleccion
            // 
            this.tLPanel_Seleccion.ColumnCount = 1;
            this.tLPanel_Seleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Seleccion.Controls.Add(this.but_InfoClientes, 0, 0);
            this.tLPanel_Seleccion.Controls.Add(this.but_ListaCompras, 0, 1);
            this.tLPanel_Seleccion.Controls.Add(this.but_ProductosMasComprados, 0, 2);
            this.tLPanel_Seleccion.Controls.Add(this.tLP_Reportes, 0, 4);
            this.tLPanel_Seleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Seleccion.Location = new System.Drawing.Point(3, 3);
            this.tLPanel_Seleccion.Name = "tLPanel_Seleccion";
            this.tLPanel_Seleccion.RowCount = 5;
            this.tLPanel_Seleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31645F));
            this.tLPanel_Seleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31645F));
            this.tLPanel_Seleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32631F));
            this.tLPanel_Seleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47851F));
            this.tLPanel_Seleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.56227F));
            this.tLPanel_Seleccion.Size = new System.Drawing.Size(283, 595);
            this.tLPanel_Seleccion.TabIndex = 0;
            // 
            // but_InfoClientes
            // 
            this.but_InfoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_InfoClientes.Location = new System.Drawing.Point(3, 3);
            this.but_InfoClientes.Name = "but_InfoClientes";
            this.but_InfoClientes.Size = new System.Drawing.Size(277, 67);
            this.but_InfoClientes.TabIndex = 0;
            this.but_InfoClientes.Text = "Info detallada Cliente";
            this.but_InfoClientes.UseVisualStyleBackColor = true;
            this.but_InfoClientes.Click += new System.EventHandler(this.but_InfoClientes_Click);
            // 
            // but_ListaCompras
            // 
            this.but_ListaCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_ListaCompras.Location = new System.Drawing.Point(3, 76);
            this.but_ListaCompras.Name = "but_ListaCompras";
            this.but_ListaCompras.Size = new System.Drawing.Size(277, 67);
            this.but_ListaCompras.TabIndex = 1;
            this.but_ListaCompras.Text = "Todas las compras realizadas";
            this.but_ListaCompras.UseVisualStyleBackColor = true;
            this.but_ListaCompras.Click += new System.EventHandler(this.but_ListaCompras_Click);
            // 
            // but_ProductosMasComprados
            // 
            this.but_ProductosMasComprados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_ProductosMasComprados.Location = new System.Drawing.Point(3, 149);
            this.but_ProductosMasComprados.Name = "but_ProductosMasComprados";
            this.but_ProductosMasComprados.Size = new System.Drawing.Size(277, 67);
            this.but_ProductosMasComprados.TabIndex = 2;
            this.but_ProductosMasComprados.Text = "Productos más comprados";
            this.but_ProductosMasComprados.UseVisualStyleBackColor = true;
            this.but_ProductosMasComprados.Click += new System.EventHandler(this.ProductosMasComprados);
            // 
            // tLP_Reportes
            // 
            this.tLP_Reportes.ColumnCount = 1;
            this.tLP_Reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Reportes.Controls.Add(this.but_GeneraInforme, 0, 3);
            this.tLP_Reportes.Controls.Add(this.comb_Reportes, 0, 2);
            this.tLP_Reportes.Controls.Add(this.lab_Reportes, 0, 0);
            this.tLP_Reportes.Controls.Add(this.lab_Herramienta, 0, 1);
            this.tLP_Reportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Reportes.Location = new System.Drawing.Point(3, 296);
            this.tLP_Reportes.Name = "tLP_Reportes";
            this.tLP_Reportes.RowCount = 4;
            this.tLP_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.63514F));
            this.tLP_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.tLP_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.56757F));
            this.tLP_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.24324F));
            this.tLP_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Reportes.Size = new System.Drawing.Size(277, 296);
            this.tLP_Reportes.TabIndex = 3;
            // 
            // but_GeneraInforme
            // 
            this.but_GeneraInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_GeneraInforme.Location = new System.Drawing.Point(3, 170);
            this.but_GeneraInforme.Name = "but_GeneraInforme";
            this.but_GeneraInforme.Size = new System.Drawing.Size(271, 123);
            this.but_GeneraInforme.TabIndex = 16;
            this.but_GeneraInforme.Text = "Crear informe";
            this.but_GeneraInforme.UseVisualStyleBackColor = true;
            this.but_GeneraInforme.Click += new System.EventHandler(this.GenerarInforme);
            // 
            // comb_Reportes
            // 
            this.comb_Reportes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comb_Reportes.FormattingEnabled = true;
            this.comb_Reportes.Location = new System.Drawing.Point(3, 127);
            this.comb_Reportes.Name = "comb_Reportes";
            this.comb_Reportes.Size = new System.Drawing.Size(261, 28);
            this.comb_Reportes.TabIndex = 13;
            // 
            // lab_Reportes
            // 
            this.lab_Reportes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_Reportes.AutoSize = true;
            this.lab_Reportes.BackColor = System.Drawing.Color.White;
            this.lab_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Reportes.Location = new System.Drawing.Point(65, 38);
            this.lab_Reportes.Name = "lab_Reportes";
            this.lab_Reportes.Size = new System.Drawing.Size(146, 29);
            this.lab_Reportes.TabIndex = 10;
            this.lab_Reportes.Text = "REPORTES";
            // 
            // lab_Herramienta
            // 
            this.lab_Herramienta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_Herramienta.AutoSize = true;
            this.lab_Herramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Herramienta.Location = new System.Drawing.Point(3, 90);
            this.lab_Herramienta.Name = "lab_Herramienta";
            this.lab_Herramienta.Size = new System.Drawing.Size(158, 25);
            this.lab_Herramienta.TabIndex = 11;
            this.lab_Herramienta.Text = "Tipo de informe: ";
            this.lab_Herramienta.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tLP_Datos
            // 
            this.tLP_Datos.BackColor = System.Drawing.SystemColors.Desktop;
            this.tLP_Datos.ColumnCount = 2;
            this.tLP_Datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Datos.Controls.Add(this.chartProductosComprados, 1, 1);
            this.tLP_Datos.Controls.Add(this.tB_MuestraInfo, 0, 1);
            this.tLP_Datos.Controls.Add(this.dataGV_Compras, 0, 3);
            this.tLP_Datos.Controls.Add(this.dataGV_DetallesCompra, 1, 3);
            this.tLP_Datos.Controls.Add(this.lab_InfoCliente, 0, 0);
            this.tLP_Datos.Controls.Add(this.lab_ProductosComprados, 1, 0);
            this.tLP_Datos.Controls.Add(this.lab_Compras, 0, 2);
            this.tLP_Datos.Controls.Add(this.label1, 1, 2);
            this.tLP_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Datos.Location = new System.Drawing.Point(292, 3);
            this.tLP_Datos.Name = "tLP_Datos";
            this.tLP_Datos.RowCount = 4;
            this.tLP_Datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_Datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLP_Datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tLP_Datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLP_Datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Datos.Size = new System.Drawing.Size(1219, 595);
            this.tLP_Datos.TabIndex = 1;
            // 
            // chartProductosComprados
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProductosComprados.ChartAreas.Add(chartArea2);
            this.chartProductosComprados.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartProductosComprados.Legends.Add(legend2);
            this.chartProductosComprados.Location = new System.Drawing.Point(612, 62);
            this.chartProductosComprados.Name = "chartProductosComprados";
            this.chartProductosComprados.Size = new System.Drawing.Size(604, 232);
            this.chartProductosComprados.TabIndex = 25;
            this.chartProductosComprados.Text = "chart1";
            // 
            // tB_MuestraInfo
            // 
            this.tB_MuestraInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tB_MuestraInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_MuestraInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tB_MuestraInfo.Location = new System.Drawing.Point(3, 62);
            this.tB_MuestraInfo.Multiline = true;
            this.tB_MuestraInfo.Name = "tB_MuestraInfo";
            this.tB_MuestraInfo.ReadOnly = true;
            this.tB_MuestraInfo.Size = new System.Drawing.Size(603, 232);
            this.tB_MuestraInfo.TabIndex = 22;
            // 
            // dataGV_Compras
            // 
            this.dataGV_Compras.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGV_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_Compras.Location = new System.Drawing.Point(3, 359);
            this.dataGV_Compras.Name = "dataGV_Compras";
            this.dataGV_Compras.RowHeadersWidth = 62;
            this.dataGV_Compras.RowTemplate.Height = 28;
            this.dataGV_Compras.Size = new System.Drawing.Size(603, 233);
            this.dataGV_Compras.TabIndex = 17;
            // 
            // dataGV_DetallesCompra
            // 
            this.dataGV_DetallesCompra.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGV_DetallesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DetallesCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_DetallesCompra.Location = new System.Drawing.Point(612, 359);
            this.dataGV_DetallesCompra.Name = "dataGV_DetallesCompra";
            this.dataGV_DetallesCompra.RowHeadersWidth = 62;
            this.dataGV_DetallesCompra.RowTemplate.Height = 28;
            this.dataGV_DetallesCompra.Size = new System.Drawing.Size(604, 233);
            this.dataGV_DetallesCompra.TabIndex = 16;
            // 
            // lab_InfoCliente
            // 
            this.lab_InfoCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_InfoCliente.AutoSize = true;
            this.lab_InfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InfoCliente.ForeColor = System.Drawing.Color.White;
            this.lab_InfoCliente.Location = new System.Drawing.Point(3, 17);
            this.lab_InfoCliente.Name = "lab_InfoCliente";
            this.lab_InfoCliente.Size = new System.Drawing.Size(179, 25);
            this.lab_InfoCliente.TabIndex = 7;
            this.lab_InfoCliente.Text = "Información Cliente";
            // 
            // lab_ProductosComprados
            // 
            this.lab_ProductosComprados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_ProductosComprados.AutoSize = true;
            this.lab_ProductosComprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ProductosComprados.ForeColor = System.Drawing.Color.White;
            this.lab_ProductosComprados.Location = new System.Drawing.Point(612, 17);
            this.lab_ProductosComprados.Name = "lab_ProductosComprados";
            this.lab_ProductosComprados.Size = new System.Drawing.Size(244, 25);
            this.lab_ProductosComprados.TabIndex = 8;
            this.lab_ProductosComprados.Text = "Productos más comprados";
            // 
            // lab_Compras
            // 
            this.lab_Compras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_Compras.AutoSize = true;
            this.lab_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Compras.ForeColor = System.Drawing.Color.White;
            this.lab_Compras.Location = new System.Drawing.Point(3, 314);
            this.lab_Compras.Name = "lab_Compras";
            this.lab_Compras.Size = new System.Drawing.Size(274, 25);
            this.lab_Compras.TabIndex = 11;
            this.lab_Compras.Text = "Compras / Compras por fecha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(612, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Detalles de compra por ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 757);
            this.Controls.Add(this.tLP_Base);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tLP_Base.ResumeLayout(false);
            this.tLP_Cabecera.ResumeLayout(false);
            this.tLP_Cabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tLP_Busquedas.ResumeLayout(false);
            this.tLP_Busquedas.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tLP_Informacion.ResumeLayout(false);
            this.tLPanel_Seleccion.ResumeLayout(false);
            this.tLP_Reportes.ResumeLayout(false);
            this.tLP_Reportes.PerformLayout();
            this.tLP_Datos.ResumeLayout(false);
            this.tLP_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DetallesCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Base;
        private System.Windows.Forms.TableLayoutPanel tLP_Cabecera;
        private System.Windows.Forms.TableLayoutPanel tLP_Informacion;
        private System.Windows.Forms.TableLayoutPanel tLPanel_Seleccion;
        private System.Windows.Forms.Button but_InfoClientes;
        private System.Windows.Forms.Button but_ListaCompras;
        private System.Windows.Forms.Button but_ProductosMasComprados;
        private System.Windows.Forms.TableLayoutPanel tLP_Datos;
        private System.Windows.Forms.TextBox tB_MuestraInfo;
        private System.Windows.Forms.DataGridView dataGV_Compras;
        private System.Windows.Forms.DataGridView dataGV_DetallesCompra;
        private System.Windows.Forms.Label lab_InfoCliente;
        private System.Windows.Forms.Label lab_ProductosComprados;
        private System.Windows.Forms.Label lab_Compras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosComprados;
        private System.Windows.Forms.TableLayoutPanel tLP_Reportes;
        private System.Windows.Forms.Label lab_Reportes;
        private System.Windows.Forms.Label lab_Herramienta;
        private System.Windows.Forms.ComboBox comb_Reportes;
        private System.Windows.Forms.Button but_GeneraInforme;
        private System.Windows.Forms.ToolTip tTip_Ayuda;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TableLayoutPanel tLP_Busquedas;
        private System.Windows.Forms.ComboBox comboB_ComprasFecha;
        private System.Windows.Forms.ComboBox comboB_Clientes;
        private System.Windows.Forms.Label lab_ComprasFecha;
        private System.Windows.Forms.Label lab_Cliente;
        private System.Windows.Forms.Label lab_idCompra;
        private System.Windows.Forms.ComboBox comboB_idCompra;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftReportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


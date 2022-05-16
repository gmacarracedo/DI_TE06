
namespace NorthWind_InterfazGrafica.Reportes
{
    partial class PideNombreEmpleado
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
            this.lab_PideNombreempleado = new System.Windows.Forms.Label();
            this.comboB_PideNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.but_PideNombreEmpleado = new System.Windows.Forms.Button();
            this.tTip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.tLP_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Base
            // 
            this.tLP_Base.ColumnCount = 1;
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Base.Controls.Add(this.lab_PideNombreempleado, 0, 0);
            this.tLP_Base.Controls.Add(this.comboB_PideNombreEmpleado, 0, 1);
            this.tLP_Base.Controls.Add(this.but_PideNombreEmpleado, 0, 2);
            this.tLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Base.Name = "tLP_Base";
            this.tLP_Base.RowCount = 3;
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.29379F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.9887F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.28249F));
            this.tLP_Base.Size = new System.Drawing.Size(392, 177);
            this.tLP_Base.TabIndex = 0;
            // 
            // lab_PideNombreempleado
            // 
            this.lab_PideNombreempleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_PideNombreempleado.AutoSize = true;
            this.lab_PideNombreempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PideNombreempleado.Location = new System.Drawing.Point(30, 13);
            this.lab_PideNombreempleado.Name = "lab_PideNombreempleado";
            this.lab_PideNombreempleado.Size = new System.Drawing.Size(332, 29);
            this.lab_PideNombreempleado.TabIndex = 0;
            this.lab_PideNombreempleado.Text = "Elige el nombre del vendedor";
            // 
            // comboB_PideNombreEmpleado
            // 
            this.comboB_PideNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboB_PideNombreEmpleado.FormattingEnabled = true;
            this.comboB_PideNombreEmpleado.Location = new System.Drawing.Point(3, 56);
            this.comboB_PideNombreEmpleado.Name = "comboB_PideNombreEmpleado";
            this.comboB_PideNombreEmpleado.Size = new System.Drawing.Size(386, 28);
            this.comboB_PideNombreEmpleado.TabIndex = 1;
            // 
            // but_PideNombreEmpleado
            // 
            this.but_PideNombreEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_PideNombreEmpleado.Location = new System.Drawing.Point(3, 90);
            this.but_PideNombreEmpleado.Name = "but_PideNombreEmpleado";
            this.but_PideNombreEmpleado.Size = new System.Drawing.Size(386, 84);
            this.but_PideNombreEmpleado.TabIndex = 2;
            this.but_PideNombreEmpleado.Text = "Generar informe";
            this.but_PideNombreEmpleado.UseVisualStyleBackColor = true;
            this.but_PideNombreEmpleado.Click += new System.EventHandler(this.but_PideNombreEmpleado_Click);
            // 
            // PideNombreEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 177);
            this.Controls.Add(this.tLP_Base);
            this.Name = "PideNombreEmpleado";
            this.Text = "PideNombreEmpleado";
            this.tLP_Base.ResumeLayout(false);
            this.tLP_Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Base;
        private System.Windows.Forms.Label lab_PideNombreempleado;
        private System.Windows.Forms.ComboBox comboB_PideNombreEmpleado;
        private System.Windows.Forms.Button but_PideNombreEmpleado;
        private System.Windows.Forms.ToolTip tTip_Ayuda;
    }
}
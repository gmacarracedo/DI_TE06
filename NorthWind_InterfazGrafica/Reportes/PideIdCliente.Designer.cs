
namespace NorthWind_InterfazGrafica.Reportes
{
    partial class PideIdCliente
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
            this.tLP_PideIdCliente = new System.Windows.Forms.TableLayoutPanel();
            this.comboB_EligeIdCliente = new System.Windows.Forms.ComboBox();
            this.but_PideIdCliente = new System.Windows.Forms.Button();
            this.lab_PideIdCliente = new System.Windows.Forms.Label();
            this.tLP_PideIdCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_PideIdCliente
            // 
            this.tLP_PideIdCliente.ColumnCount = 1;
            this.tLP_PideIdCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_PideIdCliente.Controls.Add(this.comboB_EligeIdCliente, 0, 1);
            this.tLP_PideIdCliente.Controls.Add(this.but_PideIdCliente, 0, 1);
            this.tLP_PideIdCliente.Controls.Add(this.lab_PideIdCliente, 0, 0);
            this.tLP_PideIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_PideIdCliente.Location = new System.Drawing.Point(0, 0);
            this.tLP_PideIdCliente.Name = "tLP_PideIdCliente";
            this.tLP_PideIdCliente.RowCount = 2;
            this.tLP_PideIdCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.tLP_PideIdCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tLP_PideIdCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tLP_PideIdCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_PideIdCliente.Size = new System.Drawing.Size(448, 183);
            this.tLP_PideIdCliente.TabIndex = 0;
            // 
            // comboB_EligeIdCliente
            // 
            this.comboB_EligeIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboB_EligeIdCliente.FormattingEnabled = true;
            this.comboB_EligeIdCliente.Location = new System.Drawing.Point(3, 63);
            this.comboB_EligeIdCliente.Name = "comboB_EligeIdCliente";
            this.comboB_EligeIdCliente.Size = new System.Drawing.Size(442, 28);
            this.comboB_EligeIdCliente.TabIndex = 9;
            // 
            // but_PideIdCliente
            // 
            this.but_PideIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_PideIdCliente.Location = new System.Drawing.Point(3, 97);
            this.but_PideIdCliente.Name = "but_PideIdCliente";
            this.but_PideIdCliente.Size = new System.Drawing.Size(442, 83);
            this.but_PideIdCliente.TabIndex = 8;
            this.but_PideIdCliente.Text = "Generar informe";
            this.but_PideIdCliente.UseVisualStyleBackColor = true;
            this.but_PideIdCliente.Click += new System.EventHandler(this.but_PideIdCliente_Click_1);
            // 
            // lab_PideIdCliente
            // 
            this.lab_PideIdCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_PideIdCliente.AutoSize = true;
            this.lab_PideIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PideIdCliente.Location = new System.Drawing.Point(20, 22);
            this.lab_PideIdCliente.Name = "lab_PideIdCliente";
            this.lab_PideIdCliente.Size = new System.Drawing.Size(407, 29);
            this.lab_PideIdCliente.TabIndex = 0;
            this.lab_PideIdCliente.Text = "Elige el cliente para ver sus compras";
            // 
            // PideIdCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 183);
            this.Controls.Add(this.tLP_PideIdCliente);
            this.Name = "PideIdCliente";
            this.Text = "PideIdCliente";
            this.tLP_PideIdCliente.ResumeLayout(false);
            this.tLP_PideIdCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_PideIdCliente;
        private System.Windows.Forms.Label lab_PideIdCliente;
        private System.Windows.Forms.ComboBox comboB_EligeIdCliente;
        private System.Windows.Forms.Button but_PideIdCliente;
    }
}
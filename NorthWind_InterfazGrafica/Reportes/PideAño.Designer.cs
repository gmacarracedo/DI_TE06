
namespace NorthWind_InterfazGrafica.Reportes.MicrosoftReporting
{
    partial class PideAño
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
            this.lab_PideAño = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.but_PideAño = new System.Windows.Forms.Button();
            this.numericBox = new System.Windows.Forms.NumericUpDown();
            this.tTip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_PideAño
            // 
            this.lab_PideAño.AutoSize = true;
            this.lab_PideAño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_PideAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PideAño.Location = new System.Drawing.Point(3, 0);
            this.lab_PideAño.Name = "lab_PideAño";
            this.lab_PideAño.Size = new System.Drawing.Size(384, 53);
            this.lab_PideAño.TabIndex = 1;
            this.lab_PideAño.Text = "Elige el año: ";
            this.lab_PideAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.but_PideAño, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab_PideAño, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.90411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.09589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // but_PideAño
            // 
            this.but_PideAño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_PideAño.Location = new System.Drawing.Point(3, 92);
            this.but_PideAño.Name = "but_PideAño";
            this.but_PideAño.Size = new System.Drawing.Size(384, 81);
            this.but_PideAño.TabIndex = 4;
            this.but_PideAño.Text = "Generar informe";
            this.but_PideAño.UseVisualStyleBackColor = true;
            this.but_PideAño.Click += new System.EventHandler(this.but_PideAño_Click);
            // 
            // numericBox
            // 
            this.numericBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericBox.Location = new System.Drawing.Point(3, 56);
            this.numericBox.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericBox.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericBox.Name = "numericBox";
            this.numericBox.Size = new System.Drawing.Size(384, 26);
            this.numericBox.TabIndex = 2;
            this.numericBox.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // PideAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PideAño";
            this.Text = "PideAño";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_PideAño;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button but_PideAño;
        private System.Windows.Forms.NumericUpDown numericBox;
        private System.Windows.Forms.ToolTip tTip_Ayuda;
    }
}
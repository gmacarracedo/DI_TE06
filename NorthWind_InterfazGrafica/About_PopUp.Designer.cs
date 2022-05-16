
namespace NorthWind_InterfazGrafica
{
    partial class About_PopUp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab_About = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.but_Aceptar = new System.Windows.Forms.Button();
            this.helpProv_Ayuda = new System.Windows.Forms.HelpProvider();
            this.tLP_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Base
            // 
            this.tLP_Base.ColumnCount = 1;
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Base.Controls.Add(this.textBox1, 0, 1);
            this.tLP_Base.Controls.Add(this.lab_About, 0, 0);
            this.tLP_Base.Controls.Add(this.checkBox1, 0, 2);
            this.tLP_Base.Controls.Add(this.but_Aceptar, 0, 3);
            this.tLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Base.Name = "tLP_Base";
            this.tLP_Base.RowCount = 4;
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.35915F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.78261F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91304F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68116F));
            this.tLP_Base.Size = new System.Drawing.Size(575, 345);
            this.tLP_Base.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(569, 183);
            this.textBox1.TabIndex = 4;
            // 
            // lab_About
            // 
            this.lab_About.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_About.AutoSize = true;
            this.lab_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_About.Location = new System.Drawing.Point(239, 21);
            this.lab_About.Name = "lab_About";
            this.lab_About.Size = new System.Drawing.Size(97, 25);
            this.lab_About.TabIndex = 1;
            this.lab_About.Text = "About Me";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 247);
            this.checkBox1.Name = "checkBox1";
            this.helpProv_Ayuda.SetShowHelp(this.checkBox1, true);
            this.checkBox1.Size = new System.Drawing.Size(359, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Mantenerme informado de las actualizaciones";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // but_Aceptar
            // 
            this.but_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Aceptar.Location = new System.Drawing.Point(3, 286);
            this.but_Aceptar.Name = "but_Aceptar";
            this.helpProv_Ayuda.SetShowHelp(this.but_Aceptar, true);
            this.but_Aceptar.Size = new System.Drawing.Size(569, 56);
            this.but_Aceptar.TabIndex = 3;
            this.but_Aceptar.Text = "Aceptar";
            this.but_Aceptar.UseVisualStyleBackColor = true;
            this.but_Aceptar.Click += new System.EventHandler(this.but_Aceptar_Click);
            // 
            // About_PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.tLP_Base);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About_PopUp";
            this.helpProv_Ayuda.SetShowHelp(this, true);
            this.Text = "About_PopUp";
            this.tLP_Base.ResumeLayout(false);
            this.tLP_Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Base;
        private System.Windows.Forms.Label lab_About;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button but_Aceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HelpProvider helpProv_Ayuda;
    }
}
namespace Practico.Formularios.Listados.EmpleadosEdad
{
    partial class FrmListadoEmpleadosEdad
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
            this.reportViewer12 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblEdadMaxima = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEdadMaxima = new Practico.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // reportViewer12
            // 
            this.reportViewer12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer12.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Listados.EmpleadosEdad.ListadoEmpleadosEdad.rdlc";
            this.reportViewer12.Location = new System.Drawing.Point(124, 120);
            this.reportViewer12.Name = "reportViewer12";
            this.reportViewer12.ServerReport.BearerToken = null;
            this.reportViewer12.Size = new System.Drawing.Size(595, 338);
            this.reportViewer12.TabIndex = 1;
            this.reportViewer12.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer12.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblEdadMaxima
            // 
            this.lblEdadMaxima.AutoSize = true;
            this.lblEdadMaxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEdadMaxima.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEdadMaxima.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEdadMaxima.Location = new System.Drawing.Point(120, 68);
            this.lblEdadMaxima.Name = "lblEdadMaxima";
            this.lblEdadMaxima.Size = new System.Drawing.Size(263, 19);
            this.lblEdadMaxima.TabIndex = 85;
            this.lblEdadMaxima.Text = "Empleados cuya edad sea mayor a:";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpleados.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleados.Location = new System.Drawing.Point(33, 9);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(162, 33);
            this.lblEmpleados.TabIndex = 84;
            this.lblEmpleados.Text = "Empleados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Image = global::Practico.Properties.Resources.magnifying_glass;
            this.btnBuscar.Location = new System.Drawing.Point(538, 56);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 40);
            this.btnBuscar.TabIndex = 86;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEdadMaxima
            // 
            this.txtEdadMaxima.BackColor = System.Drawing.Color.White;
            this.txtEdadMaxima.Location = new System.Drawing.Point(322, 68);
            this.txtEdadMaxima.Name = "txtEdadMaxima";
            this.txtEdadMaxima.PpMensajeError = "No ingresó Precio!";
            this.txtEdadMaxima.PpNombreCampo = null;
            this.txtEdadMaxima.PpNombreTabla = null;
            this.txtEdadMaxima.PpValidable = true;
            this.txtEdadMaxima.Size = new System.Drawing.Size(61, 20);
            this.txtEdadMaxima.TabIndex = 88;
            // 
            // FrmListadoEmpleadosEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(861, 460);
            this.Controls.Add(this.txtEdadMaxima);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEdadMaxima);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.reportViewer12);
            this.Name = "FrmListadoEmpleadosEdad";
            this.Text = "FrmListadoHelados";
            this.Load += new System.EventHandler(this.FrmListadoEmpleadosEdad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer12;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEdadMaxima;
        private System.Windows.Forms.Label lblEmpleados;
        private Clases.TextBox01 txtEdadMaxima;
    }
}
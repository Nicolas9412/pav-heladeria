namespace Practico.Formularios.Estadisticas.EmpleadosPorTurno
{
    partial class FrmEmpleadosPorTurno
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
            this.lblEmpleadosFecha = new System.Windows.Forms.Label();
            this.rpvw = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblEmpleadosFecha
            // 
            this.lblEmpleadosFecha.AutoSize = true;
            this.lblEmpleadosFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpleadosFecha.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblEmpleadosFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleadosFecha.Location = new System.Drawing.Point(27, 21);
            this.lblEmpleadosFecha.Name = "lblEmpleadosFecha";
            this.lblEmpleadosFecha.Size = new System.Drawing.Size(468, 33);
            this.lblEmpleadosFecha.TabIndex = 93;
            this.lblEmpleadosFecha.Text = "Cantidad de Empleados por Turno";
            // 
            // rpvw
            // 
            this.rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.EmpleadosPorTurno.EmpleadosPorTurno.rdlc";
            this.rpvw.Location = new System.Drawing.Point(12, 95);
            this.rpvw.Name = "rpvw";
            this.rpvw.ServerReport.BearerToken = null;
            this.rpvw.Size = new System.Drawing.Size(493, 388);
            this.rpvw.TabIndex = 94;
            // 
            // FrmEmpleadosPorTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(514, 495);
            this.Controls.Add(this.rpvw);
            this.Controls.Add(this.lblEmpleadosFecha);
            this.Name = "FrmEmpleadosPorTurno";
            this.Text = "Estadística de Empleados por Turno";
            this.Load += new System.EventHandler(this.FrmEmpleadosPorTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleadosFecha;
        private Microsoft.Reporting.WinForms.ReportViewer rpvw;
    }
}
namespace Practico.Formularios.Estadisticas.VentasXTurno
{
    partial class FrmEstadisticaVentasTurno
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
            this.reportViewerVentasTurno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerVentasTurno
            // 
            this.reportViewerVentasTurno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerVentasTurno.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.VentasXTurno.EstadisticaVentasTurno.rdlc";
            this.reportViewerVentasTurno.Location = new System.Drawing.Point(0, 0);
            this.reportViewerVentasTurno.Name = "reportViewerVentasTurno";
            this.reportViewerVentasTurno.ServerReport.BearerToken = null;
            this.reportViewerVentasTurno.Size = new System.Drawing.Size(800, 450);
            this.reportViewerVentasTurno.TabIndex = 0;
            this.reportViewerVentasTurno.Load += new System.EventHandler(this.reportViewerVentasTurno_Load);
            // 
            // FrmEstadisticaVentasTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerVentasTurno);
            this.Name = "FrmEstadisticaVentasTurno";
            this.Text = "Estadísticas de Ventas por Turno";
            this.Load += new System.EventHandler(this.FrmEstadisticaVentasTurno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVentasTurno;
    }
}
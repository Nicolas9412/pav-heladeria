namespace Practico.Formularios.Estadisticas.ProveedoresXLocalidad
{
    partial class FrmEstadisticaProveedoresLocalidad
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
            this.reportViewerProveedoresLocalidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerProveedoresLocalidad
            // 
            this.reportViewerProveedoresLocalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerProveedoresLocalidad.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.ProveedoresXLocalidad.EstadisticaProveedoresLoc" +
    "alidad.rdlc";
            this.reportViewerProveedoresLocalidad.Location = new System.Drawing.Point(0, 0);
            this.reportViewerProveedoresLocalidad.Name = "reportViewerProveedoresLocalidad";
            this.reportViewerProveedoresLocalidad.ServerReport.BearerToken = null;
            this.reportViewerProveedoresLocalidad.Size = new System.Drawing.Size(800, 450);
            this.reportViewerProveedoresLocalidad.TabIndex = 0;
            this.reportViewerProveedoresLocalidad.Load += new System.EventHandler(this.reportViewerProveedoresLocalidad_Load);
            // 
            // FrmEstadisticaProveedoresLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerProveedoresLocalidad);
            this.Name = "FrmEstadisticaProveedoresLocalidad";
            this.Text = "FrmEstadisticaProveedoresLocalidad";
            this.Load += new System.EventHandler(this.FrmEstadisticaProveedoresLocalidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProveedoresLocalidad;
    }
}
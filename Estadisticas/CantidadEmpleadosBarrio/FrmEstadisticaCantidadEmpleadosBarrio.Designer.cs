namespace Practico.Formularios.Estadisticas.CantidadEmpleadosBarrio
{
    partial class FrmEstadisticaCantidadEmpleadosBarrio
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
            this.reportViewerEmpleadosBarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerEmpleadosBarrio
            // 
            this.reportViewerEmpleadosBarrio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerEmpleadosBarrio.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.CantidadEmpleadosBarrio.CantidadEmpleadosBarrio" +
    ".rdlc";
            this.reportViewerEmpleadosBarrio.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEmpleadosBarrio.Name = "reportViewerEmpleadosBarrio";
            this.reportViewerEmpleadosBarrio.ServerReport.BearerToken = null;
            this.reportViewerEmpleadosBarrio.Size = new System.Drawing.Size(851, 491);
            this.reportViewerEmpleadosBarrio.TabIndex = 0;
            this.reportViewerEmpleadosBarrio.Load += new System.EventHandler(this.reportViewerEmpleadosBarrio_Load);
            // 
            // FrmEstadisticaCantidadEmpleadosBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 491);
            this.Controls.Add(this.reportViewerEmpleadosBarrio);
            this.Name = "FrmEstadisticaCantidadEmpleadosBarrio";
            this.Text = "FrmCantidadEmpleadosBarrio";
            this.Load += new System.EventHandler(this.FrmEstadisticaCantidadEmpleadosBarrio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEmpleadosBarrio;
    }
}
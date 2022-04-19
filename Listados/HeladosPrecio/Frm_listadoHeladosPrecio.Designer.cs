namespace Practico.Formularios.Listados.Helados
{
    partial class Frm_listadoHeladosPrecio
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
            this.reportViewerHeladosPrecio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblHeladosPrecio = new System.Windows.Forms.Label();
            this.textBox011BuscarHelado = new Practico.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // reportViewerHeladosPrecio
            // 
            this.reportViewerHeladosPrecio.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Listados.HeladosPrecio.ReporteListadoHeladosPrecio.rdlc";
            this.reportViewerHeladosPrecio.Location = new System.Drawing.Point(0, 126);
            this.reportViewerHeladosPrecio.Name = "reportViewerHeladosPrecio";
            this.reportViewerHeladosPrecio.ServerReport.BearerToken = null;
            this.reportViewerHeladosPrecio.Size = new System.Drawing.Size(861, 338);
            this.reportViewerHeladosPrecio.TabIndex = 0;
            this.reportViewerHeladosPrecio.Load += new System.EventHandler(this.reportViewerHeladosPrecio_Load);
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
            this.btnBuscar.Location = new System.Drawing.Point(452, 56);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 40);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(206, 67);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(117, 19);
            this.lblPrecio.TabIndex = 84;
            this.lblPrecio.Text = "Precio menor a:";
            // 
            // lblHeladosPrecio
            // 
            this.lblHeladosPrecio.AutoSize = true;
            this.lblHeladosPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeladosPrecio.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblHeladosPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeladosPrecio.Location = new System.Drawing.Point(28, 9);
            this.lblHeladosPrecio.Name = "lblHeladosPrecio";
            this.lblHeladosPrecio.Size = new System.Drawing.Size(263, 33);
            this.lblHeladosPrecio.TabIndex = 86;
            this.lblHeladosPrecio.Text = "Helados por Precio";
            // 
            // textBox011BuscarHelado
            // 
            this.textBox011BuscarHelado.Location = new System.Drawing.Point(329, 66);
            this.textBox011BuscarHelado.Name = "textBox011BuscarHelado";
            this.textBox011BuscarHelado.PpMensajeError = null;
            this.textBox011BuscarHelado.PpNombreCampo = null;
            this.textBox011BuscarHelado.PpNombreTabla = null;
            this.textBox011BuscarHelado.PpValidable = false;
            this.textBox011BuscarHelado.Size = new System.Drawing.Size(100, 20);
            this.textBox011BuscarHelado.TabIndex = 87;
            // 
            // Frm_listadoHeladosPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(861, 460);
            this.Controls.Add(this.textBox011BuscarHelado);
            this.Controls.Add(this.lblHeladosPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.reportViewerHeladosPrecio);
            this.Name = "Frm_listadoHeladosPrecio";
            this.Text = "Helados por Precio";
            this.Load += new System.EventHandler(this.Frm_listadoHeladosPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHeladosPrecio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblHeladosPrecio;
        private Clases.TextBox01 textBox011BuscarHelado;
    }
}
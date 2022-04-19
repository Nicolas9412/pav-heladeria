namespace Practico.Formularios.Listados.HeladosEspecialesPrecio
{
    partial class FrmListadoHeladosEspecialesPrecio
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
            this.reportViewer11 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHeladoEspecial = new System.Windows.Forms.Label();
            this.lblHelados = new System.Windows.Forms.Label();
            this.txtPrecioMaximo = new Practico.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // reportViewer11
            // 
            this.reportViewer11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer11.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Listados.HeladosEspecialesPrecio.ListadoHeladosEspeciales.rd" +
    "lc";
            this.reportViewer11.Location = new System.Drawing.Point(124, 120);
            this.reportViewer11.Name = "reportViewer11";
            this.reportViewer11.ServerReport.BearerToken = null;
            this.reportViewer11.Size = new System.Drawing.Size(595, 338);
            this.reportViewer11.TabIndex = 1;
            this.reportViewer11.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer11.Load += new System.EventHandler(this.reportViewer1_Load);
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
            this.btnBuscar.Location = new System.Drawing.Point(587, 59);
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
            // lblHeladoEspecial
            // 
            this.lblHeladoEspecial.AutoSize = true;
            this.lblHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeladoEspecial.Location = new System.Drawing.Point(120, 71);
            this.lblHeladoEspecial.Name = "lblHeladoEspecial";
            this.lblHeladoEspecial.Size = new System.Drawing.Size(321, 19);
            this.lblHeladoEspecial.TabIndex = 85;
            this.lblHeladoEspecial.Text = "Helados Especiales cuyo precio sea mayor a:";
            // 
            // lblHelados
            // 
            this.lblHelados.AutoSize = true;
            this.lblHelados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelados.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblHelados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelados.Location = new System.Drawing.Point(33, 9);
            this.lblHelados.Name = "lblHelados";
            this.lblHelados.Size = new System.Drawing.Size(264, 33);
            this.lblHelados.TabIndex = 84;
            this.lblHelados.Text = "Helados Especiales";
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.BackColor = System.Drawing.Color.White;
            this.txtPrecioMaximo.Location = new System.Drawing.Point(367, 70);
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.PpMensajeError = "No ingresó Precio!";
            this.txtPrecioMaximo.PpNombreCampo = null;
            this.txtPrecioMaximo.PpNombreTabla = null;
            this.txtPrecioMaximo.PpValidable = true;
            this.txtPrecioMaximo.Size = new System.Drawing.Size(61, 20);
            this.txtPrecioMaximo.TabIndex = 88;
            // 
            // FrmListadoHeladosEspecialesPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(861, 460);
            this.Controls.Add(this.txtPrecioMaximo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblHeladoEspecial);
            this.Controls.Add(this.lblHelados);
            this.Controls.Add(this.reportViewer11);
            this.Name = "FrmListadoHeladosEspecialesPrecio";
            this.Text = "FrmListadoHelados";
            this.Load += new System.EventHandler(this.FrmListadoHelados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHeladoEspecial;
        private System.Windows.Forms.Label lblHelados;
        private Clases.TextBox01 txtPrecioMaximo;
    }
}
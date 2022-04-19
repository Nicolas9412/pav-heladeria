namespace Practico.Formularios.Listados.EmpleadosFecha
{
    partial class Frm_listadoEmpleadosFecha
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.pckIngreso = new System.Windows.Forms.DateTimePicker();
            this.reportViewerEmpleadosFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblEmpleadosFecha
            // 
            this.lblEmpleadosFecha.AutoSize = true;
            this.lblEmpleadosFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpleadosFecha.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblEmpleadosFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleadosFecha.Location = new System.Drawing.Point(28, 9);
            this.lblEmpleadosFecha.Name = "lblEmpleadosFecha";
            this.lblEmpleadosFecha.Size = new System.Drawing.Size(447, 33);
            this.lblEmpleadosFecha.TabIndex = 87;
            this.lblEmpleadosFecha.Text = "Empleados por Fecha de Ingreso";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(144, 67);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(119, 19);
            this.lblFecha.TabIndex = 88;
            this.lblFecha.Text = "Fecha menor a:";
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFecha.FlatAppearance.BorderSize = 0;
            this.btnBuscarFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBuscarFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarFecha.Image = global::Practico.Properties.Resources.magnifying_glass;
            this.btnBuscarFecha.Location = new System.Drawing.Point(452, 56);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(123, 40);
            this.btnBuscarFecha.TabIndex = 89;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // pckIngreso
            // 
            this.pckIngreso.CustomFormat = "dd-MM-yyyy";
            this.pckIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pckIngreso.Location = new System.Drawing.Point(269, 67);
            this.pckIngreso.MaxDate = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            this.pckIngreso.Name = "pckIngreso";
            this.pckIngreso.Size = new System.Drawing.Size(176, 20);
            this.pckIngreso.TabIndex = 90;
            this.pckIngreso.Value = new System.DateTime(2020, 10, 11, 0, 0, 0, 0);
            // 
            // reportViewerEmpleadosFecha
            // 
            this.reportViewerEmpleadosFecha.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Listados.EmpleadosFecha.ReporteListadoEmpleadosFecha.rdlc";
            this.reportViewerEmpleadosFecha.Location = new System.Drawing.Point(-4, 103);
            this.reportViewerEmpleadosFecha.Name = "reportViewerEmpleadosFecha";
            this.reportViewerEmpleadosFecha.ServerReport.BearerToken = null;
            this.reportViewerEmpleadosFecha.Size = new System.Drawing.Size(1041, 353);
            this.reportViewerEmpleadosFecha.TabIndex = 91;
            this.reportViewerEmpleadosFecha.Load += new System.EventHandler(this.reportViewerEmpleadosFecha_Load);
            // 
            // Frm_listadoEmpleadosFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.reportViewerEmpleadosFecha);
            this.Controls.Add(this.pckIngreso);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpleadosFecha);
            this.Name = "Frm_listadoEmpleadosFecha";
            this.Text = "Listado de Empleados por Fecha";
            this.Load += new System.EventHandler(this.Frm_listadoEmpleadosFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleadosFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.DateTimePicker pckIngreso;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEmpleadosFecha;
    }
}
namespace Practico.Formularios.Estadisticas.CantidadComprasProveedores
{
    partial class FrmCantidadComprasProveedores
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
            this.pckDesde = new System.Windows.Forms.DateTimePicker();
            this.pckHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEmpleadosFecha = new System.Windows.Forms.Label();
            this.rpvw = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pckDesde
            // 
            this.pckDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckDesde.Location = new System.Drawing.Point(145, 69);
            this.pckDesde.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckDesde.Name = "pckDesde";
            this.pckDesde.Size = new System.Drawing.Size(112, 20);
            this.pckDesde.TabIndex = 75;
            this.pckDesde.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // pckHasta
            // 
            this.pckHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckHasta.Location = new System.Drawing.Point(145, 110);
            this.pckHasta.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckHasta.Name = "pckHasta";
            this.pckHasta.Size = new System.Drawing.Size(112, 20);
            this.pckHasta.TabIndex = 77;
            this.pckHasta.Value = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(35, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 19);
            this.lblFecha.TabIndex = 89;
            this.lblFecha.Text = "Fecha desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "Fecha hasta:";
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
            this.btnBuscar.Location = new System.Drawing.Point(288, 61);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 40);
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEmpleadosFecha
            // 
            this.lblEmpleadosFecha.AutoSize = true;
            this.lblEmpleadosFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpleadosFecha.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblEmpleadosFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleadosFecha.Location = new System.Drawing.Point(12, 9);
            this.lblEmpleadosFecha.Name = "lblEmpleadosFecha";
            this.lblEmpleadosFecha.Size = new System.Drawing.Size(512, 33);
            this.lblEmpleadosFecha.TabIndex = 92;
            this.lblEmpleadosFecha.Text = "Cantidad de Compras por Proveedor";
            // 
            // rpvw
            // 
            this.rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.CantidadComprasProveedores.CantidadComprasProve" +
    "edores.rdlc";
            this.rpvw.Location = new System.Drawing.Point(2, 161);
            this.rpvw.Name = "rpvw";
            this.rpvw.ServerReport.BearerToken = null;
            this.rpvw.Size = new System.Drawing.Size(583, 388);
            this.rpvw.TabIndex = 93;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.ForeColor = System.Drawing.SystemColors.Window;
            this.chkTodos.Location = new System.Drawing.Point(288, 110);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(112, 20);
            this.chkTodos.TabIndex = 94;
            this.chkTodos.Text = "Buscar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // FrmCantidadComprasProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(589, 561);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.rpvw);
            this.Controls.Add(this.lblEmpleadosFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pckHasta);
            this.Controls.Add(this.pckDesde);
            this.Name = "FrmCantidadComprasProveedores";
            this.Text = "CantidadComprasProveedores";
            this.Load += new System.EventHandler(this.FrmCantidadComprasProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pckDesde;
        private System.Windows.Forms.DateTimePicker pckHasta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEmpleadosFecha;
        private Microsoft.Reporting.WinForms.ReportViewer rpvw;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}
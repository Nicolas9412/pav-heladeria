namespace Practico.Formularios.Estadisticas.CantidadVentasEmpleados
{
    partial class FrmEstadisticaCantidadVentasEmpleados
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.rpvw = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.pckHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.pckDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 517);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlReport);
            this.tabPage2.Controls.Add(this.pnlBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas por Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.rpvw);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(3, 106);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(834, 379);
            this.pnlReport.TabIndex = 77;
            // 
            // rpvw
            // 
            this.rpvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvw.Location = new System.Drawing.Point(0, 0);
            this.rpvw.Name = "rpvw";
            this.rpvw.ServerReport.BearerToken = null;
            this.rpvw.Size = new System.Drawing.Size(834, 379);
            this.rpvw.TabIndex = 77;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pnlBuscar.Controls.Add(this.label1);
            this.pnlBuscar.Controls.Add(this.label2);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.chkTodos);
            this.pnlBuscar.Controls.Add(this.pckHasta);
            this.pnlBuscar.Controls.Add(this.lblHasta);
            this.pnlBuscar.Controls.Add(this.pckDesde);
            this.pnlBuscar.Controls.Add(this.lblDesde);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(3, 3);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(834, 103);
            this.pnlBuscar.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "Fecha Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Fecha Desde:";
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
            this.btnBuscar.Location = new System.Drawing.Point(267, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 40);
            this.btnBuscar.TabIndex = 81;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkTodos.Location = new System.Drawing.Point(267, 54);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(89, 17);
            this.chkTodos.TabIndex = 79;
            this.chkTodos.Text = "Buscar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // pckHasta
            // 
            this.pckHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckHasta.Location = new System.Drawing.Point(121, 46);
            this.pckHasta.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckHasta.Name = "pckHasta";
            this.pckHasta.Size = new System.Drawing.Size(112, 20);
            this.pckHasta.TabIndex = 76;
            this.pckHasta.Value = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHasta.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHasta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHasta.Location = new System.Drawing.Point(134, 52);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(0, 19);
            this.lblHasta.TabIndex = 75;
            // 
            // pckDesde
            // 
            this.pckDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckDesde.Location = new System.Drawing.Point(121, 16);
            this.pckDesde.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckDesde.Name = "pckDesde";
            this.pckDesde.Size = new System.Drawing.Size(112, 20);
            this.pckDesde.TabIndex = 74;
            this.pckDesde.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesde.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDesde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesde.Location = new System.Drawing.Point(131, 22);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(0, 19);
            this.lblDesde.TabIndex = 73;
            // 
            // FrmEstadisticaCantidadVentasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEstadisticaCantidadVentasEmpleados";
            this.Text = "FrmCantidadVentasEmpleados";
            this.Load += new System.EventHandler(this.FrmCantidadVentasEmpleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpvw;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DateTimePicker pckHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker pckDesde;
        private System.Windows.Forms.Label lblDesde;
    }
}
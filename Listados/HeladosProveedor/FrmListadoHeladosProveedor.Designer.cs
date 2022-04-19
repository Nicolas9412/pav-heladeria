namespace Practico.Formularios.Listados.Helados
{
    partial class FrmListadoHeladosProveedor
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblHelados = new System.Windows.Forms.Label();
            this.cmbProveedores = new Practico.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Listados.HeladosProveedor.ListadoHeladosProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(124, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(595, 338);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            this.btnBuscar.Location = new System.Drawing.Point(477, 56);
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
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProveedor.Location = new System.Drawing.Point(258, 70);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(83, 19);
            this.lblProveedor.TabIndex = 85;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblHelados
            // 
            this.lblHelados.AutoSize = true;
            this.lblHelados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelados.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblHelados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelados.Location = new System.Drawing.Point(33, 9);
            this.lblHelados.Name = "lblHelados";
            this.lblHelados.Size = new System.Drawing.Size(322, 33);
            this.lblHelados.TabIndex = 84;
            this.lblHelados.Text = "Helados por proveedor";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(347, 68);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.PpDisplay = "razonSocial";
            this.cmbProveedores.PpMensajeError = null;
            this.cmbProveedores.PpNombreCampo = null;
            this.cmbProveedores.PpNombreTabla = null;
            this.cmbProveedores.PpTabla = "Proveedores";
            this.cmbProveedores.PpValidable = true;
            this.cmbProveedores.PpValue = "razonSocial";
            this.cmbProveedores.Size = new System.Drawing.Size(123, 21);
            this.cmbProveedores.TabIndex = 87;
            // 
            // FrmListadoHeladosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(861, 460);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblHelados);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmListadoHeladosProveedor";
            this.Text = "FrmListadoHelados";
            this.Load += new System.EventHandler(this.FrmListadoHelados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clases.ComboBox01 cmbProveedores;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblHelados;
    }
}
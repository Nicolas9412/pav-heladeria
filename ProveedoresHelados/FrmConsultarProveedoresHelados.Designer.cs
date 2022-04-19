namespace Practico.Formularios.Abm.ProveedoresHelados
{
    partial class FrmConsultarProveedoresHelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProveedoresHelados));
            this.lblNuevoProveedor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdHelado = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbNombre = new Practico.Clases.ComboBox01();
            this.cmbNroDoc = new Practico.Clases.ComboBox01();
            this.cmbIdHelado = new Practico.Clases.ComboBox01();
            this.cmbTipoDoc = new Practico.Clases.ComboBox01();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new Practico.Clases.TextBox02();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNuevoProveedor
            // 
            this.lblNuevoProveedor.AutoSize = true;
            this.lblNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevoProveedor.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevoProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevoProveedor.Location = new System.Drawing.Point(35, 40);
            this.lblNuevoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoProveedor.Name = "lblNuevoProveedor";
            this.lblNuevoProveedor.Size = new System.Drawing.Size(324, 23);
            this.lblNuevoProveedor.TabIndex = 21;
            this.lblNuevoProveedor.Text = "Consultar Proveedor de Helado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(162, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 78;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdHelado
            // 
            this.lblIdHelado.AutoSize = true;
            this.lblIdHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblIdHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdHelado.Location = new System.Drawing.Point(149, 196);
            this.lblIdHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdHelado.Name = "lblIdHelado";
            this.lblIdHelado.Size = new System.Drawing.Size(81, 19);
            this.lblIdHelado.TabIndex = 76;
            this.lblIdHelado.Text = "Id Helado:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNroDoc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNroDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNroDoc.Location = new System.Drawing.Point(54, 167);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(176, 19);
            this.lblNroDoc.TabIndex = 75;
            this.lblNroDoc.Text = "Número de Documento:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipoDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoDoc.Location = new System.Drawing.Point(81, 129);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(149, 19);
            this.lblTipoDoc.TabIndex = 74;
            this.lblTipoDoc.Text = "Tipo de Documento:";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.Enabled = false;
            this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(238, 94);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.PpDisplay = "tipoDoc";
            this.cmbNombre.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbNombre.PpNombreCampo = null;
            this.cmbNombre.PpNombreTabla = null;
            this.cmbNombre.PpTabla = "Empleados";
            this.cmbNombre.PpValidable = true;
            this.cmbNombre.PpValue = "tipoDoc";
            this.cmbNombre.Size = new System.Drawing.Size(202, 25);
            this.cmbNombre.TabIndex = 77;
            // 
            // cmbNroDoc
            // 
            this.cmbNroDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDoc.Enabled = false;
            this.cmbNroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNroDoc.FormattingEnabled = true;
            this.cmbNroDoc.Location = new System.Drawing.Point(238, 160);
            this.cmbNroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNroDoc.Name = "cmbNroDoc";
            this.cmbNroDoc.PpDisplay = "";
            this.cmbNroDoc.PpMensajeError = "No se ingresó Número de Documento !";
            this.cmbNroDoc.PpNombreCampo = "nroDocProveedor";
            this.cmbNroDoc.PpNombreTabla = "ProveedoresHelados";
            this.cmbNroDoc.PpTabla = "";
            this.cmbNroDoc.PpValidable = true;
            this.cmbNroDoc.PpValue = "";
            this.cmbNroDoc.Size = new System.Drawing.Size(202, 25);
            this.cmbNroDoc.TabIndex = 70;
            // 
            // cmbIdHelado
            // 
            this.cmbIdHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdHelado.Enabled = false;
            this.cmbIdHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdHelado.FormattingEnabled = true;
            this.cmbIdHelado.Location = new System.Drawing.Point(238, 193);
            this.cmbIdHelado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdHelado.Name = "cmbIdHelado";
            this.cmbIdHelado.PpDisplay = "";
            this.cmbIdHelado.PpMensajeError = "No se ingresó Id Helado !";
            this.cmbIdHelado.PpNombreCampo = "idHelado";
            this.cmbIdHelado.PpNombreTabla = "ProveedoresHelados";
            this.cmbIdHelado.PpTabla = null;
            this.cmbIdHelado.PpValidable = true;
            this.cmbIdHelado.PpValue = null;
            this.cmbIdHelado.Size = new System.Drawing.Size(202, 25);
            this.cmbIdHelado.TabIndex = 71;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.Enabled = false;
            this.cmbTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(238, 126);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.PpDisplay = "";
            this.cmbTipoDoc.PpMensajeError = "No se ingresó Tipo de Documento !";
            this.cmbTipoDoc.PpNombreCampo = "tipoDocProveedor";
            this.cmbTipoDoc.PpNombreTabla = "ProveedoresHelados";
            this.cmbTipoDoc.PpTabla = null;
            this.cmbTipoDoc.PpValidable = true;
            this.cmbTipoDoc.PpValue = null;
            this.cmbTipoDoc.Size = new System.Drawing.Size(202, 25);
            this.cmbTipoDoc.TabIndex = 69;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Image = global::Practico.Properties.Resources.remove;
            this.btnCancelar.Location = new System.Drawing.Point(213, 307);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 40);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Image = global::Practico.Properties.Resources.floppy_disk1;
            this.btnAceptar.Location = new System.Drawing.Point(337, 307);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 79;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(236, 228);
            this.txtPrecio.Mask = "0000000";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PpMensajeError = "Ingrese una cantidad!";
            this.txtPrecio.PpNombreCampo = "precio";
            this.txtPrecio.PpNombreTabla = "ProveedoresHelados";
            this.txtPrecio.PpValidable = true;
            this.txtPrecio.PromptChar = ' ';
            this.txtPrecio.Size = new System.Drawing.Size(103, 24);
            this.txtPrecio.TabIndex = 89;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(175, 228);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 88;
            this.lblPrecio.Text = "Precio:";
            // 
            // FrmConsultarProveedoresHelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(578, 361);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbNroDoc);
            this.Controls.Add(this.cmbIdHelado);
            this.Controls.Add(this.lblIdHelado);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNuevoProveedor);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarProveedoresHelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Proveedor de Helado";
            this.Load += new System.EventHandler(this.FrmAltaProveedoresHelados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoProveedor;
        private Clases.ComboBox01 cmbNombre;
        private System.Windows.Forms.Label lblNombre;
        private Clases.ComboBox01 cmbNroDoc;
        private Clases.ComboBox01 cmbIdHelado;
        private System.Windows.Forms.Label lblIdHelado;
        private System.Windows.Forms.Label lblNroDoc;
        private Clases.ComboBox01 cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Clases.TextBox02 txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}
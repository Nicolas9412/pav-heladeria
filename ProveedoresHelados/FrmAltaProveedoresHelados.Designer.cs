namespace Practico.Formularios.Abm.ProveedoresHelados
{
    partial class FrmAltaProveedoresHelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaProveedoresHelados));
            this.lblNuevoProveedor = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblIdHelado = new System.Windows.Forms.Label();
            this.cmbNroDoc = new Practico.Clases.ComboBox01();
            this.cmbIdHelado = new Practico.Clases.ComboBox01();
            this.cmbTipoDoc = new Practico.Clases.ComboBox01();
            this.cmbNombre = new Practico.Clases.ComboBox01();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarHelado = new System.Windows.Forms.Button();
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
            this.lblNuevoProveedor.Size = new System.Drawing.Size(297, 23);
            this.lblNuevoProveedor.TabIndex = 21;
            this.lblNuevoProveedor.Text = "Nuevo Proveedor de Helado";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipoDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoDoc.Location = new System.Drawing.Point(97, 131);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(149, 19);
            this.lblTipoDoc.TabIndex = 30;
            this.lblTipoDoc.Text = "Tipo de Documento:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNroDoc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNroDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNroDoc.Location = new System.Drawing.Point(70, 169);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(176, 19);
            this.lblNroDoc.TabIndex = 32;
            this.lblNroDoc.Text = "Número de Documento:";
            // 
            // lblIdHelado
            // 
            this.lblIdHelado.AutoSize = true;
            this.lblIdHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblIdHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdHelado.Location = new System.Drawing.Point(165, 198);
            this.lblIdHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdHelado.Name = "lblIdHelado";
            this.lblIdHelado.Size = new System.Drawing.Size(81, 19);
            this.lblIdHelado.TabIndex = 34;
            this.lblIdHelado.Text = "Id Helado:";
            // 
            // cmbNroDoc
            // 
            this.cmbNroDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNroDoc.FormattingEnabled = true;
            this.cmbNroDoc.Location = new System.Drawing.Point(254, 162);
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
            this.cmbNroDoc.TabIndex = 1;
            // 
            // cmbIdHelado
            // 
            this.cmbIdHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdHelado.FormattingEnabled = true;
            this.cmbIdHelado.Location = new System.Drawing.Point(254, 195);
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
            this.cmbIdHelado.TabIndex = 2;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(254, 128);
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
            this.cmbTipoDoc.TabIndex = 0;
            this.cmbTipoDoc.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(254, 96);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.PpDisplay = "tipoDoc";
            this.cmbNombre.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbNombre.PpNombreCampo = null;
            this.cmbNombre.PpNombreTabla = null;
            this.cmbNombre.PpTabla = "Empleados";
            this.cmbNombre.PpValidable = true;
            this.cmbNombre.PpValue = "tipoDoc";
            this.cmbNombre.Size = new System.Drawing.Size(202, 25);
            this.cmbNombre.TabIndex = 67;
            this.cmbNombre.SelectedValueChanged += new System.EventHandler(this.cmbNombre_SelectedValueChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(178, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btnAgregarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProveedor.Image = global::Practico.Properties.Resources.add;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(465, 88);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(60, 39);
            this.btnAgregarProveedor.TabIndex = 119;
            this.btnAgregarProveedor.Text = "...";
            this.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnAgregarHelado
            // 
            this.btnAgregarHelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregarHelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarHelado.FlatAppearance.BorderSize = 0;
            this.btnAgregarHelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarHelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAgregarHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHelado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarHelado.Image = global::Practico.Properties.Resources.add;
            this.btnAgregarHelado.Location = new System.Drawing.Point(465, 187);
            this.btnAgregarHelado.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarHelado.Name = "btnAgregarHelado";
            this.btnAgregarHelado.Size = new System.Drawing.Size(60, 39);
            this.btnAgregarHelado.TabIndex = 120;
            this.btnAgregarHelado.Text = "...";
            this.btnAgregarHelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHelado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarHelado.UseVisualStyleBackColor = false;
            this.btnAgregarHelado.Click += new System.EventHandler(this.btnAgregarHelado_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(219, 307);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 40);
            this.btnCancelar.TabIndex = 122;
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
            this.btnAceptar.Location = new System.Drawing.Point(342, 307);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 121;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(252, 232);
            this.txtPrecio.Mask = "0000000";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PpMensajeError = "Ingrese una cantidad!";
            this.txtPrecio.PpNombreCampo = "precio";
            this.txtPrecio.PpNombreTabla = "ProveedoresHelados";
            this.txtPrecio.PpValidable = true;
            this.txtPrecio.PromptChar = ' ';
            this.txtPrecio.Size = new System.Drawing.Size(103, 24);
            this.txtPrecio.TabIndex = 124;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(191, 232);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 123;
            this.lblPrecio.Text = "Precio:";
            // 
            // FrmAltaProveedoresHelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(585, 361);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarHelado);
            this.Controls.Add(this.btnAgregarProveedor);
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
            this.Name = "FrmAltaProveedoresHelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Proveedor de Helado";
            this.Load += new System.EventHandler(this.FrmAltaProveedoresHelados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoProveedor;
        private System.Windows.Forms.Label lblTipoDoc;
        private Clases.ComboBox01 cmbTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblIdHelado;
        private Clases.ComboBox01 cmbIdHelado;
        private Clases.ComboBox01 cmbNroDoc;
        private Clases.ComboBox01 cmbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnAgregarHelado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Clases.TextBox02 txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}
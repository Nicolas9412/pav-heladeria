namespace Practico.Formularios.Abm.HeladosHeladosEspeciales
{
    partial class FrmAltaHeladosHeladosEspeciales
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txtCantidad = new Practico.Clases.TextBox02();
            this.cmbHeladoEspecial = new Practico.Clases.ComboBox01();
            this.cmbHelado = new Practico.Clases.ComboBox01();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(184, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "Helado Especial:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(151, 176);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(158, 19);
            this.lblTelefono.TabIndex = 84;
            this.lblTelefono.Text = "Cantidad De Bochas:";
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
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(188, 225);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 40);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "       Cancelar";
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
            this.btnAceptar.Image = global::Practico.Properties.Resources.floppy_disk;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(315, 225);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 40);
            this.btnAceptar.TabIndex = 80;
            this.btnAceptar.Text = "      Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocumento.Location = new System.Drawing.Point(245, 140);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(64, 19);
            this.lblDocumento.TabIndex = 83;
            this.lblDocumento.Text = "Helado:";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(42, 26);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(354, 23);
            this.lblNuevo.TabIndex = 82;
            this.lblNuevo.Text = "Nuevo Helado de Helado Especial";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(315, 176);
            this.txtCantidad.Mask = "0000000";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PpMensajeError = "Ingrese una cantidad!";
            this.txtCantidad.PpNombreCampo = null;
            this.txtCantidad.PpNombreTabla = null;
            this.txtCantidad.PpValidable = true;
            this.txtCantidad.PromptChar = ' ';
            this.txtCantidad.Size = new System.Drawing.Size(103, 20);
            this.txtCantidad.TabIndex = 87;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
            // 
            // cmbHeladoEspecial
            // 
            this.cmbHeladoEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHeladoEspecial.FormattingEnabled = true;
            this.cmbHeladoEspecial.Location = new System.Drawing.Point(315, 94);
            this.cmbHeladoEspecial.Name = "cmbHeladoEspecial";
            this.cmbHeladoEspecial.PpDisplay = "nombreProducto";
            this.cmbHeladoEspecial.PpMensajeError = "Seleccione un Helado Especial!!";
            this.cmbHeladoEspecial.PpNombreCampo = null;
            this.cmbHeladoEspecial.PpNombreTabla = null;
            this.cmbHeladoEspecial.PpTabla = "HeladosEspeciales";
            this.cmbHeladoEspecial.PpValidable = true;
            this.cmbHeladoEspecial.PpValue = "idHeladoEspecial";
            this.cmbHeladoEspecial.Size = new System.Drawing.Size(166, 21);
            this.cmbHeladoEspecial.TabIndex = 85;
            // 
            // cmbHelado
            // 
            this.cmbHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHelado.FormattingEnabled = true;
            this.cmbHelado.Location = new System.Drawing.Point(315, 139);
            this.cmbHelado.Name = "cmbHelado";
            this.cmbHelado.PpDisplay = "nombre";
            this.cmbHelado.PpMensajeError = "Seleccione un Helado!!";
            this.cmbHelado.PpNombreCampo = null;
            this.cmbHelado.PpNombreTabla = null;
            this.cmbHelado.PpTabla = "Helados";
            this.cmbHelado.PpValidable = true;
            this.cmbHelado.PpValue = "idHelado";
            this.cmbHelado.Size = new System.Drawing.Size(164, 21);
            this.cmbHelado.TabIndex = 79;
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar1.FlatAppearance.BorderSize = 0;
            this.btnAgregar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAgregar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar1.Image = global::Practico.Properties.Resources.add;
            this.btnAgregar1.Location = new System.Drawing.Point(487, 80);
            this.btnAgregar1.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(60, 39);
            this.btnAgregar1.TabIndex = 122;
            this.btnAgregar1.Text = "...";
            this.btnAgregar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar1.UseVisualStyleBackColor = false;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar2.FlatAppearance.BorderSize = 0;
            this.btnAgregar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAgregar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar2.Image = global::Practico.Properties.Resources.add;
            this.btnAgregar2.Location = new System.Drawing.Point(487, 129);
            this.btnAgregar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(60, 39);
            this.btnAgregar2.TabIndex = 123;
            this.btnAgregar2.Text = "...";
            this.btnAgregar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // FrmAltaHeladosHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(577, 276);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbHeladoEspecial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHelado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNuevo);
            this.Name = "FrmAltaHeladosHeladosEspeciales";
            this.Text = "Registrar Helado De Helado Especial";
            this.Load += new System.EventHandler(this.FrmAltaHeladosHeladosEspeciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBox01 cmbHeladoEspecial;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmbHelado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNuevo;
        private Clases.TextBox02 txtCantidad;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnAgregar2;
    }
}
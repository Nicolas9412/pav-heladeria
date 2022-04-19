namespace Practico.Formularios.Abm.HeladosHeladosEspeciales
{
    partial class FrmModificarHeladosHeladosEspeciales
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
            this.cmbHeladoEspecial = new Practico.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHelado = new Practico.Clases.ComboBox01();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txtCantidad = new Practico.Clases.TextBox02();
            this.SuspendLayout();
            // 
            // cmbHeladoEspecial
            // 
            this.cmbHeladoEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeladoEspecial.Enabled = false;
            this.cmbHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHeladoEspecial.FormattingEnabled = true;
            this.cmbHeladoEspecial.Location = new System.Drawing.Point(297, 90);
            this.cmbHeladoEspecial.Name = "cmbHeladoEspecial";
            this.cmbHeladoEspecial.PpDisplay = "nombreProducto";
            this.cmbHeladoEspecial.PpMensajeError = "Seleccione un Helado Especial!!";
            this.cmbHeladoEspecial.PpNombreCampo = null;
            this.cmbHeladoEspecial.PpNombreTabla = null;
            this.cmbHeladoEspecial.PpTabla = "HeladosEspeciales";
            this.cmbHeladoEspecial.PpValidable = true;
            this.cmbHeladoEspecial.PpValue = "idHeladoEspecial";
            this.cmbHeladoEspecial.Size = new System.Drawing.Size(166, 21);
            this.cmbHeladoEspecial.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(166, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Helado Especial:";
            // 
            // cmbHelado
            // 
            this.cmbHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHelado.Enabled = false;
            this.cmbHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHelado.FormattingEnabled = true;
            this.cmbHelado.Location = new System.Drawing.Point(297, 121);
            this.cmbHelado.Name = "cmbHelado";
            this.cmbHelado.PpDisplay = "nombre";
            this.cmbHelado.PpMensajeError = "Seleccione un Helado!!";
            this.cmbHelado.PpNombreCampo = null;
            this.cmbHelado.PpNombreTabla = null;
            this.cmbHelado.PpTabla = "Helados";
            this.cmbHelado.PpValidable = true;
            this.cmbHelado.PpValue = "idHelado";
            this.cmbHelado.Size = new System.Drawing.Size(164, 21);
            this.cmbHelado.TabIndex = 106;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(133, 155);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(158, 19);
            this.lblTelefono.TabIndex = 111;
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
            this.btnCancelar.Location = new System.Drawing.Point(186, 195);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.Text = "Cancelar";
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
            this.btnAceptar.Location = new System.Drawing.Point(297, 195);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 107;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocumento.Location = new System.Drawing.Point(227, 123);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(64, 19);
            this.lblDocumento.TabIndex = 110;
            this.lblDocumento.Text = "Helado:";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(24, 22);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(377, 23);
            this.lblNuevo.TabIndex = 109;
            this.lblNuevo.Text = "Modificar Helado de Helado Especial";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(297, 154);
            this.txtCantidad.Mask = "0000000";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PpMensajeError = "Ingrese una cantidad!";
            this.txtCantidad.PpNombreCampo = null;
            this.txtCantidad.PpNombreTabla = null;
            this.txtCantidad.PpValidable = true;
            this.txtCantidad.PromptChar = ' ';
            this.txtCantidad.Size = new System.Drawing.Size(103, 20);
            this.txtCantidad.TabIndex = 114;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
            // 
            // FrmModificarHeladosHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(577, 276);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbHeladoEspecial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHelado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNuevo);
            this.Name = "FrmModificarHeladosHeladosEspeciales";
            this.Text = "Modificar Helado De Helados Especiales";
            this.Load += new System.EventHandler(this.FrmModificarHeladosHeladosEspeciales_Load);
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
    }
}
namespace Practico.Formularios.Abm.FrutasHeladosEspeciales
{
    partial class FrmConsultarFrutaHeladoEspecial
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
            this.cmbFruta = new Practico.Clases.ComboBox01();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantidad = new Practico.Clases.TextBox01();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbHeladoEspecial
            // 
            this.cmbHeladoEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeladoEspecial.Enabled = false;
            this.cmbHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHeladoEspecial.FormattingEnabled = true;
            this.cmbHeladoEspecial.Location = new System.Drawing.Point(307, 92);
            this.cmbHeladoEspecial.Name = "cmbHeladoEspecial";
            this.cmbHeladoEspecial.PpDisplay = "nombreProducto";
            this.cmbHeladoEspecial.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbHeladoEspecial.PpNombreCampo = null;
            this.cmbHeladoEspecial.PpNombreTabla = null;
            this.cmbHeladoEspecial.PpTabla = "HeladosEspeciales";
            this.cmbHeladoEspecial.PpValidable = true;
            this.cmbHeladoEspecial.PpValue = "idHeladoEspecial";
            this.cmbHeladoEspecial.Size = new System.Drawing.Size(166, 25);
            this.cmbHeladoEspecial.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(176, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "Helado Especial:";
            // 
            // cmbFruta
            // 
            this.cmbFruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFruta.Enabled = false;
            this.cmbFruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFruta.FormattingEnabled = true;
            this.cmbFruta.Location = new System.Drawing.Point(307, 123);
            this.cmbFruta.Name = "cmbFruta";
            this.cmbFruta.PpDisplay = "nombre";
            this.cmbFruta.PpMensajeError = "Seleccione un numero de documento!";
            this.cmbFruta.PpNombreCampo = null;
            this.cmbFruta.PpNombreTabla = null;
            this.cmbFruta.PpTabla = "Frutas";
            this.cmbFruta.PpValidable = true;
            this.cmbFruta.PpValue = "idFruta";
            this.cmbFruta.Size = new System.Drawing.Size(164, 25);
            this.cmbFruta.TabIndex = 69;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(143, 157);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(158, 19);
            this.lblTelefono.TabIndex = 75;
            this.lblTelefono.Text = "Cantidad de gramos:";
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
            this.btnCancelar.Location = new System.Drawing.Point(196, 197);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(307, 197);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(307, 154);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PpMensajeError = "Ingrese un numero de telefono!";
            this.txtCantidad.PpNombreCampo = null;
            this.txtCantidad.PpNombreTabla = null;
            this.txtCantidad.PpValidable = true;
            this.txtCantidad.Size = new System.Drawing.Size(103, 24);
            this.txtCantidad.TabIndex = 68;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocumento.Location = new System.Drawing.Point(253, 129);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(48, 19);
            this.lblDocumento.TabIndex = 74;
            this.lblDocumento.Text = "Fruta:";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(34, 24);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(357, 23);
            this.lblNuevo.TabIndex = 72;
            this.lblNuevo.Text = "Consultar Fruta de Helado Especial";
            // 
            // FrmConsultarFrutaHeladoEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(575, 272);
            this.Controls.Add(this.cmbHeladoEspecial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFruta);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNuevo);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarFrutaHeladoEspecial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Helado Especial";
            this.Load += new System.EventHandler(this.FrmConsultarFrutaHeladoEspecial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBox01 cmbHeladoEspecial;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmbFruta;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Clases.TextBox01 txtCantidad;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNuevo;
    }
}

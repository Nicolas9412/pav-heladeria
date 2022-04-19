namespace Practico.Formularios.Abm.TelefonosEmpleados
{
    partial class FrmEliminarTelefonosEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarTelefonosEmpleados));
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNombre = new Practico.Clases.ComboBox01();
            this.cmbDocumento = new Practico.Clases.ComboBox01();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.txtTelefono = new Practico.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(136, 198);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(151, 19);
            this.lblTelefono.TabIndex = 64;
            this.lblTelefono.Text = "Numero de Telefono:";
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
            this.btnCancelar.Location = new System.Drawing.Point(255, 240);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 40);
            this.btnCancelar.TabIndex = 59;
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
            this.btnAceptar.Location = new System.Drawing.Point(372, 240);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 40);
            this.btnAceptar.TabIndex = 58;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocumento.Location = new System.Drawing.Point(111, 168);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(176, 19);
            this.lblDocumento.TabIndex = 62;
            this.lblDocumento.Text = "Numero de Documento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(138, 138);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 61;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(21, 33);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(172, 23);
            this.lblNuevo.TabIndex = 60;
            this.lblNuevo.Text = "Eliminar Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(218, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombre:";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.Enabled = false;
            this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(292, 98);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.PpDisplay = "tipoDoc";
            this.cmbNombre.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbNombre.PpNombreCampo = null;
            this.cmbNombre.PpNombreTabla = null;
            this.cmbNombre.PpTabla = "Empleados";
            this.cmbNombre.PpValidable = true;
            this.cmbNombre.PpValue = "tipoDoc";
            this.cmbNombre.Size = new System.Drawing.Size(166, 25);
            this.cmbNombre.TabIndex = 65;
            this.cmbNombre.SelectedValueChanged += new System.EventHandler(this.cmbNombre_SelectedValueChanged);
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(294, 163);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.PpDisplay = "nroDoc";
            this.cmbDocumento.PpMensajeError = "Seleccione un numero de documento!";
            this.cmbDocumento.PpNombreCampo = null;
            this.cmbDocumento.PpNombreTabla = null;
            this.cmbDocumento.PpTabla = "Empleados";
            this.cmbDocumento.PpValidable = true;
            this.cmbDocumento.PpValue = "nroDoc";
            this.cmbDocumento.Size = new System.Drawing.Size(164, 25);
            this.cmbDocumento.TabIndex = 54;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(294, 132);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "tipoDoc";
            this.cmbTipo.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "Empleados";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDoc";
            this.cmbTipo.Size = new System.Drawing.Size(123, 25);
            this.cmbTipo.TabIndex = 48;
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(294, 193);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PpMensajeError = "Ingrese un numero de telefono!";
            this.txtTelefono.PpNombreCampo = null;
            this.txtTelefono.PpNombreTabla = null;
            this.txtTelefono.PpValidable = true;
            this.txtTelefono.Size = new System.Drawing.Size(164, 24);
            this.txtTelefono.TabIndex = 50;
            // 
            // FrmEliminarTelefonosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(575, 318);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNuevo);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEliminarTelefonosEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Telefono de Empleado";
            this.Load += new System.EventHandler(this.FrmEliminarTelefonosEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.ComboBox01 cmbDocumento;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Clases.TextBox01 txtTelefono;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNuevo;
        private Clases.ComboBox01 cmbNombre;
        private System.Windows.Forms.Label label1;
    }
}

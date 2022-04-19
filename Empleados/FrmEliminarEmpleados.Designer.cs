namespace Practico.Formularios.Abm.Empleados
{
    partial class FrmEliminarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarEmpleados));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNumeroD = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNa = new System.Windows.Forms.Label();
            this.pckNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pckIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIn = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmbBarrio = new Practico.Clases.ComboBox01();
            this.cmbUsuario = new Practico.Clases.ComboBox01();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.txtNroCalle = new Practico.Clases.TextBox01();
            this.txtCalle = new Practico.Clases.TextBox01();
            this.txtApellido = new Practico.Clases.TextBox01();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.txtNroDoc = new Practico.Clases.TextBox01();
            this.cmbTurno = new Practico.Clases.ComboBox01();
            this.lblTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(206, 423);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 11;
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
            this.btnAceptar.Location = new System.Drawing.Point(317, 423);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(166, 187);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 19);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNumeroD
            // 
            this.lblNumeroD.AutoSize = true;
            this.lblNumeroD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumeroD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroD.Location = new System.Drawing.Point(59, 127);
            this.lblNumeroD.Name = "lblNumeroD";
            this.lblNumeroD.Size = new System.Drawing.Size(176, 19);
            this.lblNumeroD.TabIndex = 30;
            this.lblNumeroD.Text = "Numero de Documento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(86, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 29;
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
            this.lblNuevo.Size = new System.Drawing.Size(192, 23);
            this.lblNuevo.TabIndex = 28;
            this.lblNuevo.Text = "Eliminar Empleado";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumero.Location = new System.Drawing.Point(411, 217);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 19);
            this.lblNumero.TabIndex = 37;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCalle.Location = new System.Drawing.Point(186, 217);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(49, 19);
            this.lblCalle.TabIndex = 36;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(167, 157);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaNa
            // 
            this.lblFechaNa.AutoSize = true;
            this.lblFechaNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaNa.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFechaNa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaNa.Location = new System.Drawing.Point(71, 280);
            this.lblFechaNa.Name = "lblFechaNa";
            this.lblFechaNa.Size = new System.Drawing.Size(164, 19);
            this.lblFechaNa.TabIndex = 39;
            this.lblFechaNa.Text = "Fecha de Nacimiento:";
            // 
            // pckNacimiento
            // 
            this.pckNacimiento.Enabled = false;
            this.pckNacimiento.Location = new System.Drawing.Point(242, 274);
            this.pckNacimiento.Name = "pckNacimiento";
            this.pckNacimiento.Size = new System.Drawing.Size(176, 24);
            this.pckNacimiento.TabIndex = 7;
            // 
            // pckIngreso
            // 
            this.pckIngreso.Enabled = false;
            this.pckIngreso.Location = new System.Drawing.Point(242, 304);
            this.pckIngreso.Name = "pckIngreso";
            this.pckIngreso.Size = new System.Drawing.Size(176, 24);
            this.pckIngreso.TabIndex = 8;
            // 
            // lblFechaIn
            // 
            this.lblFechaIn.AutoSize = true;
            this.lblFechaIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaIn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFechaIn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaIn.Location = new System.Drawing.Point(103, 310);
            this.lblFechaIn.Name = "lblFechaIn";
            this.lblFechaIn.Size = new System.Drawing.Size(132, 19);
            this.lblFechaIn.TabIndex = 41;
            this.lblFechaIn.Text = "Fecha de Ingreso:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(173, 340);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 19);
            this.lblUsuario.TabIndex = 43;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarrio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblBarrio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBarrio.Location = new System.Drawing.Point(184, 248);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(51, 19);
            this.lblBarrio.TabIndex = 45;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(242, 242);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.PpDisplay = "nombre";
            this.cmbBarrio.PpMensajeError = null;
            this.cmbBarrio.PpNombreCampo = null;
            this.cmbBarrio.PpNombreTabla = null;
            this.cmbBarrio.PpTabla = "Barrios";
            this.cmbBarrio.PpValidable = true;
            this.cmbBarrio.PpValue = "idBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(123, 25);
            this.cmbBarrio.TabIndex = 6;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(242, 334);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.PpDisplay = "nombreUsuario";
            this.cmbUsuario.PpMensajeError = null;
            this.cmbUsuario.PpNombreCampo = null;
            this.cmbUsuario.PpNombreTabla = null;
            this.cmbUsuario.PpTabla = "Usuarios";
            this.cmbUsuario.PpValidable = false;
            this.cmbUsuario.PpValue = "idUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(123, 25);
            this.cmbUsuario.TabIndex = 9;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(242, 91);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "descripcion";
            this.cmbTipo.PpMensajeError = null;
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "TiposDocumento";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDocumento";
            this.cmbTipo.Size = new System.Drawing.Size(123, 25);
            this.cmbTipo.TabIndex = 0;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.BackColor = System.Drawing.Color.White;
            this.txtNroCalle.Enabled = false;
            this.txtNroCalle.Location = new System.Drawing.Point(478, 212);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.PpMensajeError = "No se ingresó cantidad en stock!";
            this.txtNroCalle.PpNombreCampo = null;
            this.txtNroCalle.PpNombreTabla = null;
            this.txtNroCalle.PpValidable = true;
            this.txtNroCalle.Size = new System.Drawing.Size(82, 24);
            this.txtNroCalle.TabIndex = 5;
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(242, 212);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PpMensajeError = "No ingresó Precio!";
            this.txtCalle.PpNombreCampo = null;
            this.txtCalle.PpNombreTabla = null;
            this.txtCalle.PpValidable = true;
            this.txtCalle.Size = new System.Drawing.Size(156, 24);
            this.txtCalle.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(242, 182);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PpMensajeError = "No ingresó nombre!";
            this.txtApellido.PpNombreCampo = null;
            this.txtApellido.PpNombreTabla = null;
            this.txtApellido.PpValidable = true;
            this.txtApellido.Size = new System.Drawing.Size(156, 24);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(242, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "No se ingresó cantidad en stock!";
            this.txtNombre.PpNombreCampo = null;
            this.txtNombre.PpNombreTabla = null;
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(156, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.BackColor = System.Drawing.Color.White;
            this.txtNroDoc.Enabled = false;
            this.txtNroDoc.Location = new System.Drawing.Point(242, 122);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.PpMensajeError = "No ingresó Precio!";
            this.txtNroDoc.PpNombreCampo = null;
            this.txtNroDoc.PpNombreTabla = null;
            this.txtNroDoc.PpValidable = true;
            this.txtNroDoc.Size = new System.Drawing.Size(124, 24);
            this.txtNroDoc.TabIndex = 1;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(242, 365);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.PpDisplay = "nombre";
            this.cmbTurno.PpMensajeError = null;
            this.cmbTurno.PpNombreCampo = null;
            this.cmbTurno.PpNombreTabla = null;
            this.cmbTurno.PpTabla = "Turnos";
            this.cmbTurno.PpValidable = false;
            this.cmbTurno.PpValue = "idTurno";
            this.cmbTurno.Size = new System.Drawing.Size(123, 25);
            this.cmbTurno.TabIndex = 46;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTurno.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTurno.Location = new System.Drawing.Point(184, 371);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(49, 19);
            this.lblTurno.TabIndex = 47;
            this.lblTurno.Text = "Turno:";
            // 
            // FrmEliminarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(634, 495);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pckIngreso);
            this.Controls.Add(this.lblFechaIn);
            this.Controls.Add(this.pckNacimiento);
            this.Controls.Add(this.lblFechaNa);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.lblNumeroD);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNuevo);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEliminarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Empleado";
            this.Load += new System.EventHandler(this.FrmEliminarEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private Clases.TextBox01 txtNroDoc;
        private System.Windows.Forms.Label lblNumeroD;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNuevo;
        private Clases.TextBox01 txtNroCalle;
        private System.Windows.Forms.Label lblNumero;
        private Clases.TextBox01 txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private Clases.TextBox01 txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.Label lblFechaNa;
        private System.Windows.Forms.DateTimePicker pckNacimiento;
        private System.Windows.Forms.DateTimePicker pckIngreso;
        private System.Windows.Forms.Label lblFechaIn;
        private Clases.ComboBox01 cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private Clases.ComboBox01 cmbBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private Clases.ComboBox01 cmbTurno;
        private System.Windows.Forms.Label lblTurno;
    }
}

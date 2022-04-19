namespace Practico.Formularios.Abm.TelefonosEmpleados
{
    partial class FrmTelefonosEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new Practico.Clases.TextBox01();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.grdTelefonos = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefonos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.lblNombre);
            this.pnlBuscar.Controls.Add(this.btnLimpiar);
            this.pnlBuscar.Controls.Add(this.txtNombre);
            this.pnlBuscar.Controls.Add(this.lblTipo);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.chkTodos);
            this.pnlBuscar.Controls.Add(this.lblNumero);
            this.pnlBuscar.Controls.Add(this.txtNumero);
            this.pnlBuscar.Controls.Add(this.cmbTipo);
            this.pnlBuscar.Location = new System.Drawing.Point(12, 70);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(485, 200);
            this.pnlBuscar.TabIndex = 23;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(114, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(188, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "No ingresó nombre!";
            this.txtNombre.PpNombreCampo = null;
            this.txtNombre.PpNombreTabla = null;
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(156, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(33, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Image = global::Practico.Properties.Resources.magnifying_glass;
            this.btnBuscar.Location = new System.Drawing.Point(190, 150);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 40);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTodos.Location = new System.Drawing.Point(188, 122);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(112, 23);
            this.chkTodos.TabIndex = 25;
            this.chkTodos.Text = "Buscar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumero.Location = new System.Drawing.Point(6, 65);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(176, 19);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero de Documento:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(188, 60);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PpMensajeError = "No ingresó nombre!";
            this.txtNumero.PpNombreCampo = null;
            this.txtNumero.PpNombreTabla = null;
            this.txtNumero.PpValidable = true;
            this.txtNumero.Size = new System.Drawing.Size(156, 24);
            this.txtNumero.TabIndex = 2;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(188, 91);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "descripcion";
            this.cmbTipo.PpMensajeError = null;
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "TiposDocumento";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDocumento";
            this.cmbTipo.Size = new System.Drawing.Size(156, 25);
            this.cmbTipo.TabIndex = 3;
            // 
            // grdTelefonos
            // 
            this.grdTelefonos.AllowUserToAddRows = false;
            this.grdTelefonos.AllowUserToDeleteRows = false;
            this.grdTelefonos.AllowUserToResizeColumns = false;
            this.grdTelefonos.AllowUserToResizeRows = false;
            this.grdTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTelefonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTelefonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Tipo,
            this.Documento,
            this.Nombre});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTelefonos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdTelefonos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdTelefonos.Location = new System.Drawing.Point(28, 307);
            this.grdTelefonos.Name = "grdTelefonos";
            this.grdTelefonos.ReadOnly = true;
            this.grdTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTelefonos.Size = new System.Drawing.Size(611, 201);
            this.grdTelefonos.TabIndex = 28;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Numero.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Doc";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Numero de Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Documento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Documento.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefonos.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblTelefonos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefonos.Location = new System.Drawing.Point(22, 34);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(363, 23);
            this.lblTelefonos.TabIndex = 27;
            this.lblTelefonos.Text = "Gestión de Telefonos de Empleados";
            // 
            // btnEscritorio
            // 
            this.btnEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscritorio.FlatAppearance.BorderSize = 0;
            this.btnEscritorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEscritorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnEscritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscritorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscritorio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEscritorio.Location = new System.Drawing.Point(616, 17);
            this.btnEscritorio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(166, 63);
            this.btnEscritorio.TabIndex = 26;
            this.btnEscritorio.Text = "Volver Al Escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            this.btnEscritorio.Click += new System.EventHandler(this.btnEscritorio_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(645, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 224);
            this.panel1.TabIndex = 32;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultar.Image = global::Practico.Properties.Resources.magnifying_glass;
            this.btnConsultar.Location = new System.Drawing.Point(8, 65);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(172, 40);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar Telefono";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = global::Practico.Properties.Resources.remove;
            this.btnEliminar.Location = new System.Drawing.Point(9, 161);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Telefono";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Image = global::Practico.Properties.Resources.iconfinder_website___pencil_3440848;
            this.btnModificar.Location = new System.Drawing.Point(8, 113);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Telefono";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Image = global::Practico.Properties.Resources.plus;
            this.btnNuevo.Location = new System.Drawing.Point(7, 17);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(173, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Telefono";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Image = global::Practico.Properties.Resources.eraser;
            this.btnLimpiar.Location = new System.Drawing.Point(353, 86);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 32);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmTelefonosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(859, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.grdTelefonos);
            this.Controls.Add(this.lblTelefonos);
            this.Controls.Add(this.btnEscritorio);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTelefonosEmpleados";
            this.Text = "Gestión de Telefonos de Empleados";
            this.Load += new System.EventHandler(this.FrmTelefonosEmpleados_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefonos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private Clases.TextBox01 txtNumero;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.DataGridView grdTelefonos;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}
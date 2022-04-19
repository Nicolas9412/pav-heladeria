namespace Practico.Formularios.Abm.HeladosHeladosEspeciales
{
    partial class FrmHeladosHeladosEspeciales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnLimpiarHeladoEspecial = new System.Windows.Forms.Button();
            this.lblHelado = new System.Windows.Forms.Label();
            this.cmbHelado = new Practico.Clases.ComboBox01();
            this.btnLimpiarHelado = new System.Windows.Forms.Button();
            this.lblHeladoEspecial = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.cmbHeladoEspecial = new Practico.Clases.ComboBox01();
            this.grdHeladosHeladosEspeciales = new System.Windows.Forms.DataGridView();
            this.lblHelados = new System.Windows.Forms.Label();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.HeladoEspecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeladosHeladosEspeciales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(535, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 247);
            this.panel1.TabIndex = 40;
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
            this.btnConsultar.Location = new System.Drawing.Point(20, 70);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 49);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar Helado de Helado Especial";
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
            this.btnEliminar.Location = new System.Drawing.Point(20, 184);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 49);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Helado de Helado Especial";
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
            this.btnModificar.Location = new System.Drawing.Point(20, 127);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 49);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Helado de Helado Especial";
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
            this.btnNuevo.Location = new System.Drawing.Point(20, 13);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 49);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Helado de Helado Especial";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.btnLimpiarHeladoEspecial);
            this.pnlBuscar.Controls.Add(this.lblHelado);
            this.pnlBuscar.Controls.Add(this.cmbHelado);
            this.pnlBuscar.Controls.Add(this.btnLimpiarHelado);
            this.pnlBuscar.Controls.Add(this.lblHeladoEspecial);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.chkTodos);
            this.pnlBuscar.Controls.Add(this.cmbHeladoEspecial);
            this.pnlBuscar.Location = new System.Drawing.Point(65, 56);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(464, 180);
            this.pnlBuscar.TabIndex = 38;
            // 
            // btnLimpiarHeladoEspecial
            // 
            this.btnLimpiarHeladoEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLimpiarHeladoEspecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarHeladoEspecial.FlatAppearance.BorderSize = 0;
            this.btnLimpiarHeladoEspecial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLimpiarHeladoEspecial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnLimpiarHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarHeladoEspecial.Location = new System.Drawing.Point(375, 36);
            this.btnLimpiarHeladoEspecial.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLimpiarHeladoEspecial.Name = "btnLimpiarHeladoEspecial";
            this.btnLimpiarHeladoEspecial.Size = new System.Drawing.Size(70, 24);
            this.btnLimpiarHeladoEspecial.TabIndex = 34;
            this.btnLimpiarHeladoEspecial.Text = "Limpiar";
            this.btnLimpiarHeladoEspecial.UseVisualStyleBackColor = false;
            this.btnLimpiarHeladoEspecial.Click += new System.EventHandler(this.btnLimpiarHeladoEspecial_Click);
            // 
            // lblHelado
            // 
            this.lblHelado.AutoSize = true;
            this.lblHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelado.Location = new System.Drawing.Point(116, 71);
            this.lblHelado.Name = "lblHelado";
            this.lblHelado.Size = new System.Drawing.Size(68, 19);
            this.lblHelado.TabIndex = 33;
            this.lblHelado.Text = "Helado: ";
            // 
            // cmbHelado
            // 
            this.cmbHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHelado.FormattingEnabled = true;
            this.cmbHelado.Location = new System.Drawing.Point(190, 65);
            this.cmbHelado.Name = "cmbHelado";
            this.cmbHelado.PpDisplay = "nombre";
            this.cmbHelado.PpMensajeError = null;
            this.cmbHelado.PpNombreCampo = null;
            this.cmbHelado.PpNombreTabla = null;
            this.cmbHelado.PpTabla = "Helados";
            this.cmbHelado.PpValidable = true;
            this.cmbHelado.PpValue = "idHelado";
            this.cmbHelado.Size = new System.Drawing.Size(123, 21);
            this.cmbHelado.TabIndex = 32;
            // 
            // btnLimpiarHelado
            // 
            this.btnLimpiarHelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLimpiarHelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarHelado.FlatAppearance.BorderSize = 0;
            this.btnLimpiarHelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLimpiarHelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnLimpiarHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHelado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarHelado.Location = new System.Drawing.Point(322, 67);
            this.btnLimpiarHelado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLimpiarHelado.Name = "btnLimpiarHelado";
            this.btnLimpiarHelado.Size = new System.Drawing.Size(70, 24);
            this.btnLimpiarHelado.TabIndex = 31;
            this.btnLimpiarHelado.Text = "Limpiar";
            this.btnLimpiarHelado.UseVisualStyleBackColor = false;
            this.btnLimpiarHelado.Click += new System.EventHandler(this.btnLimpiarHelado_Click);
            // 
            // lblHeladoEspecial
            // 
            this.lblHeladoEspecial.AutoSize = true;
            this.lblHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeladoEspecial.Location = new System.Drawing.Point(59, 40);
            this.lblHeladoEspecial.Name = "lblHeladoEspecial";
            this.lblHeladoEspecial.Size = new System.Drawing.Size(125, 19);
            this.lblHeladoEspecial.TabIndex = 18;
            this.lblHeladoEspecial.Text = "Helado Especial:";
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
            this.btnBuscar.Location = new System.Drawing.Point(194, 121);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 40);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTodos.Location = new System.Drawing.Point(192, 93);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(89, 17);
            this.chkTodos.TabIndex = 25;
            this.chkTodos.Text = "Buscar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // cmbHeladoEspecial
            // 
            this.cmbHeladoEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHeladoEspecial.FormattingEnabled = true;
            this.cmbHeladoEspecial.Location = new System.Drawing.Point(190, 34);
            this.cmbHeladoEspecial.Name = "cmbHeladoEspecial";
            this.cmbHeladoEspecial.PpDisplay = "nombreProducto";
            this.cmbHeladoEspecial.PpMensajeError = null;
            this.cmbHeladoEspecial.PpNombreCampo = null;
            this.cmbHeladoEspecial.PpNombreTabla = null;
            this.cmbHeladoEspecial.PpTabla = "HeladosEspeciales";
            this.cmbHeladoEspecial.PpValidable = true;
            this.cmbHeladoEspecial.PpValue = "idHeladoEspecial";
            this.cmbHeladoEspecial.Size = new System.Drawing.Size(176, 21);
            this.cmbHeladoEspecial.TabIndex = 3;
            // 
            // grdHeladosHeladosEspeciales
            // 
            this.grdHeladosHeladosEspeciales.AllowUserToAddRows = false;
            this.grdHeladosHeladosEspeciales.AllowUserToDeleteRows = false;
            this.grdHeladosHeladosEspeciales.AllowUserToResizeColumns = false;
            this.grdHeladosHeladosEspeciales.AllowUserToResizeRows = false;
            this.grdHeladosHeladosEspeciales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdHeladosHeladosEspeciales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdHeladosHeladosEspeciales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHeladosHeladosEspeciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdHeladosHeladosEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHeladosHeladosEspeciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeladoEspecial,
            this.Nombre,
            this.Cantidad});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHeladosHeladosEspeciales.DefaultCellStyle = dataGridViewCellStyle16;
            this.grdHeladosHeladosEspeciales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdHeladosHeladosEspeciales.Location = new System.Drawing.Point(65, 242);
            this.grdHeladosHeladosEspeciales.Name = "grdHeladosHeladosEspeciales";
            this.grdHeladosHeladosEspeciales.ReadOnly = true;
            this.grdHeladosHeladosEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHeladosHeladosEspeciales.Size = new System.Drawing.Size(474, 201);
            this.grdHeladosHeladosEspeciales.TabIndex = 39;
            // 
            // lblHelados
            // 
            this.lblHelados.AutoSize = true;
            this.lblHelados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelados.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblHelados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelados.Location = new System.Drawing.Point(24, 30);
            this.lblHelados.Name = "lblHelados";
            this.lblHelados.Size = new System.Drawing.Size(445, 23);
            this.lblHelados.TabIndex = 37;
            this.lblHelados.Text = "Gestión  De Helados  De Helados Especiales";
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
            this.btnEscritorio.Location = new System.Drawing.Point(618, 13);
            this.btnEscritorio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(166, 63);
            this.btnEscritorio.TabIndex = 36;
            this.btnEscritorio.Text = "Volver Al Escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            this.btnEscritorio.Click += new System.EventHandler(this.btnEscritorio_Click);
            // 
            // HeladoEspecial
            // 
            this.HeladoEspecial.HeaderText = "Helado Especial";
            this.HeladoEspecial.Name = "HeladoEspecial";
            this.HeladoEspecial.ReadOnly = true;
            this.HeladoEspecial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeladoEspecial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HeladoEspecial.Width = 160;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Helado";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad Bochas";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 120;
            // 
            // FrmHeladosHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(807, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.grdHeladosHeladosEspeciales);
            this.Controls.Add(this.lblHelados);
            this.Controls.Add(this.btnEscritorio);
            this.Name = "FrmHeladosHeladosEspeciales";
            this.Text = "Gestión de Helados Helados Especiales";
            this.Load += new System.EventHandler(this.FrmHeladosHeladosEspeciales_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeladosHeladosEspeciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Button btnLimpiarHeladoEspecial;
        private System.Windows.Forms.Label lblHelado;
        private Clases.ComboBox01 cmbHelado;
        private System.Windows.Forms.Button btnLimpiarHelado;
        private System.Windows.Forms.Label lblHeladoEspecial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkTodos;
        private Clases.ComboBox01 cmbHeladoEspecial;
        private System.Windows.Forms.DataGridView grdHeladosHeladosEspeciales;
        private System.Windows.Forms.Label lblHelados;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeladoEspecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}
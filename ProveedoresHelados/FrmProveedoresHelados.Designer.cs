namespace Practico.Formularios.Abm.ProveedoresHelados
{
    partial class FrmProveedoresHelados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedoresHelados));
            this.lblProveedoresHelados = new System.Windows.Forms.Label();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.lblNombreHelado = new System.Windows.Forms.Label();
            this.txtRazonSocial = new Practico.Clases.TextBox01();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdProveedoresHelados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtNombreHelado = new Practico.Clases.TextBox01();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedoresHelados)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedoresHelados
            // 
            this.lblProveedoresHelados.AutoSize = true;
            this.lblProveedoresHelados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProveedoresHelados.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblProveedoresHelados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProveedoresHelados.Location = new System.Drawing.Point(13, 34);
            this.lblProveedoresHelados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedoresHelados.Name = "lblProveedoresHelados";
            this.lblProveedoresHelados.Size = new System.Drawing.Size(366, 23);
            this.lblProveedoresHelados.TabIndex = 8;
            this.lblProveedoresHelados.Text = "Gestión de Proveedores de Helados";
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
            this.btnEscritorio.Location = new System.Drawing.Point(774, 34);
            this.btnEscritorio.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(166, 63);
            this.btnEscritorio.TabIndex = 2;
            this.btnEscritorio.Text = "Volver Al Escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            this.btnEscritorio.Click += new System.EventHandler(this.btnEscritorio_Click);
            // 
            // lblNombreHelado
            // 
            this.lblNombreHelado.AutoSize = true;
            this.lblNombreHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombreHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreHelado.Location = new System.Drawing.Point(27, 64);
            this.lblNombreHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreHelado.Name = "lblNombreHelado";
            this.lblNombreHelado.Size = new System.Drawing.Size(146, 19);
            this.lblNombreHelado.TabIndex = 20;
            this.lblNombreHelado.Text = "Nombre de Helado:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Location = new System.Drawing.Point(181, 31);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PpMensajeError = "No ingresó Razón Social !";
            this.txtRazonSocial.PpNombreCampo = null;
            this.txtRazonSocial.PpNombreTabla = null;
            this.txtRazonSocial.PpValidable = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(164, 24);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTodos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTodos.Location = new System.Drawing.Point(181, 93);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(112, 23);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Buscar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
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
            this.btnBuscar.Location = new System.Drawing.Point(362, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdProveedoresHelados
            // 
            this.grdProveedoresHelados.AllowUserToAddRows = false;
            this.grdProveedoresHelados.AllowUserToDeleteRows = false;
            this.grdProveedoresHelados.AllowUserToResizeColumns = false;
            this.grdProveedoresHelados.AllowUserToResizeRows = false;
            this.grdProveedoresHelados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdProveedoresHelados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProveedoresHelados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProveedoresHelados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProveedoresHelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProveedoresHelados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProveedoresHelados.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProveedoresHelados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdProveedoresHelados.Location = new System.Drawing.Point(13, 226);
            this.grdProveedoresHelados.Margin = new System.Windows.Forms.Padding(4);
            this.grdProveedoresHelados.Name = "grdProveedoresHelados";
            this.grdProveedoresHelados.ReadOnly = true;
            this.grdProveedoresHelados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProveedoresHelados.Size = new System.Drawing.Size(643, 319);
            this.grdProveedoresHelados.TabIndex = 24;
            // 
            // Id
            // 
            this.Id.HeaderText = "Tipo Doc";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nro Doc";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Razón Social";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Helado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(713, 226);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 278);
            this.panel1.TabIndex = 1;
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
            this.btnEliminar.Location = new System.Drawing.Point(14, 197);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 55);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Proveedor de Helado";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnConsultar.Location = new System.Drawing.Point(14, 72);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(185, 52);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Proveedor de Helado";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(13, 5);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(186, 57);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Proveedor de Helado";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazonSocial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRazonSocial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRazonSocial.Location = new System.Drawing.Point(72, 34);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(101, 19);
            this.lblRazonSocial.TabIndex = 26;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtNombreHelado
            // 
            this.txtNombreHelado.BackColor = System.Drawing.Color.White;
            this.txtNombreHelado.Location = new System.Drawing.Point(181, 61);
            this.txtNombreHelado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreHelado.Name = "txtNombreHelado";
            this.txtNombreHelado.PpMensajeError = "No ingresó Nombre de Helado !";
            this.txtNombreHelado.PpNombreCampo = null;
            this.txtNombreHelado.PpNombreTabla = null;
            this.txtNombreHelado.PpValidable = true;
            this.txtNombreHelado.Size = new System.Drawing.Size(164, 24);
            this.txtNombreHelado.TabIndex = 1;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.txtNombreHelado);
            this.pnlBuscar.Controls.Add(this.lblRazonSocial);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.chkTodos);
            this.pnlBuscar.Controls.Add(this.txtRazonSocial);
            this.pnlBuscar.Controls.Add(this.lblNombreHelado);
            this.pnlBuscar.Location = new System.Drawing.Point(34, 79);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(495, 122);
            this.pnlBuscar.TabIndex = 0;
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
            this.btnModificar.Location = new System.Drawing.Point(14, 133);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(185, 55);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar Proveedor De Helado";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmProveedoresHelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdProveedoresHelados);
            this.Controls.Add(this.btnEscritorio);
            this.Controls.Add(this.lblProveedoresHelados);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProveedoresHelados";
            this.Text = "Gestión de Proveedores de Helados";
            this.Load += new System.EventHandler(this.FrmProveedoresHelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedoresHelados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedoresHelados;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.Label lblNombreHelado;
        private Clases.TextBox01 txtRazonSocial;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdProveedoresHelados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblRazonSocial;
        private Clases.TextBox01 txtNombreHelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
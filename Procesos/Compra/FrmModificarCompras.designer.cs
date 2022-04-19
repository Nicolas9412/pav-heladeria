namespace Practico.Formularios.Procesos.Compra
{
    partial class FrmModificarCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNuevaCompra = new System.Windows.Forms.Label();
            this.pckFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblRazónSocial = new System.Windows.Forms.Label();
            this.lblTipoDocProveedor = new System.Windows.Forms.Label();
            this.lblNroDocProveedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechaHoy = new System.Windows.Forms.Button();
            this.lblPrecioHelado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblTxtTotal = new System.Windows.Forms.Label();
            this.btnAgregarHelado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grdDetallesCompras = new Practico.Clases.Grid01();
            this.txtPrecioHelado = new Practico.Clases.TextBox01();
            this.lbltxtKilos = new Practico.Clases.LabelText01();
            this.cmbIdHelado = new Practico.Clases.ComboBox01();
            this.cmbNroDocProveedor = new Practico.Clases.ComboBox01();
            this.cmbTipoDocProveedor = new Practico.Clases.ComboBox01();
            this.cmbRazonSocial = new Practico.Clases.ComboBox01();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetallesCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCompra
            // 
            this.lblNuevaCompra.AutoSize = true;
            this.lblNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevaCompra.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevaCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevaCompra.Location = new System.Drawing.Point(47, 43);
            this.lblNuevaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaCompra.Name = "lblNuevaCompra";
            this.lblNuevaCompra.Size = new System.Drawing.Size(187, 23);
            this.lblNuevaCompra.TabIndex = 22;
            this.lblNuevaCompra.Text = "Modificar Compra";
            // 
            // pckFechaCompra
            // 
            this.pckFechaCompra.Enabled = false;
            this.pckFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckFechaCompra.Location = new System.Drawing.Point(227, 102);
            this.pckFechaCompra.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckFechaCompra.Name = "pckFechaCompra";
            this.pckFechaCompra.Size = new System.Drawing.Size(121, 20);
            this.pckFechaCompra.TabIndex = 76;
            this.pckFechaCompra.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaCompra.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFechaCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaCompra.Location = new System.Drawing.Point(79, 102);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(141, 19);
            this.lblFechaCompra.TabIndex = 78;
            this.lblFechaCompra.Text = "Fecha de Compra:";
            // 
            // lblRazónSocial
            // 
            this.lblRazónSocial.AutoSize = true;
            this.lblRazónSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazónSocial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRazónSocial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRazónSocial.Location = new System.Drawing.Point(119, 155);
            this.lblRazónSocial.Name = "lblRazónSocial";
            this.lblRazónSocial.Size = new System.Drawing.Size(101, 19);
            this.lblRazónSocial.TabIndex = 84;
            this.lblRazónSocial.Text = "Razón Social:";
            // 
            // lblTipoDocProveedor
            // 
            this.lblTipoDocProveedor.AutoSize = true;
            this.lblTipoDocProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoDocProveedor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipoDocProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoDocProveedor.Location = new System.Drawing.Point(94, 190);
            this.lblTipoDocProveedor.Name = "lblTipoDocProveedor";
            this.lblTipoDocProveedor.Size = new System.Drawing.Size(126, 19);
            this.lblTipoDocProveedor.TabIndex = 85;
            this.lblTipoDocProveedor.Text = "Tipo Documento:";
            // 
            // lblNroDocProveedor
            // 
            this.lblNroDocProveedor.AutoSize = true;
            this.lblNroDocProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNroDocProveedor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNroDocProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNroDocProveedor.Location = new System.Drawing.Point(98, 226);
            this.lblNroDocProveedor.Name = "lblNroDocProveedor";
            this.lblNroDocProveedor.Size = new System.Drawing.Size(122, 19);
            this.lblNroDocProveedor.TabIndex = 86;
            this.lblNroDocProveedor.Text = "Nro Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(156, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 89;
            this.label3.Text = "Helado: ";
            // 
            // btnFechaHoy
            // 
            this.btnFechaHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnFechaHoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechaHoy.Enabled = false;
            this.btnFechaHoy.FlatAppearance.BorderSize = 0;
            this.btnFechaHoy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnFechaHoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnFechaHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaHoy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaHoy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFechaHoy.Location = new System.Drawing.Point(357, 100);
            this.btnFechaHoy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFechaHoy.Name = "btnFechaHoy";
            this.btnFechaHoy.Size = new System.Drawing.Size(43, 24);
            this.btnFechaHoy.TabIndex = 91;
            this.btnFechaHoy.Text = "Hoy";
            this.btnFechaHoy.UseVisualStyleBackColor = false;
            this.btnFechaHoy.Click += new System.EventHandler(this.btnFechaHoy_Click);
            // 
            // lblPrecioHelado
            // 
            this.lblPrecioHelado.AutoSize = true;
            this.lblPrecioHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecioHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecioHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecioHelado.Location = new System.Drawing.Point(165, 295);
            this.lblPrecioHelado.Name = "lblPrecioHelado";
            this.lblPrecioHelado.Size = new System.Drawing.Size(55, 19);
            this.lblPrecioHelado.TabIndex = 93;
            this.lblPrecioHelado.Text = "Precio:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Location = new System.Drawing.Point(753, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 200);
            this.panel3.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(4, 108);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(194, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Habilitar Modificacion";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Image = global::Practico.Properties.Resources.trash;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(4, 156);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(194, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(4, 60);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Item";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Image = global::Practico.Properties.Resources.floppy_disk;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(4, 12);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(194, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Modificacion";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTxtTotal);
            this.panel1.Location = new System.Drawing.Point(664, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 121);
            this.panel1.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSigno);
            this.panel2.Location = new System.Drawing.Point(23, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 41);
            this.panel2.TabIndex = 63;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(30, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 32);
            this.lblTotal.TabIndex = 61;
            this.lblTotal.Text = "0";
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSigno.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblSigno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSigno.Location = new System.Drawing.Point(0, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(30, 32);
            this.lblSigno.TabIndex = 62;
            this.lblSigno.Text = "$";
            // 
            // lblTxtTotal
            // 
            this.lblTxtTotal.AutoSize = true;
            this.lblTxtTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTxtTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTxtTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTxtTotal.Location = new System.Drawing.Point(34, 19);
            this.lblTxtTotal.Name = "lblTxtTotal";
            this.lblTxtTotal.Size = new System.Drawing.Size(73, 28);
            this.lblTxtTotal.TabIndex = 57;
            this.lblTxtTotal.Text = "Total:";
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
            this.btnAgregarHelado.Image = global::Practico.Properties.Resources.plus;
            this.btnAgregarHelado.Location = new System.Drawing.Point(357, 282);
            this.btnAgregarHelado.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarHelado.Name = "btnAgregarHelado";
            this.btnAgregarHelado.Size = new System.Drawing.Size(156, 42);
            this.btnAgregarHelado.TabIndex = 2;
            this.btnAgregarHelado.Text = "Agregar Helado";
            this.btnAgregarHelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHelado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarHelado.UseVisualStyleBackColor = false;
            this.btnAgregarHelado.Click += new System.EventHandler(this.btnAgregarHelado_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCerrar.Location = new System.Drawing.Point(884, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 41);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grdDetallesCompras
            // 
            this.grdDetallesCompras.AllowUserToAddRows = false;
            this.grdDetallesCompras.AllowUserToDeleteRows = false;
            this.grdDetallesCompras.AllowUserToResizeColumns = false;
            this.grdDetallesCompras.AllowUserToResizeRows = false;
            this.grdDetallesCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdDetallesCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDetallesCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetallesCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetallesCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetallesCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDetallesCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdDetallesCompras.Location = new System.Drawing.Point(75, 375);
            this.grdDetallesCompras.Name = "grdDetallesCompras";
            this.grdDetallesCompras.ReadOnly = true;
            this.grdDetallesCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetallesCompras.Size = new System.Drawing.Size(656, 121);
            this.grdDetallesCompras.TabIndex = 97;
            this.grdDetallesCompras.tabla = null;
            this.grdDetallesCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetallesCompras_CellEndEdit);
            this.grdDetallesCompras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDetallesCompras_KeyDown);
            // 
            // txtPrecioHelado
            // 
            this.txtPrecioHelado.Enabled = false;
            this.txtPrecioHelado.Location = new System.Drawing.Point(227, 294);
            this.txtPrecioHelado.Name = "txtPrecioHelado";
            this.txtPrecioHelado.PpMensajeError = "";
            this.txtPrecioHelado.PpNombreCampo = null;
            this.txtPrecioHelado.PpNombreTabla = null;
            this.txtPrecioHelado.PpValidable = false;
            this.txtPrecioHelado.Size = new System.Drawing.Size(83, 20);
            this.txtPrecioHelado.TabIndex = 92;
            // 
            // lbltxtKilos
            // 
            this.lbltxtKilos.BackColor = System.Drawing.Color.Transparent;
            this.lbltxtKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtKilos.Location = new System.Drawing.Point(75, 318);
            this.lbltxtKilos.Margin = new System.Windows.Forms.Padding(4);
            this.lbltxtKilos.Name = "lbltxtKilos";
            this.lbltxtKilos.PpEtiqueta = "Kilos:";
            this.lbltxtKilos.PpMask = "0000";
            this.lbltxtKilos.PpMensajeError = "No ingresó Kilos !";
            this.lbltxtKilos.PpNombreCampo = null;
            this.lbltxtKilos.PpNombreTabla = null;
            this.lbltxtKilos.PpText = "";
            this.lbltxtKilos.PpValidable = true;
            this.lbltxtKilos.Size = new System.Drawing.Size(208, 28);
            this.lbltxtKilos.TabIndex = 1;
            // 
            // cmbIdHelado
            // 
            this.cmbIdHelado.FormattingEnabled = true;
            this.cmbIdHelado.Location = new System.Drawing.Point(227, 267);
            this.cmbIdHelado.Name = "cmbIdHelado";
            this.cmbIdHelado.PpDisplay = null;
            this.cmbIdHelado.PpMensajeError = "No ingresó Helado !";
            this.cmbIdHelado.PpNombreCampo = null;
            this.cmbIdHelado.PpNombreTabla = null;
            this.cmbIdHelado.PpTabla = null;
            this.cmbIdHelado.PpValidable = true;
            this.cmbIdHelado.PpValue = null;
            this.cmbIdHelado.Size = new System.Drawing.Size(98, 21);
            this.cmbIdHelado.TabIndex = 0;
            this.cmbIdHelado.SelectedIndexChanged += new System.EventHandler(this.cmbIdHelado_SelectedIndexChanged);
            // 
            // cmbNroDocProveedor
            // 
            this.cmbNroDocProveedor.Enabled = false;
            this.cmbNroDocProveedor.FormattingEnabled = true;
            this.cmbNroDocProveedor.Location = new System.Drawing.Point(227, 224);
            this.cmbNroDocProveedor.Name = "cmbNroDocProveedor";
            this.cmbNroDocProveedor.PpDisplay = null;
            this.cmbNroDocProveedor.PpMensajeError = "No ingresó Razón Social !";
            this.cmbNroDocProveedor.PpNombreCampo = null;
            this.cmbNroDocProveedor.PpNombreTabla = null;
            this.cmbNroDocProveedor.PpTabla = null;
            this.cmbNroDocProveedor.PpValidable = true;
            this.cmbNroDocProveedor.PpValue = null;
            this.cmbNroDocProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbNroDocProveedor.TabIndex = 81;
            this.cmbNroDocProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbNroDocProveedor_SelectedIndexChanged);
            // 
            // cmbTipoDocProveedor
            // 
            this.cmbTipoDocProveedor.Enabled = false;
            this.cmbTipoDocProveedor.FormattingEnabled = true;
            this.cmbTipoDocProveedor.Location = new System.Drawing.Point(227, 190);
            this.cmbTipoDocProveedor.Name = "cmbTipoDocProveedor";
            this.cmbTipoDocProveedor.PpDisplay = null;
            this.cmbTipoDocProveedor.PpMensajeError = "No ingresó Tipo de Documento !";
            this.cmbTipoDocProveedor.PpNombreCampo = null;
            this.cmbTipoDocProveedor.PpNombreTabla = null;
            this.cmbTipoDocProveedor.PpTabla = null;
            this.cmbTipoDocProveedor.PpValidable = true;
            this.cmbTipoDocProveedor.PpValue = null;
            this.cmbTipoDocProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocProveedor.TabIndex = 80;
            this.cmbTipoDocProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocProveedor_SelectedIndexChanged);
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.Enabled = false;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(227, 154);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.PpDisplay = null;
            this.cmbRazonSocial.PpMensajeError = "No ingresó Razón Social !";
            this.cmbRazonSocial.PpNombreCampo = null;
            this.cmbRazonSocial.PpNombreTabla = null;
            this.cmbRazonSocial.PpTabla = null;
            this.cmbRazonSocial.PpValidable = true;
            this.cmbRazonSocial.PpValue = null;
            this.cmbRazonSocial.Size = new System.Drawing.Size(121, 21);
            this.cmbRazonSocial.TabIndex = 79;
            this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cmbRazonSocial_SelectedIndexChanged);
            // 
            // FrmModificarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(978, 527);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grdDetallesCompras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAgregarHelado);
            this.Controls.Add(this.lblPrecioHelado);
            this.Controls.Add(this.txtPrecioHelado);
            this.Controls.Add(this.btnFechaHoy);
            this.Controls.Add(this.lbltxtKilos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIdHelado);
            this.Controls.Add(this.lblNroDocProveedor);
            this.Controls.Add(this.lblTipoDocProveedor);
            this.Controls.Add(this.lblRazónSocial);
            this.Controls.Add(this.cmbNroDocProveedor);
            this.Controls.Add(this.cmbTipoDocProveedor);
            this.Controls.Add(this.cmbRazonSocial);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.pckFechaCompra);
            this.Controls.Add(this.lblNuevaCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Compra";
            this.Load += new System.EventHandler(this.FrmAltaCompras_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetallesCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCompra;
        private System.Windows.Forms.DateTimePicker pckFechaCompra;
        private System.Windows.Forms.Label lblFechaCompra;
        private Clases.ComboBox01 cmbRazonSocial;
        private Clases.ComboBox01 cmbTipoDocProveedor;
        private Clases.ComboBox01 cmbNroDocProveedor;
        private System.Windows.Forms.Label lblRazónSocial;
        private System.Windows.Forms.Label lblTipoDocProveedor;
        private System.Windows.Forms.Label lblNroDocProveedor;
        private Clases.ComboBox01 cmbIdHelado;
        private System.Windows.Forms.Label label3;
        private Clases.LabelText01 lbltxtKilos;
        private System.Windows.Forms.Button btnFechaHoy;
        private Clases.TextBox01 txtPrecioHelado;
        private System.Windows.Forms.Label lblPrecioHelado;
        private System.Windows.Forms.Button btnAgregarHelado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblTxtTotal;
        private Clases.Grid01 grdDetallesCompras;
        private System.Windows.Forms.Button btnCerrar;
    }
}
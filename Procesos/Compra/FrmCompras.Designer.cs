namespace Practico.Formularios.Procesos.Compra
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.lblNuevo = new System.Windows.Forms.Label();
            this.chkBuscarPorNroComprobante = new System.Windows.Forms.CheckBox();
            this.chkBuscarPorFecha = new System.Windows.Forms.CheckBox();
            this.pckDesde = new System.Windows.Forms.DateTimePicker();
            this.pckHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.chkBuscarPorProveedor = new System.Windows.Forms.CheckBox();
            this.lblRazónSocial = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.chkBuscarTodas = new System.Windows.Forms.CheckBox();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbRazonSocial = new Practico.Clases.ComboBox01();
            this.cmbNroDocProveedor = new Practico.Clases.ComboBox01();
            this.cmbTipoDocProveedor = new Practico.Clases.ComboBox01();
            this.lbltxtNroComprobante = new Practico.Clases.LabelText01();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.grdCompras = new Practico.Clases.Grid01();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(52, 45);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(212, 23);
            this.lblNuevo.TabIndex = 29;
            this.lblNuevo.Text = "Gestión de Compras";
            // 
            // chkBuscarPorNroComprobante
            // 
            this.chkBuscarPorNroComprobante.AutoSize = true;
            this.chkBuscarPorNroComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBuscarPorNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkBuscarPorNroComprobante.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBuscarPorNroComprobante.Location = new System.Drawing.Point(12, 4);
            this.chkBuscarPorNroComprobante.Name = "chkBuscarPorNroComprobante";
            this.chkBuscarPorNroComprobante.Size = new System.Drawing.Size(244, 20);
            this.chkBuscarPorNroComprobante.TabIndex = 0;
            this.chkBuscarPorNroComprobante.Text = "Buscar por Número de Comprobante";
            this.chkBuscarPorNroComprobante.UseVisualStyleBackColor = true;
            this.chkBuscarPorNroComprobante.CheckedChanged += new System.EventHandler(this.chkBuscarPorNroComprobante_CheckedChanged);
            // 
            // chkBuscarPorFecha
            // 
            this.chkBuscarPorFecha.AutoSize = true;
            this.chkBuscarPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBuscarPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkBuscarPorFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBuscarPorFecha.Location = new System.Drawing.Point(12, 79);
            this.chkBuscarPorFecha.Name = "chkBuscarPorFecha";
            this.chkBuscarPorFecha.Size = new System.Drawing.Size(130, 20);
            this.chkBuscarPorFecha.TabIndex = 2;
            this.chkBuscarPorFecha.Text = "Buscar por Fecha";
            this.chkBuscarPorFecha.UseVisualStyleBackColor = true;
            this.chkBuscarPorFecha.CheckedChanged += new System.EventHandler(this.chkBuscarPorFecha_CheckedChanged);
            // 
            // pckDesde
            // 
            this.pckDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckDesde.Location = new System.Drawing.Point(183, 116);
            this.pckDesde.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckDesde.Name = "pckDesde";
            this.pckDesde.Size = new System.Drawing.Size(112, 20);
            this.pckDesde.TabIndex = 3;
            this.pckDesde.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // pckHasta
            // 
            this.pckHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckHasta.Location = new System.Drawing.Point(183, 142);
            this.pckHasta.MaxDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.pckHasta.Name = "pckHasta";
            this.pckHasta.Size = new System.Drawing.Size(112, 20);
            this.pckHasta.TabIndex = 4;
            this.pckHasta.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesde.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDesde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesde.Location = new System.Drawing.Point(67, 116);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(104, 19);
            this.lblDesde.TabIndex = 77;
            this.lblDesde.Text = "Fecha Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHasta.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHasta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHasta.Location = new System.Drawing.Point(70, 142);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(101, 19);
            this.lblHasta.TabIndex = 78;
            this.lblHasta.Text = "Fecha Hasta:";
            // 
            // chkBuscarPorProveedor
            // 
            this.chkBuscarPorProveedor.AutoSize = true;
            this.chkBuscarPorProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBuscarPorProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkBuscarPorProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBuscarPorProveedor.Location = new System.Drawing.Point(12, 185);
            this.chkBuscarPorProveedor.Name = "chkBuscarPorProveedor";
            this.chkBuscarPorProveedor.Size = new System.Drawing.Size(156, 20);
            this.chkBuscarPorProveedor.TabIndex = 5;
            this.chkBuscarPorProveedor.Text = "Buscar por Proveedor";
            this.chkBuscarPorProveedor.UseVisualStyleBackColor = true;
            this.chkBuscarPorProveedor.CheckedChanged += new System.EventHandler(this.chkBuscarPorProveedor_CheckedChanged);
            // 
            // lblRazónSocial
            // 
            this.lblRazónSocial.AutoSize = true;
            this.lblRazónSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazónSocial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRazónSocial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRazónSocial.Location = new System.Drawing.Point(67, 219);
            this.lblRazónSocial.Name = "lblRazónSocial";
            this.lblRazónSocial.Size = new System.Drawing.Size(101, 19);
            this.lblRazónSocial.TabIndex = 83;
            this.lblRazónSocial.Text = "Razón Social:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipoDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoDocumento.Location = new System.Drawing.Point(42, 252);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(126, 19);
            this.lblTipoDocumento.TabIndex = 84;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNroDocumento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNroDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNroDocumento.Location = new System.Drawing.Point(46, 285);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(122, 19);
            this.lblNroDocumento.TabIndex = 85;
            this.lblNroDocumento.Text = "Nro Documento:";
            // 
            // chkBuscarTodas
            // 
            this.chkBuscarTodas.AutoSize = true;
            this.chkBuscarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBuscarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkBuscarTodas.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBuscarTodas.Location = new System.Drawing.Point(12, 324);
            this.chkBuscarTodas.Name = "chkBuscarTodas";
            this.chkBuscarTodas.Size = new System.Drawing.Size(192, 20);
            this.chkBuscarTodas.TabIndex = 9;
            this.chkBuscarTodas.Text = "Buscar Todas Las Compras";
            this.chkBuscarTodas.UseVisualStyleBackColor = true;
            this.chkBuscarTodas.CheckedChanged += new System.EventHandler(this.chkBuscarTodas_CheckedChanged);
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
            this.btnEscritorio.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEscritorio.Location = new System.Drawing.Point(843, 14);
            this.btnEscritorio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(166, 63);
            this.btnEscritorio.TabIndex = 2;
            this.btnEscritorio.Text = "Volver Al Escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            this.btnEscritorio.Click += new System.EventHandler(this.btnEscritorio_Click);
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
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(117, 376);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 40);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "       Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(183, 219);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.PpDisplay = null;
            this.cmbRazonSocial.PpMensajeError = null;
            this.cmbRazonSocial.PpNombreCampo = null;
            this.cmbRazonSocial.PpNombreTabla = null;
            this.cmbRazonSocial.PpTabla = null;
            this.cmbRazonSocial.PpValidable = false;
            this.cmbRazonSocial.PpValue = null;
            this.cmbRazonSocial.Size = new System.Drawing.Size(127, 21);
            this.cmbRazonSocial.TabIndex = 6;
            this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cmbRazonSocial_SelectedIndexChanged);
            // 
            // cmbNroDocProveedor
            // 
            this.cmbNroDocProveedor.FormattingEnabled = true;
            this.cmbNroDocProveedor.Location = new System.Drawing.Point(183, 285);
            this.cmbNroDocProveedor.Name = "cmbNroDocProveedor";
            this.cmbNroDocProveedor.PpDisplay = null;
            this.cmbNroDocProveedor.PpMensajeError = null;
            this.cmbNroDocProveedor.PpNombreCampo = null;
            this.cmbNroDocProveedor.PpNombreTabla = null;
            this.cmbNroDocProveedor.PpTabla = null;
            this.cmbNroDocProveedor.PpValidable = false;
            this.cmbNroDocProveedor.PpValue = null;
            this.cmbNroDocProveedor.Size = new System.Drawing.Size(127, 21);
            this.cmbNroDocProveedor.TabIndex = 8;
            // 
            // cmbTipoDocProveedor
            // 
            this.cmbTipoDocProveedor.FormattingEnabled = true;
            this.cmbTipoDocProveedor.Location = new System.Drawing.Point(183, 251);
            this.cmbTipoDocProveedor.Name = "cmbTipoDocProveedor";
            this.cmbTipoDocProveedor.PpDisplay = null;
            this.cmbTipoDocProveedor.PpMensajeError = null;
            this.cmbTipoDocProveedor.PpNombreCampo = null;
            this.cmbTipoDocProveedor.PpNombreTabla = null;
            this.cmbTipoDocProveedor.PpTabla = null;
            this.cmbTipoDocProveedor.PpValidable = false;
            this.cmbTipoDocProveedor.PpValue = null;
            this.cmbTipoDocProveedor.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoDocProveedor.TabIndex = 7;
            this.cmbTipoDocProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocProveedor_SelectedIndexChanged);
            // 
            // lbltxtNroComprobante
            // 
            this.lbltxtNroComprobante.BackColor = System.Drawing.Color.Transparent;
            this.lbltxtNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtNroComprobante.Location = new System.Drawing.Point(28, 31);
            this.lbltxtNroComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.lbltxtNroComprobante.Name = "lbltxtNroComprobante";
            this.lbltxtNroComprobante.PpEtiqueta = "Nro Comprobante:";
            this.lbltxtNroComprobante.PpMask = "9999";
            this.lbltxtNroComprobante.PpMensajeError = null;
            this.lbltxtNroComprobante.PpNombreCampo = "NroComprobante";
            this.lbltxtNroComprobante.PpNombreTabla = "Compras";
            this.lbltxtNroComprobante.PpText = "";
            this.lbltxtNroComprobante.PpValidable = false;
            this.lbltxtNroComprobante.Size = new System.Drawing.Size(228, 28);
            this.lbltxtNroComprobante.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.chkBuscarTodas);
            this.panel5.Controls.Add(this.cmbNroDocProveedor);
            this.panel5.Controls.Add(this.btnBuscar);
            this.panel5.Controls.Add(this.lblTipoDocumento);
            this.panel5.Controls.Add(this.lblNroDocumento);
            this.panel5.Controls.Add(this.cmbRazonSocial);
            this.panel5.Controls.Add(this.cmbTipoDocProveedor);
            this.panel5.Controls.Add(this.lblRazónSocial);
            this.panel5.Controls.Add(this.chkBuscarPorProveedor);
            this.panel5.Controls.Add(this.pckHasta);
            this.panel5.Controls.Add(this.lblHasta);
            this.panel5.Controls.Add(this.pckDesde);
            this.panel5.Controls.Add(this.lblDesde);
            this.panel5.Controls.Add(this.chkBuscarPorFecha);
            this.panel5.Controls.Add(this.lbltxtNroComprobante);
            this.panel5.Controls.Add(this.chkBuscarPorNroComprobante);
            this.panel5.Location = new System.Drawing.Point(56, 98);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 430);
            this.panel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevaVenta);
            this.panel1.Location = new System.Drawing.Point(428, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultar.Image = global::Practico.Properties.Resources.magnifying_glass;
            this.btnConsultar.Location = new System.Drawing.Point(364, 10);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(179, 40);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar Compra";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Image = global::Practico.Properties.Resources.iconfinder_website___pencil_3440848;
            this.btnModificar.Location = new System.Drawing.Point(175, 10);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(181, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Compra";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNuevaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnNuevaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevaVenta.Image = global::Practico.Properties.Resources.add_to_cart1;
            this.btnNuevaVenta.Location = new System.Drawing.Point(4, 10);
            this.btnNuevaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(163, 40);
            this.btnNuevaVenta.TabIndex = 0;
            this.btnNuevaVenta.Text = "Nueva Compra";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // grdCompras
            // 
            this.grdCompras.AllowUserToAddRows = false;
            this.grdCompras.AllowUserToDeleteRows = false;
            this.grdCompras.AllowUserToResizeColumns = false;
            this.grdCompras.AllowUserToResizeRows = false;
            this.grdCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdCompras.Location = new System.Drawing.Point(428, 102);
            this.grdCompras.Name = "grdCompras";
            this.grdCompras.ReadOnly = true;
            this.grdCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCompras.Size = new System.Drawing.Size(509, 275);
            this.grdCompras.TabIndex = 95;
            this.grdCompras.tabla = null;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1024, 554);
            this.Controls.Add(this.grdCompras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnEscritorio);
            this.Controls.Add(this.lblNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.CheckBox chkBuscarPorNroComprobante;
        private System.Windows.Forms.CheckBox chkBuscarPorFecha;
        private System.Windows.Forms.DateTimePicker pckDesde;
        private System.Windows.Forms.DateTimePicker pckHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.CheckBox chkBuscarPorProveedor;
        private Clases.ComboBox01 cmbRazonSocial;
        private Clases.ComboBox01 cmbTipoDocProveedor;
        private Clases.ComboBox01 cmbNroDocProveedor;
        private System.Windows.Forms.Label lblRazónSocial;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.CheckBox chkBuscarTodas;
        private Clases.LabelText01 lbltxtNroComprobante;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevaVenta;
        private Clases.Grid01 grdCompras;
        private System.Windows.Forms.Button btnConsultar;
    }
}
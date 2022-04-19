namespace Practico
{
    partial class FrmEscritorio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscritorio));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnListados = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.pnlProcesos = new System.Windows.Forms.Panel();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnVerConsultas = new System.Windows.Forms.Button();
            this.btnVerVacunas = new System.Windows.Forms.Button();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlEscritorio = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlProcesos.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.pnlEscritorio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.btnAdministracion);
            this.pnlMenu.Controls.Add(this.btnListados);
            this.pnlMenu.Controls.Add(this.btnEstadisticas);
            this.pnlMenu.Controls.Add(this.pnlProcesos);
            this.pnlMenu.Controls.Add(this.btnProcesos);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 526);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdministracion.Image = global::Practico.Properties.Resources.btnConfiguracion;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 293);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(200, 45);
            this.btnAdministracion.TabIndex = 4;
            this.btnAdministracion.Text = "Administracion";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnListados
            // 
            this.btnListados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnListados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListados.FlatAppearance.BorderSize = 0;
            this.btnListados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnListados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnListados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListados.Image = global::Practico.Properties.Resources.btnListados;
            this.btnListados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListados.Location = new System.Drawing.Point(0, 248);
            this.btnListados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListados.Name = "btnListados";
            this.btnListados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListados.Size = new System.Drawing.Size(200, 45);
            this.btnListados.TabIndex = 3;
            this.btnListados.Text = "Listados";
            this.btnListados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListados.UseVisualStyleBackColor = false;
            this.btnListados.Click += new System.EventHandler(this.btnListados_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEstadisticas.Image = global::Practico.Properties.Resources.btnInformes;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 203);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstadisticas.Size = new System.Drawing.Size(200, 45);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // pnlProcesos
            // 
            this.pnlProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlProcesos.Controls.Add(this.btnCompra);
            this.pnlProcesos.Controls.Add(this.btnConsulta);
            this.pnlProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcesos.Location = new System.Drawing.Point(0, 107);
            this.pnlProcesos.Name = "pnlProcesos";
            this.pnlProcesos.Size = new System.Drawing.Size(200, 96);
            this.pnlProcesos.TabIndex = 10;
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(0, 40);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCompra.Size = new System.Drawing.Size(200, 50);
            this.btnCompra.TabIndex = 12;
            this.btnCompra.Text = "Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsulta.Size = new System.Drawing.Size(200, 40);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Venta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesos.FlatAppearance.BorderSize = 0;
            this.btnProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnProcesos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesos.Image = global::Practico.Properties.Resources.cajaRegitradoraNueva;
            this.btnProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.Location = new System.Drawing.Point(0, 62);
            this.btnProcesos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProcesos.Size = new System.Drawing.Size(200, 45);
            this.btnProcesos.TabIndex = 1;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesos.UseVisualStyleBackColor = false;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlLogo.Controls.Add(this.lblUsuario);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 62);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Image = global::Practico.Properties.Resources.usuarioMini;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(45, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(137, 44);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVerConsultas
            // 
            this.btnVerConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVerConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerConsultas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerConsultas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerConsultas.Location = new System.Drawing.Point(1176, 232);
            this.btnVerConsultas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerConsultas.Name = "btnVerConsultas";
            this.btnVerConsultas.Size = new System.Drawing.Size(241, 98);
            this.btnVerConsultas.TabIndex = 4;
            this.btnVerConsultas.Text = "Ver Consultas";
            this.btnVerConsultas.UseVisualStyleBackColor = false;
            // 
            // btnVerVacunas
            // 
            this.btnVerVacunas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerVacunas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerVacunas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerVacunas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerVacunas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVerVacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVacunas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVacunas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerVacunas.Location = new System.Drawing.Point(1176, 447);
            this.btnVerVacunas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerVacunas.Name = "btnVerVacunas";
            this.btnVerVacunas.Size = new System.Drawing.Size(241, 98);
            this.btnVerVacunas.TabIndex = 6;
            this.btnVerVacunas.Text = "Ver Vacunas";
            this.btnVerVacunas.UseVisualStyleBackColor = false;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarra.Controls.Add(this.lblFechaHora);
            this.pnlBarra.Controls.Add(this.label2);
            this.pnlBarra.Controls.Add(this.btnSalir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(200, 0);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(729, 40);
            this.pnlBarra.TabIndex = 9;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblFechaHora.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFechaHora.Location = new System.Drawing.Point(164, 9);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 23);
            this.lblFechaHora.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha y Hora:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Practico.Properties.Resources.btnSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(642, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 38);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlEscritorio
            // 
            this.pnlEscritorio.AutoScroll = true;
            this.pnlEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnlEscritorio.Controls.Add(this.panel1);
            this.pnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEscritorio.Location = new System.Drawing.Point(200, 40);
            this.pnlEscritorio.Name = "pnlEscritorio";
            this.pnlEscritorio.Size = new System.Drawing.Size(729, 486);
            this.pnlEscritorio.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(156, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 290);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Heladeria Tu Gusto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Practico.Properties.Resources.iceCream;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(96, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 207);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Interval = 1000;
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // FrmEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 526);
            this.Controls.Add(this.pnlEscritorio);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.btnVerVacunas);
            this.Controls.Add(this.btnVerConsultas);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEscritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Heladeria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEscritorio_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlProcesos.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlEscritorio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVerConsultas;
        private System.Windows.Forms.Button btnVerVacunas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Panel pnlProcesos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnListados;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Panel pnlEscritorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


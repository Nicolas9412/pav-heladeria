namespace Practico.Formularios.Abm.HeladosEspeciales
{
    partial class FrmEliminarHeladosEspeciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarHeladosEspeciales));
            this.lblEliminarHeladoEspecial = new System.Windows.Forms.Label();
            this.txtStock = new Practico.Clases.TextBox01();
            this.txtPrecio = new Practico.Clases.TextBox01();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreHeladoEspecial = new System.Windows.Forms.Label();
            this.txtId = new Practico.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEliminarHeladoEspecial
            // 
            this.lblEliminarHeladoEspecial.AutoSize = true;
            this.lblEliminarHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminarHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblEliminarHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEliminarHeladoEspecial.Location = new System.Drawing.Point(34, 42);
            this.lblEliminarHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEliminarHeladoEspecial.Name = "lblEliminarHeladoEspecial";
            this.lblEliminarHeladoEspecial.Size = new System.Drawing.Size(249, 23);
            this.lblEliminarHeladoEspecial.TabIndex = 20;
            this.lblEliminarHeladoEspecial.Text = "Eliminar Helado Especial";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(268, 193);
            this.txtStock.Name = "txtStock";
            this.txtStock.PpMensajeError = "Ingrese el stock!";
            this.txtStock.PpNombreCampo = "cantidadStock";
            this.txtStock.PpNombreTabla = "HeladosEspeciales";
            this.txtStock.PpValidable = false;
            this.txtStock.Size = new System.Drawing.Size(65, 24);
            this.txtStock.TabIndex = 56;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(268, 163);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PpMensajeError = "Ingrese el precio!";
            this.txtPrecio.PpNombreCampo = "precio";
            this.txtPrecio.PpNombreTabla = "HeladosEspeciales";
            this.txtPrecio.PpValidable = true;
            this.txtPrecio.Size = new System.Drawing.Size(65, 24);
            this.txtPrecio.TabIndex = 55;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(268, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "Ingrese un nombre!";
            this.txtNombre.PpNombreCampo = "nombreProducto";
            this.txtNombre.PpNombreTabla = "HeladosEspeciales";
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(161, 24);
            this.txtNombre.TabIndex = 54;
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
            this.btnCancelar.Location = new System.Drawing.Point(155, 234);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 50;
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
            this.btnAceptar.Location = new System.Drawing.Point(268, 234);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 49;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStock.Location = new System.Drawing.Point(216, 198);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 19);
            this.lblStock.TabIndex = 53;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(211, 168);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 52;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombreHeladoEspecial
            // 
            this.lblNombreHeladoEspecial.AutoSize = true;
            this.lblNombreHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombreHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreHeladoEspecial.Location = new System.Drawing.Point(198, 139);
            this.lblNombreHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreHeladoEspecial.Name = "lblNombreHeladoEspecial";
            this.lblNombreHeladoEspecial.Size = new System.Drawing.Size(68, 19);
            this.lblNombreHeladoEspecial.TabIndex = 51;
            this.lblNombreHeladoEspecial.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(268, 103);
            this.txtId.Name = "txtId";
            this.txtId.PpMensajeError = "Ingrese un nombre!";
            this.txtId.PpNombreCampo = "nombreProducto";
            this.txtId.PpNombreTabla = "HeladosEspeciales";
            this.txtId.PpValidable = true;
            this.txtId.Size = new System.Drawing.Size(65, 24);
            this.txtId.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(235, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Id:";
            // 
            // FrmEliminarHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(578, 320);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreHeladoEspecial);
            this.Controls.Add(this.lblEliminarHeladoEspecial);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEliminarHeladosEspeciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Helado Especial";
            this.Load += new System.EventHandler(this.FrmModificarHeladosEspeciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarHeladoEspecial;
        private Clases.TextBox01 txtStock;
        private Clases.TextBox01 txtPrecio;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreHeladoEspecial;
        private Clases.TextBox01 txtId;
        private System.Windows.Forms.Label label1;
    }
}
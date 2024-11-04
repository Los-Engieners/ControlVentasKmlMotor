namespace ControlVentasKmlMotor.UI.WindowsForms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.menuCliente = new FontAwesome.Sharp.IconMenuItem();
            this.menuAutomovil = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuSucursales = new FontAwesome.Sharp.IconMenuItem();
            this.menuCuentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenucuenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCuotas = new FontAwesome.Sharp.IconMenuItem();
            this.menuCuotas = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.registrarsubMenuServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.cerrarSesionButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(997, 50);
            this.menuTitulo.TabIndex = 3;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tituloLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloLabel.Location = new System.Drawing.Point(86, 13);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tituloLabel.Size = new System.Drawing.Size(158, 17);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Sistema Control Ventas";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(661, 11);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombreUsuario.Size = new System.Drawing.Size(186, 19);
            this.labelNombreUsuario.TabIndex = 10;
            this.labelNombreUsuario.Text = "Bienvenido";
            this.labelNombreUsuario.Click += new System.EventHandler(this.labelNombreUsuario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmpleados,
            this.menuCliente,
            this.menuAutomovil,
            this.menuVentas,
            this.menuSucursales,
            this.menuCuentas,
            this.menuCuotas,
            this.menuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 55);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.menuEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEmpleados.IconSize = 30;
            this.menuEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(85, 51);
            this.menuEmpleados.Text = "Empleados";
            this.menuEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEmpleados.Click += new System.EventHandler(this.menuEmpleados_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.menuCliente.IconColor = System.Drawing.Color.Black;
            this.menuCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCliente.IconSize = 30;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(68, 51);
            this.menuCliente.Text = "Clientes";
            this.menuCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuAutomovil
            // 
            this.menuAutomovil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuModelo,
            this.subMenuMarca});
            this.menuAutomovil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAutomovil.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.menuAutomovil.IconColor = System.Drawing.Color.Black;
            this.menuAutomovil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAutomovil.IconSize = 30;
            this.menuAutomovil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAutomovil.Name = "menuAutomovil";
            this.menuAutomovil.Size = new System.Drawing.Size(78, 51);
            this.menuAutomovil.Text = "Vehículos";
            this.menuAutomovil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAutomovil.Click += new System.EventHandler(this.menuAutomovil_Click);
            // 
            // subMenuModelo
            // 
            this.subMenuModelo.Name = "subMenuModelo";
            this.subMenuModelo.Size = new System.Drawing.Size(300, 22);
            this.subMenuModelo.Text = "Registro y mantenimiento de Modelos";
            this.subMenuModelo.Click += new System.EventHandler(this.subMenuModelo_Click);
            // 
            // subMenuMarca
            // 
            this.subMenuMarca.Name = "subMenuMarca";
            this.subMenuMarca.Size = new System.Drawing.Size(300, 22);
            this.subMenuMarca.Text = "Registro de Marcas";
            this.subMenuMarca.Click += new System.EventHandler(this.subMenuMarca_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuVenta,
            this.subMenuDetalleVenta});
            this.menuVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 30;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(62, 51);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuVenta
            // 
            this.subMenuVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVenta.Name = "subMenuVenta";
            this.subMenuVenta.Size = new System.Drawing.Size(165, 22);
            this.subMenuVenta.Text = "Ventas";
            // 
            // subMenuDetalleVenta
            // 
            this.subMenuDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDetalleVenta.Name = "subMenuDetalleVenta";
            this.subMenuDetalleVenta.Size = new System.Drawing.Size(165, 22);
            this.subMenuDetalleVenta.Text = "Detalles Venta";
            // 
            // menuSucursales
            // 
            this.menuSucursales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSucursales.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.menuSucursales.IconColor = System.Drawing.Color.Black;
            this.menuSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSucursales.IconSize = 30;
            this.menuSucursales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSucursales.Name = "menuSucursales";
            this.menuSucursales.Size = new System.Drawing.Size(82, 51);
            this.menuSucursales.Text = "Sucursales";
            this.menuSucursales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSucursales.Click += new System.EventHandler(this.menuSucursales_Click);
            // 
            // menuCuentas
            // 
            this.menuCuentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenucuenta,
            this.subMenuCuotas});
            this.menuCuentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCuentas.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuCuentas.IconColor = System.Drawing.Color.Black;
            this.menuCuentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCuentas.IconSize = 30;
            this.menuCuentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCuentas.Name = "menuCuentas";
            this.menuCuentas.Size = new System.Drawing.Size(69, 51);
            this.menuCuentas.Text = "Cuentas";
            this.menuCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenucuenta
            // 
            this.subMenucuenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenucuenta.IconColor = System.Drawing.Color.Black;
            this.subMenucuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenucuenta.Name = "subMenucuenta";
            this.subMenucuenta.Size = new System.Drawing.Size(238, 22);
            this.subMenucuenta.Text = "Registrar Cuentas";
            // 
            // subMenuCuotas
            // 
            this.subMenuCuotas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCuotas.IconColor = System.Drawing.Color.Black;
            this.subMenuCuotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCuotas.Name = "subMenuCuotas";
            this.subMenuCuotas.Size = new System.Drawing.Size(238, 22);
            this.subMenuCuotas.Text = "Mantenimiento de Cuentas";
            // 
            // menuCuotas
            // 
            this.menuCuotas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCuotas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.menuCuotas.IconColor = System.Drawing.Color.Black;
            this.menuCuotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCuotas.IconSize = 30;
            this.menuCuotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCuotas.Name = "menuCuotas";
            this.menuCuotas.Size = new System.Drawing.Size(62, 51);
            this.menuCuotas.Text = "Cuotas";
            this.menuCuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarsubMenuServicio});
            this.menuReportes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BriefcaseMedical;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 30;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(111, 51);
            this.menuReportes.Text = "Servicios Extras";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarsubMenuServicio
            // 
            this.registrarsubMenuServicio.Name = "registrarsubMenuServicio";
            this.registrarsubMenuServicio.Size = new System.Drawing.Size(180, 22);
            this.registrarsubMenuServicio.Text = "Registrar Servicio";
            this.registrarsubMenuServicio.Click += new System.EventHandler(this.registrarsubMenuServicio_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 105);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(997, 518);
            this.contenedor.TabIndex = 13;
            // 
            // cerrarSesionButton
            // 
            this.cerrarSesionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cerrarSesionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarSesionButton.FlatAppearance.BorderSize = 0;
            this.cerrarSesionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesionButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrarSesionButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.cerrarSesionButton.IconColor = System.Drawing.Color.White;
            this.cerrarSesionButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.cerrarSesionButton.IconSize = 18;
            this.cerrarSesionButton.Location = new System.Drawing.Point(862, 6);
            this.cerrarSesionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Size = new System.Drawing.Size(131, 29);
            this.cerrarSesionButton.TabIndex = 54;
            this.cerrarSesionButton.Text = "CERRAR SESIÓN";
            this.cerrarSesionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarSesionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarSesionButton.UseVisualStyleBackColor = false;
            this.cerrarSesionButton.Click += new System.EventHandler(this.cerrarSesionButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.pictureBox1.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.logo_kml_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(997, 623);
            this.Controls.Add(this.cerrarSesionButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KML Motor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem menuCliente;
        private FontAwesome.Sharp.IconMenuItem menuAutomovil;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem subMenuVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem menuCuentas;
        private FontAwesome.Sharp.IconMenuItem subMenucuenta;
        private FontAwesome.Sharp.IconMenuItem subMenuCuotas;
        private FontAwesome.Sharp.IconMenuItem menuSucursales;
        private FontAwesome.Sharp.IconMenuItem menuCuotas;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton cerrarSesionButton;
        private System.Windows.Forms.ToolStripMenuItem subMenuModelo;
        private System.Windows.Forms.ToolStripMenuItem subMenuMarca;
        private System.Windows.Forms.ToolStripMenuItem registrarsubMenuServicio;
    }
}
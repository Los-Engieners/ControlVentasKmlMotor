namespace ControlVentasKmlMotor.UI.WindowsForms.Mantenimiento
{
    partial class MainEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEmpleado));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.generoLabel = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.comboBoxSucursal = new System.Windows.Forms.ComboBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.nombreEmpleadoLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoEmpleadoLabel = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.correoLabel = new System.Windows.Forms.Label();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.claveLabel = new System.Windows.Forms.Label();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.cancelarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmarClave = new System.Windows.Forms.Label();
            this.confirmarClaveTextBox = new System.Windows.Forms.TextBox();
            this.ocultarClavePictureBox = new System.Windows.Forms.PictureBox();
            this.verClavePictureBox = new System.Windows.Forms.PictureBox();
            this.ocultarPictureBox = new System.Windows.Forms.PictureBox();
            this.verPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarClavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(95, 55);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(197, 19);
            this.tituloLabel.TabIndex = 22;
            this.tituloLabel.Text = "REGISTRO DE EMPLEADOS";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(363, 42);
            this.menuTitulo.TabIndex = 39;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sistema Control Ventas";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.generoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoLabel.Location = new System.Drawing.Point(47, 83);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(51, 16);
            this.generoLabel.TabIndex = 42;
            this.generoLabel.Text = "Genero:";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(46, 103);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(278, 24);
            this.comboBoxGenero.TabIndex = 43;
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSucursal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucursal.Location = new System.Drawing.Point(47, 131);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(54, 16);
            this.labelSucursal.TabIndex = 46;
            this.labelSucursal.Text = "Sucursal:";
            this.labelSucursal.Click += new System.EventHandler(this.labelSucursal_Click);
            // 
            // comboBoxSucursal
            // 
            this.comboBoxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSucursal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSucursal.FormattingEnabled = true;
            this.comboBoxSucursal.Location = new System.Drawing.Point(46, 151);
            this.comboBoxSucursal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSucursal.Name = "comboBoxSucursal";
            this.comboBoxSucursal.Size = new System.Drawing.Size(278, 24);
            this.comboBoxSucursal.TabIndex = 47;
            this.comboBoxSucursal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSucursal_SelectedIndexChanged);
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.Location = new System.Drawing.Point(47, 179);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(44, 16);
            this.labelCargo.TabIndex = 48;
            this.labelCargo.Text = "Cargo:";
            this.labelCargo.Click += new System.EventHandler(this.labelCargo_Click);
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(46, 199);
            this.comboBoxCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(278, 24);
            this.comboBoxCargo.TabIndex = 49;
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargo_SelectedIndexChanged);
            // 
            // nombreEmpleadoLabel
            // 
            this.nombreEmpleadoLabel.AutoSize = true;
            this.nombreEmpleadoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nombreEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleadoLabel.Location = new System.Drawing.Point(43, 227);
            this.nombreEmpleadoLabel.Name = "nombreEmpleadoLabel";
            this.nombreEmpleadoLabel.Size = new System.Drawing.Size(53, 16);
            this.nombreEmpleadoLabel.TabIndex = 50;
            this.nombreEmpleadoLabel.Text = "Nombre:";
            this.nombreEmpleadoLabel.Click += new System.EventHandler(this.nombreEmpleadoLabel_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(46, 247);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(278, 21);
            this.nombreTextBox.TabIndex = 51;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // apellidoEmpleadoLabel
            // 
            this.apellidoEmpleadoLabel.AutoSize = true;
            this.apellidoEmpleadoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.apellidoEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoEmpleadoLabel.Location = new System.Drawing.Point(44, 272);
            this.apellidoEmpleadoLabel.Name = "apellidoEmpleadoLabel";
            this.apellidoEmpleadoLabel.Size = new System.Drawing.Size(57, 16);
            this.apellidoEmpleadoLabel.TabIndex = 52;
            this.apellidoEmpleadoLabel.Text = "Apellidos:";
            this.apellidoEmpleadoLabel.Click += new System.EventHandler(this.apellidoEmpleadoLabel_Click);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(46, 292);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(278, 21);
            this.apellidoTextBox.TabIndex = 53;
            this.apellidoTextBox.TextChanged += new System.EventHandler(this.apellidoTextBox_TextChanged);
            // 
            // correoLabel
            // 
            this.correoLabel.AutoSize = true;
            this.correoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.correoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoLabel.Location = new System.Drawing.Point(43, 326);
            this.correoLabel.Name = "correoLabel";
            this.correoLabel.Size = new System.Drawing.Size(108, 16);
            this.correoLabel.TabIndex = 54;
            this.correoLabel.Text = "Correo Electrónico:";
            this.correoLabel.Click += new System.EventHandler(this.correoLabel_Click);
            // 
            // correoTextBox
            // 
            this.correoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(46, 346);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(278, 21);
            this.correoTextBox.TabIndex = 55;
            this.correoTextBox.TextChanged += new System.EventHandler(this.correoTextBox_TextChanged);
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.claveLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveLabel.Location = new System.Drawing.Point(47, 371);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(44, 16);
            this.claveLabel.TabIndex = 56;
            this.claveLabel.Text = "Clave:";
            this.claveLabel.Click += new System.EventHandler(this.claveLabel_Click);
            // 
            // claveTextBox
            // 
            this.claveTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTextBox.Location = new System.Drawing.Point(46, 393);
            this.claveTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(278, 21);
            this.claveTextBox.TabIndex = 57;
            this.claveTextBox.TextChanged += new System.EventHandler(this.claveTextBox_TextChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
            this.buttonGuardar.IconColor = System.Drawing.Color.White;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuardar.IconSize = 18;
            this.buttonGuardar.Location = new System.Drawing.Point(46, 486);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(278, 40);
            this.buttonGuardar.TabIndex = 58;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.Firebrick;
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelarButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.cancelarButton.IconColor = System.Drawing.Color.White;
            this.cancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelarButton.IconSize = 18;
            this.cancelarButton.Location = new System.Drawing.Point(46, 534);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(278, 39);
            this.cancelarButton.TabIndex = 59;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // confirmarClave
            // 
            this.confirmarClave.AutoSize = true;
            this.confirmarClave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confirmarClave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClave.Location = new System.Drawing.Point(47, 418);
            this.confirmarClave.Name = "confirmarClave";
            this.confirmarClave.Size = new System.Drawing.Size(99, 16);
            this.confirmarClave.TabIndex = 60;
            this.confirmarClave.Text = "Confirmar Clave:";
            this.confirmarClave.Click += new System.EventHandler(this.confirmarClave_Click);
            // 
            // confirmarClaveTextBox
            // 
            this.confirmarClaveTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClaveTextBox.Location = new System.Drawing.Point(46, 438);
            this.confirmarClaveTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmarClaveTextBox.Name = "confirmarClaveTextBox";
            this.confirmarClaveTextBox.PasswordChar = '*';
            this.confirmarClaveTextBox.Size = new System.Drawing.Size(278, 21);
            this.confirmarClaveTextBox.TabIndex = 61;
            this.confirmarClaveTextBox.TextChanged += new System.EventHandler(this.confirmarClaveTextBox_TextChanged);
            // 
            // ocultarClavePictureBox
            // 
            this.ocultarClavePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultarClavePictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.ocultar_contraseña;
            this.ocultarClavePictureBox.Location = new System.Drawing.Point(318, 393);
            this.ocultarClavePictureBox.Name = "ocultarClavePictureBox";
            this.ocultarClavePictureBox.Size = new System.Drawing.Size(33, 21);
            this.ocultarClavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultarClavePictureBox.TabIndex = 62;
            this.ocultarClavePictureBox.TabStop = false;
            this.ocultarClavePictureBox.Click += new System.EventHandler(this.ocultarClavePictureBox_Click);
            // 
            // verClavePictureBox
            // 
            this.verClavePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verClavePictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.ver_contraseña;
            this.verClavePictureBox.Location = new System.Drawing.Point(316, 393);
            this.verClavePictureBox.Name = "verClavePictureBox";
            this.verClavePictureBox.Size = new System.Drawing.Size(35, 21);
            this.verClavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verClavePictureBox.TabIndex = 63;
            this.verClavePictureBox.TabStop = false;
            this.verClavePictureBox.Click += new System.EventHandler(this.verClavePictureBox_Click);
            // 
            // ocultarPictureBox
            // 
            this.ocultarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultarPictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.ocultar_contraseña;
            this.ocultarPictureBox.Location = new System.Drawing.Point(318, 438);
            this.ocultarPictureBox.Name = "ocultarPictureBox";
            this.ocultarPictureBox.Size = new System.Drawing.Size(33, 21);
            this.ocultarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultarPictureBox.TabIndex = 64;
            this.ocultarPictureBox.TabStop = false;
            this.ocultarPictureBox.Click += new System.EventHandler(this.ocultarPictureBox_Click);
            // 
            // verPictureBox
            // 
            this.verPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verPictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.ver_contraseña;
            this.verPictureBox.Location = new System.Drawing.Point(316, 438);
            this.verPictureBox.Name = "verPictureBox";
            this.verPictureBox.Size = new System.Drawing.Size(35, 21);
            this.verPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verPictureBox.TabIndex = 65;
            this.verPictureBox.TabStop = false;
            this.verPictureBox.Click += new System.EventHandler(this.verPictureBox_Click);
            // 
            // MainEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 586);
            this.Controls.Add(this.verPictureBox);
            this.Controls.Add(this.ocultarPictureBox);
            this.Controls.Add(this.verClavePictureBox);
            this.Controls.Add(this.ocultarClavePictureBox);
            this.Controls.Add(this.confirmarClaveTextBox);
            this.Controls.Add(this.confirmarClave);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.correoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.apellidoEmpleadoLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreEmpleadoLabel);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.comboBoxSucursal);
            this.Controls.Add(this.labelSucursal);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Empleados";
            this.Load += new System.EventHandler(this.MainEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarClavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.ComboBox comboBoxSucursal;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label nombreEmpleadoLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label apellidoEmpleadoLabel;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label correoLabel;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.TextBox claveTextBox;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private FontAwesome.Sharp.IconButton cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox confirmarClaveTextBox;
        private System.Windows.Forms.Label confirmarClave;
        private System.Windows.Forms.PictureBox ocultarClavePictureBox;
        private System.Windows.Forms.PictureBox verClavePictureBox;
        private System.Windows.Forms.PictureBox verPictureBox;
        private System.Windows.Forms.PictureBox ocultarPictureBox;
    }
}
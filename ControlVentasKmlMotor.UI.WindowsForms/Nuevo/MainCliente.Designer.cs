namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    partial class MainCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCliente));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.nombreEmpleadoLabel = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.duiLabel = new System.Windows.Forms.Label();
            this.duiTextBox = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fechanacimientoLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelarButton = new FontAwesome.Sharp.IconButton();
            this.guardarButton = new FontAwesome.Sharp.IconButton();
            this.fechaNacimientoTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(363, 42);
            this.menuTitulo.TabIndex = 52;
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
            this.label1.TabIndex = 53;
            this.label1.Text = "Sistema Control Ventas";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(103, 51);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(173, 19);
            this.tituloLabel.TabIndex = 54;
            this.tituloLabel.Text = "REGISTRO DE CLIENTES";
            // 
            // nombreEmpleadoLabel
            // 
            this.nombreEmpleadoLabel.AutoSize = true;
            this.nombreEmpleadoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nombreEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleadoLabel.Location = new System.Drawing.Point(43, 89);
            this.nombreEmpleadoLabel.Name = "nombreEmpleadoLabel";
            this.nombreEmpleadoLabel.Size = new System.Drawing.Size(51, 16);
            this.nombreEmpleadoLabel.TabIndex = 55;
            this.nombreEmpleadoLabel.Text = "Genero:";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(46, 109);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(266, 24);
            this.comboBoxGenero.TabIndex = 59;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nombreLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(43, 146);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(53, 16);
            this.nombreLabel.TabIndex = 60;
            this.nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(46, 166);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(266, 21);
            this.nombreTextBox.TabIndex = 61;
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.apellidoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel.Location = new System.Drawing.Point(43, 191);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(53, 16);
            this.apellidoLabel.TabIndex = 62;
            this.apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(46, 222);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apellidoTextBox.MaxLength = 30;
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(266, 21);
            this.apellidoTextBox.TabIndex = 63;
            // 
            // duiLabel
            // 
            this.duiLabel.AutoSize = true;
            this.duiLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.duiLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duiLabel.Location = new System.Drawing.Point(43, 247);
            this.duiLabel.Name = "duiLabel";
            this.duiLabel.Size = new System.Drawing.Size(29, 16);
            this.duiLabel.TabIndex = 64;
            this.duiLabel.Text = "DUI:";
            // 
            // duiTextBox
            // 
            this.duiTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duiTextBox.Location = new System.Drawing.Point(46, 267);
            this.duiTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.duiTextBox.MaxLength = 10;
            this.duiTextBox.Name = "duiTextBox";
            this.duiTextBox.Size = new System.Drawing.Size(266, 21);
            this.duiTextBox.TabIndex = 65;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLabel.Location = new System.Drawing.Point(43, 292);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(55, 16);
            this.telefonoLabel.TabIndex = 66;
            this.telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(46, 312);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telefonoTextBox.MaxLength = 9;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(266, 21);
            this.telefonoTextBox.TabIndex = 67;
            // 
            // fechanacimientoLabel
            // 
            this.fechanacimientoLabel.AutoSize = true;
            this.fechanacimientoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fechanacimientoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechanacimientoLabel.Location = new System.Drawing.Point(43, 337);
            this.fechanacimientoLabel.Name = "fechanacimientoLabel";
            this.fechanacimientoLabel.Size = new System.Drawing.Size(127, 16);
            this.fechanacimientoLabel.TabIndex = 68;
            this.fechanacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.direccionLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.Location = new System.Drawing.Point(43, 380);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(60, 16);
            this.direccionLabel.TabIndex = 70;
            this.direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(46, 400);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.direccionTextBox.MaxLength = 50;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(266, 21);
            this.direccionTextBox.TabIndex = 71;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.Firebrick;
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelarButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.cancelarButton.IconColor = System.Drawing.Color.White;
            this.cancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelarButton.IconSize = 18;
            this.cancelarButton.Location = new System.Drawing.Point(46, 487);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(266, 39);
            this.cancelarButton.TabIndex = 73;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.Color.ForestGreen;
            this.guardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guardarButton.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
            this.guardarButton.IconColor = System.Drawing.Color.White;
            this.guardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardarButton.IconSize = 18;
            this.guardarButton.Location = new System.Drawing.Point(46, 439);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(266, 40);
            this.guardarButton.TabIndex = 72;
            this.guardarButton.Text = "GUARDAR";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // fechaNacimientoTimePicker
            // 
            this.fechaNacimientoTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimientoTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimientoTimePicker.Location = new System.Drawing.Point(46, 356);
            this.fechaNacimientoTimePicker.Name = "fechaNacimientoTimePicker";
            this.fechaNacimientoTimePicker.Size = new System.Drawing.Size(266, 21);
            this.fechaNacimientoTimePicker.TabIndex = 75;
            this.fechaNacimientoTimePicker.Value = new System.DateTime(2023, 8, 23, 0, 0, 0, 0);
            // 
            // MainCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 552);
            this.Controls.Add(this.fechaNacimientoTimePicker);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.fechanacimientoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.duiTextBox);
            this.Controls.Add(this.duiLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.nombreEmpleadoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Cliente";
            this.Load += new System.EventHandler(this.MainCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label nombreEmpleadoLabel;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label duiLabel;
        private System.Windows.Forms.TextBox duiTextBox;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Label fechanacimientoLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox direccionTextBox;
        private FontAwesome.Sharp.IconButton guardarButton;
        private FontAwesome.Sharp.IconButton cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker fechaNacimientoTimePicker;
    }
}
namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    partial class MainModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainModelo));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.comboBoxmodelo = new System.Windows.Forms.ComboBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.fechalanzamientoLabel = new System.Windows.Forms.Label();
            this.fechalanzamientoTextBox = new System.Windows.Forms.TextBox();
            this.precioLabel = new System.Windows.Forms.Label();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.existenciasLabel = new System.Windows.Forms.Label();
            this.existenciasTextBox = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.cancelarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.tipoVehiculoLabel = new System.Windows.Forms.Label();
            this.tipoVehiculoTextBox = new System.Windows.Forms.TextBox();
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
            this.tituloLabel.Location = new System.Drawing.Point(86, 57);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(195, 19);
            this.tituloLabel.TabIndex = 59;
            this.tituloLabel.Text = "REGISTRO DE  VEHíCULOS";
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modeloLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloLabel.Location = new System.Drawing.Point(49, 143);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(52, 16);
            this.modeloLabel.TabIndex = 60;
            this.modeloLabel.Text = "Modelo:";
            // 
            // comboBoxmodelo
            // 
            this.comboBoxmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxmodelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxmodelo.FormattingEnabled = true;
            this.comboBoxmodelo.Location = new System.Drawing.Point(47, 163);
            this.comboBoxmodelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxmodelo.Name = "comboBoxmodelo";
            this.comboBoxmodelo.Size = new System.Drawing.Size(272, 24);
            this.comboBoxmodelo.TabIndex = 61;
            this.comboBoxmodelo.SelectedIndexChanged += new System.EventHandler(this.comboBoxmodelo_SelectedIndexChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.colorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(49, 236);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(38, 16);
            this.colorLabel.TabIndex = 62;
            this.colorLabel.Text = "Color:";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(46, 256);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(273, 24);
            this.colorComboBox.TabIndex = 63;
            // 
            // fechalanzamientoLabel
            // 
            this.fechalanzamientoLabel.AutoSize = true;
            this.fechalanzamientoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fechalanzamientoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechalanzamientoLabel.Location = new System.Drawing.Point(49, 284);
            this.fechalanzamientoLabel.Name = "fechalanzamientoLabel";
            this.fechalanzamientoLabel.Size = new System.Drawing.Size(117, 16);
            this.fechalanzamientoLabel.TabIndex = 64;
            this.fechalanzamientoLabel.Text = "Fecha Lanzamiento:";
            // 
            // fechalanzamientoTextBox
            // 
            this.fechalanzamientoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechalanzamientoTextBox.Location = new System.Drawing.Point(47, 304);
            this.fechalanzamientoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechalanzamientoTextBox.MaxLength = 4;
            this.fechalanzamientoTextBox.Name = "fechalanzamientoTextBox";
            this.fechalanzamientoTextBox.Size = new System.Drawing.Size(272, 21);
            this.fechalanzamientoTextBox.TabIndex = 65;
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.precioLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(49, 329);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(43, 16);
            this.precioLabel.TabIndex = 68;
            this.precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(47, 349);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(272, 21);
            this.precioTextBox.TabIndex = 69;
            // 
            // existenciasLabel
            // 
            this.existenciasLabel.AutoSize = true;
            this.existenciasLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.existenciasLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciasLabel.Location = new System.Drawing.Point(49, 383);
            this.existenciasLabel.Name = "existenciasLabel";
            this.existenciasLabel.Size = new System.Drawing.Size(67, 16);
            this.existenciasLabel.TabIndex = 70;
            this.existenciasLabel.Text = "Existencias:";
            // 
            // existenciasTextBox
            // 
            this.existenciasTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciasTextBox.Location = new System.Drawing.Point(49, 403);
            this.existenciasTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.existenciasTextBox.Name = "existenciasTextBox";
            this.existenciasTextBox.Size = new System.Drawing.Size(270, 21);
            this.existenciasTextBox.TabIndex = 71;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.Unsplash;
            this.buttonGuardar.IconColor = System.Drawing.Color.White;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuardar.IconSize = 18;
            this.buttonGuardar.Location = new System.Drawing.Point(42, 449);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(277, 40);
            this.buttonGuardar.TabIndex = 72;
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
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelarButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.cancelarButton.IconColor = System.Drawing.Color.White;
            this.cancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelarButton.IconSize = 18;
            this.cancelarButton.Location = new System.Drawing.Point(39, 497);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(280, 39);
            this.cancelarButton.TabIndex = 73;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Marca:";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(49, 115);
            this.marcaComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(270, 24);
            this.marcaComboBox.TabIndex = 75;
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // tipoVehiculoLabel
            // 
            this.tipoVehiculoLabel.AutoSize = true;
            this.tipoVehiculoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tipoVehiculoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoVehiculoLabel.Location = new System.Drawing.Point(47, 191);
            this.tipoVehiculoLabel.Name = "tipoVehiculoLabel";
            this.tipoVehiculoLabel.Size = new System.Drawing.Size(102, 16);
            this.tipoVehiculoLabel.TabIndex = 76;
            this.tipoVehiculoLabel.Text = "Tipo  de Vehículo:";
            // 
            // tipoVehiculoTextBox
            // 
            this.tipoVehiculoTextBox.Enabled = false;
            this.tipoVehiculoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoVehiculoTextBox.Location = new System.Drawing.Point(46, 211);
            this.tipoVehiculoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipoVehiculoTextBox.Name = "tipoVehiculoTextBox";
            this.tipoVehiculoTextBox.Size = new System.Drawing.Size(273, 21);
            this.tipoVehiculoTextBox.TabIndex = 77;
            // 
            // MainModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 552);
            this.Controls.Add(this.tipoVehiculoTextBox);
            this.Controls.Add(this.tipoVehiculoLabel);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.existenciasTextBox);
            this.Controls.Add(this.existenciasLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.fechalanzamientoTextBox);
            this.Controls.Add(this.fechalanzamientoLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.comboBoxmodelo);
            this.Controls.Add(this.modeloLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Vehiculo ";
            this.Load += new System.EventHandler(this.MainVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.ComboBox comboBoxmodelo;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label fechalanzamientoLabel;
        private System.Windows.Forms.TextBox fechalanzamientoTextBox;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label existenciasLabel;
        private System.Windows.Forms.TextBox existenciasTextBox;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private FontAwesome.Sharp.IconButton cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipoVehiculoTextBox;
        private System.Windows.Forms.Label tipoVehiculoLabel;
    }
}
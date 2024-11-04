namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    partial class FrmModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModelo));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.marcaLabel = new System.Windows.Forms.Label();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.tipovehiculoLabel = new System.Windows.Forms.Label();
            this.tipovehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.cancelarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.menuTitulo.TabIndex = 53;
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
            this.label1.TabIndex = 54;
            this.label1.Text = "Sistema Control Ventas";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(90, 57);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(181, 19);
            this.tituloLabel.TabIndex = 60;
            this.tituloLabel.Text = "REGISTRO DE MODELOS";
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.marcaLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaLabel.Location = new System.Drawing.Point(35, 90);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(47, 16);
            this.marcaLabel.TabIndex = 75;
            this.marcaLabel.Text = "Marca:";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(32, 110);
            this.marcaComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(286, 24);
            this.marcaComboBox.TabIndex = 76;
            // 
            // tipovehiculoLabel
            // 
            this.tipovehiculoLabel.AutoSize = true;
            this.tipovehiculoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tipovehiculoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipovehiculoLabel.Location = new System.Drawing.Point(35, 148);
            this.tipovehiculoLabel.Name = "tipovehiculoLabel";
            this.tipovehiculoLabel.Size = new System.Drawing.Size(81, 16);
            this.tipovehiculoLabel.TabIndex = 77;
            this.tipovehiculoLabel.Text = "Tipo Vehiculo:";
            // 
            // tipovehiculoComboBox
            // 
            this.tipovehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipovehiculoComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipovehiculoComboBox.FormattingEnabled = true;
            this.tipovehiculoComboBox.Location = new System.Drawing.Point(32, 168);
            this.tipovehiculoComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipovehiculoComboBox.Name = "tipovehiculoComboBox";
            this.tipovehiculoComboBox.Size = new System.Drawing.Size(286, 24);
            this.tipovehiculoComboBox.TabIndex = 78;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nombreLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(35, 196);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(53, 16);
            this.nombreLabel.TabIndex = 79;
            this.nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(32, 216);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(286, 21);
            this.nombreTextBox.TabIndex = 80;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.SheetPlastic;
            this.buttonGuardar.IconColor = System.Drawing.Color.White;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuardar.IconSize = 18;
            this.buttonGuardar.Location = new System.Drawing.Point(32, 254);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(286, 40);
            this.buttonGuardar.TabIndex = 81;
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
            this.cancelarButton.Location = new System.Drawing.Point(32, 302);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(286, 39);
            this.cancelarButton.TabIndex = 82;
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
            // FrmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 364);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.tipovehiculoComboBox);
            this.Controls.Add(this.tipovehiculoLabel);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.marcaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Modelos";
            this.Load += new System.EventHandler(this.FrmModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.Label tipovehiculoLabel;
        private System.Windows.Forms.ComboBox tipovehiculoComboBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private FontAwesome.Sharp.IconButton cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
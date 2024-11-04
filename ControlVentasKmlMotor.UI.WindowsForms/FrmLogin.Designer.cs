namespace ControlVentasKmlMotor.UI.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inicioLabel = new System.Windows.Forms.Label();
            this.correoLabel = new System.Windows.Forms.Label();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.claveLabel = new System.Windows.Forms.Label();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cerrarButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.clavePictureBox = new System.Windows.Forms.PictureBox();
            this.usuarioPictureBox = new System.Windows.Forms.PictureBox();
            this.verClavePictureBox = new System.Windows.Forms.PictureBox();
            this.ocultarClavePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarClavePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inicioLabel
            // 
            this.inicioLabel.AutoSize = true;
            this.inicioLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioLabel.Location = new System.Drawing.Point(436, 57);
            this.inicioLabel.Name = "inicioLabel";
            this.inicioLabel.Size = new System.Drawing.Size(199, 36);
            this.inicioLabel.TabIndex = 4;
            this.inicioLabel.Text = "Iniciar Sesión";
            // 
            // correoLabel
            // 
            this.correoLabel.AutoSize = true;
            this.correoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoLabel.Location = new System.Drawing.Point(344, 163);
            this.correoLabel.Name = "correoLabel";
            this.correoLabel.Size = new System.Drawing.Size(237, 21);
            this.correoLabel.TabIndex = 17;
            this.correoLabel.Text = "Ingrese su correo electrónico:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(393, 208);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(312, 27);
            this.correoTextBox.TabIndex = 18;
            this.correoTextBox.Enter += new System.EventHandler(this.correoTextBox_Enter);
            this.correoTextBox.Leave += new System.EventHandler(this.correoTextBox_Leave);
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveLabel.Location = new System.Drawing.Point(344, 258);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(185, 21);
            this.claveLabel.TabIndex = 20;
            this.claveLabel.Text = "Ingrese su contraseña:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTextBox.Location = new System.Drawing.Point(393, 297);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(312, 27);
            this.claveTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ingrese sus credenciales para validar su información";
            // 
            // cerrarButton
            // 
            this.cerrarButton.BackColor = System.Drawing.SystemColors.Control;
            this.cerrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarButton.FlatAppearance.BorderSize = 0;
            this.cerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cerrarButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.cerrarButton.IconColor = System.Drawing.Color.Black;
            this.cerrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrarButton.IconSize = 20;
            this.cerrarButton.Location = new System.Drawing.Point(732, 0);
            this.cerrarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(51, 28);
            this.cerrarButton.TabIndex = 34;
            this.cerrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarButton.UseVisualStyleBackColor = false;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 463);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.logo_kml_removebg_preview_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-24, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-1, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 114);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bienvenido al sistema control de ventas KML Motor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.buttonGuardar.IconColor = System.Drawing.Color.AliceBlue;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuardar.IconSize = 18;
            this.buttonGuardar.Location = new System.Drawing.Point(625, 376);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(134, 41);
            this.buttonGuardar.TabIndex = 20;
            this.buttonGuardar.Text = "INGRESAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // clavePictureBox
            // 
            this.clavePictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.download_removebg_preview__1_;
            this.clavePictureBox.Location = new System.Drawing.Point(344, 297);
            this.clavePictureBox.Name = "clavePictureBox";
            this.clavePictureBox.Size = new System.Drawing.Size(43, 29);
            this.clavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clavePictureBox.TabIndex = 28;
            this.clavePictureBox.TabStop = false;
            // 
            // usuarioPictureBox
            // 
            this.usuarioPictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.usuario;
            this.usuarioPictureBox.Location = new System.Drawing.Point(344, 208);
            this.usuarioPictureBox.Name = "usuarioPictureBox";
            this.usuarioPictureBox.Size = new System.Drawing.Size(43, 28);
            this.usuarioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usuarioPictureBox.TabIndex = 27;
            this.usuarioPictureBox.TabStop = false;
            // 
            // verClavePictureBox
            // 
            this.verClavePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verClavePictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.ver_contraseña;
            this.verClavePictureBox.Location = new System.Drawing.Point(711, 297);
            this.verClavePictureBox.Name = "verClavePictureBox";
            this.verClavePictureBox.Size = new System.Drawing.Size(48, 29);
            this.verClavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verClavePictureBox.TabIndex = 26;
            this.verClavePictureBox.TabStop = false;
            this.verClavePictureBox.Click += new System.EventHandler(this.verClavePictureBox_Click);
            // 
            // ocultarClavePictureBox
            // 
            this.ocultarClavePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultarClavePictureBox.Image = global::ControlVentasKmlMotor.UI.WindowsForms.Properties.Resources.ocultar_contraseña;
            this.ocultarClavePictureBox.Location = new System.Drawing.Point(711, 296);
            this.ocultarClavePictureBox.Name = "ocultarClavePictureBox";
            this.ocultarClavePictureBox.Size = new System.Drawing.Size(48, 28);
            this.ocultarClavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultarClavePictureBox.TabIndex = 25;
            this.ocultarClavePictureBox.TabStop = false;
            this.ocultarClavePictureBox.Click += new System.EventHandler(this.ocultarClavePictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 463);
            this.Controls.Add(this.cerrarButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.clavePictureBox);
            this.Controls.Add(this.usuarioPictureBox);
            this.Controls.Add(this.verClavePictureBox);
            this.Controls.Add(this.ocultarClavePictureBox);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.correoLabel);
            this.Controls.Add(this.inicioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarClavePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inicioLabel;
        private System.Windows.Forms.Label correoLabel;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.PictureBox ocultarClavePictureBox;
        private System.Windows.Forms.PictureBox verClavePictureBox;
        private System.Windows.Forms.PictureBox usuarioPictureBox;
        private System.Windows.Forms.PictureBox clavePictureBox;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton cerrarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}


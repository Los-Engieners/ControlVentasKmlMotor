namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    partial class MainSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSucursal));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.nombreEmpleadoLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(86, 53);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(199, 19);
            this.tituloLabel.TabIndex = 22;
            this.tituloLabel.Text = "REGISTRO DE SUCURSALES";
            // 
            // nombreEmpleadoLabel
            // 
            this.nombreEmpleadoLabel.AutoSize = true;
            this.nombreEmpleadoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nombreEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleadoLabel.Location = new System.Drawing.Point(47, 92);
            this.nombreEmpleadoLabel.Name = "nombreEmpleadoLabel";
            this.nombreEmpleadoLabel.Size = new System.Drawing.Size(53, 16);
            this.nombreEmpleadoLabel.TabIndex = 23;
            this.nombreEmpleadoLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(49, 112);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(261, 21);
            this.nombreTextBox.TabIndex = 24;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.direccionLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.Location = new System.Drawing.Point(47, 151);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(60, 16);
            this.direccionLabel.TabIndex = 25;
            this.direccionLabel.Text = "Dirección:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(49, 171);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(261, 21);
            this.direccionTextBox.TabIndex = 26;
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
            this.buttonGuardar.Location = new System.Drawing.Point(40, 211);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(270, 40);
            this.buttonGuardar.TabIndex = 50;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(363, 42);
            this.menuTitulo.TabIndex = 51;
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
            this.label1.TabIndex = 52;
            this.label1.Text = "Sistema Control Ventas";
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
            this.cancelarButton.Location = new System.Drawing.Point(39, 259);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(271, 39);
            this.cancelarButton.TabIndex = 60;
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
            // MainSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 326);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreEmpleadoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Sucursales";
            this.Load += new System.EventHandler(this.MainSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label nombreEmpleadoLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox direccionTextBox;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
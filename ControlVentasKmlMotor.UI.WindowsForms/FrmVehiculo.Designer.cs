namespace ControlVentasKmlMotor.UI.WindowsForms
{
    partial class FrmVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vehiculoLabel = new System.Windows.Forms.Label();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.editarButton = new FontAwesome.Sharp.IconButton();
            this.eliminarButton = new FontAwesome.Sharp.IconButton();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.registrarButton = new FontAwesome.Sharp.IconButton();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.limpiarButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculoLabel
            // 
            this.vehiculoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.vehiculoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiculoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vehiculoLabel.Location = new System.Drawing.Point(12, 9);
            this.vehiculoLabel.Name = "vehiculoLabel";
            this.vehiculoLabel.Size = new System.Drawing.Size(976, 70);
            this.vehiculoLabel.TabIndex = 50;
            this.vehiculoLabel.Text = "Mantenimiento de Vehiculos";
            this.vehiculoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonBuscar.FlatAppearance.BorderSize = 0;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.White;
            this.iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBuscar.IconSize = 18;
            this.iconButtonBuscar.Location = new System.Drawing.Point(420, 38);
            this.iconButtonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(91, 29);
            this.iconButtonBuscar.TabIndex = 53;
            this.iconButtonBuscar.Text = "BUSCAR";
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaDataGridView.EnableHeadersVisualStyles = false;
            this.listaDataGridView.Location = new System.Drawing.Point(12, 92);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.Size = new System.Drawing.Size(976, 369);
            this.listaDataGridView.TabIndex = 55;
            // 
            // editarButton
            // 
            this.editarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editarButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.editarButton.IconColor = System.Drawing.SystemColors.Window;
            this.editarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editarButton.IconSize = 18;
            this.editarButton.Location = new System.Drawing.Point(833, 468);
            this.editarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(155, 40);
            this.editarButton.TabIndex = 56;
            this.editarButton.Text = "EDITAR";
            this.editarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.Firebrick;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.eliminarButton.IconColor = System.Drawing.Color.White;
            this.eliminarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eliminarButton.IconSize = 18;
            this.eliminarButton.Location = new System.Drawing.Point(662, 468);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(165, 40);
            this.eliminarButton.TabIndex = 57;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.labelBuscarNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBuscarNombre.Location = new System.Drawing.Point(24, 44);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(159, 20);
            this.labelBuscarNombre.TabIndex = 70;
            this.labelBuscarNombre.Text = "Buscar por modelo:  ";
            // 
            // registrarButton
            // 
            this.registrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarButton.FlatAppearance.BorderSize = 0;
            this.registrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarButton.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.registrarButton.IconColor = System.Drawing.Color.White;
            this.registrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarButton.IconSize = 18;
            this.registrarButton.Location = new System.Drawing.Point(846, 33);
            this.registrarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(133, 31);
            this.registrarButton.TabIndex = 72;
            this.registrarButton.Text = "REGISTRAR";
            this.registrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registrarButton.UseVisualStyleBackColor = false;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(189, 39);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(207, 28);
            this.modeloComboBox.TabIndex = 74;
            // 
            // limpiarButton
            // 
            this.limpiarButton.BackColor = System.Drawing.Color.Gray;
            this.limpiarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarButton.FlatAppearance.BorderSize = 0;
            this.limpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.limpiarButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.limpiarButton.IconColor = System.Drawing.Color.White;
            this.limpiarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiarButton.IconSize = 18;
            this.limpiarButton.Location = new System.Drawing.Point(517, 37);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(97, 29);
            this.limpiarButton.TabIndex = 75;
            this.limpiarButton.Text = "LIMPIAR";
            this.limpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limpiarButton.UseVisualStyleBackColor = false;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 521);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.labelBuscarNombre);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.listaDataGridView);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.vehiculoLabel);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label vehiculoLabel;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private FontAwesome.Sharp.IconButton editarButton;
        private FontAwesome.Sharp.IconButton eliminarButton;
        private System.Windows.Forms.Label labelBuscarNombre;
        private FontAwesome.Sharp.IconButton registrarButton;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private FontAwesome.Sharp.IconButton limpiarButton;
    }
}
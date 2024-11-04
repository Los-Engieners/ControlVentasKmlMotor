namespace ControlVentasKmlMotor.UI.WindowsForms
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.registrarButton = new FontAwesome.Sharp.IconButton();
            this.eliminarButton = new FontAwesome.Sharp.IconButton();
            this.editarButton = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.limpiarButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.clienteLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clienteLabel.Location = new System.Drawing.Point(12, 9);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(974, 80);
            this.clienteLabel.TabIndex = 50;
            this.clienteLabel.Text = "Mantenimiento de Clientes";
            this.clienteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(94, 49);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(275, 27);
            this.textBoxBusqueda.TabIndex = 52;
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaDataGridView.EnableHeadersVisualStyles = false;
            this.listaDataGridView.Location = new System.Drawing.Point(16, 98);
            this.listaDataGridView.Name = "listaDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaDataGridView.Size = new System.Drawing.Size(970, 357);
            this.listaDataGridView.TabIndex = 55;
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.labelBuscarNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBuscarNombre.Location = new System.Drawing.Point(24, 51);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(65, 21);
            this.labelBuscarNombre.TabIndex = 68;
            this.labelBuscarNombre.Text = "Buscar:";
            // 
            // registrarButton
            // 
            this.registrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarButton.FlatAppearance.BorderSize = 0;
            this.registrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.registrarButton.IconColor = System.Drawing.Color.White;
            this.registrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarButton.IconSize = 18;
            this.registrarButton.Location = new System.Drawing.Point(832, 48);
            this.registrarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(141, 31);
            this.registrarButton.TabIndex = 72;
            this.registrarButton.Text = "REGISTRAR";
            this.registrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registrarButton.UseVisualStyleBackColor = false;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
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
            this.iconButtonBuscar.Location = new System.Drawing.Point(397, 49);
            this.iconButtonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(97, 29);
            this.iconButtonBuscar.TabIndex = 53;
            this.iconButtonBuscar.Text = "BUSCAR";
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
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
            this.limpiarButton.Location = new System.Drawing.Point(500, 48);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(97, 30);
            this.limpiarButton.TabIndex = 73;
            this.limpiarButton.Text = "LIMPIAR";
            this.limpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limpiarButton.UseVisualStyleBackColor = false;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 521);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.labelBuscarNombre);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.listaDataGridView);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.clienteLabel);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private FontAwesome.Sharp.IconButton editarButton;
        private FontAwesome.Sharp.IconButton eliminarButton;
        private System.Windows.Forms.Label labelBuscarNombre;
        private FontAwesome.Sharp.IconButton registrarButton;
        private FontAwesome.Sharp.IconButton limpiarButton;
    }
}
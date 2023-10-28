namespace CapaPresentacion.Modales
{
    partial class mdProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBtnLimpiarBusc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.gCmbBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gDgvData
            // 
            this.gDgvData.AllowUserToAddRows = false;
            this.gDgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.gDgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gDgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDgvData.BackgroundColor = System.Drawing.Color.Silver;
            this.gDgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoProd,
            this.Nombre,
            this.Categoria,
            this.Stock,
            this.Costo,
            this.Precio});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDgvData.DefaultCellStyle = dataGridViewCellStyle13;
            this.gDgvData.EnableHeadersVisualStyles = false;
            this.gDgvData.GridColor = System.Drawing.Color.White;
            this.gDgvData.Location = new System.Drawing.Point(23, 12);
            this.gDgvData.MultiSelect = false;
            this.gDgvData.Name = "gDgvData";
            this.gDgvData.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gDgvData.RowHeadersVisible = false;
            this.gDgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gDgvData.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gDgvData.RowTemplate.Height = 28;
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDgvData.Size = new System.Drawing.Size(816, 497);
            this.gDgvData.TabIndex = 62;
            this.gDgvData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDgvData.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.gDgvData.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gDgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDgvData.ThemeStyle.HeaderStyle.Height = 32;
            this.gDgvData.ThemeStyle.ReadOnly = true;
            this.gDgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gDgvData.ThemeStyle.RowsStyle.Height = 28;
            this.gDgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gDgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gDgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDgvData_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 79.54546F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 30;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CodigoProd
            // 
            this.CodigoProd.FillWeight = 204.3646F;
            this.CodigoProd.HeaderText = "Código";
            this.CodigoProd.MinimumWidth = 80;
            this.CodigoProd.Name = "CodigoProd";
            this.CodigoProd.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 355.9276F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 18.2875F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 160;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 100;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 100;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Visible = false;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 100;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            // 
            // gBtnLimpiarBusc
            // 
            this.gBtnLimpiarBusc.BorderRadius = 3;
            this.gBtnLimpiarBusc.CheckedState.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.CustomImages.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnLimpiarBusc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnLimpiarBusc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnLimpiarBusc.ForeColor = System.Drawing.Color.White;
            this.gBtnLimpiarBusc.HoverState.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Location = new System.Drawing.Point(716, 529);
            this.gBtnLimpiarBusc.Name = "gBtnLimpiarBusc";
            this.gBtnLimpiarBusc.ShadowDecoration.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Size = new System.Drawing.Size(112, 45);
            this.gBtnLimpiarBusc.TabIndex = 93;
            this.gBtnLimpiarBusc.Text = "Limpiar";
            this.gBtnLimpiarBusc.Click += new System.EventHandler(this.gBtnLimpiarBusc_Click);
            // 
            // gBtnBuscar
            // 
            this.gBtnBuscar.BorderRadius = 3;
            this.gBtnBuscar.CheckedState.Parent = this.gBtnBuscar;
            this.gBtnBuscar.CustomImages.Parent = this.gBtnBuscar;
            this.gBtnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnBuscar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.gBtnBuscar.HoverState.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Location = new System.Drawing.Point(571, 529);
            this.gBtnBuscar.Name = "gBtnBuscar";
            this.gBtnBuscar.ShadowDecoration.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Size = new System.Drawing.Size(130, 45);
            this.gBtnBuscar.TabIndex = 92;
            this.gBtnBuscar.Text = "Buscar";
            this.gBtnBuscar.Click += new System.EventHandler(this.gBtnBuscar_Click);
            // 
            // gTxtBusqueda
            // 
            this.gTxtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBusqueda.DefaultText = "";
            this.gTxtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtBusqueda.DisabledState.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtBusqueda.FocusedState.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtBusqueda.HoverState.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.Location = new System.Drawing.Point(343, 529);
            this.gTxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtBusqueda.Name = "gTxtBusqueda";
            this.gTxtBusqueda.PasswordChar = '\0';
            this.gTxtBusqueda.PlaceholderText = "";
            this.gTxtBusqueda.SelectedText = "";
            this.gTxtBusqueda.ShadowDecoration.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.Size = new System.Drawing.Size(191, 39);
            this.gTxtBusqueda.TabIndex = 91;
            // 
            // gCmbBusqueda
            // 
            this.gCmbBusqueda.Animated = true;
            this.gCmbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gCmbBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCmbBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gCmbBusqueda.FocusedColor = System.Drawing.Color.Empty;
            this.gCmbBusqueda.FocusedState.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCmbBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCmbBusqueda.FormattingEnabled = true;
            this.gCmbBusqueda.HoverState.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.ItemHeight = 30;
            this.gCmbBusqueda.ItemsAppearance.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Location = new System.Drawing.Point(168, 533);
            this.gCmbBusqueda.Name = "gCmbBusqueda";
            this.gCmbBusqueda.ShadowDecoration.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Size = new System.Drawing.Size(168, 36);
            this.gCmbBusqueda.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 32);
            this.label12.TabIndex = 89;
            this.label12.Text = "Buscar por:";
            // 
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 617);
            this.Controls.Add(this.gBtnLimpiarBusc);
            this.Controls.Add(this.gBtnBuscar);
            this.Controls.Add(this.gTxtBusqueda);
            this.Controls.Add(this.gCmbBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gDgvData);
            this.Name = "mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.mdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiarBusc;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtBusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbBusqueda;
        private System.Windows.Forms.Label label12;
    }
}
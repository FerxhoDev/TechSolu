namespace CapaPresentacion.Modales
{
    partial class mdProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gBtnLimpiarBusc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.gCmbBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
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
            this.gBtnLimpiarBusc.Location = new System.Drawing.Point(725, 559);
            this.gBtnLimpiarBusc.Name = "gBtnLimpiarBusc";
            this.gBtnLimpiarBusc.ShadowDecoration.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Size = new System.Drawing.Size(112, 45);
            this.gBtnLimpiarBusc.TabIndex = 88;
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
            this.gBtnBuscar.Location = new System.Drawing.Point(580, 559);
            this.gBtnBuscar.Name = "gBtnBuscar";
            this.gBtnBuscar.ShadowDecoration.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Size = new System.Drawing.Size(130, 45);
            this.gBtnBuscar.TabIndex = 87;
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
            this.gTxtBusqueda.Location = new System.Drawing.Point(352, 559);
            this.gTxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtBusqueda.Name = "gTxtBusqueda";
            this.gTxtBusqueda.PasswordChar = '\0';
            this.gTxtBusqueda.PlaceholderText = "";
            this.gTxtBusqueda.SelectedText = "";
            this.gTxtBusqueda.ShadowDecoration.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.Size = new System.Drawing.Size(191, 39);
            this.gTxtBusqueda.TabIndex = 86;
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
            this.gCmbBusqueda.Location = new System.Drawing.Point(177, 563);
            this.gCmbBusqueda.Name = "gCmbBusqueda";
            this.gCmbBusqueda.ShadowDecoration.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Size = new System.Drawing.Size(168, 36);
            this.gCmbBusqueda.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 32);
            this.label12.TabIndex = 84;
            this.label12.Text = "Buscar por:";
            // 
            // gDgvData
            // 
            this.gDgvData.AllowUserToAddRows = false;
            this.gDgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gDgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDgvData.BackgroundColor = System.Drawing.Color.Silver;
            this.gDgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Telefono});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDgvData.EnableHeadersVisualStyles = false;
            this.gDgvData.GridColor = System.Drawing.Color.White;
            this.gDgvData.Location = new System.Drawing.Point(27, 63);
            this.gDgvData.MultiSelect = false;
            this.gDgvData.Name = "gDgvData";
            this.gDgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gDgvData.RowHeadersVisible = false;
            this.gDgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gDgvData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gDgvData.RowTemplate.Height = 28;
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDgvData.Size = new System.Drawing.Size(740, 446);
            this.gDgvData.TabIndex = 83;
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
            this.gDgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDgvData_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 89;
            this.label1.Text = "LISTA PROVEEDORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // Nombre
            // 
            this.Nombre.FillWeight = 355.9276F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.FillWeight = 204.3646F;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 80;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // mdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBtnLimpiarBusc);
            this.Controls.Add(this.gBtnBuscar);
            this.Controls.Add(this.gTxtBusqueda);
            this.Controls.Add(this.gCmbBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gDgvData);
            this.Name = "mdProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProveedor";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiarBusc;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtBusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbBusqueda;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}
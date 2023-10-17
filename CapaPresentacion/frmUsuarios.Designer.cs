namespace CapaPresentacion
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gTxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gTxtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GtxtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBtnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gCmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gCmbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gTxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gTxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gTxtConfPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gBtnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gCmbBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gBtnLimpiarBusc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTxtIndice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // gDgvData
            // 
            this.gDgvData.AllowUserToAddRows = false;
            this.gDgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.gDgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gDgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDgvData.BackgroundColor = System.Drawing.Color.Silver;
            this.gDgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id,
            this.Nombre,
            this.Telefono,
            this.Direccion,
            this.Correo,
            this.UserName,
            this.Pass,
            this.idRol,
            this.Estado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDgvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.gDgvData.EnableHeadersVisualStyles = false;
            this.gDgvData.GridColor = System.Drawing.Color.White;
            this.gDgvData.Location = new System.Drawing.Point(12, 91);
            this.gDgvData.MultiSelect = false;
            this.gDgvData.Name = "gDgvData";
            this.gDgvData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gDgvData.RowHeadersVisible = false;
            this.gDgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gDgvData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gDgvData.RowTemplate.Height = 28;
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDgvData.Size = new System.Drawing.Size(1034, 634);
            this.gDgvData.TabIndex = 1;
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
            this.gDgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDgvData_CellContentClick);
            this.gDgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gDgvData_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 0.02217987F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 30;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
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
            // Direccion
            // 
            this.Direccion.FillWeight = 10.32773F;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 300;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 31.52491F;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 200;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre Usuario";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Visible = false;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Contraseña";
            this.Pass.MinimumWidth = 8;
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.Visible = false;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "IdRol";
            this.idRol.MinimumWidth = 8;
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 18.2875F;
            this.Estado.HeaderText = "Estado ";
            this.Estado.MinimumWidth = 100;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1132, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1129, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teléfono";
            // 
            // gTxtTelefono
            // 
            this.gTxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtTelefono.DefaultText = "";
            this.gTxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtTelefono.DisabledState.Parent = this.gTxtTelefono;
            this.gTxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtTelefono.FocusedState.Parent = this.gTxtTelefono;
            this.gTxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtTelefono.HoverState.Parent = this.gTxtTelefono;
            this.gTxtTelefono.Location = new System.Drawing.Point(1137, 170);
            this.gTxtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtTelefono.Name = "gTxtTelefono";
            this.gTxtTelefono.PasswordChar = '\0';
            this.gTxtTelefono.PlaceholderText = "";
            this.gTxtTelefono.SelectedText = "";
            this.gTxtTelefono.ShadowDecoration.Parent = this.gTxtTelefono;
            this.gTxtTelefono.Size = new System.Drawing.Size(300, 39);
            this.gTxtTelefono.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1132, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // gTxtDireccion
            // 
            this.gTxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtDireccion.DefaultText = "";
            this.gTxtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtDireccion.DisabledState.Parent = this.gTxtDireccion;
            this.gTxtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtDireccion.FocusedState.Parent = this.gTxtDireccion;
            this.gTxtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtDireccion.HoverState.Parent = this.gTxtDireccion;
            this.gTxtDireccion.Location = new System.Drawing.Point(1134, 244);
            this.gTxtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtDireccion.Name = "gTxtDireccion";
            this.gTxtDireccion.PasswordChar = '\0';
            this.gTxtDireccion.PlaceholderText = "";
            this.gTxtDireccion.SelectedText = "";
            this.gTxtDireccion.ShadowDecoration.Parent = this.gTxtDireccion;
            this.gTxtDireccion.Size = new System.Drawing.Size(300, 39);
            this.gTxtDireccion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1132, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo";
            // 
            // GtxtCorreo
            // 
            this.GtxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GtxtCorreo.DefaultText = "";
            this.GtxtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GtxtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GtxtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GtxtCorreo.DisabledState.Parent = this.GtxtCorreo;
            this.GtxtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GtxtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GtxtCorreo.FocusedState.Parent = this.GtxtCorreo;
            this.GtxtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GtxtCorreo.HoverState.Parent = this.GtxtCorreo;
            this.GtxtCorreo.Location = new System.Drawing.Point(1137, 318);
            this.GtxtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GtxtCorreo.Name = "GtxtCorreo";
            this.GtxtCorreo.PasswordChar = '\0';
            this.GtxtCorreo.PlaceholderText = "";
            this.GtxtCorreo.SelectedText = "";
            this.GtxtCorreo.ShadowDecoration.Parent = this.GtxtCorreo;
            this.GtxtCorreo.Size = new System.Drawing.Size(300, 39);
            this.GtxtCorreo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1301, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // gBtnGuardar
            // 
            this.gBtnGuardar.BorderRadius = 3;
            this.gBtnGuardar.CheckedState.Parent = this.gBtnGuardar;
            this.gBtnGuardar.CustomImages.Parent = this.gBtnGuardar;
            this.gBtnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnGuardar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.gBtnGuardar.HoverState.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Location = new System.Drawing.Point(1203, 708);
            this.gBtnGuardar.Name = "gBtnGuardar";
            this.gBtnGuardar.ShadowDecoration.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Size = new System.Drawing.Size(204, 45);
            this.gBtnGuardar.TabIndex = 12;
            this.gBtnGuardar.Text = "Guardar";
            this.gBtnGuardar.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // gBtnEliminar
            // 
            this.gBtnEliminar.BorderRadius = 3;
            this.gBtnEliminar.CheckedState.Parent = this.gBtnEliminar;
            this.gBtnEliminar.CustomImages.Parent = this.gBtnEliminar;
            this.gBtnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.gBtnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.gBtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.gBtnEliminar.HoverState.Parent = this.gBtnEliminar;
            this.gBtnEliminar.Location = new System.Drawing.Point(1203, 810);
            this.gBtnEliminar.Name = "gBtnEliminar";
            this.gBtnEliminar.ShadowDecoration.Parent = this.gBtnEliminar;
            this.gBtnEliminar.Size = new System.Drawing.Size(204, 45);
            this.gBtnEliminar.TabIndex = 13;
            this.gBtnEliminar.Text = "Eliminar";
            this.gBtnEliminar.Click += new System.EventHandler(this.gBtnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1144, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 45);
            this.label7.TabIndex = 14;
            this.label7.Text = "Detalle Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1097, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rol";
            // 
            // gCmbRol
            // 
            this.gCmbRol.Animated = true;
            this.gCmbRol.BackColor = System.Drawing.Color.Transparent;
            this.gCmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gCmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.gCmbRol.FocusedState.Parent = this.gCmbRol;
            this.gCmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCmbRol.FormattingEnabled = true;
            this.gCmbRol.HoverState.Parent = this.gCmbRol;
            this.gCmbRol.ItemHeight = 30;
            this.gCmbRol.ItemsAppearance.Parent = this.gCmbRol;
            this.gCmbRol.Location = new System.Drawing.Point(1102, 644);
            this.gCmbRol.Name = "gCmbRol";
            this.gCmbRol.ShadowDecoration.Parent = this.gCmbRol;
            this.gCmbRol.Size = new System.Drawing.Size(188, 36);
            this.gCmbRol.TabIndex = 16;
            // 
            // gCmbEstado
            // 
            this.gCmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.gCmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCmbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.gCmbEstado.FocusedState.Parent = this.gCmbEstado;
            this.gCmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCmbEstado.FormattingEnabled = true;
            this.gCmbEstado.HoverState.Parent = this.gCmbEstado;
            this.gCmbEstado.ItemHeight = 30;
            this.gCmbEstado.ItemsAppearance.Parent = this.gCmbEstado;
            this.gCmbEstado.Location = new System.Drawing.Point(1306, 644);
            this.gCmbEstado.Name = "gCmbEstado";
            this.gCmbEstado.ShadowDecoration.Parent = this.gCmbEstado;
            this.gCmbEstado.Size = new System.Drawing.Size(174, 36);
            this.gCmbEstado.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1134, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nombre de usuario";
            // 
            // gTxtUserName
            // 
            this.gTxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtUserName.DefaultText = "";
            this.gTxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtUserName.DisabledState.Parent = this.gTxtUserName;
            this.gTxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtUserName.FocusedState.Parent = this.gTxtUserName;
            this.gTxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtUserName.HoverState.Parent = this.gTxtUserName;
            this.gTxtUserName.Location = new System.Drawing.Point(1137, 399);
            this.gTxtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtUserName.Name = "gTxtUserName";
            this.gTxtUserName.PasswordChar = '\0';
            this.gTxtUserName.PlaceholderText = "";
            this.gTxtUserName.SelectedText = "";
            this.gTxtUserName.ShadowDecoration.Parent = this.gTxtUserName;
            this.gTxtUserName.Size = new System.Drawing.Size(300, 39);
            this.gTxtUserName.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1129, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Contaseña";
            // 
            // gTxtPass
            // 
            this.gTxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtPass.DefaultText = "";
            this.gTxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtPass.DisabledState.Parent = this.gTxtPass;
            this.gTxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtPass.FocusedState.Parent = this.gTxtPass;
            this.gTxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtPass.HoverState.Parent = this.gTxtPass;
            this.gTxtPass.Location = new System.Drawing.Point(1139, 474);
            this.gTxtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtPass.Name = "gTxtPass";
            this.gTxtPass.PasswordChar = '*';
            this.gTxtPass.PlaceholderText = "";
            this.gTxtPass.SelectedText = "";
            this.gTxtPass.ShadowDecoration.Parent = this.gTxtPass;
            this.gTxtPass.Size = new System.Drawing.Size(300, 39);
            this.gTxtPass.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1129, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Confirmar contraseña";
            // 
            // gTxtConfPass
            // 
            this.gTxtConfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtConfPass.DefaultText = "";
            this.gTxtConfPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtConfPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtConfPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtConfPass.DisabledState.Parent = this.gTxtConfPass;
            this.gTxtConfPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtConfPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtConfPass.FocusedState.Parent = this.gTxtConfPass;
            this.gTxtConfPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtConfPass.HoverState.Parent = this.gTxtConfPass;
            this.gTxtConfPass.Location = new System.Drawing.Point(1139, 548);
            this.gTxtConfPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtConfPass.Name = "gTxtConfPass";
            this.gTxtConfPass.PasswordChar = '*';
            this.gTxtConfPass.PlaceholderText = "";
            this.gTxtConfPass.SelectedText = "";
            this.gTxtConfPass.ShadowDecoration.Parent = this.gTxtConfPass;
            this.gTxtConfPass.Size = new System.Drawing.Size(300, 39);
            this.gTxtConfPass.TabIndex = 22;
            // 
            // gBtnLimpiar
            // 
            this.gBtnLimpiar.BorderRadius = 3;
            this.gBtnLimpiar.CheckedState.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.CustomImages.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnLimpiar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.gBtnLimpiar.HoverState.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.Location = new System.Drawing.Point(1203, 759);
            this.gBtnLimpiar.Name = "gBtnLimpiar";
            this.gBtnLimpiar.ShadowDecoration.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.Size = new System.Drawing.Size(204, 45);
            this.gBtnLimpiar.TabIndex = 24;
            this.gBtnLimpiar.Text = "Limpiar";
            this.gBtnLimpiar.Click += new System.EventHandler(this.gBtnLimpiar_Click);
            // 
            // gTxtId
            // 
            this.gTxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtId.DefaultText = "0";
            this.gTxtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtId.DisabledState.Parent = this.gTxtId;
            this.gTxtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtId.FocusedState.Parent = this.gTxtId;
            this.gTxtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtId.HoverState.Parent = this.gTxtId;
            this.gTxtId.Location = new System.Drawing.Point(1415, 51);
            this.gTxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtId.Name = "gTxtId";
            this.gTxtId.PasswordChar = '\0';
            this.gTxtId.PlaceholderText = "";
            this.gTxtId.SelectedText = "";
            this.gTxtId.SelectionStart = 1;
            this.gTxtId.ShadowDecoration.Parent = this.gTxtId;
            this.gTxtId.Size = new System.Drawing.Size(35, 32);
            this.gTxtId.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 768);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 32);
            this.label12.TabIndex = 26;
            this.label12.Text = "Buscar por:";
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
            this.gCmbBusqueda.Location = new System.Drawing.Point(164, 764);
            this.gCmbBusqueda.Name = "gCmbBusqueda";
            this.gCmbBusqueda.ShadowDecoration.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Size = new System.Drawing.Size(214, 36);
            this.gCmbBusqueda.TabIndex = 27;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(401, 764);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(273, 39);
            this.guna2TextBox1.TabIndex = 28;
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
            this.gBtnLimpiarBusc.Location = new System.Drawing.Point(856, 764);
            this.gBtnLimpiarBusc.Name = "gBtnLimpiarBusc";
            this.gBtnLimpiarBusc.ShadowDecoration.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Size = new System.Drawing.Size(112, 45);
            this.gBtnLimpiarBusc.TabIndex = 30;
            this.gBtnLimpiarBusc.Text = "Limpiar";
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
            this.gBtnBuscar.Location = new System.Drawing.Point(711, 764);
            this.gBtnBuscar.Name = "gBtnBuscar";
            this.gBtnBuscar.ShadowDecoration.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Size = new System.Drawing.Size(130, 45);
            this.gBtnBuscar.TabIndex = 29;
            this.gBtnBuscar.Text = "Buscar";
            // 
            // gTxtNombre
            // 
            this.gTxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtNombre.DefaultText = "";
            this.gTxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtNombre.DisabledState.Parent = this.gTxtNombre;
            this.gTxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtNombre.FocusedState.Parent = this.gTxtNombre;
            this.gTxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtNombre.HoverState.Parent = this.gTxtNombre;
            this.gTxtNombre.Location = new System.Drawing.Point(1137, 96);
            this.gTxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtNombre.Name = "gTxtNombre";
            this.gTxtNombre.PasswordChar = '\0';
            this.gTxtNombre.PlaceholderText = "";
            this.gTxtNombre.SelectedText = "";
            this.gTxtNombre.ShadowDecoration.Parent = this.gTxtNombre;
            this.gTxtNombre.Size = new System.Drawing.Size(300, 39);
            this.gTxtNombre.TabIndex = 2;
            // 
            // gTxtIndice
            // 
            this.gTxtIndice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtIndice.DefaultText = "-1";
            this.gTxtIndice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtIndice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtIndice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtIndice.DisabledState.Parent = this.gTxtIndice;
            this.gTxtIndice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtIndice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtIndice.FocusedState.Parent = this.gTxtIndice;
            this.gTxtIndice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtIndice.HoverState.Parent = this.gTxtIndice;
            this.gTxtIndice.Location = new System.Drawing.Point(1372, 51);
            this.gTxtIndice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtIndice.Name = "gTxtIndice";
            this.gTxtIndice.PasswordChar = '\0';
            this.gTxtIndice.PlaceholderText = "";
            this.gTxtIndice.SelectedText = "";
            this.gTxtIndice.SelectionStart = 2;
            this.gTxtIndice.ShadowDecoration.Parent = this.gTxtIndice;
            this.gTxtIndice.Size = new System.Drawing.Size(35, 32);
            this.gTxtIndice.TabIndex = 31;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 879);
            this.Controls.Add(this.gTxtIndice);
            this.Controls.Add(this.gBtnLimpiarBusc);
            this.Controls.Add(this.gBtnBuscar);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.gCmbBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gTxtId);
            this.Controls.Add(this.gBtnLimpiar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gTxtConfPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gTxtPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gTxtUserName);
            this.Controls.Add(this.gCmbEstado);
            this.Controls.Add(this.gCmbRol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gBtnEliminar);
            this.Controls.Add(this.gBtnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GtxtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gTxtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gTxtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gTxtNombre);
            this.Controls.Add(this.gDgvData);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private Guna.UI2.WinForms.Guna2TextBox gTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox gTxtTelefono;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox gTxtDireccion;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox GtxtCorreo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnGuardar;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbRol;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbEstado;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox gTxtUserName;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox gTxtPass;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox gTxtConfPass;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtId;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbBusqueda;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiarBusc;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private Guna.UI2.WinForms.Guna2TextBox gTxtIndice;
    }
}
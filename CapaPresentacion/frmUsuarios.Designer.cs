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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gTxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.gBtnEditar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
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
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 32;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Id,
            this.Nombre,
            this.Teléfono,
            this.Direccion,
            this.Correo,
            this.UserName,
            this.Pass,
            this.idRol,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(12, 91);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1034, 678);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1144, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(392, 68);
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
            this.gCmbRol.Size = new System.Drawing.Size(174, 36);
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
            this.gTxtPass.PasswordChar = '\0';
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
            this.gTxtConfPass.PasswordChar = '\0';
            this.gTxtConfPass.PlaceholderText = "";
            this.gTxtConfPass.SelectedText = "";
            this.gTxtConfPass.ShadowDecoration.Parent = this.gTxtConfPass;
            this.gTxtConfPass.Size = new System.Drawing.Size(300, 39);
            this.gTxtConfPass.TabIndex = 22;
            // 
            // gBtnEditar
            // 
            this.gBtnEditar.BorderRadius = 3;
            this.gBtnEditar.CheckedState.Parent = this.gBtnEditar;
            this.gBtnEditar.CustomImages.Parent = this.gBtnEditar;
            this.gBtnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnEditar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnEditar.ForeColor = System.Drawing.Color.White;
            this.gBtnEditar.HoverState.Parent = this.gBtnEditar;
            this.gBtnEditar.Location = new System.Drawing.Point(1203, 759);
            this.gBtnEditar.Name = "gBtnEditar";
            this.gBtnEditar.ShadowDecoration.Parent = this.gBtnEditar;
            this.gBtnEditar.Size = new System.Drawing.Size(204, 45);
            this.gBtnEditar.TabIndex = 24;
            this.gBtnEditar.Text = "Editar";
            // 
            // gTxtId
            // 
            this.gTxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtId.DefaultText = "";
            this.gTxtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtId.DisabledState.Parent = this.gTxtId;
            this.gTxtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtId.FocusedState.Parent = this.gTxtId;
            this.gTxtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtId.HoverState.Parent = this.gTxtId;
            this.gTxtId.Location = new System.Drawing.Point(1420, 44);
            this.gTxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtId.Name = "gTxtId";
            this.gTxtId.PasswordChar = '\0';
            this.gTxtId.PlaceholderText = "";
            this.gTxtId.SelectedText = "";
            this.gTxtId.ShadowDecoration.Parent = this.gTxtId;
            this.gTxtId.Size = new System.Drawing.Size(35, 32);
            this.gTxtId.TabIndex = 25;
            this.gTxtId.Visible = false;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 18.2875F;
            this.Estado.HeaderText = "Estado ";
            this.Estado.MinimumWidth = 100;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "IdRol";
            this.idRol.MinimumWidth = 8;
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Contraseña";
            this.Pass.MinimumWidth = 8;
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre Usuario";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Visible = false;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 31.52491F;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 200;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.FillWeight = 10.32773F;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 300;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Teléfono
            // 
            this.Teléfono.FillWeight = 204.3646F;
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.MinimumWidth = 80;
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 355.9276F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            // Seleccionar
            // 
            this.Seleccionar.FillWeight = 0.02217987F;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.MinimumWidth = 30;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 879);
            this.Controls.Add(this.gTxtId);
            this.Controls.Add(this.gBtnEditar);
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
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
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
        private Guna.UI2.WinForms.Guna2GradientButton gBtnEditar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtId;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
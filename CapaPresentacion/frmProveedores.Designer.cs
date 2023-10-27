namespace CapaPresentacion
{
    partial class frmProveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GtxtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gTxtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gTxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBtnLimpiarBusc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.gCmbBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gTxtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.gBtnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.gBtnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gTxtIndice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "Proveedores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1145, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 72;
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
            this.GtxtCorreo.Location = new System.Drawing.Point(1150, 348);
            this.GtxtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GtxtCorreo.Name = "GtxtCorreo";
            this.GtxtCorreo.PasswordChar = '\0';
            this.GtxtCorreo.PlaceholderText = "";
            this.GtxtCorreo.SelectedText = "";
            this.GtxtCorreo.ShadowDecoration.Parent = this.GtxtCorreo;
            this.GtxtCorreo.Size = new System.Drawing.Size(300, 39);
            this.GtxtCorreo.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1145, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 70;
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
            this.gTxtDireccion.Location = new System.Drawing.Point(1147, 274);
            this.gTxtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtDireccion.Name = "gTxtDireccion";
            this.gTxtDireccion.PasswordChar = '\0';
            this.gTxtDireccion.PlaceholderText = "";
            this.gTxtDireccion.SelectedText = "";
            this.gTxtDireccion.ShadowDecoration.Parent = this.gTxtDireccion;
            this.gTxtDireccion.Size = new System.Drawing.Size(300, 39);
            this.gTxtDireccion.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1142, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 68;
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
            this.gTxtTelefono.Location = new System.Drawing.Point(1150, 200);
            this.gTxtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtTelefono.Name = "gTxtTelefono";
            this.gTxtTelefono.PasswordChar = '\0';
            this.gTxtTelefono.PlaceholderText = "";
            this.gTxtTelefono.SelectedText = "";
            this.gTxtTelefono.ShadowDecoration.Parent = this.gTxtTelefono;
            this.gTxtTelefono.Size = new System.Drawing.Size(300, 39);
            this.gTxtTelefono.TabIndex = 67;
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
            this.gTxtNombre.Location = new System.Drawing.Point(1150, 126);
            this.gTxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtNombre.Name = "gTxtNombre";
            this.gTxtNombre.PasswordChar = '\0';
            this.gTxtNombre.PlaceholderText = "";
            this.gTxtNombre.SelectedText = "";
            this.gTxtNombre.ShadowDecoration.Parent = this.gTxtNombre;
            this.gTxtNombre.Size = new System.Drawing.Size(300, 39);
            this.gTxtNombre.TabIndex = 65;
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
            // Telefono
            // 
            this.Telefono.FillWeight = 204.3646F;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 80;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 355.9276F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1145, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Nombre";
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
            this.gBtnLimpiarBusc.Location = new System.Drawing.Point(869, 794);
            this.gBtnLimpiarBusc.Name = "gBtnLimpiarBusc";
            this.gBtnLimpiarBusc.ShadowDecoration.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Size = new System.Drawing.Size(112, 45);
            this.gBtnLimpiarBusc.TabIndex = 82;
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
            this.gBtnBuscar.Location = new System.Drawing.Point(724, 794);
            this.gBtnBuscar.Name = "gBtnBuscar";
            this.gBtnBuscar.ShadowDecoration.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Size = new System.Drawing.Size(130, 45);
            this.gBtnBuscar.TabIndex = 81;
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
            this.gTxtBusqueda.Location = new System.Drawing.Point(414, 794);
            this.gTxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtBusqueda.Name = "gTxtBusqueda";
            this.gTxtBusqueda.PasswordChar = '\0';
            this.gTxtBusqueda.PlaceholderText = "";
            this.gTxtBusqueda.SelectedText = "";
            this.gTxtBusqueda.ShadowDecoration.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.Size = new System.Drawing.Size(273, 39);
            this.gTxtBusqueda.TabIndex = 80;
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
            this.gCmbBusqueda.Location = new System.Drawing.Point(177, 794);
            this.gCmbBusqueda.Name = "gCmbBusqueda";
            this.gCmbBusqueda.ShadowDecoration.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Size = new System.Drawing.Size(214, 36);
            this.gCmbBusqueda.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 798);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 32);
            this.label12.TabIndex = 78;
            this.label12.Text = "Buscar por:";
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
            this.gTxtId.Location = new System.Drawing.Point(1428, 81);
            this.gTxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtId.Name = "gTxtId";
            this.gTxtId.PasswordChar = '\0';
            this.gTxtId.PlaceholderText = "";
            this.gTxtId.SelectedText = "";
            this.gTxtId.SelectionStart = 1;
            this.gTxtId.ShadowDecoration.Parent = this.gTxtId;
            this.gTxtId.Size = new System.Drawing.Size(35, 32);
            this.gTxtId.TabIndex = 77;
            this.gTxtId.Visible = false;
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
            this.gBtnLimpiar.Location = new System.Drawing.Point(1202, 488);
            this.gBtnLimpiar.Name = "gBtnLimpiar";
            this.gBtnLimpiar.ShadowDecoration.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.Size = new System.Drawing.Size(204, 45);
            this.gBtnLimpiar.TabIndex = 76;
            this.gBtnLimpiar.Text = "Limpiar";
            this.gBtnLimpiar.Click += new System.EventHandler(this.gBtnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1157, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 45);
            this.label7.TabIndex = 75;
            this.label7.Text = "Detalle Proveedor";
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
            this.gBtnEliminar.Location = new System.Drawing.Point(1202, 539);
            this.gBtnEliminar.Name = "gBtnEliminar";
            this.gBtnEliminar.ShadowDecoration.Parent = this.gBtnEliminar;
            this.gBtnEliminar.Size = new System.Drawing.Size(204, 45);
            this.gBtnEliminar.TabIndex = 74;
            this.gBtnEliminar.Text = "Eliminar";
            this.gBtnEliminar.Click += new System.EventHandler(this.gBtnEliminar_Click);
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
            this.gBtnGuardar.Location = new System.Drawing.Point(1202, 437);
            this.gBtnGuardar.Name = "gBtnGuardar";
            this.gBtnGuardar.ShadowDecoration.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Size = new System.Drawing.Size(204, 45);
            this.gBtnGuardar.TabIndex = 73;
            this.gBtnGuardar.Text = "Guardar";
            this.gBtnGuardar.Click += new System.EventHandler(this.gBtnGuardar_Click);
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
            this.btnSeleccionar,
            this.Id,
            this.Nombre,
            this.Telefono,
            this.Direccion,
            this.Correo});
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
            this.gDgvData.Location = new System.Drawing.Point(25, 121);
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
            this.gDgvData.Size = new System.Drawing.Size(1034, 634);
            this.gDgvData.TabIndex = 64;
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
            this.gTxtIndice.Location = new System.Drawing.Point(1385, 81);
            this.gTxtIndice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtIndice.Name = "gTxtIndice";
            this.gTxtIndice.PasswordChar = '\0';
            this.gTxtIndice.PlaceholderText = "";
            this.gTxtIndice.SelectedText = "";
            this.gTxtIndice.SelectionStart = 2;
            this.gTxtIndice.ShadowDecoration.Parent = this.gTxtIndice;
            this.gTxtIndice.Size = new System.Drawing.Size(35, 32);
            this.gTxtIndice.TabIndex = 83;
            this.gTxtIndice.Visible = false;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 879);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GtxtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gTxtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gTxtTelefono);
            this.Controls.Add(this.gTxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBtnLimpiarBusc);
            this.Controls.Add(this.gBtnBuscar);
            this.Controls.Add(this.gTxtBusqueda);
            this.Controls.Add(this.gCmbBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gTxtId);
            this.Controls.Add(this.gBtnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gBtnEliminar);
            this.Controls.Add(this.gBtnGuardar);
            this.Controls.Add(this.gDgvData);
            this.Controls.Add(this.gTxtIndice);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox GtxtCorreo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox gTxtDireccion;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox gTxtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox gTxtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiarBusc;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtBusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbBusqueda;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox gTxtId;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiar;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnEliminar;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnGuardar;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtIndice;
    }
}
namespace CapaPresentacion
{
    partial class frmNegocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new Guna.UI.WinForms.GunaElipsePanel();
            this.gBtnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gTxtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gTxtNit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gTxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.gBtnCargarL = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.gPtbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPtbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(48, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Detalles Negocio";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.panelMenu.Controls.Add(this.gBtnGuardar);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.gTxtDireccion);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.gTxtNit);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.gTxtNombre);
            this.panelMenu.Controls.Add(this.gBtnCargarL);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lblName);
            this.panelMenu.Controls.Add(this.guna2Separator1);
            this.panelMenu.Controls.Add(this.gPtbLogo);
            this.panelMenu.Location = new System.Drawing.Point(-10, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Radius = 15;
            this.panelMenu.Size = new System.Drawing.Size(851, 806);
            this.panelMenu.TabIndex = 34;
            // 
            // gBtnGuardar
            // 
            this.gBtnGuardar.BorderRadius = 3;
            this.gBtnGuardar.CheckedState.Parent = this.gBtnGuardar;
            this.gBtnGuardar.CustomImages.Parent = this.gBtnGuardar;
            this.gBtnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnGuardar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.gBtnGuardar.HoverState.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Location = new System.Drawing.Point(422, 496);
            this.gBtnGuardar.Name = "gBtnGuardar";
            this.gBtnGuardar.ShadowDecoration.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Size = new System.Drawing.Size(268, 48);
            this.gBtnGuardar.TabIndex = 50;
            this.gBtnGuardar.Text = "Guardar";
            this.gBtnGuardar.Click += new System.EventHandler(this.gBtnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(417, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 49;
            this.label4.Text = "Dirección";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.gTxtDireccion.Location = new System.Drawing.Point(419, 389);
            this.gTxtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtDireccion.Name = "gTxtDireccion";
            this.gTxtDireccion.PasswordChar = '\0';
            this.gTxtDireccion.PlaceholderText = "";
            this.gTxtDireccion.SelectedText = "";
            this.gTxtDireccion.ShadowDecoration.Parent = this.gTxtDireccion;
            this.gTxtDireccion.Size = new System.Drawing.Size(300, 39);
            this.gTxtDireccion.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(414, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "NIT";
            // 
            // gTxtNit
            // 
            this.gTxtNit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtNit.DefaultText = "";
            this.gTxtNit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtNit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtNit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtNit.DisabledState.Parent = this.gTxtNit;
            this.gTxtNit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtNit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtNit.FocusedState.Parent = this.gTxtNit;
            this.gTxtNit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtNit.HoverState.Parent = this.gTxtNit;
            this.gTxtNit.Location = new System.Drawing.Point(422, 295);
            this.gTxtNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtNit.Name = "gTxtNit";
            this.gTxtNit.PasswordChar = '\0';
            this.gTxtNit.PlaceholderText = "";
            this.gTxtNit.SelectedText = "";
            this.gTxtNit.ShadowDecoration.Parent = this.gTxtNit;
            this.gTxtNit.Size = new System.Drawing.Size(300, 39);
            this.gTxtNit.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(417, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre Negocio";
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
            this.gTxtNombre.Location = new System.Drawing.Point(419, 197);
            this.gTxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtNombre.Name = "gTxtNombre";
            this.gTxtNombre.PasswordChar = '\0';
            this.gTxtNombre.PlaceholderText = "";
            this.gTxtNombre.SelectedText = "";
            this.gTxtNombre.ShadowDecoration.Parent = this.gTxtNombre;
            this.gTxtNombre.Size = new System.Drawing.Size(300, 39);
            this.gTxtNombre.TabIndex = 44;
            // 
            // gBtnCargarL
            // 
            this.gBtnCargarL.AutoRoundedCorners = true;
            this.gBtnCargarL.BorderRadius = 24;
            this.gBtnCargarL.CheckedState.Parent = this.gBtnCargarL;
            this.gBtnCargarL.CustomImages.Parent = this.gBtnCargarL;
            this.gBtnCargarL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnCargarL.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnCargarL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnCargarL.ForeColor = System.Drawing.Color.White;
            this.gBtnCargarL.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnCargarL.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnCargarL.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnCargarL.HoverState.Parent = this.gBtnCargarL;
            this.gBtnCargarL.Image = global::CapaPresentacion.Properties.Resources.icons8_subir_30;
            this.gBtnCargarL.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gBtnCargarL.ImageSize = new System.Drawing.Size(25, 25);
            this.gBtnCargarL.Location = new System.Drawing.Point(43, 389);
            this.gBtnCargarL.Margin = new System.Windows.Forms.Padding(5);
            this.gBtnCargarL.Name = "gBtnCargarL";
            this.gBtnCargarL.Padding = new System.Windows.Forms.Padding(15);
            this.gBtnCargarL.ShadowDecoration.Parent = this.gBtnCargarL;
            this.gBtnCargarL.Size = new System.Drawing.Size(234, 50);
            this.gBtnCargarL.TabIndex = 34;
            this.gBtnCargarL.Text = "Cargar Logo";
            this.gBtnCargarL.TextOffset = new System.Drawing.Point(20, 0);
            this.gBtnCargarL.Click += new System.EventHandler(this.gBtnCargarL_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.online_point_24;
            this.pictureBox2.Location = new System.Drawing.Point(22, 910);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(62, 904);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 28);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Hola Ferdy!";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 867);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(300, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // gPtbLogo
            // 
            this.gPtbLogo.Location = new System.Drawing.Point(54, 171);
            this.gPtbLogo.Name = "gPtbLogo";
            this.gPtbLogo.ShadowDecoration.Parent = this.gPtbLogo;
            this.gPtbLogo.Size = new System.Drawing.Size(209, 184);
            this.gPtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gPtbLogo.TabIndex = 0;
            this.gPtbLogo.TabStop = false;
            this.gPtbLogo.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CapaPresentacion.Properties.Resources.cactus;
            this.gunaPictureBox1.Location = new System.Drawing.Point(1203, 298);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(159, 314);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 36;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::CapaPresentacion.Properties.Resources.Character_working_laptop_sitting_chair;
            this.gunaPictureBox2.Location = new System.Drawing.Point(903, 282);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(346, 359);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 35;
            this.gunaPictureBox2.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(206)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1489, 879);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPtbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipsePanel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox gPtbLogo;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnCargarL;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnGuardar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox gTxtDireccion;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox gTxtNit;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox gTxtNombre;
    }
}
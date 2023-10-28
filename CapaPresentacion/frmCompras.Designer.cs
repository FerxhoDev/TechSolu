namespace CapaPresentacion
{
    partial class frmCompras
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gunaElipsePanel1.Controls.Add(this.guna2GradientButton1);
            this.gunaElipsePanel1.Controls.Add(this.gBtnCategoria);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(-1, -5);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 12;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1516, 77);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pContainer.Location = new System.Drawing.Point(0, 76);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1515, 834);
            this.pContainer.TabIndex = 1;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::CapaPresentacion.Properties.Resources.ventas_50;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientButton1.Location = new System.Drawing.Point(628, 17);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(235, 45);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "Ver Detalles";
            // 
            // gBtnCategoria
            // 
            this.gBtnCategoria.BorderRadius = 5;
            this.gBtnCategoria.CheckedState.Parent = this.gBtnCategoria;
            this.gBtnCategoria.CustomImages.Parent = this.gBtnCategoria;
            this.gBtnCategoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnCategoria.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnCategoria.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnCategoria.ForeColor = System.Drawing.Color.White;
            this.gBtnCategoria.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnCategoria.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnCategoria.HoverState.Parent = this.gBtnCategoria;
            this.gBtnCategoria.Image = global::CapaPresentacion.Properties.Resources.categoria_50;
            this.gBtnCategoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gBtnCategoria.ImageSize = new System.Drawing.Size(35, 35);
            this.gBtnCategoria.Location = new System.Drawing.Point(71, 17);
            this.gBtnCategoria.Name = "gBtnCategoria";
            this.gBtnCategoria.ShadowDecoration.Parent = this.gBtnCategoria;
            this.gBtnCategoria.Size = new System.Drawing.Size(235, 45);
            this.gBtnCategoria.TabIndex = 2;
            this.gBtnCategoria.Text = "Registrar   ";
            this.gBtnCategoria.Click += new System.EventHandler(this.gBtnCategoria_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 910);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnCategoria;
        private System.Windows.Forms.Panel pContainer;
    }
}
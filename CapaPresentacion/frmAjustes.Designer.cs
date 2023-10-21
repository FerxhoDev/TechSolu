namespace CapaPresentacion
{
    partial class frmAjustes
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
            this.pContainer = new System.Windows.Forms.Panel();
            this.gBtnCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnProductos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(12, 66);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1474, 801);
            this.pContainer.TabIndex = 0;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
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
            this.gBtnCategoria.Location = new System.Drawing.Point(35, 7);
            this.gBtnCategoria.Name = "gBtnCategoria";
            this.gBtnCategoria.ShadowDecoration.Parent = this.gBtnCategoria;
            this.gBtnCategoria.Size = new System.Drawing.Size(235, 45);
            this.gBtnCategoria.TabIndex = 1;
            this.gBtnCategoria.Text = "CATEGORIAS   _";
            this.gBtnCategoria.Click += new System.EventHandler(this.gBtnCategoria_Click);
            // 
            // gBtnProductos
            // 
            this.gBtnProductos.BorderRadius = 5;
            this.gBtnProductos.CheckedState.Parent = this.gBtnProductos;
            this.gBtnProductos.CustomImages.Parent = this.gBtnProductos;
            this.gBtnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnProductos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnProductos.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnProductos.ForeColor = System.Drawing.Color.White;
            this.gBtnProductos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnProductos.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnProductos.HoverState.Parent = this.gBtnProductos;
            this.gBtnProductos.Image = global::CapaPresentacion.Properties.Resources.paquete_50;
            this.gBtnProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gBtnProductos.ImageSize = new System.Drawing.Size(35, 35);
            this.gBtnProductos.Location = new System.Drawing.Point(295, 7);
            this.gBtnProductos.Name = "gBtnProductos";
            this.gBtnProductos.ShadowDecoration.Depth = 50;
            this.gBtnProductos.ShadowDecoration.Parent = this.gBtnProductos;
            this.gBtnProductos.Size = new System.Drawing.Size(228, 45);
            this.gBtnProductos.TabIndex = 2;
            this.gBtnProductos.Text = "PRODUCTOS   .";
            this.gBtnProductos.Click += new System.EventHandler(this.gBtnProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.gBtnProductos);
            this.panel1.Controls.Add(this.gBtnCategoria);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 61);
            this.panel1.TabIndex = 3;
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1489, 879);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pContainer);
            this.Name = "frmAjustes";
            this.Text = "frmAjustes";
            this.Load += new System.EventHandler(this.frmAjustes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContainer;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnCategoria;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnProductos;
        private System.Windows.Forms.Panel panel1;
    }
}
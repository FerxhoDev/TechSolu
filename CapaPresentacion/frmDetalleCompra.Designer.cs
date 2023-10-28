namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gBtnLimpiarBusc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelefProv = new System.Windows.Forms.TextBox();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(655, 85);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(211, 26);
            this.txtBusqueda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle Compra";
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
            this.gBtnLimpiarBusc.Location = new System.Drawing.Point(1066, 66);
            this.gBtnLimpiarBusc.Name = "gBtnLimpiarBusc";
            this.gBtnLimpiarBusc.ShadowDecoration.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Size = new System.Drawing.Size(112, 45);
            this.gBtnLimpiarBusc.TabIndex = 63;
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
            this.gBtnBuscar.Location = new System.Drawing.Point(921, 66);
            this.gBtnBuscar.Name = "gBtnBuscar";
            this.gBtnBuscar.ShadowDecoration.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Size = new System.Drawing.Size(130, 45);
            this.gBtnBuscar.TabIndex = 62;
            this.gBtnBuscar.Text = "Buscar";
            this.gBtnBuscar.Click += new System.EventHandler(this.gBtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoDoc);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(270, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 122);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(11, 67);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(211, 31);
            this.txtFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(632, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(211, 31);
            this.txtUsuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(265, 67);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(243, 31);
            this.txtTipoDoc.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelefProv);
            this.groupBox2.Controls.Add(this.txtNomProv);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(270, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 122);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // txtTelefProv
            // 
            this.txtTelefProv.Location = new System.Drawing.Point(265, 67);
            this.txtTelefProv.Name = "txtTelefProv";
            this.txtTelefProv.Size = new System.Drawing.Size(243, 31);
            this.txtTelefProv.TabIndex = 6;
            // 
            // txtNomProv
            // 
            this.txtNomProv.Location = new System.Drawing.Point(11, 67);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(211, 31);
            this.txtNomProv.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre";
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
            this.Producto,
            this.Costo,
            this.Cantidad,
            this.SubTotal});
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
            this.gDgvData.Location = new System.Drawing.Point(231, 380);
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
            this.gDgvData.Size = new System.Drawing.Size(1145, 363);
            this.gDgvData.TabIndex = 66;
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
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(188, 788);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(211, 26);
            this.txtMontoTotal.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 791);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Monto Total";
            // 
            // Producto
            // 
            this.Producto.FillWeight = 355.9276F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 150;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.FillWeight = 204.3646F;
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 80;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 31.52491F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 300;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 200;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 838);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gDgvData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBtnLimpiarBusc);
            this.Controls.Add(this.gBtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Name = "frmDetalleCompra";
            this.Text = "frmDetalleCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiarBusc;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefProv;
        private System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}
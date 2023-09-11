namespace TaotitosFoodtruck.Src.Vista
{
    partial class FrmCrearIngrediente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.IconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.lblTipoIngrediente = new System.Windows.Forms.Label();
            this.lblDescipcion = new System.Windows.Forms.Label();
            this.txtDescrpcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantMax = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.lblIdTipo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIdIngrediente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconTitle)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(24, 247);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 38);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNombre.Location = new System.Drawing.Point(166, 249);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 36);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.WordWrap = false;
            // 
            // IconTitle
            // 
            this.IconTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconTitle.BackColor = System.Drawing.Color.Transparent;
            this.IconTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IconTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.IconTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.IconTitle.IconChar = FontAwesome.Sharp.IconChar.Palfed;
            this.IconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.IconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTitle.IconSize = 127;
            this.IconTitle.Location = new System.Drawing.Point(-6, -8);
            this.IconTitle.Margin = new System.Windows.Forms.Padding(0);
            this.IconTitle.Name = "IconTitle";
            this.IconTitle.Size = new System.Drawing.Size(487, 127);
            this.IconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconTitle.TabIndex = 3;
            this.IconTitle.TabStop = false;
            this.IconTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconTitle_MouseDown);
            // 
            // lblTipoIngrediente
            // 
            this.lblTipoIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoIngrediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.lblTipoIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoIngrediente.Font = new System.Drawing.Font("Maiandra GD", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIngrediente.ForeColor = System.Drawing.Color.White;
            this.lblTipoIngrediente.Location = new System.Drawing.Point(0, 20);
            this.lblTipoIngrediente.Margin = new System.Windows.Forms.Padding(10);
            this.lblTipoIngrediente.Name = "lblTipoIngrediente";
            this.lblTipoIngrediente.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.lblTipoIngrediente.Size = new System.Drawing.Size(389, 54);
            this.lblTipoIngrediente.TabIndex = 4;
            this.lblTipoIngrediente.Text = "Nombre de lo que sea";
            this.lblTipoIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescipcion
            // 
            this.lblDescipcion.AutoSize = true;
            this.lblDescipcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.lblDescipcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescipcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescipcion.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescipcion.ForeColor = System.Drawing.Color.White;
            this.lblDescipcion.Location = new System.Drawing.Point(148, 321);
            this.lblDescipcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescipcion.Name = "lblDescipcion";
            this.lblDescipcion.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.lblDescipcion.Size = new System.Drawing.Size(210, 50);
            this.lblDescipcion.TabIndex = 5;
            this.lblDescipcion.Text = "Descripcion";
            // 
            // txtDescrpcion
            // 
            this.txtDescrpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescrpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescrpcion.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrpcion.Location = new System.Drawing.Point(24, 376);
            this.txtDescrpcion.Multiline = true;
            this.txtDescrpcion.Name = "txtDescrpcion";
            this.txtDescrpcion.Size = new System.Drawing.Size(439, 162);
            this.txtDescrpcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(149, 572);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(315, 36);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(24, 570);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(104, 38);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(191, 630);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(275, 36);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantMax
            // 
            this.lblCantMax.AutoSize = true;
            this.lblCantMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.lblCantMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantMax.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMax.ForeColor = System.Drawing.Color.White;
            this.lblCantMax.Location = new System.Drawing.Point(24, 628);
            this.lblCantMax.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCantMax.Name = "lblCantMax";
            this.lblCantMax.Size = new System.Drawing.Size(144, 38);
            this.lblCantMax.TabIndex = 9;
            this.lblCantMax.Text = "Cantidad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(296, 738);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 5);
            this.panel2.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 50;
            this.btnGuardar.Location = new System.Drawing.Point(296, 686);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(81, 52);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(106, 738);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 5);
            this.panel1.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 50;
            this.btnCancelar.Location = new System.Drawing.Point(106, 686);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(81, 52);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdTipo
            // 
            this.lblIdTipo.AutoSize = true;
            this.lblIdTipo.Location = new System.Drawing.Point(379, 299);
            this.lblIdTipo.Name = "lblIdTipo";
            this.lblIdTipo.Size = new System.Drawing.Size(0, 27);
            this.lblIdTipo.TabIndex = 20;
            this.lblIdTipo.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTipoIngrediente);
            this.panel3.Location = new System.Drawing.Point(52, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 100);
            this.panel3.TabIndex = 21;
            // 
            // lblIdIngrediente
            // 
            this.lblIdIngrediente.AutoSize = true;
            this.lblIdIngrediente.Location = new System.Drawing.Point(30, 299);
            this.lblIdIngrediente.Name = "lblIdIngrediente";
            this.lblIdIngrediente.Size = new System.Drawing.Size(0, 27);
            this.lblIdIngrediente.TabIndex = 22;
            this.lblIdIngrediente.Visible = false;
            // 
            // FrmCrearIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(478, 764);
            this.Controls.Add(this.lblIdIngrediente);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblIdTipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantMax);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescrpcion);
            this.Controls.Add(this.lblDescipcion);
            this.Controls.Add(this.IconTitle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Maiandra GD", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCrearIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCrearIngrediente";
            ((System.ComponentModel.ISupportInitialize)(this.IconTitle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconPictureBox IconTitle;
        private System.Windows.Forms.Label lblTipoIngrediente;
        private System.Windows.Forms.Label lblDescipcion;
        private System.Windows.Forms.TextBox txtDescrpcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantMax;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblIdTipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIdIngrediente;
    }
}
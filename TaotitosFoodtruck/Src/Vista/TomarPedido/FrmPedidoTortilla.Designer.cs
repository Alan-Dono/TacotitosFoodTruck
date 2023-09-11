namespace TaotitosFoodtruck.Src.Vista.TomarPedido
{
    partial class FrmPedidoTortillo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPedidoTortilla = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTortillaAtras = new FontAwesome.Sharp.IconButton();
            this.pbSalsa = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTortillaSiguiente = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbDoble = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoTortilla)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPedidoTortilla);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chbDoble);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnTortillaAtras);
            this.splitContainer1.Panel2.Controls.Add(this.pbSalsa);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.btnTortillaSiguiente);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(961, 650);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvPedidoTortilla
            // 
            this.dgvPedidoTortilla.AllowUserToAddRows = false;
            this.dgvPedidoTortilla.AllowUserToDeleteRows = false;
            this.dgvPedidoTortilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvPedidoTortilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoTortilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPedidoTortilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoTortilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            this.dgvPedidoTortilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidoTortilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidoTortilla.EnableHeadersVisualStyles = false;
            this.dgvPedidoTortilla.GridColor = System.Drawing.Color.DarkRed;
            this.dgvPedidoTortilla.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidoTortilla.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvPedidoTortilla.Name = "dgvPedidoTortilla";
            this.dgvPedidoTortilla.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoTortilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPedidoTortilla.RowHeadersVisible = false;
            this.dgvPedidoTortilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPedidoTortilla.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvPedidoTortilla.RowTemplate.Height = 40;
            this.dgvPedidoTortilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoTortilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoTortilla.Size = new System.Drawing.Size(961, 543);
            this.dgvPedidoTortilla.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(753, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 5);
            this.panel1.TabIndex = 18;
            // 
            // btnTortillaAtras
            // 
            this.btnTortillaAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnTortillaAtras.FlatAppearance.BorderSize = 0;
            this.btnTortillaAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTortillaAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTortillaAtras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTortillaAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnTortillaAtras.IconColor = System.Drawing.Color.Black;
            this.btnTortillaAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTortillaAtras.IconSize = 60;
            this.btnTortillaAtras.Location = new System.Drawing.Point(753, 23);
            this.btnTortillaAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btnTortillaAtras.Name = "btnTortillaAtras";
            this.btnTortillaAtras.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTortillaAtras.Size = new System.Drawing.Size(66, 52);
            this.btnTortillaAtras.TabIndex = 17;
            this.btnTortillaAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTortillaAtras.UseVisualStyleBackColor = false;
            this.btnTortillaAtras.Click += new System.EventHandler(this.btnTortillaAtras_Click);
            // 
            // pbSalsa
            // 
            this.pbSalsa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbSalsa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbSalsa.Location = new System.Drawing.Point(51, 38);
            this.pbSalsa.Maximum = 75;
            this.pbSalsa.Name = "pbSalsa";
            this.pbSalsa.Size = new System.Drawing.Size(495, 23);
            this.pbSalsa.Step = 25;
            this.pbSalsa.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSalsa.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(846, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 5);
            this.panel2.TabIndex = 15;
            // 
            // btnTortillaSiguiente
            // 
            this.btnTortillaSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnTortillaSiguiente.FlatAppearance.BorderSize = 0;
            this.btnTortillaSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTortillaSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTortillaSiguiente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTortillaSiguiente.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnTortillaSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnTortillaSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTortillaSiguiente.IconSize = 60;
            this.btnTortillaSiguiente.Location = new System.Drawing.Point(846, 23);
            this.btnTortillaSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnTortillaSiguiente.Name = "btnTortillaSiguiente";
            this.btnTortillaSiguiente.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTortillaSiguiente.Size = new System.Drawing.Size(66, 52);
            this.btnTortillaSiguiente.TabIndex = 14;
            this.btnTortillaSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTortillaSiguiente.UseVisualStyleBackColor = false;
            this.btnTortillaSiguiente.Click += new System.EventHandler(this.btnTortillaSiguiente_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Aqua;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle26;
            this.Nombre.HeaderText = "Tortilla";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 135;
            // 
            // chbDoble
            // 
            this.chbDoble.AutoSize = true;
            this.chbDoble.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chbDoble.Location = new System.Drawing.Point(617, 18);
            this.chbDoble.Name = "chbDoble";
            this.chbDoble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbDoble.Size = new System.Drawing.Size(99, 57);
            this.chbDoble.TabIndex = 19;
            this.chbDoble.Text = "Doble";
            this.chbDoble.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoTortillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(961, 650);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmPedidoTortillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmPedidoTortillo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoTortilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPedidoTortilla;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTortillaAtras;
        private System.Windows.Forms.ProgressBar pbSalsa;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnTortillaSiguiente;
        private System.Windows.Forms.CheckBox chbDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
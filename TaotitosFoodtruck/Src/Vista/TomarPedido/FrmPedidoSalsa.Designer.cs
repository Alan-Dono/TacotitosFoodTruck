namespace TaotitosFoodtruck.Src.Vista.TomarPedido
{
    partial class FrmPedidoSalsa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSalsa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalaAtras = new FontAwesome.Sharp.IconButton();
            this.pbSalsa = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalsaSiguiente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalsa)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvSalsa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalaAtras);
            this.splitContainer1.Panel2.Controls.Add(this.pbSalsa);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalsaSiguiente);
            this.splitContainer1.Size = new System.Drawing.Size(961, 650);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvSalsa
            // 
            this.dgvSalsa.AllowUserToAddRows = false;
            this.dgvSalsa.AllowUserToDeleteRows = false;
            this.dgvSalsa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvSalsa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalsa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            this.dgvSalsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSalsa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalsa.EnableHeadersVisualStyles = false;
            this.dgvSalsa.GridColor = System.Drawing.Color.DarkRed;
            this.dgvSalsa.Location = new System.Drawing.Point(0, 0);
            this.dgvSalsa.Name = "dgvSalsa";
            this.dgvSalsa.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalsa.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSalsa.RowHeadersVisible = false;
            this.dgvSalsa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSalsa.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSalsa.RowTemplate.Height = 40;
            this.dgvSalsa.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalsa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalsa.Size = new System.Drawing.Size(961, 543);
            this.dgvSalsa.TabIndex = 1;
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle6;
            this.Nombre.HeaderText = "Salsa";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 115;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(741, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 5);
            this.panel1.TabIndex = 13;
            // 
            // btnSalaAtras
            // 
            this.btnSalaAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnSalaAtras.FlatAppearance.BorderSize = 0;
            this.btnSalaAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalaAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaAtras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnSalaAtras.IconColor = System.Drawing.Color.Black;
            this.btnSalaAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalaAtras.IconSize = 60;
            this.btnSalaAtras.Location = new System.Drawing.Point(741, 25);
            this.btnSalaAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalaAtras.Name = "btnSalaAtras";
            this.btnSalaAtras.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnSalaAtras.Size = new System.Drawing.Size(66, 52);
            this.btnSalaAtras.TabIndex = 12;
            this.btnSalaAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaAtras.UseVisualStyleBackColor = false;
            this.btnSalaAtras.Click += new System.EventHandler(this.btnSalaAtras_Click);
            // 
            // pbSalsa
            // 
            this.pbSalsa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbSalsa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbSalsa.Location = new System.Drawing.Point(39, 40);
            this.pbSalsa.Name = "pbSalsa";
            this.pbSalsa.Size = new System.Drawing.Size(625, 23);
            this.pbSalsa.Step = 75;
            this.pbSalsa.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSalsa.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(836, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 5);
            this.panel2.TabIndex = 10;
            // 
            // btnSalsaSiguiente
            // 
            this.btnSalsaSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnSalsaSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSalsaSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalsaSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalsaSiguiente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalsaSiguiente.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnSalsaSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnSalsaSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalsaSiguiente.IconSize = 60;
            this.btnSalsaSiguiente.Location = new System.Drawing.Point(836, 25);
            this.btnSalsaSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalsaSiguiente.Name = "btnSalsaSiguiente";
            this.btnSalsaSiguiente.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnSalsaSiguiente.Size = new System.Drawing.Size(66, 52);
            this.btnSalsaSiguiente.TabIndex = 9;
            this.btnSalsaSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalsaSiguiente.UseVisualStyleBackColor = false;
            // 
            // FrmPedidoSalsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(961, 650);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmPedidoSalsa";
            this.Text = "FrmPedidoTortillo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalsa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar pbSalsa;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSalsaSiguiente;
        private System.Windows.Forms.DataGridView dgvSalsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSalaAtras;
    }
}
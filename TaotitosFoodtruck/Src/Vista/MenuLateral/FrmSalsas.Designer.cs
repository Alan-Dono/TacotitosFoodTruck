namespace TaotitosFoodtruck.Src.Vista
{
    partial class FrmSalsas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevaSalsa = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModificarSalsa = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEliminarSalsa = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSalsa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalsa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaSalsa
            // 
            this.btnNuevaSalsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnNuevaSalsa.FlatAppearance.BorderSize = 0;
            this.btnNuevaSalsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevaSalsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaSalsa.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaSalsa.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnNuevaSalsa.IconColor = System.Drawing.Color.Black;
            this.btnNuevaSalsa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaSalsa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaSalsa.Location = new System.Drawing.Point(62, 21);
            this.btnNuevaSalsa.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevaSalsa.Name = "btnNuevaSalsa";
            this.btnNuevaSalsa.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnNuevaSalsa.Size = new System.Drawing.Size(227, 52);
            this.btnNuevaSalsa.TabIndex = 1;
            this.btnNuevaSalsa.Text = "Nuevo";
            this.btnNuevaSalsa.UseVisualStyleBackColor = false;
            this.btnNuevaSalsa.Click += new System.EventHandler(this.btnNuevaSalsa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(62, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 5);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(361, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 5);
            this.panel3.TabIndex = 4;
            // 
            // btnModificarSalsa
            // 
            this.btnModificarSalsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnModificarSalsa.FlatAppearance.BorderSize = 0;
            this.btnModificarSalsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificarSalsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSalsa.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSalsa.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificarSalsa.IconColor = System.Drawing.Color.Black;
            this.btnModificarSalsa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarSalsa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarSalsa.Location = new System.Drawing.Point(361, 21);
            this.btnModificarSalsa.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarSalsa.Name = "btnModificarSalsa";
            this.btnModificarSalsa.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnModificarSalsa.Size = new System.Drawing.Size(227, 52);
            this.btnModificarSalsa.TabIndex = 3;
            this.btnModificarSalsa.Text = "Modificar";
            this.btnModificarSalsa.UseVisualStyleBackColor = false;
            this.btnModificarSalsa.Click += new System.EventHandler(this.btnModificarSalsa_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(668, 73);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 5);
            this.panel4.TabIndex = 6;
            // 
            // btnEliminarSalsa
            // 
            this.btnEliminarSalsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnEliminarSalsa.FlatAppearance.BorderSize = 0;
            this.btnEliminarSalsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminarSalsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSalsa.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSalsa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarSalsa.IconColor = System.Drawing.Color.Black;
            this.btnEliminarSalsa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarSalsa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarSalsa.Location = new System.Drawing.Point(668, 21);
            this.btnEliminarSalsa.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarSalsa.Name = "btnEliminarSalsa";
            this.btnEliminarSalsa.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnEliminarSalsa.Size = new System.Drawing.Size(227, 52);
            this.btnEliminarSalsa.TabIndex = 5;
            this.btnEliminarSalsa.Text = "Eliminar";
            this.btnEliminarSalsa.UseVisualStyleBackColor = false;
            this.btnEliminarSalsa.Click += new System.EventHandler(this.btnEliminarSalsa_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.btnNuevaSalsa);
            this.splitContainer1.Panel2.Controls.Add(this.btnEliminarSalsa);
            this.splitContainer1.Panel2.Controls.Add(this.btnModificarSalsa);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(961, 650);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSalsa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 543);
            this.panel1.TabIndex = 0;
            // 
            // dgvSalsa
            // 
            this.dgvSalsa.AllowUserToAddRows = false;
            this.dgvSalsa.AllowUserToDeleteRows = false;
            this.dgvSalsa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvSalsa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalsa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalsa.RowHeadersVisible = false;
            this.dgvSalsa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSalsa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalsa.RowTemplate.Height = 40;
            this.dgvSalsa.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalsa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalsa.Size = new System.Drawing.Size(961, 543);
            this.dgvSalsa.TabIndex = 0;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "Salsa";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 128;
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
            this.Precio.Width = 139;
            // 
            // FrmSalsas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(961, 650);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalsas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSalsas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalsa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnNuevaSalsa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnModificarSalsa;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnEliminarSalsa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSalsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
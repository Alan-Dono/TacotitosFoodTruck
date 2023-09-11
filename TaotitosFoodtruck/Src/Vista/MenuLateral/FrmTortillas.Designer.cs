namespace TaotitosFoodtruck.Src.Vista
{
    partial class FrmTortillas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTortilla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNuevaTortilla = new FontAwesome.Sharp.IconButton();
            this.btnEliminarTortilla = new FontAwesome.Sharp.IconButton();
            this.btnModificarTortilla = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTortilla)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTortilla);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.btnNuevaTortilla);
            this.splitContainer1.Panel2.Controls.Add(this.btnEliminarTortilla);
            this.splitContainer1.Panel2.Controls.Add(this.btnModificarTortilla);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(961, 650);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvTortilla
            // 
            this.dgvTortilla.AllowUserToAddRows = false;
            this.dgvTortilla.AllowUserToDeleteRows = false;
            this.dgvTortilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvTortilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTortilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTortilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTortilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            this.dgvTortilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTortilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTortilla.EnableHeadersVisualStyles = false;
            this.dgvTortilla.GridColor = System.Drawing.Color.DarkRed;
            this.dgvTortilla.Location = new System.Drawing.Point(0, 0);
            this.dgvTortilla.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvTortilla.Name = "dgvTortilla";
            this.dgvTortilla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTortilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTortilla.RowHeadersVisible = false;
            this.dgvTortilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTortilla.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTortilla.RowTemplate.Height = 40;
            this.dgvTortilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTortilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTortilla.Size = new System.Drawing.Size(961, 543);
            this.dgvTortilla.TabIndex = 1;
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
            this.Nombre.HeaderText = "Tortilla";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 144;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(64, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 5);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(667, 67);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 5);
            this.panel4.TabIndex = 12;
            // 
            // btnNuevaTortilla
            // 
            this.btnNuevaTortilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnNuevaTortilla.FlatAppearance.BorderSize = 0;
            this.btnNuevaTortilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevaTortilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTortilla.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTortilla.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnNuevaTortilla.IconColor = System.Drawing.Color.Black;
            this.btnNuevaTortilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaTortilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaTortilla.Location = new System.Drawing.Point(64, 15);
            this.btnNuevaTortilla.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevaTortilla.Name = "btnNuevaTortilla";
            this.btnNuevaTortilla.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnNuevaTortilla.Size = new System.Drawing.Size(227, 52);
            this.btnNuevaTortilla.TabIndex = 7;
            this.btnNuevaTortilla.Text = "Nuevo";
            this.btnNuevaTortilla.UseVisualStyleBackColor = false;
            this.btnNuevaTortilla.Click += new System.EventHandler(this.btnNuevaTortilla_Click);
            // 
            // btnEliminarTortilla
            // 
            this.btnEliminarTortilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnEliminarTortilla.FlatAppearance.BorderSize = 0;
            this.btnEliminarTortilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminarTortilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTortilla.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTortilla.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarTortilla.IconColor = System.Drawing.Color.Black;
            this.btnEliminarTortilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarTortilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTortilla.Location = new System.Drawing.Point(667, 15);
            this.btnEliminarTortilla.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarTortilla.Name = "btnEliminarTortilla";
            this.btnEliminarTortilla.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnEliminarTortilla.Size = new System.Drawing.Size(227, 52);
            this.btnEliminarTortilla.TabIndex = 11;
            this.btnEliminarTortilla.Text = "Eliminar";
            this.btnEliminarTortilla.UseVisualStyleBackColor = false;
            this.btnEliminarTortilla.Click += new System.EventHandler(this.btnEliminarTortilla_Click);
            // 
            // btnModificarTortilla
            // 
            this.btnModificarTortilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnModificarTortilla.FlatAppearance.BorderSize = 0;
            this.btnModificarTortilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificarTortilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTortilla.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTortilla.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificarTortilla.IconColor = System.Drawing.Color.Black;
            this.btnModificarTortilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarTortilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarTortilla.Location = new System.Drawing.Point(362, 15);
            this.btnModificarTortilla.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarTortilla.Name = "btnModificarTortilla";
            this.btnModificarTortilla.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnModificarTortilla.Size = new System.Drawing.Size(227, 52);
            this.btnModificarTortilla.TabIndex = 9;
            this.btnModificarTortilla.Text = "Modificar";
            this.btnModificarTortilla.UseVisualStyleBackColor = false;
            this.btnModificarTortilla.Click += new System.EventHandler(this.btnModificarTortilla_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(362, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 5);
            this.panel3.TabIndex = 10;
            // 
            // FrmTortillas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(961, 650);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmTortillas";
            this.Load += new System.EventHandler(this.FrmTortillas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTortilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnNuevaTortilla;
        private FontAwesome.Sharp.IconButton btnEliminarTortilla;
        private FontAwesome.Sharp.IconButton btnModificarTortilla;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTortilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
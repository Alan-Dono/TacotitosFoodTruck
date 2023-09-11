namespace TaotitosFoodtruck.Src.Vista
{
    partial class FrmIngredientes
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
            this.btnNuevoAlimento = new FontAwesome.Sharp.IconButton();
            this.btnEliminarAlimento = new FontAwesome.Sharp.IconButton();
            this.btnModificarAlimento = new FontAwesome.Sharp.IconButton();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnNuevoAlimento);
            this.splitContainer1.Panel2.Controls.Add(this.btnEliminarAlimento);
            this.splitContainer1.Panel2.Controls.Add(this.btnModificarAlimento);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(961, 650);
            this.splitContainer1.SplitterDistance = 543;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvTortilla.TabIndex = 2;
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
            this.Nombre.HeaderText = "Relleno";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 154;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(65, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 5);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(668, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 5);
            this.panel4.TabIndex = 18;
            // 
            // btnNuevoAlimento
            // 
            this.btnNuevoAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnNuevoAlimento.FlatAppearance.BorderSize = 0;
            this.btnNuevoAlimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevoAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAlimento.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlimento.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnNuevoAlimento.IconColor = System.Drawing.Color.Black;
            this.btnNuevoAlimento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAlimento.Location = new System.Drawing.Point(65, 23);
            this.btnNuevoAlimento.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevoAlimento.Name = "btnNuevoAlimento";
            this.btnNuevoAlimento.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnNuevoAlimento.Size = new System.Drawing.Size(227, 52);
            this.btnNuevoAlimento.TabIndex = 13;
            this.btnNuevoAlimento.Text = "Nuevo";
            this.btnNuevoAlimento.UseVisualStyleBackColor = false;
            this.btnNuevoAlimento.Click += new System.EventHandler(this.btnNuevoAlimento_Click);
            // 
            // btnEliminarAlimento
            // 
            this.btnEliminarAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnEliminarAlimento.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlimento.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlimento.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarAlimento.IconColor = System.Drawing.Color.Black;
            this.btnEliminarAlimento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAlimento.Location = new System.Drawing.Point(668, 23);
            this.btnEliminarAlimento.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarAlimento.Name = "btnEliminarAlimento";
            this.btnEliminarAlimento.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnEliminarAlimento.Size = new System.Drawing.Size(227, 52);
            this.btnEliminarAlimento.TabIndex = 17;
            this.btnEliminarAlimento.Text = "Eliminar";
            this.btnEliminarAlimento.UseVisualStyleBackColor = false;
            this.btnEliminarAlimento.Click += new System.EventHandler(this.btnEliminarAlimento_Click);
            // 
            // btnModificarAlimento
            // 
            this.btnModificarAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnModificarAlimento.FlatAppearance.BorderSize = 0;
            this.btnModificarAlimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlimento.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlimento.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificarAlimento.IconColor = System.Drawing.Color.Black;
            this.btnModificarAlimento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarAlimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlimento.Location = new System.Drawing.Point(363, 23);
            this.btnModificarAlimento.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarAlimento.Name = "btnModificarAlimento";
            this.btnModificarAlimento.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnModificarAlimento.Size = new System.Drawing.Size(227, 52);
            this.btnModificarAlimento.TabIndex = 15;
            this.btnModificarAlimento.Text = "Modificar";
            this.btnModificarAlimento.UseVisualStyleBackColor = false;
            this.btnModificarAlimento.Click += new System.EventHandler(this.btnModificarAlimento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(363, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 5);
            this.panel3.TabIndex = 16;
            // 
            // FrmIngredientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(961, 650);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmIngredientes";
            this.Load += new System.EventHandler(this.FrmIngredientes_Load);
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
        private FontAwesome.Sharp.IconButton btnNuevoAlimento;
        private FontAwesome.Sharp.IconButton btnEliminarAlimento;
        private FontAwesome.Sharp.IconButton btnModificarAlimento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTortilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
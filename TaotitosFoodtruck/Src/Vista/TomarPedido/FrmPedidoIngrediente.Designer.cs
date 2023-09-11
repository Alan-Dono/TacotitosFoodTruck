namespace TaotitosFoodtruck.Src.Vista.TomarPedido
{
    partial class FrmPedidoIngrediente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlimentoAtras = new FontAwesome.Sharp.IconButton();
            this.pbSalsa = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlimentoSiguiente = new FontAwesome.Sharp.IconButton();
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlimentoAtras);
            this.splitContainer1.Panel2.Controls.Add(this.pbSalsa);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlimentoSiguiente);
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
            this.dgvTortilla.TabIndex = 3;
            this.dgvTortilla.SelectionChanged += new System.EventHandler(this.dgvTortilla_SelectionChanged_1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(751, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 5);
            this.panel1.TabIndex = 18;
            // 
            // btnAlimentoAtras
            // 
            this.btnAlimentoAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnAlimentoAtras.FlatAppearance.BorderSize = 0;
            this.btnAlimentoAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlimentoAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentoAtras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentoAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnAlimentoAtras.IconColor = System.Drawing.Color.Black;
            this.btnAlimentoAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlimentoAtras.IconSize = 60;
            this.btnAlimentoAtras.Location = new System.Drawing.Point(751, 23);
            this.btnAlimentoAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlimentoAtras.Name = "btnAlimentoAtras";
            this.btnAlimentoAtras.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnAlimentoAtras.Size = new System.Drawing.Size(66, 52);
            this.btnAlimentoAtras.TabIndex = 17;
            this.btnAlimentoAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlimentoAtras.UseVisualStyleBackColor = false;
            this.btnAlimentoAtras.Click += new System.EventHandler(this.btnAlimentoAtras_Click);
            // 
            // pbSalsa
            // 
            this.pbSalsa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbSalsa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbSalsa.Location = new System.Drawing.Point(49, 38);
            this.pbSalsa.Maximum = 75;
            this.pbSalsa.Name = "pbSalsa";
            this.pbSalsa.Size = new System.Drawing.Size(495, 23);
            this.pbSalsa.Step = 25;
            this.pbSalsa.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSalsa.TabIndex = 16;
            this.pbSalsa.Value = 25;
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
            // btnAlimentoSiguiente
            // 
            this.btnAlimentoSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            this.btnAlimentoSiguiente.FlatAppearance.BorderSize = 0;
            this.btnAlimentoSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlimentoSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentoSiguiente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentoSiguiente.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnAlimentoSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnAlimentoSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlimentoSiguiente.IconSize = 60;
            this.btnAlimentoSiguiente.Location = new System.Drawing.Point(846, 23);
            this.btnAlimentoSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlimentoSiguiente.Name = "btnAlimentoSiguiente";
            this.btnAlimentoSiguiente.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnAlimentoSiguiente.Size = new System.Drawing.Size(66, 52);
            this.btnAlimentoSiguiente.TabIndex = 14;
            this.btnAlimentoSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlimentoSiguiente.UseVisualStyleBackColor = false;
            this.btnAlimentoSiguiente.Click += new System.EventHandler(this.btnAlimentoSiguiente_Click);
            // 
            // FrmPedidoIngrediente
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
            this.Name = "FrmPedidoIngrediente";
            this.Text = "FrmPedidoIngrediente";
            this.Load += new System.EventHandler(this.FrmPedidoIngrediente_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTortilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTortilla;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAlimentoAtras;
        private System.Windows.Forms.ProgressBar pbSalsa;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAlimentoSiguiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
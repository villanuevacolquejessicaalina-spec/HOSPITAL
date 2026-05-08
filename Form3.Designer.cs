namespace HOSPITAL
{
    partial class Form3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvJornadas = new System.Windows.Forms.DataGridView();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnNuevaJornada = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJornadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(494, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HISTORIAL DE JORNADAS LABORALES";
            // 
            // dgvJornadas
            // 
            this.dgvJornadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJornadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvJornadas.Location = new System.Drawing.Point(44, 41);
            this.dgvJornadas.MultiSelect = false;
            this.dgvJornadas.Name = "dgvJornadas";
            this.dgvJornadas.RowHeadersWidth = 51;
            this.dgvJornadas.RowTemplate.Height = 24;
            this.dgvJornadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJornadas.Size = new System.Drawing.Size(1123, 571);
            this.dgvJornadas.TabIndex = 1;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.Yellow;
            this.btnVerDetalle.Location = new System.Drawing.Point(439, 636);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(104, 27);
            this.btnVerDetalle.TabIndex = 2;
            this.btnVerDetalle.Text = "Ver/Editar";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnNuevaJornada
            // 
            this.btnNuevaJornada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevaJornada.Location = new System.Drawing.Point(560, 636);
            this.btnNuevaJornada.Name = "btnNuevaJornada";
            this.btnNuevaJornada.Size = new System.Drawing.Size(89, 27);
            this.btnNuevaJornada.TabIndex = 3;
            this.btnNuevaJornada.Text = "Nueva lista";
            this.btnNuevaJornada.UseVisualStyleBackColor = false;
            this.btnNuevaJornada.Click += new System.EventHandler(this.btnNuevaJornada_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolver.Location = new System.Drawing.Point(663, 635);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 27);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 705);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevaJornada);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.dgvJornadas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJornadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvJornadas;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnNuevaJornada;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
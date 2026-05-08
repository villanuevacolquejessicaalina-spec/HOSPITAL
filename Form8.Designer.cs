namespace HOSPITAL
{
    partial class Form8
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
            this.dgvHistorialFechas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialFechas
            // 
            this.dgvHistorialFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHistorialFechas.Location = new System.Drawing.Point(78, 98);
            this.dgvHistorialFechas.Name = "dgvHistorialFechas";
            this.dgvHistorialFechas.RowHeadersWidth = 51;
            this.dgvHistorialFechas.RowTemplate.Height = 24;
            this.dgvHistorialFechas.Size = new System.Drawing.Size(549, 285);
            this.dgvHistorialFechas.TabIndex = 1;
            this.dgvHistorialFechas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialFechas_CellContentClick);
            this.dgvHistorialFechas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialFechas_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Motivo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHistorialFechas);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHistorialFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
namespace HOSPITAL
{
    partial class Form7
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvCitasDia = new System.Windows.Forms.DataGridView();
            this.txtCIEmergencia = new System.Windows.Forms.TextBox();
            this.cmbEspecialidadE = new System.Windows.Forms.ComboBox();
            this.btnAgregarEmergencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(90, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "label1";
            // 
            // dgvCitasDia
            // 
            this.dgvCitasDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCitasDia.Location = new System.Drawing.Point(93, 64);
            this.dgvCitasDia.Name = "dgvCitasDia";
            this.dgvCitasDia.RowHeadersWidth = 51;
            this.dgvCitasDia.RowTemplate.Height = 24;
            this.dgvCitasDia.Size = new System.Drawing.Size(720, 407);
            this.dgvCitasDia.TabIndex = 1;
            // 
            // txtCIEmergencia
            // 
            this.txtCIEmergencia.Location = new System.Drawing.Point(111, 501);
            this.txtCIEmergencia.Name = "txtCIEmergencia";
            this.txtCIEmergencia.Size = new System.Drawing.Size(144, 22);
            this.txtCIEmergencia.TabIndex = 2;
            // 
            // cmbEspecialidadE
            // 
            this.cmbEspecialidadE.FormattingEnabled = true;
            this.cmbEspecialidadE.Location = new System.Drawing.Point(370, 501);
            this.cmbEspecialidadE.Name = "cmbEspecialidadE";
            this.cmbEspecialidadE.Size = new System.Drawing.Size(260, 24);
            this.cmbEspecialidadE.TabIndex = 3;
            // 
            // btnAgregarEmergencia
            // 
            this.btnAgregarEmergencia.Location = new System.Drawing.Point(658, 501);
            this.btnAgregarEmergencia.Name = "btnAgregarEmergencia";
            this.btnAgregarEmergencia.Size = new System.Drawing.Size(81, 24);
            this.btnAgregarEmergencia.TabIndex = 4;
            this.btnAgregarEmergencia.Text = "Agregar";
            this.btnAgregarEmergencia.UseVisualStyleBackColor = true;
            this.btnAgregarEmergencia.Click += new System.EventHandler(this.btnAgregarEmergencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "CI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Especialidades:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CI";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Especialidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarEmergencia);
            this.Controls.Add(this.cmbEspecialidadE);
            this.Controls.Add(this.txtCIEmergencia);
            this.Controls.Add(this.dgvCitasDia);
            this.Controls.Add(this.lblFecha);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvCitasDia;
        private System.Windows.Forms.TextBox txtCIEmergencia;
        private System.Windows.Forms.ComboBox cmbEspecialidadE;
        private System.Windows.Forms.Button btnAgregarEmergencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
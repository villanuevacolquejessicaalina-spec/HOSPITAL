namespace HOSPITAL
{
    partial class Form5
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
            this.txtFechaJornada = new System.Windows.Forms.DateTimePicker();
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarALista = new System.Windows.Forms.Button();
            this.cmbMedicoEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtCIPaciente = new System.Windows.Forms.TextBox();
            this.dgvTempJornada = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarJornada = new System.Windows.Forms.Button();
            this.btnIniciarConsulta = new System.Windows.Forms.Button();
            this.gbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempJornada)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaJornada
            // 
            this.txtFechaJornada.Location = new System.Drawing.Point(88, 23);
            this.txtFechaJornada.Name = "txtFechaJornada";
            this.txtFechaJornada.Size = new System.Drawing.Size(256, 22);
            this.txtFechaJornada.TabIndex = 0;
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.label2);
            this.gbIngreso.Controls.Add(this.label1);
            this.gbIngreso.Controls.Add(this.btnAgregarALista);
            this.gbIngreso.Controls.Add(this.cmbMedicoEspecialidad);
            this.gbIngreso.Controls.Add(this.txtCIPaciente);
            this.gbIngreso.Location = new System.Drawing.Point(88, 71);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(725, 77);
            this.gbIngreso.TabIndex = 1;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingresar paciente a consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Especialidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CI:";
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarALista.Location = new System.Drawing.Point(628, 34);
            this.btnAgregarALista.Name = "btnAgregarALista";
            this.btnAgregarALista.Size = new System.Drawing.Size(82, 25);
            this.btnAgregarALista.TabIndex = 2;
            this.btnAgregarALista.Text = "Agregar";
            this.btnAgregarALista.UseVisualStyleBackColor = false;
            this.btnAgregarALista.Click += new System.EventHandler(this.btnAgregarALista_Click);
            // 
            // cmbMedicoEspecialidad
            // 
            this.cmbMedicoEspecialidad.FormattingEnabled = true;
            this.cmbMedicoEspecialidad.Location = new System.Drawing.Point(348, 34);
            this.cmbMedicoEspecialidad.Name = "cmbMedicoEspecialidad";
            this.cmbMedicoEspecialidad.Size = new System.Drawing.Size(274, 24);
            this.cmbMedicoEspecialidad.TabIndex = 1;
            // 
            // txtCIPaciente
            // 
            this.txtCIPaciente.Location = new System.Drawing.Point(69, 34);
            this.txtCIPaciente.Name = "txtCIPaciente";
            this.txtCIPaciente.Size = new System.Drawing.Size(142, 22);
            this.txtCIPaciente.TabIndex = 0;
            // 
            // dgvTempJornada
            // 
            this.dgvTempJornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempJornada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTempJornada.Location = new System.Drawing.Point(88, 155);
            this.dgvTempJornada.Name = "dgvTempJornada";
            this.dgvTempJornada.RowHeadersWidth = 51;
            this.dgvTempJornada.RowTemplate.Height = 24;
            this.dgvTempJornada.Size = new System.Drawing.Size(931, 457);
            this.dgvTempJornada.TabIndex = 2;
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
            // btnGuardarJornada
            // 
            this.btnGuardarJornada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarJornada.Location = new System.Drawing.Point(501, 627);
            this.btnGuardarJornada.Name = "btnGuardarJornada";
            this.btnGuardarJornada.Size = new System.Drawing.Size(105, 38);
            this.btnGuardarJornada.TabIndex = 3;
            this.btnGuardarJornada.Text = "Guardar Lista";
            this.btnGuardarJornada.UseVisualStyleBackColor = false;
            this.btnGuardarJornada.Click += new System.EventHandler(this.btnGuardarJornada_Click);
            // 
            // btnIniciarConsulta
            // 
            this.btnIniciarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIniciarConsulta.Location = new System.Drawing.Point(658, 627);
            this.btnIniciarConsulta.Name = "btnIniciarConsulta";
            this.btnIniciarConsulta.Size = new System.Drawing.Size(155, 38);
            this.btnIniciarConsulta.TabIndex = 4;
            this.btnIniciarConsulta.Text = "Iniciar Consulta";
            this.btnIniciarConsulta.UseVisualStyleBackColor = false;
            this.btnIniciarConsulta.Click += new System.EventHandler(this.btnIniciarConsulta_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 689);
            this.Controls.Add(this.btnIniciarConsulta);
            this.Controls.Add(this.btnGuardarJornada);
            this.Controls.Add(this.dgvTempJornada);
            this.Controls.Add(this.gbIngreso);
            this.Controls.Add(this.txtFechaJornada);
            this.Name = "Form5";
            this.Text = "Form5";
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempJornada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtFechaJornada;
        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.Button btnAgregarALista;
        private System.Windows.Forms.ComboBox cmbMedicoEspecialidad;
        private System.Windows.Forms.TextBox txtCIPaciente;
        private System.Windows.Forms.DataGridView dgvTempJornada;
        private System.Windows.Forms.Button btnGuardarJornada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnIniciarConsulta;
    }
}
namespace HOSPITAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModuloPacientes = new System.Windows.Forms.Button();
            this.btnModuloCitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModuloPacientes
            // 
            this.btnModuloPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModuloPacientes.Location = new System.Drawing.Point(86, 113);
            this.btnModuloPacientes.Name = "btnModuloPacientes";
            this.btnModuloPacientes.Size = new System.Drawing.Size(119, 38);
            this.btnModuloPacientes.TabIndex = 0;
            this.btnModuloPacientes.Text = "PACIENTES";
            this.btnModuloPacientes.UseVisualStyleBackColor = false;
            this.btnModuloPacientes.Click += new System.EventHandler(this.btnModuloPacientes_Click);
            // 
            // btnModuloCitas
            // 
            this.btnModuloCitas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnModuloCitas.Location = new System.Drawing.Point(274, 113);
            this.btnModuloCitas.Name = "btnModuloCitas";
            this.btnModuloCitas.Size = new System.Drawing.Size(120, 38);
            this.btnModuloCitas.TabIndex = 1;
            this.btnModuloCitas.Text = "CITAS";
            this.btnModuloCitas.UseVisualStyleBackColor = false;
            this.btnModuloCitas.Click += new System.EventHandler(this.btnModuloCitas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 281);
            this.Controls.Add(this.btnModuloCitas);
            this.Controls.Add(this.btnModuloPacientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModuloPacientes;
        private System.Windows.Forms.Button btnModuloCitas;
    }
}


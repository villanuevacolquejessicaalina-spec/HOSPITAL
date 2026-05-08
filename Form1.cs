using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModuloPacientes_Click(object sender, EventArgs e)
        {
            Form2 ventanaPacientes = new Form2();
            ventanaPacientes.ShowDialog();
        }

        private void btnModuloCitas_Click(object sender, EventArgs e)
        {
            Form3 ventanaCitas = new Form3();
            ventanaCitas.ShowDialog();
        }

    }

}

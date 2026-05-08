using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace HOSPITAL
{
    public partial class Form2 : Form
    {
        private string DATA_FILE = "pacientes_hospital.json";
        private Dictionary<string, Paciente> pacientes;
        public Form2()
        {
            InitializeComponent();
            CargarDatos();
            MostrarPacientes();
        }
        private void CargarDatos()
        {
            if (File.Exists(DATA_FILE))
            {
                string json = File.ReadAllText(DATA_FILE);
                pacientes = JsonConvert.DeserializeObject<Dictionary<string, Paciente>>(json);
            }
            else
            {
                pacientes = new Dictionary<string, Paciente>();
            }
        }
        private void GuardarDatos()
        {
            string json = JsonConvert.SerializeObject(pacientes, Formatting.Indented);
            File.WriteAllText(DATA_FILE, json);
        }
        private void MostrarPacientes()
        {
            dgvPacientes.Rows.Clear();

            if (pacientes != null)
            {
                foreach (var item in pacientes)
                {
                    dgvPacientes.Rows.Add(item.Key, item.Value.Nombre, item.Value.Sexo, item.Value.Telefono);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                string ci = dgvPacientes.SelectedRows[0].Cells[0].Value.ToString();

                var resultado = MessageBox.Show($"¿Está seguro de eliminar al paciente con CI: {ci}?",
                                               "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    pacientes.Remove(ci);
                    GuardarDatos();
                    MostrarPacientes();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ci = txtBuscarCI.Text;
            if (pacientes.ContainsKey(ci))
            {
                dgvPacientes.Rows.Clear();
                var p = pacientes[ci];
                dgvPacientes.Rows.Add(ci, p.Nombre, p.Sexo, p.Telefono);
            }
            else
            {
                MessageBox.Show("Paciente no encontrado.", "Búsqueda");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscarCI.Clear();
            MostrarPacientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form4 ventana = new Form4();
            ventana.ShowDialog(); 

            CargarDatos();    
            MostrarPacientes();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                string ci = dgvPacientes.SelectedRows[0].Cells[0].Value.ToString();
                Form6 ventanaConsulta = new Form6(ci);
                ventanaConsulta.ShowDialog();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatos();
            MostrarPacientes();
        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ci = dgvPacientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (pacientes.ContainsKey(ci))
                {
                    Form8 historial = new Form8(pacientes[ci]);
                    historial.ShowDialog();
                }
            }

        }
    }
 
}

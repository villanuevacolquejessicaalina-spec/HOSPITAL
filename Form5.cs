using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HOSPITAL.Form3;
using System.IO;

namespace HOSPITAL
{
    public partial class Form5 : Form
    {
        private string DATA_FILE = "pacientes_hospital.json";
        private string CITAS_FILE = "citas_hospital.json";

        private Dictionary<string, Paciente> pacientes;
        private Dictionary<string, List<Cita>> citasDiarias;
        private List<Cita> listaTemporalJornada = new List<Cita>();
        public Form5()
        {
            InitializeComponent();
            CargarTodosLosDatos();
            txtFechaJornada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbMedicoEspecialidad.Items.Add("Dr. López - Medicina General");
            cmbMedicoEspecialidad.Items.Add("Dra. Vargas - Pediatría");
            cmbMedicoEspecialidad.Items.Add("Dr. Choque - Odontología");
            cmbMedicoEspecialidad.Items.Add("Dra. Salas - Ginecología");
            if (cmbMedicoEspecialidad.Items.Count > 0)
                cmbMedicoEspecialidad.SelectedIndex = 0;
        }
        private void CargarTodosLosDatos()
        {
            if (File.Exists(DATA_FILE))
                pacientes = JsonConvert.DeserializeObject<Dictionary<string, Paciente>>(File.ReadAllText(DATA_FILE));
            else
                pacientes = new Dictionary<string, Paciente>();
            if (File.Exists(CITAS_FILE))
                citasDiarias = JsonConvert.DeserializeObject<Dictionary<string, List<Cita>>>(File.ReadAllText(CITAS_FILE));
            else
                citasDiarias = new Dictionary<string, List<Cita>>();
        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            string ci = txtCIPaciente.Text.Trim();

            if (pacientes.ContainsKey(ci) && cmbMedicoEspecialidad.SelectedIndex != -1)
            {
                string[] partes = cmbMedicoEspecialidad.Text.Split('-');
                string medico = partes[0].Trim();
                string especialidad = partes[1].Trim();
                Cita nuevaCita = new Cita
                {
                    Ci = ci,
                    Nombre = pacientes[ci].Nombre,
                    Medico = medico,
                    Especialidad = especialidad
                };

                listaTemporalJornada.Add(nuevaCita);
                dgvTempJornada.Rows.Add(nuevaCita.Ci, nuevaCita.Nombre, nuevaCita.Medico);
                txtCIPaciente.Clear();
            }
            else
            {
                MessageBox.Show("CI no encontrado o médico no seleccionado.", "Aviso");
            }
        }

        private void btnGuardarJornada_Click(object sender, EventArgs e)
        {
            string fecha = txtFechaJornada.Text.Trim();

            if (listaTemporalJornada.Count == 0)
            {
                MessageBox.Show("No hay pacientes en la lista de hoy.");
                return;
            }
            if (citasDiarias.ContainsKey(fecha))
            {
                var opcion = MessageBox.Show("Ya existe una jornada para esta fecha. ¿Desea sobreescribirla?", "Confirmar", MessageBoxButtons.YesNo);
                if (opcion == DialogResult.No) return;
            }

            citasDiarias[fecha] = listaTemporalJornada;
            string json = JsonConvert.SerializeObject(citasDiarias, Formatting.Indented);
            File.WriteAllText(CITAS_FILE, json);

            MessageBox.Show("Jornada guardada correctamente.");
            this.Close();
        }

        private void btnIniciarConsulta_Click(object sender, EventArgs e)
        {
            if (dgvTempJornada.SelectedRows.Count > 0)
            {
                string ci = dgvTempJornada.SelectedRows[0].Cells[0].Value.ToString();
                Form6 frm = new Form6(ci);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero al paciente de la tabla para iniciar su consulta.");
            }
        }
    }
}

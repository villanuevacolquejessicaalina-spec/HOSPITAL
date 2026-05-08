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
using System.IO;
using static HOSPITAL.Form3;

namespace HOSPITAL
{
    public partial class Form7 : Form
    {
        private string fechaActual;
        private List<Cita> citasDelDia;
        private Dictionary<string, Paciente> pacientes;
        private string CITAS_FILE = "citas_hospital.json";
        private string PACIENTES_FILE = "pacientes_hospital.json";

        public Form7(string fecha, List<Cita> listaCitas)
        {
            InitializeComponent();
            this.fechaActual = fecha;
            this.citasDelDia = listaCitas;
            this.Text = "Detalle de Jornada - " + fecha;
            lblFecha.Text = "Pacientes atendidos el: " + fecha;

            CargarBasePacientes();
            ConfigurarTabla();
            MostrarTabla();
            CargarEspecialidadesEmergencia();
        }

        private void CargarBasePacientes()
        {
            if (File.Exists(PACIENTES_FILE))
            {
                string json = File.ReadAllText(PACIENTES_FILE);
                pacientes = JsonConvert.DeserializeObject<Dictionary<string, Paciente>>(json);
            }
            else
            {
                pacientes = new Dictionary<string, Paciente>();
            }
        }

        private void ConfigurarTabla()
        {
            dgvCitasDia.Columns.Clear();
            dgvCitasDia.Columns.Add("CI", "Documento (CI)");
            dgvCitasDia.Columns.Add("Nombre", "Nombre Completo");
            dgvCitasDia.Columns.Add("Especialidad", "Especialidad/Médico");
            dgvCitasDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitasDia.AllowUserToAddRows = false;
        }

        private void MostrarTabla()
        {
            dgvCitasDia.Rows.Clear();
            if (citasDelDia != null)
            {
                foreach (var cita in citasDelDia)
                {
                    dgvCitasDia.Rows.Add(cita.Ci, cita.Nombre, cita.Especialidad);
                }
            }
        }

        private void CargarEspecialidadesEmergencia()
        {
            cmbEspecialidadE.Items.Clear();
            cmbEspecialidadE.Items.Add("Emergencias - Medicina General");
            cmbEspecialidadE.Items.Add("Emergencias - Traumatología");
            cmbEspecialidadE.Items.Add("Emergencias - Pediatría");
            if (cmbEspecialidadE.Items.Count > 0) cmbEspecialidadE.SelectedIndex = 0;
        }
        private void btnAgregarEmergencia_Click(object sender, EventArgs e)
        {
            string ci = txtCIEmergencia.Text.Trim();

            if (string.IsNullOrEmpty(ci))
            {
                MessageBox.Show("Por favor, ingrese un CI.");
                return;
            }

            if (pacientes.ContainsKey(ci))
            {
                Cita nuevaEmergencia = new Cita
                {
                    Ci = ci,
                    Nombre = pacientes[ci].Nombre,
                    Medico = "Médico de Guardia",
                    Especialidad = cmbEspecialidadE.Text
                };

                citasDelDia.Add(nuevaEmergencia);
                GuardarEnArchivoCitas();
                MostrarTabla();
                txtCIEmergencia.Clear();
                MessageBox.Show("Paciente de emergencia añadido a la lista de hoy.");
            }
            else
            {
                MessageBox.Show("El CI no existe en la base de datos. Debe registrar al paciente en el Form2 primero.");
            }
        }
        private void GuardarEnArchivoCitas()
        {
            try
            {
                Dictionary<string, List<Cita>> todasLasCitas;

                if (File.Exists(CITAS_FILE))
                {
                    todasLasCitas = JsonConvert.DeserializeObject<Dictionary<string, List<Cita>>>(File.ReadAllText(CITAS_FILE));
                }
                else
                {
                    todasLasCitas = new Dictionary<string, List<Cita>>();
                }

                todasLasCitas[fechaActual] = citasDelDia;
                string json = JsonConvert.SerializeObject(todasLasCitas, Formatting.Indented);
                File.WriteAllText(CITAS_FILE, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

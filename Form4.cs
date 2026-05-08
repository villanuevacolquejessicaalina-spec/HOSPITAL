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

namespace HOSPITAL
{
    public partial class Form4 : Form
    {
        private string DATA_FILE = "pacientes_hospital.json";
        private Dictionary<string, Paciente> pacientes;
        public Form4()
        {
            InitializeComponent();
            LlenarCombosFecha();
            CargarDatosExistentes();
        }
        private void LlenarCombosFecha()
        {
            for (int d = 1; d <= 31; d++) cmbDia.Items.Add(d.ToString());
            for (int m = 1; m <= 12; m++) cmbMes.Items.Add(m.ToString());
            int anioActual = DateTime.Now.Year;
            for (int a = anioActual; a >= 1920; a--) cmbAnio.Items.Add(a.ToString());
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Otro");
            cmbSexo.SelectedIndex = 0;
        }
        private void CargarDatosExistentes()
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ci = txtCI.Text.Trim();
            if (string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre y el CI son obligatorios.");
                return;
            }

            if (pacientes.ContainsKey(ci))
            {
                MessageBox.Show("Este CI ya está registrado en la base de datos.");
                return;
            }
            string fechaNac = $"{cmbDia.Text}/{cmbMes.Text}/{cmbAnio.Text}";
            Paciente nuevo = new Paciente
            {
                Nombre = txtNombre.Text,
                Sexo = cmbSexo.Text,
                Nacimiento = fechaNac,
                Telefono = txtTelefono.Text,
                Ocupacion = txtOcupacion.Text,
                Residencia = txtResidencia.Text,
                Historial = new List<Consulta>() 
            };
            pacientes.Add(ci, nuevo);

            string json = JsonConvert.SerializeObject(pacientes, Formatting.Indented);
            File.WriteAllText(DATA_FILE, json);

            MessageBox.Show("Paciente registrado exitosamente.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

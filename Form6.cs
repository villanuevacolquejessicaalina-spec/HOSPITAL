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
    public partial class Form6 : Form
    {
        private string DATA_FILE = "pacientes_hospital.json";
        private Dictionary<string, Paciente> pacientes;
        private string ciPacienteActual;
        public Form6(string ci)
        {
            InitializeComponent();
            this.ciPacienteActual = ci;
            CargarDatos();

            if (pacientes.ContainsKey(ci))
            {
                lblPaciente.Text = $"Paciente: {pacientes[ci].Nombre}";
                lblPaciente.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void CargarDatos()
        {
            if (File.Exists(DATA_FILE))
                pacientes = JsonConvert.DeserializeObject<Dictionary<string, Paciente>>(File.ReadAllText(DATA_FILE));
        }

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                var vitales = new Dictionary<string, string>
        {
            { "Peso/Talla", txtPesoTalla.Text },
            { "PA", txtPA.Text },
            { "FC", txtFC.Text },
            { "FR", txtFR.Text },
            { "Temp", txtTemp.Text },
            { "SatO2", txtSatO2.Text }
        };

                var anamnesis = new Dictionary<string, string>
        {
            { "Motivo", txtMotivo.Text },
            { "Enfermedad Actual", txtEnfermedad.Text },
            { "Antecedentes", txtAntecedentes.Text }
        };

                Consulta nueva = new Consulta
                {
                    Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    Motivo = txtMotivo.Text,
                    Vitales = vitales,
                    Anamnesis = anamnesis
                };
                if (pacientes.ContainsKey(ciPacienteActual))
                {
                    pacientes[ciPacienteActual].Historial.Add(nueva);
                    string json = JsonConvert.SerializeObject(pacientes, Formatting.Indented);
                    File.WriteAllText(DATA_FILE, json); 

                    MessageBox.Show("Consulta registrada y guardada exitosamente en el historial.", "Éxito");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el paciente en la base de datos.", "Error Grave");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error Técnico");
            }
        }
        
    
    }
}

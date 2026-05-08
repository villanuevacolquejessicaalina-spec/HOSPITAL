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
    public partial class Form3 : Form
    {
        private string CITAS_FILE = "citas_hospital.json";
        private Dictionary<string, List<Cita>> citasDiarias;
        public Form3()
        {
            InitializeComponent();
            CargarCitas();
            MostrarJornadas();
        }
        private void CargarCitas()
        {
            if (File.Exists(CITAS_FILE))
            {
                string json = File.ReadAllText(CITAS_FILE);
                citasDiarias = JsonConvert.DeserializeObject<Dictionary<string, List<Cita>>>(json);
            }
            else
            {
                citasDiarias = new Dictionary<string, List<Cita>>();
            }
        }
        private void MostrarJornadas()
        {
            dgvJornadas.Rows.Clear();
            var fechasOrdenadas = citasDiarias.Keys.OrderByDescending(f => f);
            foreach (var fecha in fechasOrdenadas)
            {
                dgvJornadas.Rows.Add(fecha, citasDiarias[fecha].Count);
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            dgvJornadas.EndEdit();
            if (dgvJornadas.CurrentRow != null && dgvJornadas.CurrentRow.Index >= 0)
            {
                var filaNombre = dgvJornadas.CurrentRow.Cells[0].Value;

                if (filaNombre != null)
                {
                    string fechaSeleccionada = filaNombre.ToString();

                    if (citasDiarias.ContainsKey(fechaSeleccionada))
                    {
                        Form7 ventanaDetalle = new Form7(fechaSeleccionada, citasDiarias[fechaSeleccionada]);
                        ventanaDetalle.ShowDialog();
                        CargarCitas();
                        MostrarJornadas();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos internos para la fecha: " + fechaSeleccionada);
                    }
                }
            }
            else
            {
                MessageBox.Show("La tabla detecta que no hay nada seleccionado. Haz clic directamente sobre la fecha azul.");
            }
        }

        private void btnNuevaJornada_Click(object sender, EventArgs e)
        {
            Form5 ventanaNuevaJornada = new Form5();
            ventanaNuevaJornada.ShowDialog();
            CargarCitas();
            MostrarJornadas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Cita
        {
            public string Ci { get; set; }
            public string Nombre { get; set; }
            public string Medico { get; set; }
            public string Especialidad { get; set; }
        }

        private void btnHacerConsulta_Click(object sender, EventArgs e)
        {
            if (dgvJornadas.SelectedRows.Count > 0)
            {
                string ci = dgvJornadas.SelectedRows[0].Cells[0].Value.ToString();
                Form6 frmConsulta = new Form6(ci);
                frmConsulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente de la lista de jornada.", "Aviso");
            }
        }
    }
}

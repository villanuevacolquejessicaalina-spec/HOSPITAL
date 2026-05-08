using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HOSPITAL
{
    public partial class Form8 : Form
    {
        private Paciente pacienteActual;

        public Form8(Paciente paciente)
        {
            InitializeComponent();
            this.pacienteActual = paciente;

            if (this.pacienteActual != null)
            {
                this.Text = "Historial Médico - " + paciente.Nombre;
            }

            ConfigurarTabla();
            MostrarConsultas();
        }

        private void ConfigurarTabla()
        {
            dgvHistorialFechas.Columns.Clear();
            dgvHistorialFechas.Columns.Add("Fecha", "Fecha de Consulta");
            dgvHistorialFechas.Columns.Add("Motivo", "Motivo / Diagnóstico");
            dgvHistorialFechas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialFechas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialFechas.AllowUserToAddRows = false;
            dgvHistorialFechas.ReadOnly = true;
        }

        private void MostrarConsultas()
        {
            dgvHistorialFechas.Rows.Clear();
            if (pacienteActual != null && pacienteActual.Historial != null)
            {
                foreach (var consulta in pacienteActual.Historial)
                {
                    dgvHistorialFechas.Rows.Add(consulta.Fecha, consulta.Motivo);
                }
            }
        }

        private void dgvHistorialFechas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && pacienteActual != null && pacienteActual.Historial != null)
            {
                var consultaSeleccionada = pacienteActual.Historial[e.RowIndex];
                string detalles = "--- SIGNOS VITALES ---\n";

                if (consultaSeleccionada.Vitales != null)
                {
                    foreach (var v in consultaSeleccionada.Vitales)
                    {
                        detalles += v.Key + ": " + v.Value + "\n";
                    }
                }

                detalles += "\n--- ANAMNESIS ---\n";

                if (consultaSeleccionada.Anamnesis != null)
                {
                    foreach (var a in consultaSeleccionada.Anamnesis)
                    {
                        detalles += a.Key + ": " + a.Value + "\n";
                    }
                }

                MessageBox.Show(detalles, "Detalle de Consulta - " + consultaSeleccionada.Fecha);
            }
        }

        private void dgvHistorialFechas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var consultaSeleccionada = pacienteActual.Historial[e.RowIndex];
                string detalle = $"FECHA: {consultaSeleccionada.Fecha}\n\n" +
                                 $"MOTIVO: {consultaSeleccionada.Motivo}\n" +
                                 $"PESO/TALLA: {consultaSeleccionada.Vitales["Peso/Talla"]}\n" +
                                 $"P. ARTERIAL: {consultaSeleccionada.Vitales["PA"]}\n" +
                                 $"ENFERMEDAD: {consultaSeleccionada.Anamnesis["Enfermedad Actual"]}";

                MessageBox.Show(detalle, "Detalle de la Consulta Realizada");
            }
        }
    }
}


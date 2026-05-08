using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Consulta
    {
        public string Fecha { get; set; }
        public string Motivo { get; set; }
        public Dictionary<string, string> Vitales { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Anamnesis { get; set; } = new Dictionary<string, string>();
    }

    public class Paciente
    {
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Nacimiento { get; set; } 
        public string Ocupacion { get; set; }
        public string Residencia { get; set; }
        public List<Consulta> Historial { get; set; } = new List<Consulta>();
    }
}

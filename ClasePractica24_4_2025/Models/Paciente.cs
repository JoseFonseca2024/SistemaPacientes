using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica24_4_2025.Models
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public string Obsevarción { get; set; }
    }
}

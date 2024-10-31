using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    public struct Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public char Genero { get; set; }
        public string Departamento { get; set; }
        public string Motivo { get; set; }
        private string alergia;
        public string Alergia
        {
            get
            {
                return
                string.IsNullOrEmpty(alergia) ? "Sin alergias" : alergia;
            }
            set
            {
                alergia = value;
            } 
        }
    }
}

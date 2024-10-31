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
        public string Alergia
        {
            get
            {
                return
                string.IsNullOrEmpty(Alergia) ? "Sin alergias" : Alergia;
            }
            set { Alergia = value; }
        }
    }
}

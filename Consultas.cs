using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    internal class Consultas
    {
        List<Paciente> pacientes = new List<Paciente>();

        public void Agregar(Paciente paciente)
        {
            pacientes.Add(paciente);
        }
        public List <Paciente> Mostrar()
        {
            return pacientes;
        }
    }
}

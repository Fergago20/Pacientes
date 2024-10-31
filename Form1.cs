using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class Form1 : Form
    {
        Consultas cosultas = new Consultas();
        public Form1()
        {
            InitializeComponent();
            Departamento();
            Genero();
        }

        private void Departamento()
        {
            cbDepartamento.Items.Clear();
            string[] departamentos={"Cardiología", "Pediatría", "Emergencias", "Neurología"};
            cbDepartamento.Items.AddRange(departamentos);
        }
        private void Genero()
        {
            char[] generos = { 'M', 'F' };
            cbGenero.Items.Add(generos);
        }
    }
}

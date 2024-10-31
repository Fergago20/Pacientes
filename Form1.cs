using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class Form1 : Form
    {
        Consultas consultas = new Consultas();
        Paciente paciente = new Paciente();
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
            cbGenero.Items.Clear();
            char[] generos = { 'M', 'F' };
            foreach (var gen in generos)
            {
                cbGenero.Items.Add(gen);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Nombre = tbNombre.Text;
                paciente.Apellido = tbApellido.Text;
                paciente.Nacimiento = DateTime.Parse(tbFecha.Text);
                paciente.Departamento = cbDepartamento.SelectedItem.ToString();
                paciente.Genero = char.Parse(cbGenero.SelectedItem.ToString());
                paciente.Motivo = tbMotivo.Text;
                paciente.Alergia = tbAlergia.Text;
                consultas.Agregar(paciente);
                Mostrar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNombre.Text= "";
            tbApellido.Text="";
            tbFecha.Text="";
            cbDepartamento.SelectedIndex=-1;
            cbGenero.SelectedIndex=-1;
            tbMotivo.Text= "";
            tbAlergia.Text="";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mostrar()
        {
            dgvSalida.DataSource = null;
            dgvSalida.DataSource = consultas.Mostrar();
        }

        private void AlergiasSi(object sender, EventArgs e)
        {
            tbAlergia.Enabled = chbAlergia.Checked;
        }
    }
}

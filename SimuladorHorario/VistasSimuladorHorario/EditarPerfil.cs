using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorHorario;
using Microsoft.VisualBasic;

namespace VistasSimuladorHorario
{
    public partial class eliminarCursoButton : Form
    {

        public event EventHandler OnGuardar;
        Estudiante estudiante;
        public eliminarCursoButton()
        {
            InitializeComponent();
        }

        private void usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        public void cargarInfo(Estudiante estudianteActivo)
        {
            List<string> listaNombreCursoInscrito = new List<string>();
            foreach (Curso curso in estudianteActivo.listaInscripcion)
            {
                listaNombreCursoInscrito.Add(curso.nombre);
            }

            cursosInscritosComboBox.DataSource = listaNombreCursoInscrito;

            textBox1.Text = estudianteActivo.nombre;
            textBox2.Text = estudianteActivo.contraseña;
            estudiante = estudianteActivo;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

            listBox1.DataSource = estudiante.avanceMalla;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre de usuario: ", "Editar nombre", estudiante.nombre);   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva contraseña: ", "Editar Contraseña", estudiante.contraseña);
        }

        public void Guardar(Estudiante estudianteActivo)
        {
            estudianteActivo.SetNombre(textBox1.Text);
            estudianteActivo.SetContraseña(textBox2.Text);
        }

        private void EditarPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Aplicacion.SerializeAll();
            //System.Environment.Exit(0);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            OnGuardar(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cursoEliminar = cursosInscritosComboBox.Text;
            foreach (CursoCurricular curso in estudiante.listaInscripcion)
            {
                if (curso.nombre == cursoEliminar)
                {
                    estudiante.listaInscripcion.Remove(curso);
                    MessageBox.Show(curso.nombre + " eliminado con exito");
                    cargarInfo(estudiante);
                    break;
                }
            }
            if (cursosInscritosComboBox.Items.Count == 0)
            {
                cursosInscritosComboBox.Text = string.Empty;
                MessageBox.Show("Se han removido todos los cursos");
            }
        }

        private void limpiarCursosButton_Click(object sender, EventArgs e)
        {
            List<CursoCurricular> listaCursosBorrar = new List<CursoCurricular>();
            foreach (CursoCurricular curso in estudiante.listaInscripcion)
            {
                listaCursosBorrar.Add(curso);
            }

            foreach (CursoCurricular curso in listaCursosBorrar)
            {
                estudiante.listaInscripcion.Remove(curso);
            }
            cursosInscritosComboBox.Text = string.Empty;
            MessageBox.Show("Se han removido todos los cursos");
            cargarInfo(estudiante);
        }

        private void cursosInscritosLabel_Click(object sender, EventArgs e)
        {

        }

        private void cursosInscritosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eliminarCursoButton_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}




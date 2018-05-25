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
            foreach(Curso curso in estudianteActivo.listaInscripcion)
            {
                listaNombreCursoInscrito.Add(curso.nombre);
            }

            cursosInscritosComboBox.DataSource = listaNombreCursoInscrito;

            textBox1.Text = estudianteActivo.nombre;
            textBox2.Text = estudianteActivo.contraseña;
            estudiante = estudianteActivo;

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
            foreach(CursoCurricular curso in estudiante.listaInscripcion)
            {
                if(curso.nombre == cursoEliminar)
                {
                    estudiante.listaInscripcion.Remove(curso);
                    cargarInfo(estudiante);
                    break;
                }
            }
        }

        private void limpiarCursosButton_Click(object sender, EventArgs e)
        {
            List<CursoCurricular> listaCursosBorrar = new List<CursoCurricular>();
            foreach (CursoCurricular curso in estudiante.listaInscripcion)
            {
                listaCursosBorrar.Add(curso);
            }

            foreach(CursoCurricular curso in listaCursosBorrar)
            {
                estudiante.listaInscripcion.Remove(curso);
            }

            cargarInfo(estudiante);
        }
    }


}

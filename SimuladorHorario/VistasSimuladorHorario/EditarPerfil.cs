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
    public partial class EditarPerfil : Form
    {


        public EditarPerfil()
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

        }

        public void Guardar(Estudiante estudianteActivo)
        {
            estudianteActivo.SetNombre(textBox1.Text);
            estudianteActivo.SetContraseña(textBox2.Text);
        }
    }


}

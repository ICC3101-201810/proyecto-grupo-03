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
    public partial class ActualizarAvanceDeMallaForm : Form
    {
        Estudiante estudianteActual;
        public ActualizarAvanceDeMallaForm()
        {
            InitializeComponent();
            InicializarAlumnoCB();
        }

        public void InicializarAlumnoCB()
        {
            List<string> estudiantes = new List<string>();
            foreach(Usuario user in Aplicacion.usuarios)
            {
                if (user is Estudiante)
                {
                    estudiantes.Add(user.nombre);
                }
            }
        }

        public void CambiarListaCursos()
    }
}

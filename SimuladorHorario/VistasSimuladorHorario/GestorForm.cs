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
    public partial class GestorForm : Form
    {
        public event EventHandler OnCrearCurso;
        public event EventHandler OnEliminarCurso;
        public event EventHandler OnLeerCurso;

        public GestorForm()
        {
            InitializeComponent();
        }

        private void CrearCursoButton_Click(object sender, EventArgs e)
        {
            OnCrearCurso(this, EventArgs.Empty);
            this.Hide();
        }

        private void GestorForm_Load(object sender, EventArgs e)
        {

        }

        private void EliminarCursoButton_Click(object sender, EventArgs e)
        {
            OnEliminarCurso(this, EventArgs.Empty);
            this.Hide();
        }

        private void LeerCursoButton_Click(object sender, EventArgs e)
        {

            OnLeerCurso(this, EventArgs.Empty);
            //this.Hide();
        }

        private void GestorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            System.Environment.Exit(0);
        }
    }
}

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
    public partial class InscribirCursoForm : Form
    {
        public InscribirCursoForm()
        {
            InitializeComponent();
            InicializarCursoComboBox();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void InicializarCursoComboBox()
        {
            CursosComboBox.DataSource = Aplicacion.cursos;
        }

    }
}

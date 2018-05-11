using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasSimuladorHorario
{
    public partial class GestorForm : Form
    {
        public event EventHandler OnCrearCurso;
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class EliminarEventoForm : Form
    {

        public event EventHandler OnEliminarClick;


        public EliminarEventoForm()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            foreach(EventoPersonal evento in ((Estudiante)Aplicacion.usuarioActual).listaEventosPersonal)
            {
                comboBox1.Items.Add(evento);
            }

            
        }
        
        private void EliminarCurso()
        {
            ((Estudiante)Aplicacion.usuarioActual).listaEventosPersonal.Remove((EventoPersonal)comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            MessageBox.Show("Evento eliminado");
            if (OnEliminarClick != null)
            {
                OnEliminarClick(this, EventArgs.Empty);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            EliminarCurso();
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Text = "";
            }


            

    }

        private void EliminarEventoForm_Load(object sender, EventArgs e)
        {

        }
    }
}

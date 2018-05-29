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
    public partial class AgregarEventoForm : Form
    {

        Estudiante usuarioActivo;

        public AgregarEventoForm(Estudiante estudianteActivo)
        {
            InitializeComponent();
            usuarioActivo = estudianteActivo;
            List<string> bloques = new List<string>();
            foreach(string str in Enum.GetNames(typeof(BloquesHorarios)))
            {
                bloques.Add(str.Replace("i", "").Replace('_', ':'));
            }
            BloqueHComboBox.DataSource = bloques;
            DuracionComboBox.DataSource = new List<string> { "1", "2", "3", "4", "5" };
        }

        private void AgregarEventoButton_Click(object sender, EventArgs e)
        {
            string fecha = FechaEvento.Value.ToString("dd:MM:yyyy");
            string nombre = nombreTextBox.Text;
            TipoEvento tipoEvento = TipoEvento.PERS;
            string sala = SalaUser.Text;
            string horaInicio = (string)(BloqueHComboBox.SelectedItem);
            int duracion = Convert.ToInt32(DuracionComboBox.SelectedItem);
            EventoPersonal evento = new EventoPersonal(nombre, horaInicio,fecha, sala);
            Estudiante estudiante = (Estudiante)Aplicacion.usuarioActual;
            estudiante.AgregarEventoPersonal(evento);
            this.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEventoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

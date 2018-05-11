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


        public AgregarEventoForm()
        {
            InitializeComponent();
            TipoEventoComboBox.DataSource = Enum.GetValues(typeof(TipoEvento));
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
            TipoEvento tipoEvento = (TipoEvento)TipoEventoComboBox.SelectedItem;
            string sala = SalaUser.Text;
            string horaInicio = (string)(BloqueHComboBox.SelectedItem);
            int duracion = Convert.ToInt32(DuracionComboBox.SelectedItem);
            Gestor.CrearEvento(fecha, tipoEvento, sala, horaInicio, duracion);
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

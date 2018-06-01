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
    public partial class AgregarEventoForm1 : Form
    {
        
        CrearCursoForm parent;
        public AgregarEventoForm1(CrearCursoForm parent)
        {
            InitializeComponent();
            this.parent = parent;
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
            
            string nombre = NombreEventoTextBox.Text;
            string fecha = FechaEvento.Value.ToString("dd-MM-yyyy");
            TipoEvento tipoEvento = (TipoEvento)TipoEventoComboBox.SelectedItem;
            string sala = SalaUser.Text;
            string horaInicio = (string)(BloqueHComboBox.SelectedItem);
            int duracion = Convert.ToInt32(DuracionComboBox.SelectedItem);
            List<Evento> listaEventos = Gestor.CrearEvento(nombre,fecha, tipoEvento, sala, horaInicio, duracion, (Convert.ToString(((int)FechaEvento.Value.DayOfWeek)-1) + "-"));
            parent.AñadirEventos(listaEventos);
            this.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEventoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
        }

        public void DisableType()
        {
            this.TipoEventoComboBox.SelectedItem = TipoEvento.PERS;
            this.TipoEventoComboBox.Enabled = false;
        }

        private void AgregarEventoForm1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.IO;
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
    public partial class PlataformaEstudianteForm : Form

    
    {
        public event EventHandler OnInscribirCurso;
        public event EventHandler OnEditarPerfil;
        public event EventHandler OnCerrarSesion;
        public event EventHandler OnCerrandoApp;

        public PlataformaEstudianteForm()
        {
            InitializeComponent();
            InicializarHorario();
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PlataformaEstudianteForm_Load(object sender, EventArgs e)
        {

        }

        private void PlataformaEstudianteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCerrandoApp(this, EventArgs.Empty);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void InicializarHorario()
        {
            List<string> listaHorariosString =  Enum.GetNames(typeof(BloquesHorarios)).ToList();
            int contadorHora = 8;
            foreach (string horario in listaHorariosString)
            {
                dataGridView1.Rows.Add($"{contadorHora}:30 - {contadorHora+1}:20", "", "", "", "", "", "", "");
                contadorHora++;
            }

            List<Evento> listaEventos = new List<Evento>();
            Estudiante estudianteActual = (Estudiante)Aplicacion.usuarioActual;
            foreach(Curso curso in estudianteActual.listaInscripcion)
            {
                CursoCurricular cursoCurricular = (CursoCurricular)curso;
                listaEventos.AddRange(cursoCurricular.eventosCurso);
            }

            foreach(Evento evento in listaEventos)
            {
                AgendaDataGrid.Rows.Add(evento.hora);
            }

            ActualizarHorario(estudianteActual.listaInscripcion);

            //dataGridView1.Rows[rowIndex].Cells[ColumnIndex].Value = data;




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inscribirCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnInscribirCurso(this, EventArgs.Empty);
        }

        public void ActualizarHorario(List<Curso> listaCursos)
        {

            foreach (CursoCurricular curso in listaCursos)
            {


                foreach (Evento evento in curso.eventosCurso)
                {
                    if (evento.tipo != TipoEvento.CLAS && evento.tipo != TipoEvento.AYUD && evento.tipo != TipoEvento.LABT) { continue; }

                    int diaSemana = Convert.ToInt32(evento.hora.Split('-')[0]);
                    int horaInicio = Convert.ToInt32((evento.hora.Split('-')[1]).Split(':')[0]);
                    dataGridView1.Rows[horaInicio - 8].Cells[diaSemana + 1].Value = (curso.nombre + " " + evento.sala);
                }
                dataGridView1.Enabled = false;
                dataGridView1.Enabled = true;

            }
        }


        public void ActualizarAgenda(List<Curso> listaCursos)
        {

            foreach (CursoCurricular curso in listaCursos)
            {

                foreach (Evento evento in curso.eventosCurso)
                {

                    if (evento.tipo != TipoEvento.CLAS && evento.tipo != TipoEvento.AYUD && evento.tipo != TipoEvento.LABT)
                    {
                        AgendaDataGrid.Rows.Add(evento.tipo.ToString() + ": " + curso.nombre,evento.fecha);
                    }

                    
                }
                dataGridView1.Enabled = false;
                dataGridView1.Enabled = true;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEditarPerfil(this, EventArgs.Empty);
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            OnCerrarSesion(this, EventArgs.Empty);
        }

        private void wIWIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicacion.SerializeAll();
            MessageBox.Show("Guardado Exitoso");
        }

        private void documentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("..\\..\\..\\Documentacion\\Manual de Usuario.pdf");
            }
            catch
            {
                MessageBox.Show("No se encontró el archivo", "Error");
            }
        }

        private void acercaDeSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }
    }
}

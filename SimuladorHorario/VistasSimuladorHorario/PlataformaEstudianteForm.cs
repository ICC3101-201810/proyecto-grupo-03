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
        public event EventHandler OnAgregarEvento;

        public DateTime selectedDate = new DateTime(2018,5,27);
        List<Evento> listaEventos = new List<Evento>();
        List<Curso> listaInscripcion = new List<Curso>();


        public PlataformaEstudianteForm()
        {
            InitializeComponent();
            AgendaDataGrid.Columns[1].DefaultCellStyle.Format = "d";
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
            Aplicacion.SerializeAll();
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void InicializarHorario()
        {

            userNameLabel.Text = "Usuario: "+Aplicacion.usuarioActual.nombre;
            
            List<DataGridViewRow> lstRows = new List<DataGridViewRow>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                lstRows.Add(row);
            }

            foreach(DataGridViewRow row in lstRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            //MessageBox.Show("Iniciando Horario");
            List<string> listaHorariosString =  Enum.GetNames(typeof(BloquesHorarios)).ToList();
            int contadorHora = 8;
            foreach (string horario in listaHorariosString)
            {
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Rows.Add($"{contadorHora}:30 - {contadorHora+1}:20", "", "", "", "", "", "", "");
                contadorHora++;
            }

            listaEventos = new List<Evento>();
            Estudiante estudianteActual = (Estudiante)Aplicacion.usuarioActual;
            listaInscripcion = estudianteActual.listaInscripcion;
            foreach (Curso curso in estudianteActual.listaInscripcion)
            {
                CursoCurricular cursoCurricular = (CursoCurricular)curso;
                listaEventos.AddRange(cursoCurricular.eventosCurso);
            }

            foreach(Evento evento in listaEventos)
            {
                AgendaDataGrid.Rows.Add(evento.hora);
            }
            for (int a = 0; a < 13; a++)
            {
                dataGridView1.Rows[a].Cells[0].Style.BackColor = Color.LightGray;
            }
            
            ActualizarHorario(estudianteActual.listaInscripcion);
            ActualizarAgenda();

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
            List<Color> colores = new List<Color>();
            colores.Add(Color.Aqua); colores.Add(Color.GreenYellow); colores.Add(Color.Tomato); colores.Add(Color.Gold);
            colores.Add(Color.LightSteelBlue);colores.Add(Color.DarkKhaki);colores.Add(Color.LightPink);colores.Add(Color.LightSeaGreen);
            //MessageBox.Show("Actualizando Horario");
            foreach (CursoCurricular curso in listaCursos)
            {


                foreach (Evento evento in curso.eventosCurso)
                {
                    if (evento.tipo != TipoEvento.CLAS && evento.tipo != TipoEvento.AYUD && evento.tipo != TipoEvento.LABT) { continue; }

                    int diaSemana = Convert.ToInt32(evento.hora.Split('-')[0]);
                    int horaInicio = Convert.ToInt32((evento.hora.Split('-')[1]).Split(':')[0]);
                    /*
                    for (int r = 0; r < 7; r++)
                    {
                        dataGridView1.Columns[r].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        //dataGridView1.Columns[r].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;  
                    }
                    */
                    



                    dataGridView1.Rows[horaInicio - 8].Cells[diaSemana + 1].Style.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Rows[horaInicio - 8].Cells[diaSemana + 1].Value = curso.nombre + "\n" +evento.tipo.ToString()+": "+ evento.sala;
                    dataGridView1.Rows[horaInicio - 8].Cells[diaSemana + 1].Style.BackColor = colores[listaCursos.IndexOf(curso)];
                }
                dataGridView1.Enabled = false;
                dataGridView1.Enabled = true;

            }
        }


        public void ActualizarAgenda()
        {
            limpiarTabla(AgendaDataGrid);
            label1.Text = selectedDate.ToString("MMMM");
            foreach (Curso cursoC in listaInscripcion)
            {
                CursoCurricular curso = (CursoCurricular)cursoC;
                foreach (Evento evento in curso.eventosCurso)
                {

                    if (evento.tipo != TipoEvento.CLAS && evento.tipo != TipoEvento.AYUD && evento.tipo != TipoEvento.LABT)
                    {
                        if (evento.primerPeriodo)
                        {

                            DateTime date;
                            try
                            {
                                date = evento.GetDateTime();
                            }
                            catch
                            {
                                continue;
                            }
                            if (selectedDate.Month != date.Month)
                            {
                                continue;
                            }

                            AgendaDataGrid.Rows.Add(evento.tipo.ToString() + ": " + curso.nombre, evento.GetDateTime().ToString("d"));
                        }
                    }

                    
                }
            }


            Estudiante estudianteActual = (Estudiante)Aplicacion.usuarioActual;
            foreach (EventoPersonal evento in estudianteActual.listaEventosPersonal)
            {
                DateTime date;
                try
                {
                    date = evento.GetDateTime();
                }
                catch
                {
                    continue;
                }
                if (selectedDate.Month != date.Month)
                {
                    continue;
                }

                AgendaDataGrid.Rows.Add(TipoEvento.PERS.ToString()+ ": " + evento.nombre, evento.GetDateTime().ToString("d"));
            }

            AgendaDataGrid.Sort(AgendaDataGrid.Columns[1], ListSortDirection.Ascending);
            dataGridView1.Enabled = false;
            dataGridView1.Enabled = true;
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

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }



        private void limpiarTabla (DataGridView Tabla)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach(DataGridViewRow row in Tabla.Rows)
            {
                rows.Add(row);
            }

            foreach(DataGridViewRow row in rows)
            {
               Tabla.Rows.Remove(row);
            }
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(-1);
            ActualizarAgenda();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(1);
            ActualizarAgenda();
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnAgregarEvento(this, EventArgs.Empty);
        }

        private void eventoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarEventoForm eliminarEventoForm = new EliminarEventoForm();
            eliminarEventoForm.ShowDialog();
            ActualizarAgenda();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEditarPerfil(this, EventArgs.Empty);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

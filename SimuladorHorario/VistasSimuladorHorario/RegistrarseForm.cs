using SimuladorHorario;
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
    public partial class RegistrarseForm : Form
    {
        public event EventHandler OnRegistrarse;

        public RegistrarseForm()
        {
            InitializeComponent();
            this.EspecialidadCB.DataSource = Enum.GetValues(typeof(Especialidad));
            this.ConcentracionComboBox.DataSource = Enum.GetValues(typeof(Concentracion));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrarseButton_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TextUser.Text;
            string passUsuario = PassUser.Text;
            Especialidad especialidad= (Especialidad) EspecialidadCB.SelectedItem;
            Concentracion concentracion = (Concentracion)ConcentracionComboBox.SelectedItem;
            if (nombreUsuario == null || passUsuario == null)
            {
                MessageBox.Show("Debe ingresar todos los datos");
                return;
            }
            
            
            bool comprobacion = Aplicacion.RegistrarUsuario(nombreUsuario, passUsuario, concentracion, especialidad);
            if (!comprobacion)
            {
                MessageBox.Show("El nombre de usuario ya existe", "escoja otro");
                return;
            }
            MessageBox.Show("Usuario creado");
            OnRegistrarse(this, EventArgs.Empty);
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {

            OnRegistrarse(this, EventArgs.Empty);
            this.Hide();
        }

        private void RegistrarseForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            System.Environment.Exit(0);
        }
    }
}

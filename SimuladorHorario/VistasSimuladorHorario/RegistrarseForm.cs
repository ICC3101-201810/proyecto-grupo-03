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
            Especialidad especialidad= (Especialidad)Enum.Parse(typeof(Especialidad), EspecialidadCB.SelectedText);
            Concentracion concentracion = (Concentracion)Enum.Parse(typeof(Concentracion),ConcentracionComboBox.SelectedText);
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
            OnRegistrarse(this, null);
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
    }
}

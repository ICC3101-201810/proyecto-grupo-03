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
    public partial class CrearNuevoAdministradorForm : Form
    {
        public event EventHandler OnCrearNuevoAdministrador;
        public event EventHandler OnRegresar;

        public CrearNuevoAdministradorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreAdmin = textBox1.Text;
            string contraseñaAdmin = textBox2.Text;
            if (nombreAdmin == "" || contraseñaAdmin == "")
            {
                MessageBox.Show("Debe ingresar todos los datos");
                return;
            }

            bool comprobacion = Gestor.RegistrarAdmin(nombreAdmin, contraseñaAdmin);
            if (!comprobacion)
            {
                MessageBox.Show("El nombre de usuario ya existe", "escoja otro");
                return;
            }
            MessageBox.Show("Administrador creado");
            OnCrearNuevoAdministrador(this, EventArgs.Empty);
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnRegresar(this, EventArgs.Empty);
            this.Hide();
        }

        private void CrearNuevoAdministradorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            Environment.Exit(0);
        }

        private void CrearNuevoAdministradorForm_Load(object sender, EventArgs e)
        {

        }
    }
}

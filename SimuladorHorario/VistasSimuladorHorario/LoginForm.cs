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
    public partial class LoginForm : Form
    {

        public event EventHandler<IniciarSesionEventArgs> OnIniciarSesion;
        public event EventHandler OnRegistro;
        bool loadCSV = false;
        public LoginForm()
        {
            InitializeComponent();

            
            
            if (Aplicacion.cursos.Count == 0 && !loadCSV)
            {
                Aplicacion.DeSerializeAll();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ESTO PERMITE IMPORTAR MEDIANTE ARCHIVOS CSV
            
            if (Aplicacion.cursos.Count == 0 && loadCSV)
            {
                Aplicacion.CargarCursos();

                if (Aplicacion.usuarios.Count == 0)
                {
                    Aplicacion.CargarUsuarios();

                }
            }
            
            
            //ESTO PERMITE IMPORTAR MEDIANTE SERIALIZACION
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            string nombreUsuario = usuarioText.Text;
            string passUsuario = contraseñaText.Text;


            Usuario usuario = Aplicacion.IniciarSesion(nombreUsuario, passUsuario);
            if (usuario == null) { MessageBox.Show("Usuario o Contraseña incorrecto", "Login Error"); return; }
            IniciarSesionEventArgs iniciarSesionArgs = new IniciarSesionEventArgs();
            iniciarSesionArgs.usuario = usuario;
            OnIniciarSesion(this, iniciarSesionArgs);
            this.Hide();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void RegistrarseB_Click(object sender, EventArgs e)
        {
            OnRegistro(this, null);
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            System.Environment.Exit(0);
        }
    }
}

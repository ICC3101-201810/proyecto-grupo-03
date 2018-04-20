using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class Aplicacion
    {
        static List<Usuario> usuarios;
        static List<Curso> cursos;
        public enum TipoEvento { PRBA, CLAS, LABT, AYUD, EXTRAP, PERS}

       

        public static bool IniciarSesion()
        {
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nombre==nombreUsuario && usuario.contraseña == contraseña)
                {
                    
                }
            }
            return false;
        }

        public static bool Registrarse()
        {
            return false;
        }

        static void AbrirInformacion(string fileName = "data.csv")
        {


            List<Usuario> listaUsuarios = new List<Usuario>();

            StreamReader file = new StreamReader(fileName);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }

            


            Console.ReadKey();
        }


    }
}

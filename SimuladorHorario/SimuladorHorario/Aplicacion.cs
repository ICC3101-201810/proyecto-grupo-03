using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{

    public enum TipoEvento { PRBA, CLAS, LABT, AYUD, EXTRAP, PERS }
    public enum Especialidad {ING, IOC, ICE, ICC, ICI, ICA }
    static class Aplicacion
    {
        static List<Usuario> usuarios;
        static List<Curso> cursos;
 
        public static void IniciarSesion()
        {
            InicioSesion:
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nombre==nombreUsuario && usuario.contraseña == contraseña)
                {
                    if (usuario.esAdmin)
                    {
                        Gestor.MenuGestor();
                    }
                    else PlataformaEstudiante.MenuPlataformaEstudiante();
                }

                Console.WriteLine("Usuario o contraseña invalidos\n " +
                    "Que desea hacer: \n " +
                    "1. Volver a iniciar sesion" +                                                                               
                    "2. Registrarse" +                                                                   
                    "3. Salir al menu principal");
                int opcion =Program.ChequearOpcion(1,3);
               
                if (opcion == 1) goto InicioSesion;
                if (opcion == 2) Registrarse();
                if (opcion == 3) return;
            

            }
            return;
        }

        public static bool Registrarse()
        {
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            Console.WriteLine("Ingrese su especialidad");

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

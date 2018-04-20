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
    public enum TipoCurso { Curricular, Extra}
    public enum Concentracion {AplicacionesWeb, Algoritmos, Modelacion, Bioprocesos, Hidraulica, Señales  }
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

        public static void Registrarse()
        {
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();

            if (NombresUsuarios().Contains(nombreUsuario))
            {
                do
                {
                    Console.WriteLine("Ese nombre de usuario ya existe, ingrese otro");

                } while (NombresUsuarios().Contains(nombreUsuario));
            }
            

            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            Console.WriteLine("Ingrese su especialidad");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i+1 + ". " + Enum.GetName(typeof(Especialidad), i));
            }
            Especialidad especialidad = (Especialidad)Program.ChequearOpcion(1, 7);
            List <CursoCurricular>avanceMalla = new List<CursoCurricular>();
            Console.WriteLine("Ingrese los cursos de su avance de malla");
            List<CursoCurricular> cursosCurriculares = GetCursosCurriculares();
            bool flag = true;
            int cont = 0;
            do
            {
                for (int i = 1; i < cursosCurriculares.Count(); i++)
                {

                    if (cursos[i].tipo.Equals(TipoCurso.Curricular))
                    {
                        Console.WriteLine(i + ". " + cursosCurriculares[i-1].nombre);
                        cont++;
                    }
                }
                Console.WriteLine("Ingrese su curso:");
                int opcion2 = Program.ChequearOpcion(1, cursos.Count()-cont);
                avanceMalla.Add(cursosCurriculares[opcion2-1]);
                Program.ImprimirPositivo("Curso agregado a su avance de malla");
                Console.WriteLine("¿Desea agregar otro curso?\n1. Si\n2. No");
                opcion2 = Program.ChequearOpcion(1, 2);
                if (opcion2 == 2) flag = false;
            } while (flag);
            Console.WriteLine("Ingrese su concentracion:");
            for (int i= 0; i <= 5; i++)
            {
                Console.Write(i + 1 + ". " + Enum.GetName(typeof(Especialidad), i));
            }

            Concentracion concentracion = (Concentracion)Program.ChequearOpcion(1, 5);
            usuarios.Add(new Estudiante(avanceMalla, especialidad, concentracion, nombreUsuario, contraseña, false));
            return;
        }

        public static void AbrirInformacion(string fileName = "data.csv")
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
        public static List<string> NombresUsuarios()
        {
            List<string> retorno = new List<string>();
            foreach (Usuario u in usuarios)
            {
                retorno.Add(u.nombre);
            }
            return retorno;
        }

        public static List<CursoCurricular> GetCursosCurriculares()
        {
            List<CursoCurricular> retorno = new List<CursoCurricular>();
            foreach(CursoCurricular c in cursos)
            {
                retorno.Add(c);
            }
            return retorno;
        }

    }
}

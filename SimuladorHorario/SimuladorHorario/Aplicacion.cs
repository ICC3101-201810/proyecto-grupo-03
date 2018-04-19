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
            
            return false;
        }

        public static bool Registrarse()
        {
            return false;
        }

        static void AbrirInformacion(string fileName = "data.csv")
        {
            StreamReader file = new StreamReader(fileName);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                

            }

            //CHUPALA


            Console.ReadKey();
        }


    }
}

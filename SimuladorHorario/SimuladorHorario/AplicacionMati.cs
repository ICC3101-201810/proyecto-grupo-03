using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class AplicacionMati
    {
             
        
        public static void app()
        {
            AbrirInformacion();
            while (true)
            {
                Console.WriteLine("--Aplicacion Mati--");
                Console.ReadKey();
            }
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
    }
}

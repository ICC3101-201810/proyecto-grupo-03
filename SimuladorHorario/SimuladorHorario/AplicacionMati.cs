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
                //Console.WriteLine(line);

                //Console.WriteLine(line.Split(';')[0]);
                string nombre = line.Split(';')[0];
                string contraseña = line.Split(';')[1];

                bool admin;

                if (line.Split(';')[2] == "true") { admin = true; }
                else
                {
                    string carrera, especialidad, añoIngreso, concentracion,avanceMalla;
                    carrera = line.Split(';')[3];
                    especialidad = line.Split(';')[4];
                    añoIngreso = line.Split(';')[5];
                    concentracion = line.Split(';')[6];
                    avanceMalla = line.Split(';')[7];




                    Console.WriteLine(nombre+especialidad+añoIngreso+concentracion+avanceMalla); 


                }
                



            }




            Console.ReadKey();
        }
    }
}

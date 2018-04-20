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
             
        static List<CursoCurricular> listaCursoCurricular = new List<CursoCurricular>();


        public static void app()
        {
            AbrirInformacionCursos();
            AbrirInformacionUsuario();
            while (true)
            {
                Console.WriteLine("--Aplicacion Mati--");
                Console.ReadKey();
            }
        }


        public static void AbrirInformacionUsuario(string fileName = "dataUsuarios.csv")
        {


            List<Usuario> listaUsuarios = new List<Usuario>();



            StreamReader file = new StreamReader(fileName);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);


                string[] LI = line.Split(';');


                //Console.WriteLine(line.Split(';')[0]);
                string nombre = LI[0];
                string contraseña = LI[1];

                bool admin;

                if (LI[2] == "true") { admin = true; }
                else
                {
                    string especialidad, añoIngreso, concentracion, avanceMalla;
                    especialidad = LI[4];
                    añoIngreso = LI[5];
                    concentracion = LI[6];
                    avanceMalla = LI[7];


                    Console.WriteLine(nombre + especialidad + añoIngreso + concentracion + avanceMalla);


                    List<CursoCurricular> listaAvanceMalla = new List<CursoCurricular>();

                    foreach(string nrc in LI[7].Split(','))
                    {

                        CursoCurricular curso = listaCursoCurricular.Find(x => x.nrc == nrc);
                        listaAvanceMalla.Add(curso);
                        Console.WriteLine(curso.nrc+" "+curso.nombre);
                    }


                    //Estudiante estudiante= new Estudiante(listaAvanceMalla)



                    Console.WriteLine();




                    //Estudiante estudiante = new Estudiante(listaCursoCurricular)



                }




            }

            file.Close();


        }

        public static void AbrirInformacionCursos(string fileName = "dataCursosDisponibles.csv")
        {


       

            StreamReader file = new StreamReader(fileName);

            string line;


            string previoNRC = string.Empty;




            while ((line = file.ReadLine()) != null)
            {


                string[] LI = line.Split(';');

                string nombre, profesor, nrc, carrera;
                nombre = LI[4];
                profesor = LI[15];
                nrc = LI[0];
                carrera = LI[1];

                int creditos = Convert.ToInt32(LI[5]);

                //Console.WriteLine(nombre);

                List<Evento> listaEventos = new List<Evento>();
                Evento evento = new Evento(nrc, DateTime.Now, DateTime.Now, DateTime.Now, "B-23", 0);
                listaEventos.Add(evento);


                if (nrc != previoNRC)
                {
                    CursoCurricular cursoCurricular = new CursoCurricular(nrc, creditos, new List<CursoCurricular>(),Especialidad.ICI, listaEventos, nombre, profesor, listaEventos);
                    listaCursoCurricular.Add(cursoCurricular);
                }
                else { continue; }



            }


            file.Close();


        }


    }
}

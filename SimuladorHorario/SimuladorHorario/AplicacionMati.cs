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
        static List<Estudiante> ListaEstudiante = new List<Estudiante>();
        static List<Administrador> listaAdministrador = new List<Administrador>();

        public static void app()
        {
            GenerarCursos();
            GenerarUsuarios();
            while (true)
            {
                Console.WriteLine("--Aplicacion Mati--");

                foreach(Estudiante estudiante in ListaEstudiante)
                {
                    Console.WriteLine($"{estudiante.nombre} {estudiante.contraseña}");

                    foreach(CursoCurricular curso in estudiante.avanceMalla)
                    {
                        Console.WriteLine($"{curso.nrc} {curso.nombre}");
                    }
                    Console.WriteLine();
                }
                //






                Console.ReadKey();
            }
        }

  
        public static void GenerarUsuarios(string fileName = "dataUsuarios.csv")
        {




            StreamReader file = new StreamReader(fileName);

            string line;

            while ((line = file.ReadLine()) != null)
            {


                string[] LI = line.Split(';');


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


                    List<CursoCurricular> listaAvanceMalla = new List<CursoCurricular>();

                    foreach(string nrc in LI[7].Split(','))
                    {

                        CursoCurricular curso = listaCursoCurricular.Find(x => x.nrc == nrc);
                        listaAvanceMalla.Add(curso);
                    }



                    Estudiante estudiante = new Estudiante(listaAvanceMalla, Especialidad.ICC, Concentracion.Hidraulica, nombre, contraseña, false);
                    ListaEstudiante.Add(estudiante);


                }




            }




            file.Close();


        }

        public static void GenerarCursos(string fileName = "dataCursosDisponibles.csv")
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
                    CursoCurricular curso = new CursoCurricular(nrc, creditos, new List<CursoCurricular>(), Especialidad.ICA, listaEventos, nombre, profesor, listaEventos, TipoCurso.Curricular);
                    listaCursoCurricular.Add(curso);
                }
                else { continue; }



            }


            file.Close();


        }


    }
}

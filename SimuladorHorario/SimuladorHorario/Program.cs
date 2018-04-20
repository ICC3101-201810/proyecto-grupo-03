using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class Program
    {
        /*public static bool ChequearTipoOpcion(string op) // hecho por Vicente
        {
            int cero = 0;
            if (Char.IsNumber(op,cero))
                {
                Console.WriteLine("Es int!!");
                return true;
                }
            else { return false; }
        }*/
        public static int ChequearOpcion(int inicio, int fin) //Chequea si la opcion es valida. Solo sirve para opciones de numeros enteros: Inicio: cota inferior ; Fin Cota superior
        {   
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion > fin || opcion < inicio)
            {
                do
                {
                    Console.Write("Ingrese una opcion valida:");
                    opcion = Convert.ToInt32(Console.ReadLine()); 
                } while ((opcion > fin || opcion < inicio));
            }
            return opcion;
        }
        public static void ImprimirPositivo(string str) //Imprime lo que recibe en fondo verde

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ImprimirNegativo(string str)//Imprime lo que recibe en fondo rojo
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void ImprimirBanner(string str)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(str);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void Log(string userInput, string accion)
        {
            StreamWriter archivoLog = new StreamWriter("Log.txt", true);
            DateTime dateTime = DateTime.Now;
            archivoLog.WriteLine($"Date Time:{dateTime}\r\nUser: {Aplicacion.usuarioActual.nombre}\r\nOperation: {accion}\r\nUserInput: {userInput}\r\n");
            archivoLog.Close();

            return;
        }


        static void Main(string[] args)
        {


            Aplicacion.CargarCursos();
            Aplicacion.CargarUsuarios();
            //Aplicacion.print();

            /*
            Console.WriteLine("super Usuario?\n(1) Si\n(2) No");
            string op = Console.ReadLine();
            if (op == "1")
            {
                AplicacionMati.app();
            }
            */


            Console.ForegroundColor = ConsoleColor.White;
            void MenuPrincipal()
            {
                InicioMenuPrincipal:
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Bienvenido al Simulador de Horario");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Que desea hacer: ");
                Console.WriteLine("1. Iniciar sesion\n" +
                              "2. Registrarse\n" +
                              "3. Salir del Programa\n" +
                              "4. Mostrar Usuarios");
                int opcion = ChequearOpcion(1, 4); //Ejemplo de uso de Chequear opcion

                if (opcion == 1)
                {
                    Aplicacion.IniciarSesion();
                    goto InicioMenuPrincipal;
                }

                if (opcion == 2) Aplicacion.Registrarse();

                if (opcion == 3) Environment.Exit(0);

                if (opcion == 4) Aplicacion.MostrarUsuarios();

                goto InicioMenuPrincipal;



            }
            MenuPrincipal();
        }
    }
}

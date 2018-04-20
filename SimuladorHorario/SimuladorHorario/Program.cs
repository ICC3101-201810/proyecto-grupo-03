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
        public static int ChequearOpcion(int inicio, int fin) //Chequea si la opcion es valida. Solo sirve para opciones de numeros enteros: Inicio: cota inferior ; Fin Cota superior
        {
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion > fin || opcion < inicio)
            {
                do
                {
                    Console.Write("Ingrese una opcion valida:");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion > 3 || opcion < 1);
            }
            return opcion;
        }
        public static void ImprimirPositivo(string str) //Imprime lo que recibe en fondo verde

        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void ImprimirNegativo(string str)//Imprime lo que recibe en fondo rojo
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void Main(string[] args)
        {


            Console.WriteLine("super Usuario?\n(1) Si\n(2) No");
            string op = Console.ReadLine();
            if (op == "1")
            {
                AplicacionMati.app();
            }



            Console.ForegroundColor = ConsoleColor.White;
            void MenuPrincipal()
            {
                InicioMenuPrincipal:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Bienvenido al Simulador de Horario");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Que desea hacer: ");
                Console.WriteLine("1. Iniciar sesion\n" +
                              "2. Registrarse\n" +
                              "3. Salir del Programa\n" +
                              "4. Cerrar sesion");
                int opcion = ChequearOpcion(1, 5); //Ejemplo de uso de Chequear opcion

                if (opcion == 1)
                {
                    Aplicacion.IniciarSesion();
                    goto InicioMenuPrincipal;
                }


                if (opcion == 2) Aplicacion.Registrarse();

                if (opcion == 4)return ;
                goto InicioMenuPrincipal;

                
                
            }
            MenuPrincipal();
        }
    }
}

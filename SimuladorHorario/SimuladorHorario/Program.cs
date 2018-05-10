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

            EmpiezaDeNuevo:
            Console.Write(":> ");
            string strOpcion = Console.ReadLine();
            int opcion;
            try
            {
                opcion = Convert.ToInt32(strOpcion);
            }
            catch
            {
                Console.Write("Ingrese una opcion valida:> ");
                goto EmpiezaDeNuevo;
            }

            if (opcion > fin || opcion < inicio)
            {
                Console.Write("Ingrese una opcion valida:> ");
                goto EmpiezaDeNuevo;
            }
            else return opcion;
        }
        public static void ImprimirPositivo(string str) //Imprime lo que recibe en fondo verde

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ImprimirNegativo(string str) //Imprime lo que recibe en fondo rojo
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

            //Genera el directorio donde se guardara Log.txt
            string path = Path.GetFullPath(@"..\..");
            path = Path.Combine(path, "archivos");
            Directory.CreateDirectory(path);
            path = Path.Combine(path, @"Log.txt");

            StreamWriter archivoLog = new StreamWriter(path, true);
            DateTime dateTime = DateTime.Now;
            archivoLog.WriteLine($"Date Time: {dateTime}\r\nUser: {Aplicacion.usuarioActual.nombre}\r\nOperation: {accion}\r\nUserInput: {userInput}\r\n");
            archivoLog.Close();
            return;
        }
        public static string ConvertirFormato(string str)
        {
            return str.Replace("i", "").Replace('_', ':');
        }

        static void Main(string[] args)
        {
            
            #region
            /*Aplicacion.CargarCursos();
            Aplicacion.CargarUsuarios();

            Console.ForegroundColor = ConsoleColor.White;
            void MenuPrincipal()
            {
                InicioMenuPrincipal:
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Bienvenido al Simulador de Horario");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Que desea hacer: ");
                Console.WriteLine("1. Iniciar sesion\n" +
                              "2. Registrarse\n" +
                              "3. Mostrar usuarios\n" +
                              "4. Guardar Informacion\n" +
                              "5. Salir del Programa");

                int opcion = ChequearOpcion(1, 5); //Ejemplo de uso de Chequear opcion
                if (opcion == 1)
                {
                    Aplicacion.IniciarSesion("macanepa","123");
                    goto InicioMenuPrincipal;
                }

                if (opcion == 2) Aplicacion.RegistrarUsuario();

                if (opcion == 5) Environment.Exit(0);

                if (opcion == 3) Aplicacion.MostrarUsuarios();

                if (opcion == 4) Aplicacion.GuardarData();

                goto InicioMenuPrincipal;

            }
            MenuPrincipal();*/
        }
        #endregion
    }
}

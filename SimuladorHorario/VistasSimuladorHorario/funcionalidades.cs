using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    static class funcionalidades
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
    }
}

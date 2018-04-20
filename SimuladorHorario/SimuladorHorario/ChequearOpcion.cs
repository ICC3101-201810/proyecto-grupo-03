using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    interface ChequearOpcion
    {
        int ChequearOpcion(int inicio, int fin) //Chequea si la opcion es valida. Solo sirve para opciones de numeros enteros: Inicio: cota inferior ; Fin Cota superior
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
    }
}

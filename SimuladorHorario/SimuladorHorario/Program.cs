using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicacion app = new Aplicacion(new List<string>() { "a", "b", "c" });
            Console.WriteLine($"{app.listaPrueba[0]}");
            Console.ReadKey();
            
        }
    }
}

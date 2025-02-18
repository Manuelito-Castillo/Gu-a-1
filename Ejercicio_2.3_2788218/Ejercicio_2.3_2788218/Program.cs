using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3_2788218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenador ordenador = new Ordenador("hp", "Intel Core i3", "DDR4", "SSD", 100);
            Console.WriteLine("José tiene un ordenador con las siguientes características: \n");
            Console.WriteLine("- Marca: " + ordenador.marca);
            Console.WriteLine("- Tipo de procesador: " + ordenador.procesador);
            Console.WriteLine("- Tipo de memoria:  " + ordenador.memoria);
            Console.WriteLine("- Tipo de disco: " + ordenador.disco);
            ordenador.incrementar(200);
            ordenador.reducir(0);

            Console.ReadKey();
        }
    }
}

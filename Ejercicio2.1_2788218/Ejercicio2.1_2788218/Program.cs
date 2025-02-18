using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1_2788218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coche_generico coche = new coche_generico("Honda", "Civic", "500", "10" ); //Clase--objeto--clase

            Console.WriteLine("El auto de José Pérez\n\n - marca: "+ coche.marca);    //objeto, campo
            Console.WriteLine("\n - modelo: " + coche.modelo);
            Console.WriteLine("\n - Puede llegar a recorrer: " + coche.velocidad_max+ " Km/h como velocidad máxima.");
            Console.WriteLine("\n - Actualmente está corriendo a una velocidad de  " + coche.velocidad_act + "Km/h.");
            coche.acelerar(15);     //Acá se llena el campo que creamos en la otra clase.
            coche.desacelerar(5);
            //Instanciar a ejercicio 2.2
            Ejercicio2 cocheheredado = new Ejercicio2("Honda", "Civic", "500", "10");
            cocheheredado.Frenar();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_2788218
{
    internal class Program
    {
        static void Main(string[] args)
        {//instanciar o crear objeto

            PersonaNadadora Persona1 = new PersonaNadadora("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona:");
            Console.WriteLine("Ojos: " + Persona1.Ojos);
            Console.WriteLine("Altura: " + Persona1.Altura);
            Console.WriteLine("Peso: "+ Persona1.Peso);
            Console.WriteLine("Sexo: " + Persona1.Sexo);

            Persona1.Hablar("Me llamo Borja");                          //Objeto, acción
            Console.WriteLine("Color de mis ojos: "+ Persona1.Ojos);
            Persona1.correr(1000);
            Console.WriteLine("Mi peso actual es: "+ Persona1.Peso);
            Persona1.Nadar();
            Console.WriteLine("Tras nadar peso: " + Persona1.Peso);
            Console.ReadKey();
        }

    }
}

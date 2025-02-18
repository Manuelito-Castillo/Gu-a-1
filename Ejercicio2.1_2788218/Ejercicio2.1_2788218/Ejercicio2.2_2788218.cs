using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1_2788218
{
    public class Ejercicio2:coche_generico
    {
       
        public Ejercicio2(string marca, string modelo, string velocidad_maxima, string velocidad_actual): base(marca, modelo, velocidad_maxima, velocidad_actual)
        {
            
        }

        public void Frenar()
        {
            Console.WriteLine(" - Luego el auto  freno a 0 km/h" );
            
        }
    }
}

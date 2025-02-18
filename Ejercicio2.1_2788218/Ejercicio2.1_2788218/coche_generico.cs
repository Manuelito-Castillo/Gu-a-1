using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1_2788218
{
    public class coche_generico
    {
        public string marca;    //Campos
        public string modelo;
        public string velocidad_max;
        public string velocidad_act;
        public string velocidad_fin;
      
        

        //  |   Constructor              Atributos  o parámetros                                                             |
        public coche_generico (string marca, string modelo, string velocidad_maxima, string velocidad_actual)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.velocidad_max = velocidad_maxima;
            this.velocidad_act = velocidad_actual;
            
            
        }

        //acciones
        public void acelerar(double aceleracion)
        {
            Console.WriteLine("\n - Luego el auto aceleró de "+ velocidad_act+ " km/h a "+ aceleracion +" km/h" );
            
        }

        public void desacelerar(double desaceleracion)
        {
            Console.WriteLine("\n - Al final el auto desaceleró de "+velocidad_act+ " km/h a "+ desaceleracion + " km/h");
            
        }
    }
}

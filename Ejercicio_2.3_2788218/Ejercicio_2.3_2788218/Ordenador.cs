using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3_2788218
{
    public class Ordenador
    {
        

        //Constructor
        public Ordenador(string marca, string procesador, string memoria, string disco, double capacidad_del_disco)
        {
            this.marca = marca;
            this.procesador = procesador;
            this.memoria = memoria;
            this.disco = disco;
            this.capacidad_del_disco = capacidad_del_disco;
        }
        public string marca;            //Campos
        public string procesador;
        public string memoria;
        public string disco;
        public double capacidad_del_disco;
        public double gb_incrementadas;

        //Acciones
        public void incrementar(double gb_incrementadas)
        {
            Console.WriteLine("José llevo a reparar su ordenador y las gb del disco aumentaron de " + capacidad_del_disco + " a " + gb_incrementadas + " gb.");
        }
        
        public void reducir(double gb_reducidas)
        {
            Console.WriteLine("Sin embargo, el disco duro se daño y las gb de este se redujeron de " +capacidad_del_disco + " a " + gb_reducidas + " gb.");
        }

    }
}

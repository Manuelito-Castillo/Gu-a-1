﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_2788218
{
    public class Persona
    {
        public Persona (string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }

        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;

        public void Hablar(string texto) //acción
        {
            Console.WriteLine("Hoy voy a decir "+ texto);
        }   

        public void Comer(double calorias)
        {
            Console.WriteLine("Ganando "+ calorias+ " calorías");
            this.Peso += calorias / 1000;
        }

        public void correr(double calorias)
        {
            Console.WriteLine("Perdiendo "+calorias + " calorías");
            this.Peso = Convert.ToString(calorias / 1000);  
        }
    }

}

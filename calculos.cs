using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora_de_area
{
    public class calculos
    {
        public int Base { get; set; }
        public int altura { get; set; }

        public double radio { get; set; }

        //Calcular el area del cuadrado
        public int Cuadrado()
        {
            return Base * Base;
        }
        
        //Formula para calcular el area del triangulo
        public int Triangulo()
        {
            return (Base * altura) / 2;
        }
        
        //Formula para calcular el area del circulo

        public double Circulo()
        {
            double elevadoAlCuadrado = Math.Pow(radio, 2);
            return 3.1416 * elevadoAlCuadrado;
        }
        


    }
}
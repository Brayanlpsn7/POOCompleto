using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exercicios.Ex2Calculadora
{
    internal class CalculadoraDeArea
    {
        public double CalcularArea(double lado)
        {
            return (lado * lado);
        }

        public double CalcularArea(double largura, double altura)
        {
            return (largura * altura);
        }




    }
}

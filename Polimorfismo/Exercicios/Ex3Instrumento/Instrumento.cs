using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exercicios.Ex3Instrumento
{
    internal class Instrumento
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Tocando um instrumento...");
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exercicios.Ex3Instrumento
{
    internal class Violao : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Violão: plim plim");
        }


    }
}

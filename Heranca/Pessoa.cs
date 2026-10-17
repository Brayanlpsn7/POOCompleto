using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Oi! Eu sou " + Nome);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ex1Animal
{
    internal class Animal
    {
        public string Nome { get; set; }

        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
}

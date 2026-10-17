using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ex1Animal
{
    internal class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome}: Au au!");
        }
    }
}

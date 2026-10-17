using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ex3Veiculo
{
    internal class Carro : Veiculo
    {
        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }

        public int Portas { get; set; }

        public void ExibirPortas()
        {
            Console.WriteLine(Portas);
        }


    }
}

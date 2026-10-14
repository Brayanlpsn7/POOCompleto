using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoConstrutor
{
    internal class Viagem
    {
        // Atributos

        public string Destino;
        public int Dias;
        public double ValorDiaria;

        public Viagem(string destino, int dias, double valorDiaria)
        {
            Destino = destino;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }

        public double CalcularTotal()
        {
            return Dias * ValorDiaria;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Destino}: {Dias} dias X {ValorDiaria:c} = {CalcularTotal():c} "); // SEMPRE por () qnd for metodo
        }
            
    }
}

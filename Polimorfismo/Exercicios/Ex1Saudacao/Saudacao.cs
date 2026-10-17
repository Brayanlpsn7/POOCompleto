using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exercicios.Ex1Saudacao
{
    internal class Saudacao
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Olá!");
        }

        public void Cumprimentar(string nome)
        {
            Console.WriteLine($"Olá, {nome}!");
        }

        public void Cumprimentar(string nome, int idade)
        {
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
        }


    }
}

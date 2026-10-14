using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoConstrutor
{
    internal class Contato
    {
        // Atributos

        public string Nome, Email, Telefone;

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} | {Telefone} | {Email}");
        }
    }
}

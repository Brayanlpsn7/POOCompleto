using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Usuario
    {
        public string Login { get; set; }

        private string Senha { get; set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ex2Func
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }



    }
}

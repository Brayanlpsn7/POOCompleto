using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao.Exemplos
{
    public class Email : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Email disparado: {mensagem}");
        }
    }
}

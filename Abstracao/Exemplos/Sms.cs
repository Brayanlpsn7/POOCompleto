using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao.Exemplos
{
    public class Sms : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"SMS enviado: {mensagem}");
        }
    }
}

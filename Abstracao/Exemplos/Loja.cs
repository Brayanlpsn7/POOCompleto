using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao.Exemplos
{
    public class Loja
    {
        public void Finalizar(INotificador notificador)
        {
            notificador.Enviar("Compra finalizada");
}
    }
}

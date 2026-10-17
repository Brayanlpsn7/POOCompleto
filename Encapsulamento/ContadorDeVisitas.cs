using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class ContadorDeVisitas
    {
        //atributos

        private int Visitas { get; set; }

        public void RegistrarVisita()
        {
            Visitas++;
        }
        
        public int ObterTotal()
        {
            return Visitas;
        }




    }
}

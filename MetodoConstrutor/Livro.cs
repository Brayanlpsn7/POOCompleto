using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoConstrutor
{
    internal class Livro
    {
        // Atributos

        public string Titulo, Autor;
        public int Paginas;

        public Livro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Titulo}, de {Autor}.({Paginas} páginas)");
        }



    }
}

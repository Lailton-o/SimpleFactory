using System;

namespace SimpleFactory
{
    public class Livro : ILivro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public DateTime Lancamento { get; set; }

        public Livro(string titulo, string autor, int paginas, DateTime lancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Lancamento = lancamento;
        }

        public override string ToString()
        {
            return $"{Autor} {Titulo} {Paginas} {Lancamento}";
        }
    }
}

using System;

namespace SimpleFactory
{
    public interface ILivro
    {
        string Autor { get; set; }
        string Titulo { get; set; }
        int Paginas { get; set; }
        DateTime Lancamento { get; set; }
    }
}

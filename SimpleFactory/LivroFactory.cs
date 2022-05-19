using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class LivroFactory
    {
        public static ILivro CriaLivro(string titulo, string autor, int paginas, DateTime lancamento)
        {
            return new Livro(titulo, autor, paginas, lancamento);
        }
    }
}

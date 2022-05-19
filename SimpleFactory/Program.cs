using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var livroJamesKing = LivroFactory.CriaLivro("C# - Básico", "James King", 323, DateTime.Now);

            Console.WriteLine("Titulo: " + livroJamesKing.Titulo);
            Console.WriteLine("Autor: " + livroJamesKing.Autor);
            Console.WriteLine("Paginas : " + livroJamesKing.Paginas);
            Console.WriteLine("Data de Lançamento: " + livroJamesKing.Lancamento);


            Console.WriteLine("Objeto Livro: " + livroJamesKing.ToString());
            Console.WriteLine();
            Console.WriteLine();

            var programadorApaixonado = 
                LivroFactory.CriaLivro("O Programador Apaixonado: Construindo uma carreira notável em desenvolvimento de software",
                "Chad Fowler", 266, new DateTime(2009, 5, 28));

            Console.WriteLine("Titulo: " + programadorApaixonado.Titulo);
            Console.WriteLine("Autor: " + programadorApaixonado.Autor);
            Console.WriteLine("Paginas : " + programadorApaixonado.Paginas);
            Console.WriteLine("Data de Lançamento: " + programadorApaixonado.Lancamento);


            Console.WriteLine("Objeto Livro: " + programadorApaixonado.ToString());
            Console.ReadLine();
        }
    }
}

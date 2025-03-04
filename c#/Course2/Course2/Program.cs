using System;
using System.Globalization;
namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "TV 4k";

            Console.WriteLine(p.Preco);
            //p.Preco = 789.99

            //Produto p = new Produto(nome, preco, quantidade);
            //Produto p = new Produto(nome, preco);

            //Produto p2 = new Produto();

            //Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 10 };
            //Produto p3 = new Produto() { Nome = "TV", Preco = 500.00, Quantidade = 10 };

 
        }
    }
}
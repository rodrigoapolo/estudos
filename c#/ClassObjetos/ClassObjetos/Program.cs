using System;
using System.Globalization;

namespace ClassObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Começando a resolver um segundo problema exemplo-------------------------------------------------------------------------------------------------------------------------------
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");

            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do procuto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a se adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizado: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a se removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizado: " + p);

            //Criando uma classe com três atributos para representar melhor um Triângulo -------------------------------------------------------------------------------------
            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X: ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //double areaX = x.Area();
            //double areaY = y.Area();

            //Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}

        }
    }

}


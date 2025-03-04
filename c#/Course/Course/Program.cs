// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using static System.Formats.Asn1.AsnWriter;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estrutura repetitiva para (for)
            //Console.Write("Quantos número inteiros você vai digitar? ");
            //int N = int.Parse(Console.ReadLine());

            //int soma = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine($"Valor: {i}");
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}

            //Console.WriteLine("Soma = " + soma);

            // Estrutura repetitiva enquanto (while)--------------------------------------------------------------------------------------------------------------
            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Número negativo!");

            // Funções (sintaxe)---------------------------------------------------------------------------------------------------------------------

            //Console.WriteLine("Digite três números: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //double resultado = Maior(n1, n2, n3);

            //Console.WriteLine("Maior = " + resultado);

            //Escopo e inicialização-------------------------------------------------------------------------------------------------------------

            //int x;

            //Console.WriteLine(x);

            //double preco = double.Parse(Console.ReadLine());
            //double desconto = 0.0;

            //if(preco > 100)
            //{
            //    desconto = preco * 0.1;
            //}

            //Console.WriteLine(desconto);

            //Estrutura condicional(if-else)-------------------------------------------------------------------------------------------

            //int x = 10;

            //Console.WriteLine("Bom dia");

            //if(x > 5)
            //{
            //    Console.WriteLine("Boa tarde");
            //}

            //Console.WriteLine("Boa noite");

            //Console.WriteLine("Entre com um número inteiro:");
            //int x = int.Parse(Console.ReadLine());

            //if(x % 2 == 0)
            //{
            //    Console.WriteLine("Par!");
            //}
            //else
            //{
            //    Console.WriteLine("Impar!");
            //}

            //Console.WriteLine("Qual a hora atual!");
            //int hora = int.Parse(Console.ReadLine());

            //if (hora < 12)
            //{
            //    Console.WriteLine("Bom dia!");
            //}
            //else if (hora < 18)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite!");
            //}

            //Operadores lógicos---------------------------------------------------------------------------------------
            //bool c1 = 2 > 3 && 4 != 5;
            //bool c1 = 2 > 3 || 4 != 5;
            //bool c2 = !(2 > 3) && 4 != 5;


            //Console.WriteLine(c1);
            //Console.WriteLine(c2);

            //Console.WriteLine("-------------------------------------");

            //bool c3 = 10 < 5;
            //bool c4 = c1 || c2 && c3;

            //Console.WriteLine(c4);

            //Operadores comparativos---------------------------------------------------------------------------------
            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("------------------------");

            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10;
            //bool c8 = a != 10;

            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);


            //Entrada de dados em C# - PARTE 1---------------------------------------------------------------------
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(" ");
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("Voce digitou:");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();


            //string[] vet = Console.ReadLine().Split(" ");

            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];

            //Console.WriteLine("Voce digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //int n1 = 3 + 4 * 2;
            //int n2 = (3 + 4) * 2;
            //int n3 = 17 % 3;
            //double n4 = (double) 10 / 8;
            ////double n4 = 10.0 / 8;

            //double a = 1.0, b = -3.0, c = -4.0;

            ////double delta = b * b - 4.0 * a * c;
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            //double x1 = (-b + Math.Sqrt(delta)) / (2.0  * a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2.0  * a);

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //int a = 5;
            //int b = 2;

            //double resultado = (double) a / b;
            //Console.WriteLine(resultado);

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a;
            //Console.WriteLine(b);

            //double a;
            //float b;

            //a = 5.1;
            //b = (float)a;
            //Console.WriteLine(b);

            //float x = 4.5f;

            //double y = x;

            //Console.WriteLine(y);

            //int a = 10;
            // a = a + 1
            //a++;
            //Console.WriteLine(a);

            //int a = 10;
            ////int b = a++;
            //int b = ++a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int a = 10;
            //Console.WriteLine(a);

            //a += 2;
            //Console.WriteLine(a);

            //a *= 3;
            //Console.WriteLine(a);

            //string s = "ABC";

            //s += "DEF";

            //Console.WriteLine(s);



            //int idade = 32;
            //double saldo = 10.35783;
            //string nome = "Maria";

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            //char genero = 'F';
            //int idade = 32;
            //double saldo = 10.35783;
            //string nome = "Maria";

            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("------------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F3"));
            //Console.WriteLine(saldo.ToString("f4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            //int n1 = int.MinValue;
            //int n2 = int.MaxValue;
            //sbyte n3 = sbyte.MinValue;
            //decimal n4 = decimal.MaxValue;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            //bool completo = false;
            //char genero = 'F';
            //char letra = '\u0041';
            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483649L;
            //float n5 = 4.5f;
            //double n6 = 4.5;
            //string nome = "Maria Green";

            //object obj1 = "Alex Brown";
            //object obj2 = 4.5f;

            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;

namespace ComportamentoMenoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrizes===========================================================================================================

            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            
            
            
            //Listas (List)===========================================================================================================

            //List<string> list;
            //List<string> list = new List<string>();

            //List<string> list2 = new List<string>() { "Maria", "Alex" };

            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna");
            //list.Insert(2, "Marco");

            //foreach(string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("List Count: " + list.Count);

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': "+ s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': " + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': " + pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last position 'A': " + pos2);


            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //Console.WriteLine("========================================");
            //foreach(string name in list2)
            //{
            //    Console.WriteLine(name);
            //}

            //list.Remove("Alex");
            //Console.WriteLine("========================================");

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //list.RemoveAt(3);
            //Console.WriteLine("========================================");

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //list.RemoveRange(2, 2);
            //Console.WriteLine("========================================");

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}


            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("========================================");

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}


            //Sintaxe opcional: laço foreach===========================================================================================================

            //string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //foreach (string nome in vect)
            //{
            //    Console.WriteLine(nome);
            //}


            //Modificadores de parâmetros ref e out============================================================================================

            //int a = 10;
            //int triple;
            ////Calculator.Triple(ref a);
            //Calculator.Triple(a, out triple);
            //Console.WriteLine(triple);



            //Modificador de parâmetros params======================================================================================

            //int s1 = Calculator.Sum(2, 3 ,4);

            //Console.WriteLine(s1);

            // Vetores====================================================================================================
            //int n = int.Parse(Console.ReadLine());

            //Product[] vect = new Product[n];

            //for(int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE PRICE = "+ avg.ToString("F3",CultureInfo.InvariantCulture));

            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}


            //double sum = 0.0;
            //for(int i = 0; i < n; i++)
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F3", CultureInfo.InvariantCulture));

            //Nullable====================================================================================================================================

            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if(x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X é null");

            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Y é null");

            //double? i = null;
            //double? j = 10;

            //double a = i ?? 5;
            //double b = j ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            ////===========================================================================
            //Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();

            //Console.WriteLine(p);
        }
    }
}
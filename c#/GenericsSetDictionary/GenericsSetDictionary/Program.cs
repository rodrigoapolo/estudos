using GenericsSetDictionary.Entities;
using System;

namespace GenericsSetDictionary{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]);

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Sizer: "+ cookies.Count);

            Console.WriteLine("ALL COOKIES:");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": "+ item.Value);
            }





            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 5, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            ////union
            //SortedSet<int> c = new SortedSet<int>(a);
            //c.UnionWith(b);

            //PrintCollection(c);

            ////intersection
            //SortedSet<int> d = new SortedSet<int>(a);
            //d.IntersectWith(b);
            //PrintCollection(d);

            ////Difference
            //SortedSet<int> e = new SortedSet<int>(a);
            //e.ExceptWith(b);
            //PrintCollection(e);

            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("tablet");


            //Console.WriteLine(set.Contains("Notebook"));

            //foreach(string p in set)
            //{
            //    Console.WriteLine(p);
            //}

            //Client a = new Client { Name = "Maria", Email = "maria@gamil.com" };
            ////Client b = new Client { Name = "Alex", Email = "alex@gamil.com" };
            //Client b = new Client { Name = "Alex", Email = "maria@gamil.com" };

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a == b);
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            //string a = "Maria";
            ////string b = "Alex";
            //string b = "Maria";

            ////Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());


            //List<int> list = new List<int>();

            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    list.Add(x);
            //}

            //CalculationService calculation = new CalculationService();

            //int max = calculation.Max(list);

            //Console.WriteLine("Max");
            //Console.WriteLine(max);


            //PrintService<int> printService = new PrintService<int>();

            //Console.Write("How many values? ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    printService.AddValue(x);
            //}

            //printService.Print();
            //Console.WriteLine("First: " + printService.First());
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }

}
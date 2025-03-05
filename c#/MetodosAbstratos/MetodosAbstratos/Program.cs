using System.Globalization;
using System;
using MetodosAbstratos.Model.Entities;
using MetodosAbstratos.Model.Enums;
namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //List<Shape> list = new List<Shape>();
            //Console.Write("Enter the number of shapes: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Shape #{i} data: ");
            //    Console.Write("Rectangel or Circle (r/c)? ");
            //    char ch = char.Parse(Console.ReadLine());
            //    Console.Write("Color (Black/Blue/Red): ");
            //    Color color = Enum.Parse<Color>(Console.ReadLine());
                
            //    if(ch == 'r')
            //    {
            //        Console.Write("Width: ");
            //        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Console.Write("Height: ");
            //        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //        list.Add(new Rectangle(width, height, color));
            //    }
            //    else
            //    {
            //        Console.Write("Radius: ");
            //        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        list.Add(new Circle(radius, color));
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("SHAPE AREAS");
            //foreach (Shape shape in list)
            //{
            //    Console.WriteLine(shape.Area().ToString("F3", CultureInfo.InvariantCulture));
            //}
        }
    }
}

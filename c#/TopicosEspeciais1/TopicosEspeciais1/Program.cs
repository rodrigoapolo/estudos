﻿using System;
using System.Globalization;

namespace TopicosEspeciasis1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTimeKind e padrão ISO 8601===============================================================================================
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            //Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());


            // Propriedades e operações com TimeSpan===============================================================================================

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);
            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t);
            //Console.WriteLine("Days: " + t.Days);
            //Console.WriteLine("Hours: " + t.Hours);
            //Console.WriteLine("Minutes: " + t.Minutes);
            //Console.WriteLine("Milliseconds: " + t.Milliseconds);
            //Console.WriteLine("Seconds: " + t.Seconds);
            //Console.WriteLine("Ticks: " + t.Ticks);

            //Console.WriteLine("TotalDays: " + t.TotalDays);
            //Console.WriteLine("TotalHours: " + t.TotalHours);
            //Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);



            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);


            // Propriedades e operações com DateTime===============================================================================================

            //DateTime d1 = new DateTime(2000, 10, 15);
            //DateTime d2 = new DateTime(2000, 10, 18);

            //TimeSpan t = d2.Subtract(d1);

            //Console.WriteLine(t);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);
            //DateTime d4 = d.AddDays(7);



            //Console.WriteLine(d);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));


            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);




            // TimeSpan - representando durações===============================================================================================

            //TimeSpan t1 = TimeSpan.FromDays(1.5);
            //TimeSpan t2 = TimeSpan.FromHours(1.5);
            //TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t5 = TimeSpan.FromMicroseconds(1.5);
            //TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);

            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2,11,21);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21,321);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);

            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);


            // DateTime - representando data e hora===============================================================================================

            //DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);



            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d3 = DateTime.Parse("15/08/2000");
            //DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);


            //DateTime d1 = new DateTime(2018,11,25);
            //DateTime d2 = new DateTime(2018,11,25, 20, 45, 3);
            //DateTime d3 = new DateTime(2018,11,25, 20, 45, 3, 500);
            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;



            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            //DateTime d1 = DateTime.Now;

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);



            // Funções interessantes para string===============================================================================================

            //string original = "abcde FGHIJ ABC abc DEFG   ";

            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();
            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");
            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);
            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");
            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);


            //Console.WriteLine("Original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("IndexOf('bc'): "+n1);
            //Console.WriteLine("LastIndexOf('bc'): " + n2);
            //Console.WriteLine("Substring(3): " + s4);
            //Console.WriteLine("Substring(3, 5): " + s5);
            //Console.WriteLine("Replace('a', 'x'): " + s6);
            //Console.WriteLine("Replace('abc', 'xy': " + s7);
            //Console.WriteLine("String.IsNullOrEmpty: " + b1);
            //Console.WriteLine("String.IsNullOrWhiteSpace: " + b2);







            // Sintaxe alternativa - expressão condicional ternária===============================================================================================

            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            ////if(preco < 20.0)
            ////{
            ////    desconto = preco * 0.1;
            ////}else
            ////{
            ////    desconto = preco * 0.05;
            ////}

            //Console.WriteLine(desconto);


            // Sintaxe alternativa - switch-case===============================================================================================
            //int x = int.Parse(Console.ReadLine());
            //string day;

            //switch (x)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid value";
            //        break;                    
            //}

            //Console.WriteLine("Day: " + day);


            // Inferência de tipos: palavra var===============================================================================================

            //var x = 10;
            //var y = 20.0;
            //var z = "Maria";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
        }
    }
}

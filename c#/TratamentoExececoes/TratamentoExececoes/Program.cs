﻿using System;
using TratamentoExececoes.Entities;
using TratamentoExececoes.Entities.Execeptions;

namespace TratamentoExececoes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre date to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);


                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }catch(DormainExeception e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }


            //try
            //{

            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    int result = n1 / n2;

            //    Console.WriteLine(result);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine("Error! " + e.Message);

            //}catch(FormatException e)
            //{
            //    Console.WriteLine("Format error! " + e.Message);
            //}
        }
    }
}
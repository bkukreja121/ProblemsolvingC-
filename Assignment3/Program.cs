using System.Collections.Generic;
using System;

namespace Assignment3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            bool loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("1.Program to Replace username");
                Console.WriteLine("2.Program to check leap year");
                Console.WriteLine("3.Program to display prime factorization of a number");

                Console.WriteLine("Please select a program");
                int input = Convert.ToInt32(Console.ReadLine());


                switch (input)
                {

                    case 1:

                        ReplaceString.Replace();
                        break;

                    case 2:

                        Console.WriteLine("Enter the Year in four digits");
                        int year = Convert.ToInt32(Console.ReadLine());
                        LeapYear.Leap(year);
                        break;

                    case 3:

                        Console.WriteLine("Please enter your integer: ");
                        int a = int.Parse(Console.ReadLine());
                        PrimeaFactor.Factor(a);
                        break;

                    case 4:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (loopContinue)
                    Console.WriteLine("Please enter a valid choice.");
            }
        }
    }
}
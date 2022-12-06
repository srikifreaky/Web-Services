using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;
            Console.Write("---------- CALCULATOR --------- \n");
            Console.WriteLine("ENTER THE 1st NUMBER: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE 2nd NUMBER: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("WHAT DO YOU WANNA PERFORM? ");
            Console.WriteLine("\ta - ADDITION");
            Console.WriteLine("\ts - SUBTRACTION");
            Console.WriteLine("\tm - MULTIPLICATION");
            Console.WriteLine("\td - DIVISION");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"ANSWER: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"ANSWER: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"ANSWER: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"ANSWER: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}

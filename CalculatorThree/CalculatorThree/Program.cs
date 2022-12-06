using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;
            string value;
            Console.WriteLine("---------- CALCULATOR ---------\n");
            do
            {
                Console.WriteLine("ENTER THE 1st NUMBER: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTER THE 2nd NUMBER: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("WHAT DO YOU WANNA PERFORM?");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
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

                Console.Write("\nPRESS 'y' TO CONTINUE or 'n' TO EXIT: ");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
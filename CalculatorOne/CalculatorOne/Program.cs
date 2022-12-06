using System;
using System.Diagnostics.Metrics;
using static System.Console;
namespace CalculatorOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---------- CALCULATOR ----------");
            WriteLine("ENTER THE 1st NUMBER: ");
            int a = Convert.ToInt32(Console.ReadLine());
            WriteLine("ENTER THE 2ND NUMBER: ");
            int b = Convert.ToInt32(Console.ReadLine());
            WriteLine("SUM: {0}", add(a, b));
        }
        static int add(int a, int b)
        {
            return a + b;
        }
    }
}
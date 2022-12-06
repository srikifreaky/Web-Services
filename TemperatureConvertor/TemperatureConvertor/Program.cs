using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TemperatureConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--------- TEMPERATURE CONVERTOR ---------\n");
            Console.Write("CURRENT CELSIUS: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KELVIN = {0}", celsius + 273);
            Console.WriteLine("FAHRENHEIT = {0}", celsius * 18 / 10 + 32);
        }
    }
}
using System;

namespace Lesson01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskete temperatura C: ");
            decimal tempC = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Farenheint = {(tempC * 18m/10) + 32 }");
            
        }
    }
}

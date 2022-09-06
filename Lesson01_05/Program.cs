using System;

namespace Lesson01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite pirma skaiciu:");
            decimal firstNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            decimal secondNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Dvieju skaiciu suma: {firstNum + secondNum}");
            Console.WriteLine($"Dvieju skaiciu sandauga: {firstNum * secondNum}");
            if (secondNum != 0)
            {
                Console.WriteLine($"Dvieju skaiciu sandauga: {firstNum * secondNum}");
            }
            else
            {
                Console.WriteLine("Dalyba is nulio negalima");
            }
            Console.WriteLine($"Dvieju skaiciu skirtumas: {firstNum - secondNum}");
        }
    }
}

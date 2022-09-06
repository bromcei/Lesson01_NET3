using System;

namespace Lesson01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal inputNum;
            decimal numSum = 0;
            Console.WriteLine("Iveskite 4 skaicius:");
            for (int i = 0; i < 4; i++)
            {
                inputNum = Decimal.Parse(Console.ReadLine());
                numSum = numSum + inputNum;
            }
            Console.WriteLine($"Siu skaiciu vidurkis yra: {numSum / 4m}");
        }
    }
}

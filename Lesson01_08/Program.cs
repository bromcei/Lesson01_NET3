using System;

namespace Lesson01_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal aNum;
            decimal bNum;
            decimal cNum;

            Console.WriteLine("Iveskite A, B ir C skaicius:");
            aNum = decimal.Parse(Console.ReadLine());
            bNum = decimal.Parse(Console.ReadLine());
            cNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"(A + B) x C = {(aNum + bNum) * cNum}");
            Console.WriteLine($"A x C + B x C  = {(aNum * bNum) + (bNum * cNum)}");
        }
    }
}

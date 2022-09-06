using System;

namespace Lesson01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputVar;
            inputVar = Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", inputVar);
            Console.WriteLine("{0}{1}{0}", inputVar, " ");
            Console.WriteLine("{0}{1}{0}", inputVar, " ");
            Console.WriteLine("{0}{1}{0}", inputVar, " ");
            Console.WriteLine("{0}{0}{0}", inputVar);

        }
    }
}

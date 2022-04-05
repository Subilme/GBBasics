using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min temperature = ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max temperature = ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Avg temperature = ", (max + min) / 2);
        }
    }
}

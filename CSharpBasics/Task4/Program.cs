using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}

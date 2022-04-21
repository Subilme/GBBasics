using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("start.txt", Convert.ToString(DateTime.Now));
        }
    }
}

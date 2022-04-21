using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task3
{
    class Program
    { 
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), numbers);
        }
    }
}

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Леухин", "Максим", "Юрьевич"));
            Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
            Console.WriteLine(GetFullName("Петров", "Андрей", "Викторович"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + ' ' + lastName + ' ' + patronymic;
        }
    }
}

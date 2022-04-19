using System;

namespace Task3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            IdentifySeason(n);
        }

        static void IdentifySeason(int n)
        {
            switch (n)
            {
                case 12:
                case 1:
                case 2:
                    PrintMonth(Seasons.Winter);
                    break;
                case 3:
                case 4:
                case 5:
                    PrintMonth(Seasons.Spring);
                    break;
                case 6:
                case 7:
                case 8:
                    PrintMonth(Seasons.Winter);
                    break;
                case 9:
                case 10:
                case 11:
                    PrintMonth(Seasons.Winter);
                    break;
            }
        }

        static void PrintMonth(Seasons season)
        {
            switch (season)
            {
                case Seasons.Winter:
                    Console.WriteLine("Зима");
                    return;
                case Seasons.Spring:
                    Console.WriteLine("Весна");
                    return;
                case Seasons.Summer:
                    Console.WriteLine("Лето");
                    return;
                case Seasons.Autumn:
                    Console.WriteLine("Осень");
                    return;
            }
            Console.WriteLine("Ошибка: введите число от 1 до 12");
        }
    }
}

using System;
using System.IO;
using System.Text.Json;
using static Task5.ToDo;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo[] listing;

            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                listing = JsonSerializer.Deserialize<ToDo[]>(json);

                for (int i = 0; i < listing.Length; i++)
                {
                    Console.Write(i + 1);
                    listing[i].Print();
                }
            }

            while (true)
            {
                Console.WriteLine("1. Добавить");
                Console.WriteLine("2. Выполнено");
                Console.WriteLine("3. Выход");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 3) break;

                switch (n)
                {
                    case 1:
                        listing[listing.Length] = new ToDo(Console.ReadLine());
                        break;
                    case 2:
                        if (listing.Length == 0)
                        {
                            Console.WriteLine("Список пуст");
                            break;
                        }
                        int i = Convert.ToInt32(Console.ReadLine());
                        listing[i].Done();
                        break;
                }

                for (int i = 0; i < listing.Length; i++)
                {
                    Console.Write(i + 1);
                    listing[i].Print();
                }
            }

            string json = JsonSerializer.Serialize(listing);
            File.WriteAllText("tasks.json", json);
        }
    }
}

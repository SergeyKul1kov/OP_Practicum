using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите какой по порядку Сергей стоит в очереди: ");
            int order = Convert.ToInt32(Console.ReadLine());
            int time = order * 20;

            if (time + 20 < 480)
            {
                if (time % 60 == 0)
                {
                    time = time / 60;
                    Console.WriteLine($"Сергей простоит в очереди {time} часов");
                }
                else
                {
                    int chas = time / 60;
                    int minut = time % 60;
                    Console.WriteLine($"Сергей простоит в очереди {chas} час(ов) и {minut} минут");
                }
            }
            else
            {
                Console.WriteLine("Сергей ушел домой, увидя огромную очередь");
            }

            Console.ReadLine();
        }
    }
}
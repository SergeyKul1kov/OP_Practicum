using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите номер Сережи в шеренге: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
            {
                Console.WriteLine("Я первый :)");
            }
            else
            {
                Console.WriteLine("Я второй :(");
            }

            Console.ReadLine();
        }
    }
}
using System;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вам предложено три варианта вклада");

            Console.WriteLine();

            Console.WriteLine("1. Вклад на 1 год под 7% годовых");
            Console.WriteLine("2. Вклад на 3 года под 8% годовых");
            Console.WriteLine("3. Вклад на 10 лет под 10% годовых");

            Console.Write("Какой вариант вклада вы предпочитаете(Введите номер варианта): ");
            int optionNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("А теперь скажите какую сумму вы хотите внести: ");
            int deposit = Convert.ToInt32(Console.ReadLine());

            if (optionNum == 1)
            {
                double profit = (deposit * 7) / 100;
                Console.WriteLine($"Вы заработаете {profit} рублей");
            }
            else if (optionNum == 2)
            {
                double profit = ((deposit * 8) / 100) * 3;
                Console.WriteLine($"Вы заработаете {profit} рублей");
            }
            else if (optionNum == 3)
            {
                double profit = ((deposit * 10) / 100) * 5;
                Console.WriteLine($"Вы заработаете {profit} рублей");
            }
            else
            {
                Console.WriteLine("К сожалению, вы можете выбрать выриант вклада, только из предложенного");
            }
            Console.ReadLine();
        }
    }
}
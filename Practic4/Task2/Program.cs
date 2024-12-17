using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal> accounts = new Dictionary<string, decimal>
            {
                { "Маша", 10000 },
                { "Петя", 30000 },
                { "Вася", 100000 }
            };

            Console.WriteLine("Введите ваше имя: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Введите сумму, которую хотите положить на карту: ");
            decimal deposit;
            while (!decimal.TryParse(Console.ReadLine(), out deposit) || deposit <= 0)
            {
                Console.WriteLine("Пожалуйста, введите корректную сумму: ");
            }

            if (accounts.ContainsKey(userName))
            {
                accounts[userName] += deposit;
                Console.WriteLine($"{userName}, ваш баланс счета изменен! Текущий баланс {accounts[userName]} рублей.");
            }
            else
            {
                accounts[userName] = deposit;
                Console.WriteLine($"Благодорим, что вы стали клиентом нашего банка, {userName}! Ваш баланс счета изменен! Текущий баланс {accounts[userName]} рублей.");
            }

            decimal profit = CalculateProfit(accounts[userName]);
            Console.WriteLine($"Вы можете воспользоваться стандартным вкладом нашего банка! Вложив сумму остатка {accounts[userName]} на 3 года под 17% годовых, вы получите прибыль {profit}.");
            Console.WriteLine("Для активации вклада войдите в мобильное приложение!");

            Console.Read();

        }

        static decimal CalculateProfit(decimal balance)
        {
            decimal interestRate = 0.17m;
            int years = 3;
            decimal futureValue = balance * (decimal)Math.Pow((1 + (double)interestRate), years);

            return futureValue - balance;
        }
    }
}
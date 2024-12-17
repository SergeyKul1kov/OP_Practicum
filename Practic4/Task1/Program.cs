using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 5, 1, 9, 2, 8 };
            CalculateCollection(numbers);

            Console.ReadLine();
        }

        static void CalculateCollection(List<int> collection)
        {
            if (collection == null || collection.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            int count = collection.Count;
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int number in collection)
            {
                if (number > max)
                    max = number;

                if (number < min)
                    min = number;
            }

            Console.WriteLine($"Количество элементов: {count}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Минимальный элемент: {min}");

            int product = CalculateProduct(min, max);
            Console.WriteLine($"Произведение минимума и максимума: {product}");
        }

        static int CalculateProduct(int a, int b)
        {
            return a * b;
        }
    }
}
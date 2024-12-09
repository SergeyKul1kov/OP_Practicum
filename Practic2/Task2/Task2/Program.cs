using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первую сторону треугольника: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if ((Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)) || (Math.Pow(A, 2) == Math.Pow(C, 2) + Math.Pow(B, 2)) || (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)))
            {
                Console.WriteLine("Треугольник ПРЯМОУГОЛЬНЫЙ");
            }
            else
            {
                Console.WriteLine("Треугольник НЕ прямоугольный");
            }

            Console.ReadLine();
        }
    }
}
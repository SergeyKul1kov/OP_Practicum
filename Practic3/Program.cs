using System;

namespace Practic3
{
    class Program
    {
        static void Main()
        {

            //Задание 1

            Random random = new Random();
            int secretNum = random.Next(1, 11);
            int userNum = 0;
            int attepts = 0;

            Console.WriteLine("Я загадал число от 1 до 10. Угадай его!)");

            while (userNum != secretNum)
            {
                Console.Write("Введите ваше число: ");
                userNum = Convert.ToInt32(Console.ReadLine());
                attepts++;

                if (userNum < secretNum)
                {
                    Console.WriteLine("Вы не угадали! Загаданное число больше вашего.");
                }
                else if (userNum > secretNum)
                {
                    Console.WriteLine("Вы не угадали! Загаданное число меньше вашего.");
                }
            }

            Console.WriteLine($"Поздравляю! Вы угадали число {secretNum} за {attepts} попыток.");



            //Задание 2

            Console.Write("Введите число N больше 10: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int sumSquarse = 0;

            if (N <= 10)
            {
                Console.WriteLine("Число должно быть больше 10!");
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                sum += i;
                sumSquarse += i * i;

                if (sumSquarse > 500)
                {
                    Console.WriteLine("Сумма квадратов привышает 500.");
                    break;
                }
            }

            Console.WriteLine($"Сумма всех чисел: {sum}");
            Console.WriteLine($"Сумма всех квадратов: {sumSquarse}");



            //Задание 3

            Console.Write("Введите количество студентов: ");
            int students = Convert.ToInt32(Console.ReadLine());
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int maxPullUps = 0;
            int minPullUps = Int32.MaxValue;

            for (int i = 1; i <= students; i++)
            {
                Console.Write($"Введите количество подтягиваний студента {i}: ");
                int pullUps = Convert.ToInt32(Console.ReadLine());

                if (pullUps == 12) count3++;
                else if (pullUps == 14) count4++;
                else if (pullUps == 16) count5++;

                if (pullUps > maxPullUps)
                {
                    maxPullUps = pullUps;
                }

                if (pullUps < minPullUps)
                {
                    minPullUps = pullUps;
                }
            }

            Console.WriteLine($"Количество студентов, сдавших зачет на 3: {count3}");
            Console.WriteLine($"Количество студентов, сдавших зачет на 4: {count4}");
            Console.WriteLine($"Количество студентов, сдавших зачет на 5: {count5}");
            Console.WriteLine($"Максимальное количество подтягиваний: {maxPullUps}");
            Console.WriteLine($"Минимальное количество подтягиваний: {minPullUps}");



            //Задание 4

            Console.Write("Введите число A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число D: ");
            double D = Convert.ToDouble(Console.ReadLine());

            double sumPositive = 0;
            int countPositive = 0;

            for (int x == 1; x <= 10; x++) 
            {
                double y = A * Math.Sqrt(B * x + D) - C * x;
                Console.WriteLine($"Для x = {x}, y = {y}");

                if (y > 0)
                {
                    sumPositive += y;
                    countPositive++;
                }
            }

            Console.WriteLine($"Сумма положительных y: {sumPositive}");

            if (countPositive > 0)
            {
                double average = sumPositive / countPositive;
                Console.WriteLine($"Среднее значение положительных y: {average}");
            }
            else
            {
                Console.WriteLine("Положительных значение y нет");
            }



            //Задание 5

            Console.Write("Введите количество элементов в массиве: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];

            Console.Write("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxIndex = 0;

            //Наибольший элемент массива
            for (int i = 1; i < N; i++)
            {
                if (A[i] > A[maxIndex])
                {
                    maxIndex = i;
                }
            }

            //Перестановка наибольшего элемента на последнее место
            if (maxIndex != N - 1)
            {
                int maxValue = A[maxIndex];

                for (int i = maxIndex; i < N - 1; i++)
                {
                    A[i] = A[i + 1];
                }
                A[N - 1] = maxValue;
            }

            Console.WriteLine("Массив после изменений");
            for (int i = 0; i < N; i ++)
            {
                Console.Write(A[i] + " ");
            }



            //Задание 6

            Console.Write("Введите радиус окружности: ");
            double R = Convert.ToDouble(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Введите координаты x для точки {i + 1}: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Введите координаты y для точки {i + 1}: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double distance = Math.Sqrt(x * x + y * y);

                if (distance < 2 * R)
                {
                    count++;
                }

            }

            Console.WriteLine($"Количество окружностей, пересекающих заданную окружность: {count}");


            Console.Read();
        }
    }
}
using System;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.Write("С какой скоростью двигался автомобиль: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            int overSpeed = Math.Abs(speed - 90);

            if (overSpeed <= 20)
            {
                Console.WriteLine("Скорость автомобиля допустима на данном участке");
            }
            else
            {
                if (overSpeed > 20 && overSpeed <= 40)
                {
                    Console.WriteLine("Вы привысили скорость. Заплатите штраф: 500 рублей");
                }
                else if (overSpeed > 40 && overSpeed <= 60)
                {
                    Console.WriteLine("Вы привысили скорость. Заплатите штраф: 1500 рублей");
                }
                else if (overSpeed > 60 && overSpeed <= 80)
                {
                    Console.WriteLine("Вы привысили скорость. Заплатите штраф: 2500 рублей. Или вы лишитесь прав на 4 месяца");
                }
                else if (overSpeed > 80)
                {
                    Console.WriteLine("Вы привысили скорость. Заплатите штраф: 5000 рублей. Или вы лишитесь прав на полгода");
                }
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Practic5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите план тренировок (через запятую): ");

            string[] exercises = Console.ReadLine().Split(',');

            FitnessProgram fitnessProgram = new FitnessProgram(name, exercises);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Выполнить упражнение");
                Console.WriteLine("2. Вывести текущую информацию об уровне физической подготовке");
                Console.WriteLine("3. Установить целевую норму калорий");
                Console.WriteLine("4. Задать новый план тренировок");
                Console.WriteLine("5. Изменить план тренировок");
                Console.WriteLine("6. Вывести мотивационное сообщение");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт меню: ");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Write("Введите количество сожженых калорий: ");
                        int calories = Convert.ToInt32(Console.ReadLine());
                        fitnessProgram.CompleteExercise(calories);
                        break;
                    case 2:
                        Console.WriteLine(fitnessProgram.ShowFithessLevelInformation());
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите целевую норму калорий: ");
                        fitnessProgram.DailyCaloriesGoal = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Введите новый план тренировок (через запятую): ");
                        exercises = Console.ReadLine().Split(',');
                        fitnessProgram.SetExercisePlan(exercises);
                        break;
                    case 5:
                        Console.WriteLine("1. Удалить тренировку");
                        Console.WriteLine("2. Добавить тренировку");

                        int modifyChoice = Convert.ToInt32(Console.ReadLine());

                        switch (modifyChoice)
                        {
                            case 1:
                                Console.Write("Введите название тренировки для удаления: ");
                                string exercisesToRemove = Console.ReadLine();
                                fitnessProgram.RemoveExercises(exercisesToRemove);
                                break;
                            case 2:
                                Console.Write("Введите название тренировки для добавления: ");
                                string exercisesToAdd = Console.ReadLine();
                                fitnessProgram.AddExercises(exercisesToAdd);
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine(fitnessProgram.Motivate());

                        Console.ReadLine();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте сноваю");
                        break;

                }
            }
        }
    }
}
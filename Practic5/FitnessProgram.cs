using System;
using System.Collections.Generic;

namespace Practic5
{
    class FitnessProgram
    {

        private int CaloriesBurned { get; set; }
        private int TotalExcesises { get; set; }
        private string[] motivationMessageArray = 
        {
            "Вы можете больше!",
            "Двигайтесь к своей цели!",
            "Не останавливайтесь, вы на верном пути!"
        };
        private Random randomKey = new Random();

        public string Name { get; }
        public List<string> ExercisePlan { get; set; }
        public int DailyCaloriesGoal { get; set; }

        public FitnessProgram(string name, string[] exercises)
        {
            Name = name;
            ExercisePlan = new List<string>(exercises);
        }
        
        public string ShowFithessLevelInformation()
        {
            string level;
            if (CaloriesBurned > 2000) level = "Спортсмен";
            else if (CaloriesBurned > 1000) level = "Активный";
            else level = "Новичок";

            string warningMessage = Warning() ? "Цель достигнута!" : "Цель достигнута!";
            return $"Количество тренировок: {TotalExcesises} \nУровень тренировок: {level}\n{warningMessage}";
        }

        public bool Warning()
        {
            return CaloriesBurned < DailyCaloriesGoal;
        }

        public void CompleteExercise(int calories)
        {
            if (ExercisePlan.Count > 0)
            {
                CaloriesBurned += calories;
                TotalExcesises++;
                ExercisePlan.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Нет доступных тренировок в плане!");
            }
        }

        public string Motivate()
        {
            int index = randomKey.Next(motivationMessageArray.Length);
            return motivationMessageArray[index];
        }

        public void SetExercisePlan(string[] exercises)
        {
            ExercisePlan = new List<string>(exercises);
        }

        public void AddExercises(string exercises)
        {
            ExercisePlan.Add(exercises);
        }

        public void RemoveExercises(string exercises)
        {
            ExercisePlan.Remove(exercises);
        }
    }
}

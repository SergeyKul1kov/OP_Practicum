using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите пароль для проверки: ");
            string password = Console.ReadLine();

            bool isValid = ValidatePassword(password);
            Console.WriteLine(isValid);
            Console.Read();
        }

        static bool ValidatePassword(string password)
        {
            if (password.Length < 6 || password.Length > 12)
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            string specialCharacters = @"!@#$%^&*()_+[]{}|;':"",.<>?`~";

            if (!password.Any(ch => specialCharacters.Contains(ch)))
            {
                return false;
            }

            return true;
        }
    }
}
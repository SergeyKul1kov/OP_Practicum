using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение для нахождения самого длинного слова: ");
            string sentence = Console.ReadLine();
            string longestWord = FindLongestWord(sentence);

            Console.WriteLine(longestWord);
            Console.Read();
        }

        static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longest = "";

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            return longest;
        }
    }
}

using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string phrase = Console.ReadLine();
            int counter = 0;
            char a = 'а';
            char A = 'А';
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == a || phrase[i] == A)
                {
                    counter++;
                }
            }
            Console.WriteLine("В слове " + phrase + "  " + counter + "  " + "букв А");
        }
    }
}

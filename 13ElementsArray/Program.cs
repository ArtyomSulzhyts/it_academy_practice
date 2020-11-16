using System;

namespace _13ElementsArray
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] elementsArray = new int[13];
           FillRandomNumbers(elementsArray);
           Sort(elementsArray);
           Results(elementsArray);
        }

        static void FillRandomNumbers(int[] numbersToFill)
        {
            for (int i = 0; i < numbersToFill.Length; i++)
            {
                Random rnd = new Random();
                numbersToFill[i] = rnd.Next(0,100);
            }
        }

        static void Sort(int[] numbersForSorting)
        {
            int temporaryVariable;
            for (int i = 0; i < numbersForSorting.Length - 1; i++)
            {
                for (int j = i + 1; j < numbersForSorting.Length; j++)
                {
                    if (numbersForSorting[i] > numbersForSorting[j])
                    {
                        temporaryVariable = numbersForSorting[i];
                        numbersForSorting[i] = numbersForSorting[j];
                        numbersForSorting[j] = temporaryVariable;
                    }
                }
            }
        }

        static void Results(int[] numbersForConsole)
        {
            for (int i = 0; i < numbersForConsole.Length-1; i++)
            {
                Console.WriteLine(numbersForConsole[i]);
            }

            Console.WriteLine("Максимальное значение массива - " + numbersForConsole[numbersForConsole.Length-1]);
        }
    }
}

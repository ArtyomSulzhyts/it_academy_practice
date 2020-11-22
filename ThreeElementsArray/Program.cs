using System;

namespace ThreeElementsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] variousTypesArray = new Object[] { 32, 'А', "Hello"};

            writeArray(variousTypesArray);
            
            variousTypesArray[0] = Convert.ToInt32(variousTypesArray[0]) +  10;
            variousTypesArray[2] = variousTypesArray[2] + ", guys!";

            writeArray(variousTypesArray);
        }
        static void writeArray(Object[] someArray)
        {
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.WriteLine(someArray[i]);
            }
            Console.WriteLine();
        }
    }
}

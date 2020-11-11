using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings();
        }
        static void Greetings()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            if (now.Hour > 8 && now.Hour < 13)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (now.Hour > 11 && now.Hour < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (now.Hour > 14 && now.Hour < 23)
            {
                Console.WriteLine("Good evening, guys");
            }
            else
            {
                Console.WriteLine("Good to bed, guys");
            }
        }
    }
}

using System;

namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
         short forBoxing = 8;
         object boxing = forBoxing;
         sbyte unboxing = Convert.ToSByte(boxing);

         Console.WriteLine(unboxing + "  " + unboxing.GetType());
        }
    }
}

using System;

namespace SimpleSequence
{
    class SimpleSequence
    {
        static void Main()
        {
            for (double i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}

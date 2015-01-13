using System;

namespace SimpleSequence
{
    class SimpleSequence
    {
        static void Main()
        {
            for (int i = 2; i <= 1000; i++) // Here we are intializing a "for" loop operator in order to start cycling (adding +1 to the value of "i") from the given number (2) to till the condition ("i" being smaller than 1000) is met. 
            {
                if (i % 2 == 0) // If the number is even (it can be diveded by 2). 
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

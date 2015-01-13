using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            double numberToSQRT = Math.Sqrt(12345f); // We use double since the square root of the given number (12345) will result in a fraction.
            Console.WriteLine(numberToSQRT); // The console writes the result of the mathematical solution for "numberToSQRT". 
        }
    }
}

/*
    Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result. 
 */

using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? randomInt = null;
            double? randomDouble = null;

            Console.WriteLine("The Null Integer is: {0}" + System.Environment.NewLine + "The Null Double is: {1}", randomInt, randomDouble);
            Console.WriteLine("Int + 2 = {0}", (randomInt + 2));
            Console.WriteLine("Double + 2 = {0}", (randomDouble + 2));

        }
    }
}

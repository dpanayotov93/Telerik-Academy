using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first number that you want to compare: ");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number that you want to compare: ");
            double second = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool comparison;

            if ((Math.Abs(first - second)) < eps)
            {
                comparison = true;
            }
            else
            {
                comparison = false;
            }
          
            Console.Clear();
            Console.WriteLine("The numbers are the same: {0}", comparison);
        }
    }
}

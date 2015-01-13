using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine("a={0}, b={1}", a, b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("a={0}, b={1}", a , b);
        }
    }
}

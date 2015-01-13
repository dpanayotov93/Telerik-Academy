using System;
using System.Text;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char copyright = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(" " + " " + " " + copyright);
            Console.WriteLine(" " + " " + copyright + " " + copyright);
            Console.WriteLine(" " + copyright + " " + " " + " " + copyright);
            Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
        }
    }
}

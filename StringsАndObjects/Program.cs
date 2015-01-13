using System;

namespace StringsАndObjects
{
    class StringsАndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "world";
            object bothWords = hello + " " + world;
            string typecasting = (string)bothWords;

            Console.WriteLine(typecasting);
        }
    }
}

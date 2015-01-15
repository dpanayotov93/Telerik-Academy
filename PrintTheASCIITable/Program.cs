using System;
using System.Text;

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.ASCII;
            for (int numberInTable = 0; numberInTable <= 255; numberInTable++)
            {
                char character = (char)numberInTable;
                Console.WriteLine("{0} = {1}", numberInTable, character);
            }
        }
    }
}

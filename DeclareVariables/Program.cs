using System;

namespace DeclareVariables
{
    class Program
    {
        static void Main()
        {
            byte vByte = 97;
            sbyte vSbyte = -115;
            short vShort = -10000;
            ushort vUshort = 52130;
            int VInt = 4825932;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", vByte, vSbyte, vShort, vUshort, VInt); 
        }
    }
}

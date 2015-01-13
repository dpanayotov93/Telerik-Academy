using System;

namespace AgeInTenYears
{
    class AgeInTenYears
    {
        static void Main()
        {
            int yeari;
            int monthi;
            int dayi;
            DateTime today = DateTime.Now; // DateTime is used to store a date and DateTime.Now shows the current date.

            Console.WriteLine("Please, enter the day you were born in: ");
            string day = Console.ReadLine();

            Console.WriteLine("Please, enter your birth month: ");
            string month = Console.ReadLine();

            Console.WriteLine("Please, enter your birth year: ");
            string year = Console.ReadLine();

            yeari = int.Parse(year); // The string is converted to int.
            monthi = int.Parse(month); // The string is converted to int.
            dayi = int.Parse(day); // The string is converted to int.

            DateTime date = new DateTime(yeari, monthi, dayi); // New DateTime is created holding a date with the value set from the input user data.
            var curage = today.Year - date.Year; // The operator var is used to find the difference between two values (dates in this case).
            
            Console.WriteLine("Your current age is: " + curage); // The console prints the string and the value of "curage" (Current Age).

            var ageinten = curage + 10; // 10 is added to the value of curage.
            Console.WriteLine("Your age in 10 years will be: " + ageinten);

            
        }
    }
}

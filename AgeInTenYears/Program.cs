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
            DateTime daynow = DateTime.Now;

            Console.WriteLine("Please, enter the day you were born in: ");
            string day = Console.ReadLine();

            Console.WriteLine("Please, enter your birth month: ");
            string month = Console.ReadLine();

            Console.WriteLine("Please, enter your birth year: ");
            string year = Console.ReadLine();

            yeari = int.Parse(year);
            monthi = int.Parse(month);
            dayi = int.Parse(day);

            DateTime date = new DateTime(yeari, monthi, dayi);
            DateTime today = DateTime.Now;
            var curage = today.Year - date.Year;
            
            Console.WriteLine("Your current age is: " + curage);

            var ageinten = curage + 10;
            Console.WriteLine("Your age in 10 years will be: " + ageinten);

            
        }
    }
}

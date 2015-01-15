/*

    A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
    Use descriptive names. Print the data at the console.
 */

using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {

            Console.WriteLine("Please, enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please, enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please, enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your gender (m/f): ");
            string gender = Console.ReadLine();
                             

           Console.WriteLine("Please, enter your Personal Identification Number (10 signs max) :");
           long pid = long.Parse(Console.ReadLine());

           Console.WriteLine("Please, enter your Unique Employee Number (27560000…27569999): ");
           int uen = int.Parse(Console.ReadLine());

           Console.Clear();
           Console.WriteLine("First Name: {0}", firstName);
           Console.WriteLine("Last Name: {0}", lastName);
           Console.WriteLine("Age: {0}", age);

           if (gender.Contains("m"))
           {
               gender = "Male";
               Console.WriteLine("Gender: {0}", gender);
           }
           else
           {
               if (gender.Contains("f"))
               {
                   gender = "Female";
                   Console.WriteLine("Gender: {0}", gender);
               }
               else
               {
                   Console.WriteLine("Gender: Unspecified");
               }
           }

           Console.WriteLine("Personal Identification Number: {0}", pid);
           Console.WriteLine("Unique Employee Number: {0}", uen);

        }
    }
}

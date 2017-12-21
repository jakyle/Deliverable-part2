using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRedo = true;
            bool isValid = false;
            // learned about the Date Object, very simillar in functionallity in other languages, takes arugments from years up to seconds. 
            DateTime userDateTime1 = new DateTime();
            DateTime userDateTime2 = new DateTime();
            // using two booleans to check if the user put in the correct forat for date and time and second bool to check if they put it in the correct order.
            while (isRedo)
            {
                Console.WriteLine("Enter two dates in the proper format and we will return the difference of the two dates in days, hours, mins!");
                while (!isValid)
                {
                    Console.Write("Enter a recent date (e.g. 10/22/2015): ");

                    if (DateTime.TryParse(Console.ReadLine(), out userDateTime1))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an incorrect value.");
                    }
                }
                isValid = false;
                while (!isValid)
                {
                    Console.Write("Enter a date that falls before your first date (e.g. 10/22/1987): ");

                    if (DateTime.TryParse(Console.ReadLine(), out userDateTime2))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an incorrect value.");
                    }
                }
                isValid = false;
                if ((userDateTime1 - userDateTime2).TotalDays > 0)
                {
                    isRedo = false;
                }
                else
                {
                    Console.WriteLine("Difference of Dates yielding a negative number, plese enter dates in the proper order.");
                }
            }
            Console.WriteLine("The difference Between both dates are - ");
            // I figured the simplest way to display the Days/Hours/Minutes was just to do a quick converstion and log it. 
            Console.WriteLine
                (
                    "  Days:  " + (userDateTime1 - userDateTime2).TotalDays +
                    "  Hours:  " + (userDateTime1 - userDateTime2).TotalDays * 24 +
                    "  Minutes:  " + (userDateTime1 - userDateTime2).TotalDays * 24 * 60
                );
            Console.Read();
        }
    }
}

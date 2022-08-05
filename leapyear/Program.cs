
// C# program to check
// for a leap year
using System;

internal class Program
{

    static bool checkYear(int year)
    {
        // If a year is multiple of 400,
        // then it is a leap year
        if (year % 400 == 0)
            return true;

        // Else If a year is multiple of 100,
        // then it is not a leap year
        if (year % 100 == 0)
            return false;

        // Else If a year is multiple of 4,
        // then it is a leap year
        if (year % 4 == 0)
            return true;
        return false;
    }

    // Driver method
    public static void Main()
    {
        Console.WriteLine("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        //int year = 2002;
        Console.Write(checkYear(year) ? "Leap Year" :
                                 "Not a Leap Year");
    }

}
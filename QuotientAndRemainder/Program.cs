using System;

namespace QuotientAndRemainder
{


    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter Dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

         

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}




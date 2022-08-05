//Harmonic Number Print the Nth harmonic number: 1 / 1 + 1 / 2 + ... +1 / N

using System;

namespace Harmonic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double result = 0;
            double num = 0;
            double j;
            Console.WriteLine("enter the harmonic you want to find: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (j = 1; j <= n; j++)
            {
                num = num + (1 / j);
                result = num;
            }
            Console.WriteLine("the value of harmonic no. " + n + " is: " + result);

        }
    }
}

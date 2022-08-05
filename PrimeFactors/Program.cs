using System;

namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int n;
            Console.Write("Enter a Number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("The Prime Factors of " + n + " are : ");

            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    n = n / i;
                }
                else
                    i++;
            }
            Console.WriteLine(" ");
        }
        }
    }

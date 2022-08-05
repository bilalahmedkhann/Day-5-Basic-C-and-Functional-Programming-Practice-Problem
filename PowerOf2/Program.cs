using System;

namespace PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiple = 1;
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 31)
            {
                Console.WriteLine("value of number should be less than 31");
            }
            else
            {
                Console.WriteLine(multiple);
                for(int j = 1; j <= num; j++)
                {
                    multiple = multiple * 2;
                    Console.WriteLine(multiple);
                }

            }
        }
    }
}

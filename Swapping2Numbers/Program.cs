using System;

namespace Swapping2Numbers
{
    using System;
    public class SwapExample
    {
        public static void Main(string[] args)
        {
            //int a = 5, b = 10;
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;      
            b = a / b;      
            a = a / b;    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}

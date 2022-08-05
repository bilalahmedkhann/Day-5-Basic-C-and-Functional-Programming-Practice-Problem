//Flip Coin and print percentage of Heads and Tails


using System;

namespace CoinToss
{
    internal class Program
    {
        //public const int h_cnt = 0;
        //public const int t_cnt = 0;
  
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("enter no. of times you want to flip the coin: ");
            double n =Convert.ToDouble(Console.ReadLine());
            Random rand = new Random();
            double t_cnt = 0;
            double h_cnt = 0;
            


            for (double j = 0; j < n; j++)
            {

                double x = rand.NextDouble();
                Console.WriteLine(x);
                if (x < 0.5)
                    t_cnt++;
                else
                    h_cnt++;
            }
           double heads = h_cnt / (double) n * 100;
            double tails = t_cnt / (double) n * 100;
            Console.WriteLine("Percentage of heads: " + heads + "%");
            Console.WriteLine("Percentage of tails: " + tails + "%");

        }
    }
}

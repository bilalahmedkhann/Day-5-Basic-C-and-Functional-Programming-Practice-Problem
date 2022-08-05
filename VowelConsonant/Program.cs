using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a character:");
        char input = Convert.ToChar(Console.ReadLine());

        if (input == 'a' || input == 'A' || input == 'e' || input == 'E' || input == 'i' || input == 'I' || input == 'o'
                || input == 'O' || input == 'u' || input == 'U')
        {
            Console.WriteLine("Its a vowel");
        }
        else if ((input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z'))
        {

            Console.WriteLine("Its a consonant");
        }
        else
        {
            Console.WriteLine("Invalid input please enter an alphabet");
        }
    }
}
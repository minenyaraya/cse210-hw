using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("Write your guess: ") ;
            guess = int.Parse(Console.ReadLine()) ;

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console .WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        }

    }
}
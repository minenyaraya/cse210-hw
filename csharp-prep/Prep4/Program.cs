using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Write a number (some -), and press enter after each one(0 to finish).");

        List<int> numbers = new List<int>();
        numbers.Sort();
        int userNumber = -1;
     
        while (userNumber != 0)
        
        {

            Console.Write("Write a number :");

            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);
        

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number ;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Tha average is: {average}"); 

    }

}             
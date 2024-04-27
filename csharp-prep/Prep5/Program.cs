using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PrompUserName();
        int userNumber = PrompUserNumber(); 

        int squareNumber = SqueareNumber(userNumber); 

        DisplayResult(userName, squareNumber);   


    }
    static void DisplayWelcomeMessage() 
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PrompUserName() 
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine(); 

        return name;
    }

    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SqueareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string Name, int square)
    {
        Console.WriteLine($"{Name}, the square of your number is {square}");
    }

}
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nPlease enter to delete some word to memorize or type 'quit' to exit.");
        Scripture scripture = new Scripture("Ruth ", 1, 16, " And Ruth said, Entreat me not to leave thee, or to return from following after thee: for whither thou goest, I will go; and where thou lodgest, I will lodge: thy people shall be my people, and thy God my God");
        scripture.Display(); 
            
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
            Console.WriteLine("\nYou win!!");
                break;
            }
            scripture.Display();      
        }
    }
}

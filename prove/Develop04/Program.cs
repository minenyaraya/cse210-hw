using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        bool Quit = false;
        while(Quit == false)
         do
         { 
            Console.Write(" Select a Choice from de Menu: ");
            Console.WriteLine("Menu Option: Choose one activity  ");
            Console.WriteLine(" 1. Start Breathing Activity: ");
            Console.WriteLine(" 2. Star Reflecting activity: ");
            Console.WriteLine(" 3. Star Listing activity: ");
            Console.WriteLine(" 4. Quit! ");
           
            choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.DisplayEndingMessage();    
                    //breathingActivity.ShowSpinner(5);
                    //breathingActivity.ShowCountDown(5);

                } 
                else if (choice == "2") 
                {
                    Console.WriteLine(ListingActivity.MenuMessage);
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayPromptsGenerator();
                } 
                else if (choice == "3") 
                {
                    Console.WriteLine(ReflectingActivity.MenuMessage);
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.DisplayPromptsGenerator();
                    break;
                } 
                else if (choice == "4")
                {
                    Console.WriteLine(" You Quit! ");
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Try Again");
                }

        }
        while (choice != "4 ");
       
    Console.Write("Press any key to close the Calculator console app...");
    Console.ReadKey();
      
    }
}
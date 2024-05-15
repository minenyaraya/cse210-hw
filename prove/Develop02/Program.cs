using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class Program
{
    // public List<string> choose=>new List<string>();
    public static PromptGenerator promptGenerator;
    public static Journal journal;
    static void Main(string[] args)
    {
        promptGenerator = new PromptGenerator();
        journal = new Journal();

        Console.WriteLine("How was your day today?: ");
        string day = Console.ReadLine();
        
        int input = 0;
        int running = 0;


        while (running == 0)
        {
            Console.WriteLine("Hello Mineny, welcome to Journal ");
            
            

            Console.WriteLine(" Please choose What do you like to do :");
            Console.WriteLine(" 1 - Write : ");
            Console.WriteLine(" 2 - Display :");
            Console.WriteLine(" 3 - Load :");
            Console.WriteLine(" 4 - Save :");
            Console.WriteLine(" 5 - Quit :");
            input = Convert.ToInt32(Console.ReadLine());
            
            if(input == 1)
            {
                Write();
            }
            else if (input == 2)
            {
                Display();
            }
            else if (input == 3)
            {
                Load();
            }
            else if (input == 4){
                Console.WriteLine("Saving in Journal.txt");
                Save();
            }
            else if (input == 5){
                Console.WriteLine ($"Your day today was {day}"); 
                running = 1;
            }
        }
             
    }
    public static void Write()
    {
        
        Console.WriteLine("Please write: ");
        string prompt = promptGenerator.DisplayPrompt();
        Console.WriteLine(prompt);
        string text = Console.ReadLine();
       

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        journal.AddEntry(prompt, text, dateText);
    }
    public static void Display()
    {
        Console.WriteLine("Display all: ");

        journal.DisplayingEntries();
    }
    public static void Load() 
    {
        Console.WriteLine("From Journal.txt");
        journal.LoadFromFile();
    }

    public static void Save() {
        journal.SaveToFile();

    }


}
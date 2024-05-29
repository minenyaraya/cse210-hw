using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //string filename ="myFile.txt";
        //string[] lines = System.IO.File.ReadAllLines(filename);
        

        //foreach ( string line in lines)
        //{
           // string[] parts = line.Split("|");
           // string goalName = parts[0];
           //string shortName=parts[1];
            //string goalDescription = parts[2];
            //int Bonus=int.Parse(parts[4]);
            //int howMany=int.Parse(parts[5]);
        //}
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;


        Console.WriteLine("Goals!");
        Console.WriteLine();

        while (userMainMenuSelection != 6)
        {
            GoalManager goalManager = new GoalManager();
            allGoals.DisplayPoints(allGoals.getTotalPoints());
            Console.WriteLine();
            goalManager.DisplayMainMenu();
            userMainMenuSelection = int.Parse(Console.ReadLine());
           

            switch (userMainMenuSelection)
            {
                case 1:
                    goalManager.DisplayNewGoalMenu();
                    int userNewGoalSelection = int.Parse(Console.ReadLine());
                    Goal goal = null;
                    if (userNewGoalSelection == 1)
                    {
                        goal = new SimpleGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else if (userNewGoalSelection == 2)
                    {
                        goal = new EternalGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else
                    {
                        goal = new CheckListGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }
                    break;

                case 2:
                    allGoals.DisplayGoals();
                    break;

                case 3:
                    allGoals.SaveGoals();
                    break;

                case 4:
                    allGoals.LoadGoals();
                    break;

                case 5:
                    allGoals.DisplayGoalRecordEvent();
                    break;

                case 6:
                    Console.Write("Save before you quit (y/n)? ");
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        allGoals.SaveGoals();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Goodbye! ");
                    break;

                default:
                    Console.WriteLine("Select a valid option.");
                    break;

            }
        }
    }
}

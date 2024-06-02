using System;

class Program
{
    static void Main(string[] args)
    {
         List<Exercise> exerciseList = new List<Exercise>();

        Running running = new Running("05/04/2024", 90, 3.0);
        exerciseList.Add(running);

        Biking stationaryBicycles = new Biking("05/08/2024", 60, 15);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("05/12/2024", 20, 50);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
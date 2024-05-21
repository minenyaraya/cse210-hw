using System;
using System.Collections.Generic;
using System.IO;

public class PromptsGenerator : Activity
{
    Random rd = new Random();
    public List<string> __promptsGenerator= new List<string>()
    {
        "What thought did you remember today?",
        "Did you remember anything from the past today?",
        "Any new anecdote?",
        "What people made your day today?",
        "Want to write something you want to remember?",
        "Have you learned something new today?",
        "How do you feel?",
        "Has there been any change that you want to record?",
        "Do you want to write a goal?",
    };
    public string DisplayPromptsGenerator()
    {
        int rand_num = rd.Next(__promptsGenerator.Count);
        return __promptsGenerator[rand_num];
        // string new_input = Console.ReadLine();
        // Console.WriteLine(new_input);

    }

}
using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    Random rd = new Random();
    public List<string> __prompts= new List<string>()
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
    public string DisplayPrompt()
    {
        int rand_num = rd.Next(__prompts.Count);
        return __prompts[rand_num];
        // string new_input = Console.ReadLine();
        // Console.WriteLine(new_input);

    }

}
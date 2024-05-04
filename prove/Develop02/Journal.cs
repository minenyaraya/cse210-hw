using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Journal
{
    // Journal journaltoday = new Journal();
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string text, string date)
    {
        Entry newEntry = new Entry(prompt, text, date);
        _entries.Add(newEntry);
    }
    public void DisplayingEntries()
    {
        foreach(Entry entry in _entries) {
            entry.DisplayEntry();
            Console.WriteLine("-------------");
        }
    }
    public void SaveToFile()
    {
        string fileName = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._text}");
            }
        }
    }
    
    public void LoadFromFile()
    {
        _entries.Clear();
        string filename = "Journal.txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
           

            AddEntry(prompt, text, date);
        }
    }


}
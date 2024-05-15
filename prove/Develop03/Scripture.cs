using System.Diagnostics;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, List<Word> words)
    {
        this.reference = reference;
        this.words = words;
    }
    public Reference Reference
    {
        get{
        return reference;
        }
    }    
     public bool IsCompletelyHidden()
     {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
     }
     public void HideWords(int count)
     {
        Random random=new Random();
        for (int i=0; i < count; i = + +1)
        {
            int index = random.Next(0, words.Count);
            while (words[index].IsHidden == true)
            {
                index = random.Next(0, words.Count);
            }
            words[index].IsHidden = true;
        }
     }
     public int CountWords()
     {
        int allWords = 0;
        foreach (Word words in words)
        {
            if (words.IsHidden)
            {
                allWords += 0;
            }
            else
            {
                allWords += 1;
            }
        }
        return allWords;
     }
     public void Display()
     {
        Console.WriteLine(reference);
        foreach (Word word in words)
        {
            string wordText = word.Text;
            if (word.IsHidden)
            {
                for (int i=0; i < wordText.Length; i++)
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
     }
}
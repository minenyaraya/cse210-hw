public class ListingActivity : Activity{

    public ListingActivity()
    {
        _name = "ListingActivity";
        _description = "Listening to positive words";
    }
    private string _promptsGenerator;
    public static string MenuMessage = "Listening to positive words.";
    
        public string GetPromptsGenerator()
    {
        return _promptsGenerator;
    }
    public void SetPromptsGenerator(string promptsGenerator)
    {
        _promptsGenerator = promptsGenerator;
    }
    public void DisplayPromptsGenerator()
    {
        var random = new Random();
        Console.WriteLine();

        Console.WriteLine("Welcome To The Activities");
        Console.WriteLine("Listing : With the prompt you read, make a list of uplifting words that come to mind. Please press enter");
        string promptsGenerator = GetPromptsGenerator();
        promptsGenerator = Console.ReadLine();
        
        Console.WriteLine("Time to write positive words: ");
        CountWords();

        animation();

        Console.WriteLine("Yay! You done. ");
    }
    public void CountWords()
    {
        Console.Write("*-*");
        string words = Console.ReadLine();
        int count = AddWords(words);
        DisplayWords(count);
    }
    public void DisplayWords(int count)
    {
        Console.WriteLine($" You wrote {count} words, now is time to Listing that list! ");
        Thread.Sleep(1000);
    }
    public int AddWords(string words) {
        string[] wordArray = words.Split(" ");
        return wordArray.Length;
    }
     public void animation() 
    {
        ///>\*|*/<
        List<string> animationStrings = new List<string>();
        animationStrings.Add(" >");
        animationStrings.Add("\\");
        animationStrings.Add("*_*");
        animationStrings.Add("|");
        animationStrings.Add("*_-");
        animationStrings.Add("/");
        animationStrings.Add(">");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\n ");
        }
    }
        
}
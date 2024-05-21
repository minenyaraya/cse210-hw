public class ReflectingActivity : Activity
{
    public static string MenuMessage = "Reflecting on what we read helps us keep a mind free of negative thoughts.";
    private string _promptsGenerator;
    private string _reflectingActivity;

     public ReflectingActivity()
    {
        _name = "ReflectingActivity";
        _description = "Reflecting";
    }
    public string GetPromptsGenerator()
    {
        return  _promptsGenerator;
    }
    public string GetReflecting()
    {
        return _reflectingActivity;
    }
    public void SetReflecting(string reflecting)
    {
        _reflectingActivity = reflecting;
    }
    public void DisplayPromptsGenerator()
    {
        Console.WriteLine("Welcome To The Activities");

        Console.WriteLine("Reflecting on what we read helps us keep a mind free of negative thoughts. Read each of the sentences, take a deep breath when you finish the sentence and apply it to your day.");
        string PromptsGenerator = GetPromptsGenerator();
        Console.WriteLine("{promptsGenerator}");
            
        animation();
        animation();
        Console.WriteLine(" Now your are ready to write something nice. ");
        string words = Console.ReadLine();
        
        Console.WriteLine("Yay! You done. ");
    }
         
    public void DisplayReflecting()
    {
        string reflecting = GetPromptsGenerator();
        Console.WriteLine($"\n    {reflecting}   ");
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
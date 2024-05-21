public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description ="Breathing Activity, Breathing helps us relax the mind and body.";
    }
    
       public void Run()
    {   
        Console.Write("\n ");
        Console.WriteLine("Welcome To The Activities");
        Console.WriteLine("Slowly inhale and exhale in this time: ");
        animation();
        Console.Write("\n ");

        Console.WriteLine(" Now  ... > inhale");
        Console.Write("\n ");
        Thread.Sleep(1000);
        animation();
       
        
        Console.WriteLine("Now ... > exhale ");
        Console.Write("\n ");
        animation();
        

        Console.WriteLine("Yay! You done. ");
        Thread.Sleep(1000);
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
        
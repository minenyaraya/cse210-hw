

public class Activity
{
   protected string _name;
   protected string _description;
   protected int _duration;
   public Activity()
   {
        //comenzar con _name, _description, _duracion
        _name = "";
        _description = "";
        _duration = 5;
   }
   public string GetName()
   {
    return _name;
   }
   public void SetName(string name)
   {
        _name = name;
   }

   public string GetDescription()
   {
    return _description;
   }
   public void SetDescription(string description)
   {
        _description = description;
   }
   public int GetDuration()
   {
        return _duration;
   }
   public void SetDuration(int duration)
   {
        _duration = duration;
   }
   
    public void DisplayStartingMessage()
    {
        //Console.Clear();
        Console.WriteLine($"Welcome to the {_name}, {_description}");
        
        ShowSpinner(5);  
       

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
       // Console.Clear();

    }
    public void ShowSpinner(int seconds)
    {
        //ver video
    Console.WriteLine("Timer");
    Thread.Sleep(500);
    Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = 1; i<= seconds; i ++){
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Count Down");
    }
    

}
public class GoalManager
{
    private List<string> _mainGoalManager;
    private List<string> _createGoalManager;

    public GoalManager()
    {
        _mainGoalManager = new List<string>
        {
            "Menu Options:",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };

        _createGoalManager = new List<string>
        {
            "The types of Goals are:",
            "  1. Simple Goal",
            "  2. Eternal Goal",
            "  3. CheckList Goal"
        };
    }

    public void DisplayMainMenu()
    {
        foreach (string GoalManagerItem in _mainGoalManager)
        {
            Console.WriteLine(GoalManagerItem);
        }

        Console.Write("Select a choice: ");
       
    }

    public void DisplayNewGoalMenu()
    {
        foreach (string goalManagerItem in _createGoalManager)
        {
            Console.WriteLine(goalManagerItem);
        }
        Console.Write("Select a choice from the menu: ");
    }

}
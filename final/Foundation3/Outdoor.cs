public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GenerateWeatherStatement()
    {
        return "Our Weather " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "Outdoor";
    }
    public string GenerateDetailedOutdoor()
    {
        string detailed = "";
        string weatherStatement = GenerateWeatherStatement();
        
        detailed += GenerateStandard() + "\n";
        detailed += "The Weather: " + weatherStatement;
        return detailed;
    }
    public string GenerateShortOutdoor()
    {
        string shortOut = "";
        string eventType = ReturnEventType();

        shortOut +=  eventType + "\n";
        shortOut += GenerateShort();
        return shortOut;
    }
}
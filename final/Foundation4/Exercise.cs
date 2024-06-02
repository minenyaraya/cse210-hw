using System;

public class Exercise
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public string GetSummary()
    {
        string summary = $"{_date} {_name} ({_minutes} min)- Distance {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace().ToString("#.##")} min per miles";
        return summary;
    }
}
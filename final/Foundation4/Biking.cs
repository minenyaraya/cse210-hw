using System;

public class Biking : Exercise
{
    private double _speed;

    public Biking(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Biking";
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = _speed * _minutes / 60;
        return distance;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}
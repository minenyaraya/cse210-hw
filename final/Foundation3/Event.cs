public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandard()
    {
        string standard =   _title + "\n";
        standard +=  _description + "\n";
        standard += _date + " | " + _time + "\n";

        string address = _address.GenerateAddress();
        standard += address;
        return standard;
    }

    public string GenerateShort()
    {
        string shortM =   _title + "\n";

        shortM += _date + "\n";
        return shortM;
    }
}
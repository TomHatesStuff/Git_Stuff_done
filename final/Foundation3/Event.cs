class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetDescription()
    {
        return description;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public TimeSpan GetTime()
    {
        return time;
    }

    public Address GetAddress()
    {
        return address;
    }

    private string GetAddressString()
    {
        return $"{address.Street}, {address.City}, {address.State} {address.ZipCode}";
    }
}
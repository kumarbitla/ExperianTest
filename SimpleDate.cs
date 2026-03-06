// See https://aka.ms/new-console-template for more information
public class SimpleDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public SimpleDate(int day, int month, int year)
    {
        if(day < 1 || day > 31)
            throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31.");
        if(month < 1 || month > 12)
            throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
        if(year < 1)
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be a positive integer.");
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}
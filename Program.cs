// See https://aka.ms/new-console-template for more information
using DateApp;

try
{
    Console.WriteLine("Enter date in dd/mm/yyyy format");
    string input = Console.ReadLine();
    Console.WriteLine("Enter nuber of days to add");
    int days = int.Parse(Console.ReadLine());

    SimpleDate dateObj = DateParser.Parse(input);
    DateCalculator calculator = new DateCalculator(new GregorianDaysStrategy());
    SimpleDate newDate = calculator.AddDays(dateObj, days);
    Console.WriteLine($"New date after adding {days} days: {newDate}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Input error: {ex.Message}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Date error: {ex.Message}");
}
Console.ReadLine();

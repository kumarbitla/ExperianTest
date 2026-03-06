// See https://aka.ms/new-console-template for more information
using DateApp;
using Microsoft.Extensions.DependencyInjection;

try
{
    Console.WriteLine("Enter date in dd/mm/yyyy format");
    string input = Console.ReadLine();
    Console.WriteLine("Enter nuber of days to add");
    int days = int.Parse(Console.ReadLine());
    DateCalculatorService service= new DateCalculatorService();
    string newDate = service.AddDays(input, days);

    Console.WriteLine($"New date after adding {days} days: {newDate}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Input error: {ex.Message} : Allowed only numbers.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Date error: {ex.Message}");
}
Console.ReadLine();

// See https://aka.ms/new-console-template for more information
public class DateParser
{
    public static SimpleDate Parse(string? input)
    {
        try
        {
            if (input?.Length > 0)
            {
                int day = (input[0] - '0') * 10 + (input[1] - '0');
                int month = (input[3] - '0') * 10 + (input[4] - '0');

                int year = (input[6] - '0') * 1000 + (input[7] - '0') * 100 + (input[8] - '0') * 10 + (input[9] - '0');
                return new SimpleDate(day, month, year);
            }
            else
                throw new FormatException("Input string was not in the correct format. Expected format: dd/mm/yyyy");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing date: {ex.Message}");
            throw new FormatException("Input string was not in the correct format. Expected format: dd/mm/yyyy", ex);
        }
    }
}
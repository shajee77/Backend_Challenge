using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz;

public class Program
{
    private static void Main(string[] args)
    {
        const int minVal = 1;
        const int maxVal = 100;

        var lstKeyVal = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(3, "Fizz"),
            new KeyValuePair<int, string>(5, "Buzz")
        };

        try
        {
            // add required dependencies
            var builder = new ServiceCollection()
                .AddSingleton<FizzBuzzHelper>()
                .BuildServiceProvider();

            var helperService = builder.GetRequiredService<FizzBuzzHelper>();

            for (int i = minVal; i <= maxVal; i++)
            {
                string fbValue = helperService.GetFizzBuzzValue(lstKeyVal, i);
                   
                if (!string.IsNullOrEmpty(fbValue))
                {
                    Console.WriteLine(fbValue);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch (Exception ex)
        {
            // log any exception in here
            throw;
        }
    }
}
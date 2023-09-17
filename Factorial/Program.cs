using Microsoft.Extensions.DependencyInjection;

namespace Factorial;

public class Program
{
    const string PromptQuestion = "Please enter a number to find the factorial or press 'Q' to quit: ";

    private static void Main(string[] args)
    {
        try
        {
            // add required dependencies
            var builder = new ServiceCollection()
                .AddSingleton<IFactorialHelper, FactorialHelper>()
                .BuildServiceProvider();

            var helperService = builder.GetRequiredService<IFactorialHelper>();

            Console.WriteLine();
            helperService.PrintMessage(PromptQuestion);

            string input = Console.ReadLine()!;

            while (true)
            {
                if (input == "q" || input == "Q")
                {
                    break;
                }

                if (helperService.IsNumber(input))
                {
                    var userVal = int.Parse(input);

                    if (helperService.IsInputNegative(userVal))
                    {
                        helperService.PrintMessage("Negative number is not accepted. Please enter a positive number");
                        input = Console.ReadLine()!;
                    }
                    else
                    {
                        var result = helperService.GetFactorial(userVal);

                        helperService.PrintMessage($"Result: {userVal}! = {result} ", true);
                    }
                }
                else
                {
                    helperService.PrintMessage($"'{input}' is not a valid number.");
                }

                helperService.PrintMessage(PromptQuestion);
                input = Console.ReadLine()!;
            }
        }
        catch (Exception ex)
        {
            // log any exception in here
            throw;
        }
    }
}
namespace Factorial;

public class FactorialHelper : IFactorialHelper
{
    public int GetFactorial(int userVal)
    {
        int num = 1;
        for (int i = userVal; i > 0; i--)
        {
            num *= i;
        }

        return num;
    }

    public bool IsInputNegative(int val)
    {
        return val < 0;
    }

    public bool IsNumber(string input)
    {
        return int.TryParse(input, out int defaultValue);
    }

    public void PrintMessage(string message, bool addEmptyLine)
    {
        Console.WriteLine(message);

        if (addEmptyLine)
        {
            Console.WriteLine();
        }
    }
}
namespace Factorial;

public interface IFactorialHelper
{
    bool IsNumber(string input);
    bool IsInputNegative(int val);
    int GetFactorial(int userVal);
    void PrintMessage(string message, bool addEmptyLine = false);
}

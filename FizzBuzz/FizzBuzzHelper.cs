namespace FizzBuzz;

public class FizzBuzzHelper
{
    public bool IsDivisible(int i, int val)
    {
        return i % val == 0;
    }

    public bool IsDivisibleByTwoNumbers(int i)
    {
        return i % 3 == 0 && i % 5 == 0;
    }

    public string GetFizzBuzzValue(IEnumerable<KeyValuePair<int, string>> lstKeyVal, int i)
    {
        string resultVal = string.Empty;

        if (IsDivisibleByTwoNumbers(i))
        {
            resultVal = "FizzBuzz";
        }
        else
        {
            foreach (var item in lstKeyVal)
            {
                var divisible = IsDivisible(i, item.Key);
                if (divisible)
                {
                    resultVal = item.Value;
                    break;
                }
            }
        }

        return resultVal;
    }
}

using FizzBuzz;

namespace Backend_Challenge_Test.FizzBuzz;

public class FizzBuzzTests
{
    private readonly FizzBuzzHelper _helper = new();

    [Fact]
    public void IsDivisibleBy_3_Returns_true()
    {
        var res = _helper.IsDivisible(3, 3);
        Assert.True(res);
    }

    [Fact]
    public void IsDivisibleBy_4_Returns_false()
    {
        var res = _helper.IsDivisible(4, 3);
        Assert.False(res);
    }

    [Fact]
    public void GetFizzOrBuzzValue_Returns_Fizz()
    {
        var lst = new List<KeyValuePair<int, string>>() 
        {
            new KeyValuePair<int, string>(3, "Fizz"),
            new KeyValuePair<int, string>(5, "Buzz")
        };

        var res = _helper.GetFizzBuzzValue(lst, 3);
        Assert.Equal("Fizz", res);
    }

    [Fact]
    public void GetFizzOrBuzzValue_Returns_Buzz()
    {
        var lst = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(3, "Fizz"),
            new KeyValuePair<int, string>(5, "Buzz")
        };

        var res = _helper.GetFizzBuzzValue(lst, 5);
        Assert.Equal("Buzz", res);
    }

    [Fact]
    public void GetFizzOrBuzzValue_Returns_FizzBuzz()
    {
        var lst = new List<KeyValuePair<int, string>>();

        var res = _helper.GetFizzBuzzValue(lst, 15);
        Assert.Equal("FizzBuzz", res);
    }
}

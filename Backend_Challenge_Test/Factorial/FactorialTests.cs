namespace Backend_Challenge_Test.Factorial;

public class FactorialTests
{
    private readonly FactorialHelper _helper = new();

    [Theory]
    [InlineData("2")]
    [InlineData("45")]
    [InlineData("01")]
    public void IsNumber_Should_Return_True(string input)
    {
        var res = _helper.IsNumber(input);
        Assert.True(res);
    }

    [Theory]
    [InlineData("Two")]
    [InlineData("FortyFive")]
    [InlineData("$")]
    [InlineData("+")]
    [InlineData(null)]
    [InlineData("")]
    public void IsNumber_Should_Return_False(string input)
    {
        var res = _helper.IsNumber(input);
        Assert.False(res);
    }

    [Theory]
    [InlineData(-2)]
    [InlineData(-45)]
    [InlineData(-01)]
    public void IsInputNegative_Should_Return_True(int val)
    {
        var res = _helper.IsInputNegative(val);
        Assert.True(res);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(45)]
    [InlineData(01)]
    public void IsInputNegative_Should_Return_False(int val)
    {
        var res = _helper.IsInputNegative(val);
        Assert.False(res);
    }

    [Fact]
    public void GetFactorial_Should_Return_24()
    {
        var res = _helper.GetFactorial(4);
        Assert.Equal(24, res);
    }


    [Theory]
    [InlineData(0, 1)]
    [InlineData(3, 6)]
    [InlineData(6, 720)]
    public void GetFactorial_Should_Return_ExpectedValue(int userval, int expectedVal)
    {
        var resultVal = _helper.GetFactorial(userval);
        Assert.Equal(expectedVal, resultVal);
    }
}
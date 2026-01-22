namespace FactorialLibrary.Tests;

using FactorialLibrary;

public class FactorialServiceTests
{
    [Fact]
    public void Test1()
    {
        var result1 = FactorialService.Factorial(0);
        Assert.Equal(1, result1);

        var result2 = FactorialService.Factorial(1);
        Assert.Equal(1, result2);
    }
}

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

        var result3 = FactorialService.Factorial(10);
        Assert.Equal(3628800, result3);

        var result4 = FactorialService.Factorial(7);
        Assert.Equal(5040, result4);
        
        // Assert.Throws<InvalidOperationException>(() => (
        //     var result5 = FactorialService.Factorial(-1);
        // ));
    }
}

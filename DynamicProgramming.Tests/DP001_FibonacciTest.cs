namespace DynamicProgramming.Tests;

public class DP001_FibonacciTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(7, 13)]
    [InlineData(8, 21)]
    [InlineData(9, 34)]
    [InlineData(10, 55)]
    [InlineData(11, 89)]
    [InlineData(12, 144)]
    [InlineData(13, 233)]
    [InlineData(14, 377)]
    [InlineData(15, 610)]
    [InlineData(16, 987)]
    [InlineData(17, 1597)]
    public void Test(int i, int sum)
    {
        var fibonacci = new DP001_Fibonacci();

        // Act
        var result = fibonacci.Fibonacci(i);

        // Assert
        Assert.Equal(sum, result);

    }
}
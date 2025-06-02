namespace DynamicProgramming.Tests;

public class DP002_ClimbingStairsTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(6, 13)]
    [InlineData(7, 21)]
    [InlineData(8, 34)]
    public void Test(int i, int sum)
    {
        var climbingStairs = new DP002_ClimbingStairs();

        // Act
        var stairs = climbingStairs.ClimbStairs(i);

        // Assert
        Assert.Equal(sum, stairs);

    }
}
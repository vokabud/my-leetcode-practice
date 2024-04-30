namespace TopInterviewQuestions.Tests;

public class L002_BestTimeToBuyAndSellStockIITest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums = new int[] { 7, 1, 5, 3, 6, 4 };

        // Act
        var result = new L002_BestTimeToBuyAndSellStockII()
            .MaxProfit(nums);

        // Assert
        Assert.Equal(7, result);
    }
}

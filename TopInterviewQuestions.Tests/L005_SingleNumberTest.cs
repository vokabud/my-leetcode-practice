namespace TopInterviewQuestions.Tests;

public class L005_SingleNumberTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums = new int[] { 4, 1, 2, 1, 2 };

        // Act
        var result = new L005_SingleNumber()
            .SingleNumber(nums);

        // Assert
        Assert.Equal(4, result);
    }
}

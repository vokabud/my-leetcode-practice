namespace TopInterviewQuestions.Tests;

public class L004_ContainsDuplicateTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        // Act
        var result = new L004_ContainsDuplicate()
            .ContainsDuplicate(nums);

        // Assert
        Assert.True(result);
    }
}

namespace TopInterviewQuestions.Tests;

public class L003_RotateArrayTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        var k = 3;

        // Act
        var result = new L003_RotateArray()
            .Rotate(nums, k);

        // Assert
        Assert.Equal("5 6 7 1 2 3 4", string.Join(" ", result));
    }
}

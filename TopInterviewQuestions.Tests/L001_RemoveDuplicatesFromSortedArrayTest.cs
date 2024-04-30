namespace TopInterviewQuestions.Tests;

public class L001_RemoveDuplicatesFromSortedArrayTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Act
        var result = new L001_RemoveDuplicatesFromSortedArray()
            .RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result);
    }
}
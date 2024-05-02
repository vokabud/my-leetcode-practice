namespace TopInterviewQuestions.Tests;

public class L006_IntersectionOfTwoArraysIITest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums1 = new int[] { 4, 1, 2, 1, 2 };
        var nums2 = new int[] { 4, 1, 2, 1, 2 };

        // Act
        var result = new L006_IntersectionOfTwoArraysII()
            .Intersect(nums1, nums2);

        // Assert
        
    }
}

namespace MyInterviewQuestions.Tests;

public class RotateArrayTest
{
    [Fact]
    public void Rotate_1_1()
    {
        // Arrange
        var nums = new int[,] { { 1} };

        // Act
        var result = new RotateArray()
            .Rotate(nums);

        // Assert
        Assert.Equal(new int[,] { { 1 } }, result);
    }

    [Fact]
    public void Rotate_2_2()
    {
        // Arrange
        var nums = new int[,]
        { 
            { 1, 2 },
            { 3, 4 }
        };

        // Act
        var result = new RotateArray()
            .Rotate(nums);

        // Assert
        Assert.Equal(new int[,] { { 3, 1 }, { 4, 2 } } , result);
    }

    [Fact]
    public void Rotate_3_3()
    {
        // Arrange
        var nums = new int[,] 
        { 
            { 1, 2, 3 }, 
            { 4, 5, 6 }, 
            { 7, 8, 9 }
        };

        // Act
        var result = new RotateArray()
            .Rotate(nums);

        // Assert
        Assert.Equal(new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }, result);
    }

    [Fact]
    public void Rotate_4_4()
    {
        // Arrange
        var nums = new int[,] 
        { 
            { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        // Act
        var result = new RotateArray()
            .Rotate(nums);

        // Assert
        Assert.Equal(new int[,] { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } }, result);
    }
}

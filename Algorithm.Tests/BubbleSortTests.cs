namespace CopilotCsharp.Algorithm.Tests;

public class BubbleSortTests
{
    [Fact]
    public void BubbleSort_SortsArrayInAscendingOrder()
    {
        // Arrange
        int[] array = { 5, 2, 8, 3, 1, 6 };
        int[] expected = { 1, 2, 3, 5, 6, 8 };

        // Act
        Sort.BubbleSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void BubbleSort_SortsArrayWithDuplicateValues()
    {
        // Arrange
        int[] array = { 5, 2, 8, 3, 1, 6, 2 };
        int[] expected = { 1, 2, 2, 3, 5, 6, 8 };

        // Act
        Sort.BubbleSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void BubbleSort_SortsArrayWithNegativeValues()
    {
        // Arrange
        int[] array = { -5, 2, -8, 3, 1, 6 };
        int[] expected = { -8, -5, 1, 2, 3, 6 };

        // Act
        Sort.BubbleSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void BubbleSort_SortsArrayWithOneElement()
    {
        // Arrange
        int[] array = { 5 };
        int[] expected = { 5 };

        // Act
        Sort.BubbleSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void BubbleSort_SortsArrayWithZeroElements()
    {
        // Arrange
        int[] array = { };
        int[] expected = { };

        // Act
        Sort.BubbleSort(array);

        // Assert
        Assert.Equal(expected, array);
    }
}
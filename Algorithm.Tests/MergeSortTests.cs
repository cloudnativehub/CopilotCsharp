// generate xunit test cases for selected code
// could you add more test cases
// could you generate a few of xunit test cases for function MergeSort, the test case function name should start with MergeSort, then use _ to concat test case, for example, if the test case is empty array, then the function name is MergeSort_EmptyArray

using Xunit;

namespace CopilotCsharp.Algorithm.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void MergeSort_SortsCorrectly()
        {
            // Arrange
            int[] array = new int[] { 5, 3, 1, 2, 6, 4 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };

            // Act
            Algorithm.Sort.MergeSort(array);

            // Assert
            Assert.True(array.SequenceEqual(expected));
        }

        [Fact]
        public void MergeSort_SortsCorrectly_SingleElement()
        {
            // Arrange
            int[] array = new int[] { 1 };
            int[] expected = new int[] { 1 };

            // Act
            Algorithm.Sort.MergeSort(array);

            // Assert
            Assert.True(array.SequenceEqual(expected));
        }

        [Fact]
        public void MergeSort_SortsCorrectly_EmptyArray()
        {
            // Arrange
            int[] array = new int[] { };
            int[] expected = new int[] { };

            // Act
            Algorithm.Sort.MergeSort(array);

            // Assert
            Assert.True(array.SequenceEqual(expected));
        }

        [Fact]
        public void MergeSort_SortsCorrectly_NegativeNumbers()
        {
            // Arrange
            int[] array = new int[] { -5, -1, -3, -2, -4 };
            int[] expected = new int[] { -5, -4, -3, -2, -1 };

            // Act
            Algorithm.Sort.MergeSort(array);

            // Assert
            Assert.True(array.SequenceEqual(expected));
        }
    }
}
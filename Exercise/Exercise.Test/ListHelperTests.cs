using System.Linq;
using Xunit;
using FluentAssertions;

namespace Exercise.Test;

public class ListHelperTests
{
    [Theory]
    [InlineData(new [] { 1, 2, 3 }, new [] { 1, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 3, 5 })]
    [InlineData(new [] { 1, 1, 3, 4 }, new [] { 1, 1, 3 })]
    public void FilterOddNumber_ShouldRemoveOddNumbersFromList(int[] input, int[] expected)
    {
        // Arrange
        
        // Act
        var actual = ListHelper.FilterOddNumber(input.ToList());
        
        // Assert
        actual.ToArray().Should().Equal(expected);
    }
}
using Xunit;

namespace Exercise.Test;

public class StringHelperTests
{
    [Theory]
    [InlineData("ala ma kota", "kota ma ala")]
    [InlineData("to jest test", "test jest to")]
    public void ReverseWords_ShouldReverseOrderOfWords(string input, string expected)
    {
        // Arrange

        // Act
        var actual = StringHelper.ReverseWords(input);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("ala", true)]
    [InlineData("ola", false)]
    [InlineData("Ala", false)]
    [InlineData("HannaH", true)]
    public void IsPalindrome_ShouldReturnTrue_WhenStringIsPalindrome(string input, bool expected)
    {
        // Arrange

        // Act
        var actual = StringHelper.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
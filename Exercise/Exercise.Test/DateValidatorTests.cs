using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Exercise.Test;

public class DateValidatorTests
{
    public static readonly List<DateRange> Booked = new()
    {
        new DateRange(new DateOnly(2019, 1, 1), new DateOnly(2019, 1, 2)),
        new DateRange(new DateOnly(2019, 2, 1), new DateOnly(2019, 2, 2)),
        new DateRange(new DateOnly(2001, 1, 1), new DateOnly(2002, 1, 1)),
    };
    
    public static IEnumerable<object[]> Inputs => new List<object[]>
    {
        new object[] {new DateRange(new DateOnly(2019, 1, 3), new DateOnly(2019, 2, 10)), true},
        new object[] {new DateRange(new DateOnly(2019, 3, 1), new DateOnly(2019, 4, 2)), false},
        new object[] {new DateRange(new DateOnly(2001, 2, 1), new DateOnly(2001, 3, 1)), true},
        new object[] {new DateRange(new DateOnly(2000, 1, 1), new DateOnly(2003, 1, 1)), true},
    };

    [Theory]
    [MemberData(nameof(Inputs))]
    public void ValidateOverlapping_ShouldReturnTrue_WhenDatesAreOverlapping(DateRange input, bool expected)
    {
        // Arrange
        
        // Act
        var result = Validator.ValidateOverlapping(Booked, input);

        // Assert
        result.Should().Be(expected);
    }
}
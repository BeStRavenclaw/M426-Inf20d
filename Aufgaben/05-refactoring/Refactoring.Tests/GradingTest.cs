using System;
using Xunit;

namespace Refactoring.Tests;

public class GradingTest 
{
    [Theory]

    [InlineData(1, 'A')]
    [InlineData(2, 'B')]
    [InlineData(3, 'C')]
    [InlineData(4, 'D')]
    [InlineData(5, 'E')]
    [InlineData(6, 'F')]

    public void GetLetterGrade_GradeFrom6To1_ReturnsFToA(int numGrade, char charGrade)
    {
        // Act
        char actual = Grading.GetLetterGrade(numGrade);

        // Assert
        Assert.Equal(charGrade, actual);
    }

    [Fact]
    public void GetLetterGrade_GradeNotReal_ThrowsException()
    {
        // Assert
        int numGrade = 7;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Grading.GetLetterGrade(numGrade));
    }
}
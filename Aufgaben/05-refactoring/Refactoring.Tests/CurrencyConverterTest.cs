using System;
using Xunit;

namespace Refactoring.Tests;

public class CurrencyConverterTest
{
    [Theory]

    [InlineData(2, "USD", 2.18)]
    [InlineData(2, "EUR", 1.92)]
    [InlineData(2, "GBP", 1.64)]
    [InlineData(1, "RUB", 79.78)]

    public void ConvertTo_ForeignCurrencyExists_ReturnsRightValue(double chfValue, string foreignCurrency, double foreignValue)
    {
        // Assert
        CurrencyConverter currencyConverter = new CurrencyConverter(foreignCurrency);

        // Act
        double actual = currencyConverter.ConvertTo(chfValue);

        // Assert
        Assert.Equal(foreignValue, actual);
    }

    [Fact]
    public void Constructor_ForeignCurrencyDontExists_ReturnsExeption()
    {
        // Assert
        string foreignCurrency = "BEST";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new CurrencyConverter(foreignCurrency));
    }
}
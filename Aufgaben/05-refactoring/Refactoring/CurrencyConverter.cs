namespace Refactoring;

public class CurrencyConverter
{
    private double factor = 0;

    public CurrencyConverter(string toCurrency)
    {
        switch (toCurrency)
        {
            case "USD":
                factor = 1.09;
                break;
            case "EUR":
                factor = 0.96;
                break;
            case "GBP":
                factor = 0.82;
                break;
            case "RUB":
                factor = 79.78;
                break;
            default:
                throw new ArgumentException($"no exchange rate for {toCurrency} available");
        }
    }

    public double ConvertTo(double amount)
    {
        return amount * factor;
    }
}
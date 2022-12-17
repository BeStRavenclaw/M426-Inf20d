namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int n)
    {
        int last = 1;
        int secondLast = 1;
        int result = 0;

        if (n < 0)
        {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        }

        for (int i = 1; i < n; i++)
        {
            result += secondLast;
            secondLast = last;
            last = result;
        }
        return result;
    }
}
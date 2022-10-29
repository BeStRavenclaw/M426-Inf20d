using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int factorA, int factorB)
        {
            return factorA * factorB;
        }

        public int Divide(int divident, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException('You can not divide by Zero!');

            return divident / divisor;
        }
    }
}

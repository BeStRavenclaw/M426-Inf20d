using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            if (numbers.Count == 0)
                throw new ArgumentException("There are no numbers for the Mean!");


            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int> numbers)
        {
            if (numbers.Count == 0)
                throw new ArgumentException("There are no numbers for the Median!");

            numbers.Sort();

            if (numbers.Count % 2 == 0)
            {
                List<int> meanList = new List<int> { numbers[(numbers.Count) / 2 - 1], numbers[(numbers.Count) / 2] };
                return Mean(meanList);
            }
            else
            {
                return numbers[(numbers.Count - 1) / 2];
            }
        }
    }
}

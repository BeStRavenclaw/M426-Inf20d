using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 2, 103 };
            double expected = 52.5;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 10, 20, 103 };
            double expected = 27.2;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int> {};
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int> { 2, 5, 3, 9, 10 };
            double expected = 5;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            List<int> numbers = new List<int> { 2, 5, 3, 9 };
            double expected = 4;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForNoElements()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithms
{
    public class BubbleSorting
    {
        double[] numbers;
        public BubbleSorting(double[] _numbers)
        {
            numbers = _numbers;
        }
        private void Sorting()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j=0; j<numbers.Length-1-i; j++)
                {
                    if (numbers[j]>numbers[j+1])
                    {
                        double t = numbers[j];
                        numbers[j]= numbers[j+1];
                        numbers[j+1] = t;
                    }
                }
            }
        }
        public void Time()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Sorting();

            stopwatch.Stop();

            Console.WriteLine("BubbleSorting = " +stopwatch.ElapsedMilliseconds);
        }

    }
}

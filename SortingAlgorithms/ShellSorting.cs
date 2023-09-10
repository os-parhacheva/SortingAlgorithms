using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class ShellSorting
    {
        double[] numbers;
        public ShellSorting(double[] _numbers)
        {
            numbers = _numbers;
        }
        private void Sorting()
        {
            int j;
            for (int h = numbers.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < numbers.Length; i++)
                {
                    double temp = numbers[i];

                    for (j = i; j >= h; j -= h)
                    {
                        if (temp < numbers[j - h])
                            numbers[j] = numbers[j - h];
                        else
                            break;
                    }
                    numbers[j] = temp;
                }

            }
        }
        public void Time()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Sorting();

            stopwatch.Stop();

            Console.WriteLine("ShellSorting = "+ stopwatch.ElapsedMilliseconds);
        }

    }
}

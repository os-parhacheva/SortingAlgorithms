using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = new double[20000];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.NextDouble();
            }
            BubbleSorting bubbleSorting = new BubbleSorting(numbers);
            bubbleSorting.Time();

        }
    }
}

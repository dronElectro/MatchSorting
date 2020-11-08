using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingMatch
{
    class CombSort: ISorting
    {
        public string Name { get; set; }
        public int N { get; set; }
        public int[] NotSortedArray { get; set; }

        public CombSort(RandomArrayGenerator randArray)
        {
            Name = "Comb";
            N = randArray.N;
            NotSortedArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                NotSortedArray[i] = randArray.NotSortedArray[i];
            }
        }

        public CombSort(int[] notSortedArray)
        {
            Name = "Comb";
            N = notSortedArray.Length;
            NotSortedArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                NotSortedArray[i] = notSortedArray[i];
            }
        }
        public CombSort()
        {
            Name = "Comb";
        }
        public double timeToSort()
        {
            Stopwatch stopwatchComb = new Stopwatch();
            stopwatchComb.Start();
            int temp = 0;
            double k = 1.247;
            double step = N - 1;

            while (step>1)
            {
                for (int i = 0; i + step < N; i++)
                {
                    if (NotSortedArray[i]> NotSortedArray[i+(int)step])
                    {
                        temp = NotSortedArray[i + (int)step];
                        NotSortedArray[i + (int)step] = NotSortedArray[i];
                        NotSortedArray[i] = temp;
                    }
                }
                step /= k;
            }

                

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (NotSortedArray[j] > NotSortedArray[j + 1])
                    {
                        temp = NotSortedArray[j + 1];
                        NotSortedArray[j + 1] = NotSortedArray[j];
                        NotSortedArray[j] = temp;
                    }
                }
            stopwatchComb.Stop();
            return stopwatchComb.ElapsedTicks;
        }
    }
}

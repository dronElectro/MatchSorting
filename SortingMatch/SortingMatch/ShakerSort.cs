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
    class ShakerSort: ISorting
    {
        public string Name { get; set; }
        public int N { get; set; }
        public int[] NotSortedArray { get; set; }

        public ShakerSort(RandomArrayGenerator randArray)
        {
            Name = "Shaiker";
            N = randArray.N;
            NotSortedArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                NotSortedArray[i] = randArray.NotSortedArray[i];
            }
        }
        public ShakerSort(int[] notSortedArray)
        {
            Name = "Shaiker";
            N = notSortedArray.Length;
            NotSortedArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                NotSortedArray[i] = notSortedArray[i];
            }
        }
        public ShakerSort()
        {
            Name = "Shaiker";
        }
        public double timeToSort()
        {
            
            Stopwatch stopwatchSh = new Stopwatch();
            stopwatchSh.Start();
            int temp = 0;
            int start = -1, end = N - 1;
            bool sorting = true;
            while (true)
            {
                sorting = false;
                start++;

                for (int j = start; j < end; j++)
                {
                    if (NotSortedArray[j] > NotSortedArray[j + 1])
                    {
                        temp = NotSortedArray[j + 1];
                        NotSortedArray[j + 1] = NotSortedArray[j];
                        NotSortedArray[j] = temp;
                        sorting = true;
                    }
                }
                if (!sorting)
                    break;
                end--;
                for (int j = end; j > start; j--)
                {
                    if (NotSortedArray[j] < NotSortedArray[j - 1])
                    {
                        temp = NotSortedArray[j - 1];
                        NotSortedArray[j - 1] = NotSortedArray[j];
                        NotSortedArray[j] = temp;
                        sorting = true;
                    }
                }
            }
            stopwatchSh.Stop();
            return stopwatchSh.ElapsedTicks;
        }
    }
}

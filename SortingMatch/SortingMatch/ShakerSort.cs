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

        public void newArray(int[] arr, int n)
        {
            N = n;
            NotSortedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                NotSortedArray[i] = arr[i];
            }
        }

        public long timeToSort()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int temp = 0;
            int start = 0, end = N - 1;
            bool sorting = true;

            while (sorting)
            {
                sorting = false;
                for (int j = start; j < end-1; j++)
                {
                    if (NotSortedArray[j] > NotSortedArray[j + 1])
                    {
                        temp = NotSortedArray[j + 1];
                        NotSortedArray[j + 1] = NotSortedArray[j];
                        NotSortedArray[j] = temp;
                        sorting = true;
                    }
                }
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
                start++;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
    }
}

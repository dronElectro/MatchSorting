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
    class BubbleSort : ISorting
    {
        public string Name { get; set; }
        public int N { get; set; }
        public int[] NotSortedArray { get; set; }

        public BubbleSort(RandomArrayGenerator randArray)
        {
            Name = "Bubble";
            N = randArray.N;
            NotSortedArray = new int[N];
            for (int i=0;i<N;i++)
            {
                NotSortedArray[i] = randArray.NotSortedArray[i];
            }
        }
        public BubbleSort(int[] notSortedArray)
        {
            Name = "Bubble";
            N = notSortedArray.Length;
            NotSortedArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                NotSortedArray[i] = notSortedArray[i];
            }
        }

        public BubbleSort() {
            Name = "Bubble";
        }

        public void newArray(int[] arr, int n)
        {
            N = n;
            NotSortedArray = new int[n];
            for (int i=0;i<n;i++)
            {
                NotSortedArray[i] = arr[i];
            }
        }
        public long timeToSort()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int temp = 0;

            for(int i=0;i<N;i++)
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (NotSortedArray[j] > NotSortedArray[j + 1])
                    {
                        temp = NotSortedArray[j + 1];
                        NotSortedArray[j + 1] = NotSortedArray[j];
                        NotSortedArray[j] = temp;
                    }
                }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
    }
}

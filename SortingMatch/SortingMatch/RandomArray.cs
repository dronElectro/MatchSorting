using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingMatch
{
    class RandomArrayGenerator
    {
        public int N { get; set; }
        public int[] NotSortedArray { get; set; }

        public RandomArrayGenerator(int n)
        {
            N = n;
            NotSortedArray = new int[N];
            Random rand = new Random();
            for (int i=0;i<N;i++)
            {
                NotSortedArray[i] = rand.Next(1000);
            }
        }
        
    }
}

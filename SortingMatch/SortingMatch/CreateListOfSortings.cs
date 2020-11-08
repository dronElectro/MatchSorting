using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingMatch
{
    class CreateListOfSortings
    {
        public ISorting[] Sorts { get; set; }

        public CreateListOfSortings(bool[] sorts, int[] notSortedArray)
        {
            Sorts = new ISorting[sorts.Length];
            for (int i = 0; i < sorts.Length; i++)
            {
                if (sorts[i])
                {
                    switch (i)
                    {
                        case 0: Sorts[i] = new BubbleSort(notSortedArray); break;
                        case 1: Sorts[i] = new ShakerSort(notSortedArray); break;
                        case 2: Sorts[i] = new CombSort(notSortedArray); break;
                    }
                }
            }
        }
        public CreateListOfSortings(bool[] sorts)
        {
            Sorts = new ISorting[sorts.Length];
            for (int i = 0; i < sorts.Length; i++)
            {
                if (sorts[i])
                {
                    switch (i)
                    {
                        case 0: Sorts[i] = new BubbleSort(); break;
                        case 1: Sorts[i] = new ShakerSort(); break;
                        case 2: Sorts[i] = new CombSort(); break;
                    }
                }
                else
                    Sorts[i] = null;
            }
        }
    }
}

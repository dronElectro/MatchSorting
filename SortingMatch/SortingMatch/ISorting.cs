using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMatch
{
   

    interface ISorting
    {
        string Name { get; set; }
        int[] NotSortedArray { get; set; }
        int N { get; set; }
        double timeToSort();

    }
}

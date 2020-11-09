using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingMatch
{
    class CreateCoordList
    {
        
        public long[,] Coords { get; set; }
        public long max{ get; set; }
        CreateListOfSortings listOfSorts;
        RandomArrayGenerator randArray;
        public CreateCoordList(bool[] numOfSorts, int[] numOfCells)
        {
            max = 0;
            Coords = new long[numOfSorts.Length, numOfCells.Length];
            listOfSorts = new CreateListOfSortings(numOfSorts);

            for (int i=0;i< numOfCells.Length;i++)
            {
                if (numOfCells[i]!=0)
                {
                    randArray = new RandomArrayGenerator(numOfCells[i]);
                    for (int j = 0; j< numOfSorts.Length;j++)
                    {
                        if(listOfSorts.Sorts[j]!=null)
                        {
                            listOfSorts.Sorts[j].newArray(randArray.NotSortedArray, randArray.NotSortedArray.Length);
                            Coords[j, i] = listOfSorts.Sorts[j].timeToSort();
                            if (Coords[j, i] > max)
                                max = Coords[j, i];
                        }
                    }
                }   
            }
        }
    }
}

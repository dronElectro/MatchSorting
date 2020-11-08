using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingMatch
{
    class CreateCoordList
    {
        public int[,] Coords { get; set; }
        public int max=0;
        CreateListOfSortings listOfSorts;
        RandomArrayGenerator randArray;
        public CreateCoordList(bool[] numOfSorts, int[] numOfCells)
        {
            Coords = new int[numOfSorts.Length, numOfCells.Length];
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
                            listOfSorts.Sorts[j].NotSortedArray = randArray.NotSortedArray;
                            listOfSorts.Sorts[j].N = randArray.NotSortedArray.Length;
                            Coords[j, i] = (int)(listOfSorts.Sorts[j].timeToSort());
                            MessageBox.Show(listOfSorts.Sorts[j].Name + " " + Coords[j, i].ToString());
                            if (Coords[j, i] > max) max = Coords[j, i];
                        }
                    }
                }

                    
            }
        }
    }
}

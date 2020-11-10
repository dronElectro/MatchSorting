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

            Console.WriteLine();
            Console.Write("Массив значений - кол-во ячеек массива по горизонтали/метод сортировки по вертикали");
            Console.WriteLine();
            for (int i = 0; i < numOfSorts.Length; i++)
            {
                if (listOfSorts.Sorts[i]!=null)
                    Console.Write(listOfSorts.Sorts[i].Name + "\t");
                else Console.Write(" \t");
                for (int j = 0; j < numOfCells.Length; j++)
                    Console.Write(String.Format("{0,20}", Coords[i, j]));
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}

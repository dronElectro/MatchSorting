using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SortingMatch
{
    class DrawGraphics
    {
        Graphics graphics;
        Pen pen;
        public DrawGraphics(int[,] coords, bool[] numOfSorts, int[] numOfCells, Style styles, System.Windows.Forms.PictureBox e)
        {
            graphics = e.CreateGraphics();
            int x = 0, y = 0;
            for (int i=0;i< numOfSorts.Length;i++)
            {
                if (numOfSorts[i] == false) continue;
                pen = new Pen(styles.color[i], 1);
                bool frstCoord = true;
                for (int j=0;j< numOfCells.Length; j++)
                {
                    if(frstCoord)
                    {
                        x = numOfCells[j];
                        y = coords[i, j];
                        frstCoord = false;
                        continue;
                    }
                    if (numOfCells[i] == 0) continue;
                    graphics.DrawLine(pen, x, y, numOfCells[j]/100, coords[i, j]);
                    x = numOfCells[j];
                    y = coords[i, j];
                }
            }
        }
    }
}

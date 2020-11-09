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
        Pen pen = new Pen(Color.Black,1);
        SolidBrush brush;
        public DrawGraphics(long[,] coords, long maxValue, bool[] numOfSorts, int[] numOfCells, Style styles, System.Windows.Forms.PictureBox e)
        {

            long[,] min = new long[4, numOfCells.Length];// min i x y
            int height = e.Height;
            int width = e.Width;
            double kHeight = maxValue / (height - 40);
            graphics = e.CreateGraphics();
            long x = 0, y = 0, x1=0,y1=0;

            for (int i = 0; i < numOfSorts.Length; i++)
            {

                if (numOfSorts[i] == false) continue;
                pen.Color = styles.color[i];
                bool frstCoord = true;
                double kWidth = (width - 10) / numOfCells.Length;
                x = Convert.ToInt64(kWidth/2);
                y = 0;
                int cntSteps = 0;

                for (int j = 0; j < numOfCells.Length; j++)
                {
                    if (numOfCells[j] == 0)
                    {
                        cntSteps++;
                        continue;
                    }

                    if (min[0, j] == 0 || (coords[i, j] < min[0, j] && coords[i, j] != 0))
                    {
                        min[0, j] = coords[i, j];
                        min[1, j] = i;
                        if (frstCoord) min[2, j] = x;
                        else min[2, j] = x + Convert.ToInt64(kWidth) * cntSteps;
                        min[3, j] = Convert.ToInt64(height - coords[i, j] / kHeight);
                    }

                    if (frstCoord)
                    {
                        frstCoord = false;
                        x += Convert.ToInt64(kWidth) * cntSteps;
                        y = Convert.ToInt64(height - coords[i, j] / kHeight);
                        brush = new SolidBrush(styles.color[i]);
                        graphics.FillEllipse(brush, x, y, 3, 3);
                        cntSteps = 1;
                        continue;
                    }
                    x1 = x + Convert.ToInt64(kWidth) * cntSteps;
                    y1 = Convert.ToInt64(height - coords[i, j] / kHeight);
                    graphics.DrawLine(pen, x, y, x1, y1);
                    x = x1;
                    y = y1;
                }

            }
            ShowLabel showLabel = new ShowLabel(min, numOfCells.Length, styles, e);
        }
    }
}

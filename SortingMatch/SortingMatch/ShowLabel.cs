using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingMatch
{
    class ShowLabel
    {
        Label[] label;
        public ShowLabel(long[,] minArr, int n, Style style, System.Windows.Forms.PictureBox e)
        {
            label = new Label[n];
            for(int i=0;i<n;i++)
            {
                if(minArr[0,i]!=0)
                {
                    label[i] = new Label();
                    label[i].AutoSize = true;
                    label[i].Location = new System.Drawing.Point( Convert.ToInt32(minArr[2, i]), Convert.ToInt32(minArr[3, i])-10);
                    label[i].Name = "label" + i.ToString();
                    label[i].Size = new System.Drawing.Size(35, 13);
                    label[i].TabIndex = 0;
                    label[i].Text = minArr[0, i].ToString();
                    label[i].ForeColor = style.color[minArr[1, i]];
                    e.Controls.Add(label[i]);
                }
            }
        }
    }
}

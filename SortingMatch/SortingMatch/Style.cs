using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMatch
{
    class Style
    {
        Random rand = new Random();
        public Color[] color { get; set; }
        public Style(int n)
        {
            color = new Color[n];
            for(int i = 0;i<n;i++)
            {
                color[i] = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            }
        }

    }
}

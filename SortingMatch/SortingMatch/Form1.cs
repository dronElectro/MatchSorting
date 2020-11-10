using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingMatch
{
    public partial class Form1 : Form
    {
        private bool[] numOfSorts;
        private int[] numOfCells;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SortingMatchGraphicsPB.Controls.Clear();
            SortingMatchGraphicsPB.Refresh();
            numOfSorts = new bool[ListOfSorts.Items.Count];
            numOfCells = new int[ListNumOfCells.Items.Count];
            Style style = new Style(numOfSorts.Length);
            for (int i=0;i<ListOfSorts.Items.Count;i++)
            {
                if (ListOfSorts.Items[i].Checked)
                {
                    ListOfSorts.Items[i].ForeColor = style.color[i];
                    numOfSorts[i] = true;
                }
                else
                    numOfSorts[i] = false;
            }
            for (int i=0;i<ListNumOfCells.Items.Count;i++)
            {
                if (ListNumOfCells.Items[i].Checked)
                {
                    numOfCells[i] = Convert.ToInt32(ListNumOfCells.Items[i].Text);
                }

                else
                    numOfCells[i] = 0;
            }
            CreateCoordList coordList = new CreateCoordList(numOfSorts, numOfCells);
            long[,] coords = coordList.Coords;
            DrawGraphics drawGraphics = new DrawGraphics(coords, coordList.max, numOfSorts, numOfCells, style, SortingMatchGraphicsPB);
        }


    }
}

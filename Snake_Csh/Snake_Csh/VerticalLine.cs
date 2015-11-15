using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Csh
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                pList.Add(new Point(x, i, sym));
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
                p.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Csh
{
    class Walls
    {
        List<Figure> wallList;

        public Walls( int mapWidth, int mapHeight)
        {
            HorizontalLine hlineUp = new HorizontalLine(0, mapWidth - 2, 0, 'x');
            HorizontalLine hlineDown = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, 'x');
            VerticalLine vlineLeft = new VerticalLine(0, mapHeight - 1, 0, 'x');
            VerticalLine vlineRight = new VerticalLine(0, mapHeight - 1, mapWidth - 2, 'x');

            wallList.Add(hlineUp);
            wallList.Add(hlineDown);
            wallList.Add(vlineLeft);
            wallList.Add(vlineRight);
        }

        internal bool IsHit( Figure figure)
        {
            foreach( var wall in wallList)
            {
                if (wall.IsHit(figure))  return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach(var w in wallList)
            {
                w.Draw();
            }
        }
    }
}

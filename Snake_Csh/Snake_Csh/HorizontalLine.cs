﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Csh
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int i=xLeft; i<=xRight; i++)
            {
                pList.Add(new Point(i, y, sym));
            } 
        }

        public override void Draw()
        {
            ConsoleColor currForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //foreach(Point p in pList)
            //{
            //    p.Draw();
            //}
            base.Draw();
            Console.ForegroundColor = currForegroundColor;
        }

    }
}

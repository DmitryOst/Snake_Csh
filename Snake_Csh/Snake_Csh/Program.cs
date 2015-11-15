using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Csh
{
	class Program
	{
		static void Main( string[] args )
		{
			Point p1 = new Point(1, 3, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();

            Console.WriteLine("Create horizontal and vertical line");

            HorizontalLine hline = new HorizontalLine(3, 35, 4, '*'); 
            hline.Draw();

            VerticalLine vline = new VerticalLine(4, 20, 36, 'x');
            vline.Draw();

            Console.ReadLine();
     	}
	}
}

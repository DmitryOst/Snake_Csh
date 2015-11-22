using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Csh
{
	class Program
	{
		static void Main( string[] args )
		{
            Console.SetBufferSize(80, 25);

            //Рисуем рамочку
            HorizontalLine hlineUp = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine hlineDown = new HorizontalLine(0, 78, 24, '*');
            VerticalLine vlineLeft = new VerticalLine(0, 24, 0, 'x');
            VerticalLine vlineRight = new VerticalLine(0, 24, 78, 'x');

            hlineUp.Draw();
            vlineRight.Draw();
            hlineDown.Draw();
            vlineLeft.Draw();

            //Рисуем точку
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 5, Direction.DOWN);
            snake.Draw();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
     	}
	}
}

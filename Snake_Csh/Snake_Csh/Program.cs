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
            int bufferSize_x = 80;
            int bufferSize_y = 25;

            Console.SetBufferSize(bufferSize_x, bufferSize_y);

            //Рисуем рамочку
            Walls walls = new Walls(bufferSize_x, bufferSize_y);
            walls.Draw();

            //Рисуем точку
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 5, Direction.DOWN);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator( 80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if(snake.Eat( food ))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);


                if (Console.KeyAvailable)
                {
//                    ConsoleKeyInfo key = Console.ReadKey();
//                    snake.ChangeDirection(key.Key);
                    snake.ChangeDirection( Console.ReadKey().Key );
                }
            }

     	}
	}
}

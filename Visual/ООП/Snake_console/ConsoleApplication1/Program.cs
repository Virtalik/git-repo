using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Figure H1 = new HorizontalLine(0, 79, 0, '+');
            H1.Draw();
            Figure H2 = new HorizontalLine(0, 79, 23, '+');
            H2.Draw();
            Figure V1 = new VerticalLine(0, 0, 23, '+');
            V1.Draw();
            Figure V2 = new VerticalLine(79, 0, 23, '+');
            V2.Draw();


            WallsCreator W1 = new WallsCreator(2, 5, Direction.LEFT, 79, 23);
            W1.Draw();
            WallsCreator W2 = new WallsCreator(2, 5, Direction.DOWN, 79, 23);
            W2.Draw();

            
            
            Point p1 = new Point(4, 8, '#');
            Snake s1 = new Snake(p1, 7, Direction.RIGHT);
            s1.Draw();
            FoodCreator foodCr = new FoodCreator(79, 23, '@');
            Point food = foodCr.Create();
            food.Print(ConsoleColor.Red);

            while (true)
            {
                if (s1.eat(food))
                {
                    food = foodCr.Create();
                    food.Print(ConsoleColor.Red);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    s1.HandControl(key);
                }

                s1.Move();
                Thread.Sleep(150);
            }

            
        }
        static void Initialization()
        {
        }
    }
}

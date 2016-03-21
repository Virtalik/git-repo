using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Point
    {
        public int x;
        public int y;
        public char sign;

        public Point()
        {

        }
        public Point(int _x, int _y, char _sign)
        {
            x = _x;
            y = _y;
            sign = _sign;

        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sign = p.sign;
        }
        public void Move(int number, Direction dir)
        {
            switch (dir)
            {
                case Direction.RIGHT:
                    x += number;
                    break;
                case Direction.LEFT:
                    x -= number;
                    break;
                case Direction.UP:
                    y -= number;
                    break;
                case Direction.DOWN:
                    y += number;
                    break;
                default: break;
            }
        }
        public void Clear()
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.Write(' ');
        }
        public void Print()
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.Write(sign);
        }
        public void Print(ConsoleColor col1)
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.BackgroundColor = col1;
            System.Console.Write(sign);
            System.Console.ResetColor();
        }



        internal bool isMeat(Point food)
        {
            return (x == food.x) && (y == food.y);
        }
    }

    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
}

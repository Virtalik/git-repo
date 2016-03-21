using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Snake : Figure
    {

        Direction dir;
        public Snake(Point pstart, int length, Direction direction)
        {
            dir = direction;
            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p1 = new Point(pstart);
                p1.Move(i, dir);
                pList.Add(p1);
            }
        }
        public void Move()
        {
            Point p1 = new Point();
            p1 = GetNextPoint();
            pList.Add(p1);
            p1.Print();
            pList.ElementAt(0).Clear();
            pList.RemoveAt(0);
        }
        Point GetNextPoint()
        {
            Point p = new Point(pList.Last());
            p.Move(1, dir);
            return p;
        }

        public void HandControl(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    dir = Direction.RIGHT;
                    break;
                case ConsoleKey.LeftArrow:
                    dir = Direction.LEFT;
                    break;
                case ConsoleKey.UpArrow:
                    dir = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    dir = Direction.DOWN;
                    break;
                default: break;
            }
        }

        internal bool eat(Point food)
        {
            bool eat0 = false;
            if (GetNextPoint().isMeat(food))
            {
                Point p1 = new Point();
                p1 = GetNextPoint();
                pList.Add(p1);
                p1.Print();
                eat0 = true;
            }
            return eat0;
        }
    }
}

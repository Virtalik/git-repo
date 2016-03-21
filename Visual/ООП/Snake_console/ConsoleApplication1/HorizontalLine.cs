using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xfirst, int xlast, int y, char sim)
        {
            pList = new List<Point>();
            for (int x = xfirst; x <= xlast; x++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }

        }
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            base.Draw();
            Console.ResetColor();
        }
    }
}

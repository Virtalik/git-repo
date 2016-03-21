using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yfirst, int ylast, char sim)
        {
            pList = new List<Point>();
            for (int y = yfirst; y <= ylast; y++)
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

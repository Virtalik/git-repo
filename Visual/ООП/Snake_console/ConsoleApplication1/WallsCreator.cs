using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class WallsCreator : Figure
    {
        private List<Figure> FigMas = new List<Figure>();
        private Figure fig = new Figure();

        public WallsCreator()
        {
                      
        }
		public WallsCreator(Figure fig)
        {
            this.fig = fig;
			FigMas.Add(this.fig);
        }
        public WallsCreator(int wide, int pieces, Direction dir, int ViewHight, int ViewWidth)
        {
            Random ran = new Random();
            for (int i = 0; i < pieces; i++ )
            {
                int x = ran.Next(wide, ViewHight - wide);
                int x1;
                int y = ran.Next(wide, ViewWidth - wide);
                int y1;
                

                switch(dir)
                {
                    case Direction.RIGHT:
                        x1 = x + wide; fig = new HorizontalLine(x, x1, y, '&');
                        break;
                    case Direction.LEFT:
                        x1 = x - wide; fig = new HorizontalLine(x1, x, y, '&');
                        break;
                    case Direction.UP:
                        y1 = y - wide; fig = new VerticalLine(x, y1, y, '&');
                        break;
                    case Direction.DOWN:
                        y1 = y + wide; fig = new VerticalLine(x, y, y1, '&');
                        break;
                    default: break;
                }
                FigMas.Add(fig);

            }
        }
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            foreach (Figure f in FigMas)
            {
                f.Draw();
            }
            Console.ResetColor();
        }
        

    }
}

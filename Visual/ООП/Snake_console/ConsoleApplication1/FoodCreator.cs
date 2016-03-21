using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class FoodCreator
    {
        private int w;
        private int h;
        private char sig;

        public FoodCreator(int w, int h, char sig)
        {
            // TODO: Complete member initialization
            this.w = w;
            this.h = h;
            this.sig = sig;
        }


        internal Point Create()
        {
            Random ran = new Random();
            int x = ran.Next(2,w-1);
            int y = ran.Next(2,h-1);
            return new Point(x, y, sig);
        }
        
        
    }
}

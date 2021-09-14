using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Geom.lib
{
    public struct Point
    {
        public int X, Y;
        const char Symbol = '*';
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            SetCursorPosition(X, Y);
            Write(Symbol);
        }
    }
}

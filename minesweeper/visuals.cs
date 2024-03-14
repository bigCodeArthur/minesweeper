using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace minesweeper
{
    internal class visuals
    {
        public static void drawField(Graphics g, Pen p, Point size, Point panelSize)
        {
            for (int i = 0; i < size.X; i++) g.DrawLine(p, 0, 0, 0, 0);
            for (int i = 0; i < size.Y; i++) g.DrawLine(p, 0, 0, 0, 0);
        }
    }
}

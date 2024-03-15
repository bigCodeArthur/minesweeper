using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    internal class functionality
    {
        internal static void dig(Point position, grid gr, Size size)
        {
            // Calculate panel size
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            // Calculate tile index based on mouse position
            int tileX = (int)((float)e.X / panelWidth * (float)panelWidth / TileWidth);
            int tileY = (int)((float)e.Y / panelHeight * (float)panelHeight / TileHeight);

            gr.reveal(tileX, tileY);
        }
    }
}

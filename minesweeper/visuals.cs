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
        public static void drawField(Graphics g, Pen p, Size size, Size panelSize, grid gr)
        {
            
            int tileWidth = (panelSize.Width / size.Width);
            int tileHeight = (panelSize.Height / size.Height);
            Size tileSize = new Size(tileWidth, tileHeight);
            for (int i = 1; i < size.Width; i++) g.DrawLine(p, tileWidth * i, 0, tileWidth * i, panelSize.Height);
            for (int i = 1; i < size.Height; i++) g.DrawLine(p, 0, tileHeight * i, panelSize.Width, tileHeight * i);
            gr.current = gr.topLeft;
            while (true) drawTile(g, p, gr.next(), tileSize);
        }

        private static void drawTile(Graphics g, Pen p, tile current, Size tileSize)
        {
            Brush b = new SolidBrush(Color.Brown);
            Font f = SystemFonts.DefaultFont;
            if (current.revealed) {

                if (current.surroundingBombs > 0) g.DrawString("" + current.surroundingBombs, f, b, (float)current.X * tileSize.Width, (float)current.Y * tileSize.Height); 

            }
        }
    }
}
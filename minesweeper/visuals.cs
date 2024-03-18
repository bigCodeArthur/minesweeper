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
            // draw tiles.
            gr.current = gr.topLeft;
            for (int i = 0; i < gr.width * gr.height; i++) drawTile(g, p, gr.next(), tileSize);
            // draw grid.
                // vertical
            for (int i = 0; i < size.Width+1; i++) g.DrawLine(p, tileWidth * i, 0, tileWidth * i, tileHeight * size.Height - 1);
                // horizontal
            for (int i = 0; i < size.Height; i++) g.DrawLine(p, 0, tileHeight * i, tileWidth * size.Width, tileHeight * i);
        }

        private static void drawTile(Graphics g, Pen p, tile current, Size tileSize)
        {
            Brush b = new SolidBrush(Color.Brown);
            Brush r = new SolidBrush(Color.Red);
            Brush w = new SolidBrush(Color.White);

            Font f = SystemFonts.DefaultFont;
            if (current.revealed) {
                g.FillRectangle(w, (float)current.X * tileSize.Width, (float)current.Y * tileSize.Height, tileSize.Width, tileSize.Height);
                if (current.surroundingBombs > 0) g.DrawString("" + current.surroundingBombs, f, b, (float)current.X * tileSize.Width, (float)current.Y * tileSize.Height);
            }
        }
    }
}
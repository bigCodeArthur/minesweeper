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
        /// <summary>
        /// turns the location of the mouse on the canvas into a usable X and Y index to reveal the tile.
        /// </summary>
        /// <algo>
        /// calculate canvas size.
        /// 
        /// calculate tile size.
        /// 
        /// position / tile size = usable index.
        /// </algo>
        internal static void dig(Point position, grid gr, Size size)
        {
            // Calculate panel size
            int panelWidth = size.Width;
            int panelHeight = size.Height;

            int TileWidth = panelWidth / gr.width;
            int TileHeight = panelHeight / gr.height;

            // Calculate tile index based on mouse position
            int tileX = position.X / TileWidth;
            int tileY = position.Y / TileHeight;

            gr.reveal(tileX, tileY);
        }
        /// <summary>
        /// spreads a set amount of mines in a minesweeper grid.
        /// </summary>
        /// <algo>
        /// 
        /// </algo>
        internal static void spreadMines(grid gr, Random rng, int inputM)
        {
            int mines = inputM;
            gr.current = gr.topLeft;
            while (mines > 0)
            {
                gr.next();
                if (rng.Next(0, 30) < 5)
                {
                    gr.current.bomb = true;
                    mines--;
                }
                
            }
        }
    }
}

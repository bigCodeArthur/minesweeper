using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    internal class functionality
    {
        /// <summary>
        /// turns the location of the mouse on the canvas into a usable X and Y index to reveal the tile, also returns true on bombs.
        /// </summary>
        /// <algo>
        /// calculate canvas size.
        /// 
        /// calculate tile size.
        /// 
        /// position / tile size = usable index.
        /// 
        /// returns true if the player digs into a bomb.
        /// </algo>
        internal static bool dig(Point position, grid gr, Size size)
        {
            // Calculate panel size
            int panelWidth = size.Width;
            int panelHeight = size.Height;

            int TileWidth = panelWidth / gr.width;
            int TileHeight = panelHeight / gr.height;

            // Calculate tile index based on mouse position
            int tileX = position.X / TileWidth;
            int tileY = position.Y / TileHeight;

            if(gr.reveal(tileX, tileY)) return true;
            else return false;
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

        internal static bool winConCheck(grid gr)
        {
            int revealed = 0;
            for (int i = 0; i < gr.width * gr.height; i++) if (gr.next().revealed) revealed++;
            if (revealed == (gr.width * gr.height) - gr.allBombs) return true;
            return false;
        }
    }
}

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
        /// 
        /// </summary>
        /// <algo>
        /// 
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
    }
}

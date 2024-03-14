using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    public class tile
    {
        // a tile is connected to other tile on the cardinal directions.
        public tile top = null;
        public tile bottom = null;
        public tile left = null;
        public tile right = null;
        // some tiles have bombs and some do not.
        public bool bomb = false;
        // some tiles are revealed and some are not.
        public bool revealed = false;
        public int surroundingBombs = 0;
        // positional indexes.
        public int X = 0;
        public int Y = 0;
        public tile(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    public class grid
    {
        // size.
        int width;
        int height;
        // reference points.
        tile topLeft;
        tile current;
        public grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.topLeft = new tile(0, 0);
            this.current = topLeft;
            recursiveGridBuilder(width, height, current, null, null);
        }
        /// <summary>
        /// a method to recursively build a grid with the top-left tile as the beginning (0 index);
        /// </summary>
        /// <algo>
        /// reset to top and shift to the right when reaching the vertical limit
        /// 
        /// add tile to the current's bottom.
        ///     connect the tile horizontally if there is a tile to the left.
        ///     
        /// exit recursion when reaching the vertical and horizontal limit.
        ///     or recurse with the inhereted size and new current/prev.
        /// </algo>
        private void recursiveGridBuilder(int width, int height, tile current, tile YPrev, tile XPrev)
        {
            // reset to top and shift to the right when reaching the vertical limit
            if (current.Y >= height - 1)
            {
                // reset to top
                while (current.top != null) current = current.top;
                // shift right
                current.right = new tile(current.X + 1, 0);
                current = current.right;
                XPrev = current.left;
            }
            // add tile to the current's bottom.
            current.bottom = new tile(current.X, current.Y + 1);
            // connect the tile horizontally if there is a tile to the left.
            if (current.X > 0) current.left = XPrev;

            // exit recursion when reaching the vertical and horizontal end point.
            if (current.X >= width - 1 && current.Y >= height - 1) return;
            // or recurse with the inhereted size and new current/prev.
            else recursiveGridBuilder(width, height, current.bottom, current, current.bottom.left);
        }

        private void reveal(int X, int Y)
        {
            current = topLeft;
            while (current.X >= X) current = current.right;
            while (current.Y >= Y) current = current.bottom;
            recursiveReveal(current);
        }
        private void recursiveReveal(tile input)
        {
            if (countAndRevealBombs(input) > 0) return;
            else
            {
                recursiveReveal(input.top);
                recursiveReveal(input.right);
                recursiveReveal(input.bottom);
                recursiveReveal(input.left);
            }
        }
        /// <summary>
        /// count the bombs around the given tile by XY index.
        /// </summary>
        /// <algo>
        /// reveal tile.
        /// 
        /// check for bombs in the cardinal(vertical and horizontal) and ordinal(corner) directions
        /// </algo>
        private int countAndRevealBombs(tile input)
        {
            // store counted bombs.
            int bombs = 0;
            // reveal the bomb.
            input.revealed = true;
            // count all bombs.
            // check all cardinal bombs.
            if (input.top.bomb) bombs++;
            if (input.right.bomb) bombs++;
            if (input.bottom.bomb) bombs++;
            if (input.left.bomb) bombs++;
            // check all corner bombs.
            if (input.top.right.bomb) bombs++;
            if (input.right.bottom.bomb) bombs++;
            if (input.bottom.left.bomb) bombs++;
            if (input.left.top.bomb) bombs++;
            // return counted bombs.
            input.surroundingBombs = bombs;
            return bombs;
        }
    }
}

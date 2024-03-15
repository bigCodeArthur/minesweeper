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
        public int width;
        public int height;
        // reference points.
        public tile topLeft;
        public tile current;
        public grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.topLeft = new tile(0, 0);
            this.current = topLeft;
            recursiveGridBuilder(width, height, current, null);
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
        private void recursiveGridBuilder(int width, int height, tile current, tile leftConn)
        {
            tile nextLeft = null;
            // connect the tile horizontally if there is a tile to the left.
            if (current.X > 0)
            {
                current.left = leftConn;
                leftConn.right = current;
                nextLeft = leftConn.bottom;
            }
            // reset to top and shift to the right when reaching the vertical limit
            if (current.Y >= height)
            {
                // reset to top.
                while (current.top != null) current = current.top;
                // shift and connect right.
                current.right = new tile(current.X + 1, 0);
                leftConn = current;
                current = current.right;
                current.left = leftConn;
                nextLeft = leftConn.bottom;
            }
            // add and connect tile to the current's bottom.
            if (current.Y < height)
            {
                current.bottom = new tile(current.X, current.Y + 1);
                current.bottom.top = current;
            }
           

            if (current.X >= width - 1 && current.Y >= height - 1) return;
            // or recurse with the inhereted size and new current/prev.
            else recursiveGridBuilder(width, height, current.bottom, nextLeft);
        }
        /// <summary>
        /// reveal all tiles that are guaranteed to not have bombs.
        /// </summary>
        /// <algo>
        /// move into position and...
        ///     start the recursion
        /// </algo>
        public bool reveal(int X, int Y)
        {
            // move into position and...
            current = topLeft;
            while (current.X >= X) current = current.right;
            while (current.Y >= Y) current = current.bottom;
            // start the recursion.
            if (!current.bomb) recursiveReveal(current);
            else return true;
            return false;
        }
        /// <summary>
        /// the recursive halve of the reveal methods
        /// </summary>
        /// <algo>
        /// reveal and count the bombs.
        /// 
        /// then recurse to all cardinal neighbors.
        /// </algo>
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
        /// check for bombs in the cardinal(vertical and horizontal) and ordinal(corner) directions.
        /// 
        /// store and return the amount.
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
        /// <summary>
        /// move the Current tile to a "next" tile that in time goes through all tiles.
        /// </summary>
        /// <algo>
        /// store the output(being the current value).
        /// 
        /// (then move to the next tile by the following logic)
        /// 
        /// when on an even row...
        ///     move to the right.
        ///     when reaching the right end...
        ///         move down.
        /// 
        /// when on an uneven row...
        ///     move to the left.
        ///     men reaching the left end...
        ///         move down.
        ///         
        /// return the output.
        /// </algo>
        public tile next()
        {
            tile output = current;

            if (current.Y % 2 == 0) if (current.right == null) current = current.bottom;
            else current = current.right;

            else if (current.left == null) current = current.bottom;
            else current = current.left;

            return output;
        }
    }
}

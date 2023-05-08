using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class Room
    {
        private int size;
        private Cell[,] cells;

        /// <summary>
        /// Create a new <c>Room</c>.
        /// </summary>
        /// <param name="size">The number of <c>Cell</c>s that make up one side of the <c>Room</c>.</param>
        public Room(int size)
        {
            this.size = size;
            cells = new Cell[size, size];
        }

        public void SetCell(int x, int y, Cell cell)
        {
            cells[x, y] = cell;
        }

        public Cell GetCell(int x, int y)
        {
            return cells[x, y];
        }

        /// <returns>The number of <c>Cell</c>s that make up on side of the <c>Room</c>.</returns>
        public int GetSize()
        {
            return size;
        }
    }
}

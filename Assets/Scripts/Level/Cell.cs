using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class Cell
    {
        private CellCategory category;

        public Cell(CellCategory category)
        {
            this.category = category;
        }

        public CellCategory GetCategory()
        {
            return category;
        }
    }
}

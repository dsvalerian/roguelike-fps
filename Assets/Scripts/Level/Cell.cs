using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class Cell
    {
        private CallCategory category;

        public Cell(CallCategory category)
        {
            this.category = category;
        }

        public CallCategory GetCategory()
        {
            return category;
        }
    }
}

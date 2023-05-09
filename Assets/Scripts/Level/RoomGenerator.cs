using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class RoomGenerator
    {
        private const int roomSize = 20;

        public static Room GenerateRoom()
        {
            Room room = new Room(roomSize);

            for (int x = 0; x < roomSize; x++)
            {
                for (int y = 0; y < roomSize; y++)
                {
                    room.SetCell(x, y, new Cell(CellCategory.Empty));
                }
            }

            return room;
        }
    }
}

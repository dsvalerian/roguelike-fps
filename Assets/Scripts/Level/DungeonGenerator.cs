using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class DungeonGenerator
    {
        private const int dungeonSize = 5;

        public static Dungeon GenerateDungeon()
        {
            Dungeon dungeon = new Dungeon(dungeonSize);
            for (int x = 0; x < dungeonSize; x++)
            {
                for (int y = 0; y < dungeonSize; y++)
                {
                    dungeon.SetRoom(x, y, RoomGenerator.GenerateRoom());
                }
            }

            return dungeon;
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class RoomGenerator
    {
        private const int roomSize = 20;

        public static Room GenerateRoom()
        {
            return new Room(roomSize);
        }
    }
}

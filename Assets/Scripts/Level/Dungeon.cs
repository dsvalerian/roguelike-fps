using System;
using System.Collections;
using System.Collections.Generic;

namespace RoguelikeFPS.Level
{
    public class Dungeon
    {
        private int size;
        private Room[,] rooms;

        public Dungeon(int size)
        {
            this.size = size;
            this.rooms = new Room[size, size];
        }

        public void SetRoom(int x, int y, Room room)
        {

            rooms[x, y] = room;
        }

        public Room GetRoom(int x, int y)
        {
            return rooms[x, y];
        }

        public int GetSize()
        {
            return size;
        }
    }
}

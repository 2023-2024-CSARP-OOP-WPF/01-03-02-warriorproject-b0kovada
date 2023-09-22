using System;

namespace WarriorProject
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine($"({x},{y})");
        }
    }
}

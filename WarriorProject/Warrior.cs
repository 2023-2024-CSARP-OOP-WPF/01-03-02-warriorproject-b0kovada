using System;

namespace WarriorProject
{
    public class Warrior
    {
        private string name;
        private Position position;

        public Warrior(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }

        public void MoveHorizontal(int distance)
        {
            position.x += distance;
        }

        public void MoveVertical(int distance)
        {
            position.y += distance;
        }

        public void ToConsole()
        {
            Console.WriteLine($"{name}, position ({position.x},{position.y})");
        }
    }
}

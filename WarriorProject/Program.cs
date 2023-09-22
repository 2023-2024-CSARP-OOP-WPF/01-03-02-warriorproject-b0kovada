using System;

namespace WarriorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngineDLL
{
    public class Monster : Character
    {
        public int pixelsToMove = 50; // Move in 50-pixel steps
        public Direction monsterDirection = Direction.None;
        public PictureBox monsterPictureBox;

        public enum Direction
        {
            None, Up, Down, Left, Right
        }

        public Monster(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(char[][] map, Hunter hunter)
        {
            Random random = new Random();
            int dir = random.Next(4); // Randomly select a direction
            monsterDirection = (Direction)dir;

            int newX = X, newY = Y;

            switch (monsterDirection)
            {
                case Direction.Up:
                    newY--;
                    break;
                case Direction.Down:
                    newY++;
                    break;
                case Direction.Left:
                    newX--;
                    break;
                case Direction.Right:
                    newX++;
                    break;
            }

            // Validate new position
            if (newY >= 0 && newY < map.Length &&
                newX >= 0 && newX < map[newY].Length &&
                map[newY][newX] != '#' &&
                !(newX == hunter.X && newY == hunter.Y))
            {
                X = newX;
                Y = newY;
            }
        }
    }
}

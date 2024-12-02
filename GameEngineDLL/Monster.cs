using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    internal class Monster :  Character
    {
        public class monster
        {
            //constants
            const int pixelsToMove = 50;

            //variables
            List<monster> allmonsters = new List<monster>();

            public int X = 0;
            public int Y = 0;
            public Direction monsterDirection;
            

            public enum Direction
            {
                None, Up, Down, Left, Right, //0,1,2,3
            }

        }
    }
}

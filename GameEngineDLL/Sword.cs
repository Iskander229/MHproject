using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    public class Sword
    {
        //constants
        private const int BreakChance = 5; // 1/5 chance

        //variables
        public int Strength
        {
            get
            {
                return this.Strength;
            }
            private set
            {
                this.Strength += Strength = RandomGenerator.Instance.Next(4, 10); // 
                IsBroken = false;
            }

        }

        public bool IsBroken
        {
            get;
            private set;
        }

        public bool Use()
        {
            if (RandomGenerator.Instance.Next(1, BreakChance + 1) == 1)
            {
                IsBroken = true;
            }
            return IsBroken;
        }
    }
}

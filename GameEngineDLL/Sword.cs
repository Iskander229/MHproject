using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    public class Sword
    {
        private const int BreakChance = 5; // chance of break
        private int _strength;

        public Sword()
        {
            _strength = RandomGenerator.Instance.Next(4, 10); // using singleton
            IsBroken = false;
        }

        public int Strength => _strength;
        public bool IsBroken { get; private set; }

        public bool Use()
        {
            // random chance to break
            if (RandomGenerator.Instance.Next(1, BreakChance + 1) == 1)
            {
                IsBroken = true;
            }
            return IsBroken;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineDLL
{
    public sealed class RandomGenerator
    {
        private static readonly Random _instance = new Random();
        private RandomGenerator() { }

        public static Random Instance
        {
            //randomizing
            get { return _instance; }
        }
    }
}

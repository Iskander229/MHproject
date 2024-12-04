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

        private RandomGenerator() { } // Private constructor to prevent instantiation

        public static Random Instance
        {
            get { return _instance; } // Singleton instance of Random
        }
    }
}
